namespace TestingConsole
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using System.Net;
	using System.Web;
	using System.Xml;
	using System.Xml.Serialization;
	using Newtonsoft.Json;
	using Zeta.EnterpriseLibrary.Common.Collections;

	public class Program
	{
		static void Main()
		{
			var at = getAccessToken("ZetaResourceEditor", "");
			Console.WriteLine(at.Token);
			Console.WriteLine(at.ValidUntil);

			var ls = getLanguagesForTranslate(at);
			Console.WriteLine(ls);

			var ar = translateArray(at, @"en", @"de", new[] { "Dog", "Cat" });
			var a = translate(at, @"en", @"de", "Dog");

			Console.WriteLine(ar[0].Translation);
			Console.WriteLine(a.Translation);
		}

		private static TranslationResult translate(
			AccessToken at,
			string from,
			string to,
			string text)
		{
			var a = translateArray(at, from, to, new[] { text });
			return a.Length == 1 ? a[0] : null;
		}

		private class AccessToken
		{
			public string Token { get; set; }
			public DateTime ValidUntil { get; set; }
		}

		private static AccessToken getAccessToken(
			string clientID,
			string clientSecret)
		{
			var dic =
				new List<Pair<string, string>>
					{
						new Pair<string, string>(@"grant_type", @"client_credentials"),
						new Pair<string, string>(@"client_id", clientID),
						new Pair<string, string>(@"client_secret", clientSecret),
						new Pair<string, string>(@"scope", @"http://api.microsofttranslator.com"),
					};

			var xml = makeTranslateRestCallPost(@"https://datamarket.accesscontrol.windows.net/v2/OAuth2-13", dic, null);

			var accessTokenNode = xml.SelectSingleNode(@"/root/access_token");
			if (accessTokenNode == null)
			{
				throw new Exception("No access token value can be read from access token.");
			}
			else
			{
				var expirationNode = xml.SelectSingleNode(@"/root/expires_in");
				if (expirationNode == null)
				{
					throw new Exception("No expiration date can be read from access token.");
				}
				else
				{
					var result =
						new AccessToken
							{
								Token = accessTokenNode.InnerText,
								ValidUntil = DateTime.Now.AddSeconds(
									Convert.ToInt32(expirationNode.InnerText) - 5)
							};

					return result;
				}
			}
		}

		private static XmlDocument makeTranslateRestCallPost(
			string url,
			IEnumerable<Pair<string, string>> parameters,
			ICollection<Pair<string, string>> headers)
		{
			var ps = string.Empty;

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var pair in parameters)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				if (!string.IsNullOrEmpty(pair.Value))
				{
					var p =
						string.Format(
							@"{0}={1}&",
							pair.Name,
							HttpUtility.UrlEncode(pair.Value));

					ps += p;
				}
			}

			ps = ps.TrimEnd('?', '&');

			// --

			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Referer = string.Format(@"http://www.zeta-resource-editor.com/rest?{0:N}", Guid.NewGuid());

			//WebServiceManager.Current.ApplyProxy(request);

			// Encode all the source data.
			var postSourceData = ps;
			request.Method = @"POST";
			request.ContentType = @"application/x-www-form-urlencoded";
			request.ContentLength = postSourceData.Length;
			request.UserAgent = @"Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";

			if (headers != null && headers.Count > 0)
			{
				foreach (var header in headers)
				{
					request.Headers.Add(header.Name, header.Value);
				}
			}

			// http://code.google.com/intl/de/apis/language/translate/v2/using_rest.html
			request.Headers.Add(@"X-HTTP-Method-Override", @"GET");

			var writeStream = request.GetRequestStream();
			var bytes = Encoding.UTF8.GetBytes(postSourceData);
			writeStream.Write(bytes, 0, bytes.Length);
			writeStream.Close();

			// --

			string rawResult;

			// If the following fails, you must add this to web.config:
			// <configuration> 
			//		<system.net> 
			//			<settings> 
			//				<httpWebRequest useUnsafeHeaderParsing="true" /> 
			//			</settings> 
			//		</system.net> 
			// </configuration>
			using (var response = (HttpWebResponse)request.GetResponse())
			using (var responseStream = response.GetResponseStream())
			{
				if (responseStream == null)
				{
					return new XmlDocument();
				}
				else
				{
					using (var readStream = new StreamReader(responseStream, Encoding.UTF8))
					{
						rawResult = readStream.ReadToEnd();
					}
				}
			}

			if (string.IsNullOrEmpty(rawResult))
			{
				return new XmlDocument();
			}
			else
			{
				var r = string.Format(@"{{ ""root"": {0} }}", rawResult);

				return JsonConvert.DeserializeXmlNode(r);
			}
		}

		private class TranslationResult
		{
			public string Translation { get; set; }
			public string Error { get; set; }
		}

		private static TranslationResult[] translateArray(
			AccessToken at,
			string from,
			string to,
			IEnumerable<string> texts)
		{
			var appId = string.Empty; //go to http://msdn.microsoft.com/en-us/library/ff512386.aspx to obtain AppId.

			const string uri = @"http://api.microsofttranslator.com/v2/Http.svc/TranslateArray?appId=";

			//The request body is a xml string generated according to the schema specified at http://api.microsofttranslator.com/v2/Http.svc/help.

			var swriter = new StringWriter();
			var xwriter = new XmlTextWriter(swriter);

			xwriter.WriteStartElement(@"TranslateArrayRequest");

			xwriter.WriteStartElement(@"AppId");
			xwriter.WriteString(appId);
			xwriter.WriteEndElement();

			xwriter.WriteStartElement(@"From");
			xwriter.WriteString(from);
			xwriter.WriteEndElement();

			xwriter.WriteStartElement(@"Options");

			xwriter.WriteStartElement(@"Category");
			xwriter.WriteAttributeString(@"xmlns", "http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2");
			xwriter.WriteEndElement();

			xwriter.WriteStartElement(@"ContentType");
			xwriter.WriteAttributeString(@"xmlns", @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2");
			xwriter.WriteString(@"text/plain");
			xwriter.WriteEndElement();

			xwriter.WriteStartElement(@"ReservedFlags");
			xwriter.WriteAttributeString(@"xmlns", @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2");
			xwriter.WriteEndElement();

			xwriter.WriteStartElement(@"State");
			xwriter.WriteAttributeString(@"xmlns", @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2");
			xwriter.WriteEndElement();

			xwriter.WriteStartElement(@"Uri");
			xwriter.WriteAttributeString(@"xmlns", @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2");
			xwriter.WriteEndElement();

			xwriter.WriteStartElement(@"User");
			xwriter.WriteAttributeString(@"xmlns", @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2");
			xwriter.WriteEndElement();

			xwriter.WriteEndElement();

			xwriter.WriteStartElement(@"Texts");
			foreach (var text in texts)
			{
				xwriter.WriteStartElement(@"string");
				xwriter.WriteAttributeString(@"xmlns", @"http://schemas.microsoft.com/2003/10/Serialization/Arrays");
				xwriter.WriteString(text);
				xwriter.WriteEndElement();
			}
			xwriter.WriteEndElement();

			xwriter.WriteStartElement(@"To");
			xwriter.WriteString(to);
			xwriter.WriteEndElement();

			xwriter.WriteEndElement();

			xwriter.Close();
			swriter.Close();


			// create the request
			var request = (HttpWebRequest)WebRequest.Create(uri);
			request.ContentType = @"text/xml";
			request.Method = @"POST";

			request.Headers.Add(@"Authorization", @"Bearer " + at.Token);

			//WebServiceManager.Current.ApplyProxy(request);

			using (var stream = request.GetRequestStream())
			{
				var arrBytes = Encoding.UTF8.GetBytes(swriter.ToString());
				stream.Write(arrBytes, 0, arrBytes.Length);
			}

			var result = new List<TranslationResult>();

			// Get the response
			WebResponse response = null;
			try
			{
				response = request.GetResponse();
				using (var stream = response.GetResponseStream())
				{
					if (stream != null)
					{
						using (var rdr = new StreamReader(stream, Encoding.UTF8))
						{
							// Deserialize the response
							var strResponse = rdr.ReadToEnd();
							var translateResponseArray = TranslationDeserializer.Deserialize<ArrayOfTranslateArrayResponse>(strResponse);

							// Print the response
							// ReSharper disable LoopCanBeConvertedToQuery
							foreach (var translateResponse in translateResponseArray.TranslateArrayResponse)
							// ReSharper restore LoopCanBeConvertedToQuery
							{
								result.Add(
									new TranslationResult
										{
											Error = translateResponse.Error,
											Translation = translateResponse.TranslatedText
										});
							}
						}
					}
				}
			}
			finally
			{
				if (response != null)
				{
					response.Close();
				}
			}

			return result.ToArray();
		}

		private static string[] getLanguagesForTranslate(AccessToken at)
		{
			const string uri = @"http://api.microsofttranslator.com/v2/Http.svc/GetLanguagesForTranslate?appId=";
			var request = (HttpWebRequest)WebRequest.Create(uri);

			request.Headers.Add(@"Authorization", @"Bearer " + at.Token);

			//WebServiceManager.Current.ApplyProxy(request);

			// --

			string rawResult;

			// If the following fails, you must add this to web.config:
			// <configuration> 
			//		<system.net> 
			//			<settings> 
			//				<httpWebRequest useUnsafeHeaderParsing="true" /> 
			//			</settings> 
			//		</system.net> 
			// </configuration>
			using (var response = (HttpWebResponse)request.GetResponse())
			using (var responseStream = response.GetResponseStream())
			{
				if (responseStream == null)
				{
					return new string[] { };
				}
				else
				{
					using (var readStream = new StreamReader(responseStream, Encoding.UTF8))
					{
						rawResult = readStream.ReadToEnd();
					}
				}
			}

			if (string.IsNullOrEmpty(rawResult))
			{
				return new string[] { };
			}
			else
			{
				var xml = new XmlDocument();
				xml.LoadXml(rawResult);

				var result = new List<string>();

				var nodes = xml.ChildNodes[0].ChildNodes;

				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (XmlNode node in nodes)
					// ReSharper restore LoopCanBeConvertedToQuery
				{
					result.Add(node.InnerText);
				}

				return result.ToArray();
			}
		}

		// Utility class used for deserializing responses
		public static class TranslationDeserializer
		{
			public static T Deserialize<T>(string restResponse)
			{
				restResponse = @"" + restResponse;

				var serializer = new XmlSerializer(typeof(T));

				using (var read = new StringReader(restResponse))
				using (var reader = new XmlTextReader(read))
				{
					var responseType = (T)serializer.Deserialize(reader);
					return responseType;
				}
			}
		}

		[SerializableAttribute]
		[XmlTypeAttribute(Namespace = @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
		[XmlRootAttribute(Namespace = @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2", IsNullable = true)]
		public class ArrayOfTranslateArrayResponse
		{
			[XmlElementAttribute(@"TranslateArrayResponse", IsNullable = true)]
			// ReSharper disable MemberHidesStaticFromOuterClass
			public TranslateArrayResponse[] TranslateArrayResponse { get; set; }
			// ReSharper restore MemberHidesStaticFromOuterClass
		}

		[SerializableAttribute]
		[XmlTypeAttribute(Namespace = @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
		[XmlRootAttribute(Namespace = @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2", IsNullable = true)]
		public class TranslateArrayResponse
		{
			[XmlElement(IsNullable = true)]
			public string Error { get; set; }

			[XmlElementAttribute(IsNullable = true)]
			public string From { get; set; }

			[XmlElementAttribute(IsNullable = true)]
			public ArrayOfint OriginalTextSentenceLengths { get; set; }

			[XmlElementAttribute(IsNullable = true)]
			public string State { get; set; }

			[XmlElementAttribute(IsNullable = true)]
			public string TranslatedText { get; set; }

			[XmlElementAttribute(IsNullable = true)]
			public ArrayOfint TranslatedTextSentenceLengths { get; set; }
		}

		[SerializableAttribute]
		[XmlTypeAttribute(Namespace = @"http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
		[XmlRootAttribute(Namespace = @"http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = true)]
		public class ArrayOfint
		{

			[XmlElement(@"int")]
			public int[] @int { get; set; }
		}
	}
}