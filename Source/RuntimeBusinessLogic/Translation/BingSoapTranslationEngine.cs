namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Net;
	using System.Text;
	using System.Web.Services.Protocols;
	using System.Xml;
	using FileGroups;
	using Language;
	using Properties;
	using Runtime;
	using Zeta.VoyagerLibrary.Logging;

	public class BingSoapTranslationEngine :
		ITranslationEngine
	{
		// http://msdn.microsoft.com/en-us/library/hh454950.aspx
		// Client ID: ZetaResourceEditor
		// Client secret: ==> See external text file.

		//private SoapService _ws;
		private TranslationLanguageInfo[] _names;

		//private SoapService createWebService()
		//{
		//    if (_ws == null)
		//    {
		//        _ws = new SoapService();
		//        WebServiceManager.Current.ApplyProxy(_ws);
		//    }

		//    return _ws;
		//}

		public bool Has2AppIDs
		{
			get { return true; }
		}

		public string AppID1Name
		{
			get { return Resources.BingSoapTranslationEngine_AppID1Name_Client_ID; }
		}

		public string AppID2Name
		{
			get { return Resources.BingSoapTranslationEngine_AppID2Name_Client_secret; }
		}

		public bool IsUserSelectable
		{
			get { return true; }
		}

		public bool IsDefault
		{
			get { return false; }
		}

		public string UniqueInternalName
		{
			get { return @"b5c87f9c-e3cd-4963-a3a2-559d3e69e961"; }
		}

		public string UserReadableName
		{
			get { return Resources.BingSoapTranslationEngine_UserReadableName_Microsoft_Translator__Bing_; }
		}

		public TranslationLanguageInfo[] GetSourceLanguages(string appID, string appID2)
		{
			if (_names == null)
			{
				try
				{
					protectWSCall(
						delegate
						{
							var at = BingTranslationHelper.GetAccessToken(appID, appID2);
							var names = BingTranslationHelper.GetLanguagesForTranslate(at);

							var result = new List<TranslationLanguageInfo>();

							// ReSharper disable LoopCanBeConvertedToQuery
							foreach (var iso6391Code in names)
							// ReSharper restore LoopCanBeConvertedToQuery
							{
								var ci = IntelligentGetCultureInfo(iso6391Code);

								if (ci != null)
								{
									result.Add(
										new TranslationLanguageInfo
											{
												LanguageCode = iso6391Code,
												UserReadableName = ci.DisplayName,
											});
								}
							}

							_names = result.ToArray();
						});
				}
				catch (WebException x)
				{
					LogCentral.Current.LogError(@"Error while getting source languages. Ignoring.", x);
					return new TranslationLanguageInfo[] { };
				}
			}

			return _names;
		}

		public TranslationLanguageInfo[] GetDestinationLanguages(string appID, string appID2)
		{
			return GetSourceLanguages(appID, appID2);
		}

		internal static CultureInfo IntelligentGetCultureInfo(string iso6391Code)
		{
			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var cultureInfo in CultureInfo.GetCultures(CultureTypes.AllCultures))
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				if (string.Compare(iso6391Code, cultureInfo.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase) == 0 ||
					string.Compare(iso6391Code, cultureInfo.Name, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return cultureInfo;
				}
			}

			return null;
		}

		private delegate void ActionToProtect();

		public bool SupportsArrayTranslation { get { return true; } }

		public int MaxArraySize
		{
			get { return 25; }
		}

		public string AppIDLink
		{
			get { return @"http://zeta.li/zre-translation-appid-bing"; }
		}

		public string[] TranslateArray(
			string appID,
			string appID2,
			string[] texts,
			string sourceLanguageCode,
			string destinationLanguageCode,
			string[] wordsToProtect,
			string[] wordsToRemove)
		{
			if (texts == null || texts.Length <= 0)
			{
				return texts;
			}
			else
			{
				var result = new List<string>();

				protectWSCall(
					delegate
					{
						var at = BingTranslationHelper.GetAccessToken(appID, appID2);
						var raw =
							BingTranslationHelper.TranslateArray(
								at,
								sourceLanguageCode,
								destinationLanguageCode,
								TranslationHelper.ProtectWords(
									TranslationHelper.RemoveWords(
										texts,
										wordsToRemove),
									wordsToProtect));

						foreach (var response in raw)
						{
							if (StringExtensionMethods.IsNullOrWhiteSpace(response.Error))
							{
								result.Add(TranslationHelper.UnprotectWords(response.Translation, wordsToProtect));
							}
							else
							{
								result.Add(FileGroup.DefaultTranslationErrorPrefix + @" " + response.Error);
							}
						}
					});

				return result.ToArray();
			}
		}

		public bool isSourceLanguageSupported(string appID, string appID2, string languageCode)
		{
			return TranslationHelper.IsSupportedLanguage(languageCode, GetSourceLanguages(appID, appID2));
		}

		public bool isDestinationLanguageSupported(string appID, string appID2, string languageCode)
		{
			return TranslationHelper.IsSupportedLanguage(languageCode, GetDestinationLanguages(appID, appID2));
		}

		public string Translate(
			string appID,
			string appID2,
			string text,
			string sourceLanguageCode,
			string destinationLanguageCode,
			string[] wordsToProtect,
			string[] wordsToRemove)
		{
			if (StringExtensionMethods.IsNullOrWhiteSpace(text))
			{
				return text;
			}
			else
			{
				var result = string.Empty;

				protectWSCall(
					delegate
					{
						var at = BingTranslationHelper.GetAccessToken(appID, appID2);
						result =
							TranslationHelper.UnprotectWords(
								BingTranslationHelper.Translate(
									at,
									sourceLanguageCode,
									destinationLanguageCode,
									TranslationHelper.ProtectWords(
										TranslationHelper.RemoveWords(
											text,
											wordsToRemove),
										wordsToProtect)).Translation,
								wordsToProtect);
					});

				return result;
			}
		}

		private static void protectWSCall(ActionToProtect action)
		{
			// http://msdn.microsoft.com/en-us/library/dd877917.aspx
			try
			{
				action();
			}
			catch (SoapException ex)
			{
				var msg = displayErrors(ex, ex.Detail);
				throw new Exception(msg, ex);
			}
		}

		private static string displayErrors(Exception x, XmlNode errorDetails)
		{
			var sb = new StringBuilder();
			sb.Append(x.Message);
			sb.Append(@" ");

			if (errorDetails != null && errorDetails.OwnerDocument != null)
			{
				// Add the default namespace to the namespace manager.
				var nsmgr =
					new XmlNamespaceManager(
						errorDetails.OwnerDocument.NameTable);
				nsmgr.AddNamespace(
					@"api",
					@"http://schemas.microsoft.com/LiveSearch/2008/03/Search");

				var errors = errorDetails.SelectNodes(
					@"./api:Errors/api:Error",
					nsmgr);

				if (errors != null)
				{
					// Iterate over the list of errors and display error details.
					foreach (XmlNode error in errors)
					{
						foreach (XmlNode detail in error.ChildNodes)
						{
							sb.Append(detail.Name + @": " + detail.InnerText);
							sb.Append(@" ");
						}
					}
				}
			}

			return sb.ToString().Trim();
		}

		public string MapCultureToSourceLanguageCode(string appID, string appID2, CultureInfo cultureInfo)
		{
			return DoMapCultureToLanguageCode(GetSourceLanguages(appID, appID2), cultureInfo);
		}

		public string MapCultureToDestinationLanguageCode(string appID, string appID2, CultureInfo cultureInfo)
		{
			return DoMapCultureToLanguageCode(GetDestinationLanguages(appID, appID2), cultureInfo);
		}

		public bool AreAppIDsSyntacticallyValid(string appID, string appID2)
		{
			return !string.IsNullOrEmpty(appID) && !string.IsNullOrEmpty(appID2);
		}

		internal static string DoMapCultureToLanguageCode(
			IEnumerable<TranslationLanguageInfo> availableLanguageInfos,
			CultureInfo cultureInfo)
		{
			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var translationLanguageInfo in availableLanguageInfos)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				if (string.Compare(
					translationLanguageInfo.LanguageCode,
					cultureInfo.TwoLetterISOLanguageName,
					StringComparison.OrdinalIgnoreCase) == 0 ||
					string.Compare(
						CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode).Name,
						cultureInfo.Name,
						StringComparison.OrdinalIgnoreCase) == 0 ||
					string.Compare(
						CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode).Name.Substring(0, 2),
						cultureInfo.Name.Substring(0, 2),
						StringComparison.OrdinalIgnoreCase) == 0)
				{
					return translationLanguageInfo.LanguageCode;
				}
			}

			throw new Exception(
				string.Format(
					Resources.BingSoapTranslationEngine_doMapCultureToLanguageCode_Microsoft_Translator__Bing__does_not_provide_a_language_code_for_the_culture___0___to_translate_,
					PrettyPrint(cultureInfo)));
		}

		public static string PrettyPrint(CultureInfo cultureInfo)
		{
			return string.Format(
				@"{0} ({1})",
				cultureInfo.DisplayName,
				cultureInfo);
		}
	}
}