namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.FourZeroFour
{
	using System;
	using System.Data;
	using System.Net;
	using System.Net.Sockets;
	using System.Web;
	using Zeta.EnterpriseLibrary.Data;
	using Zeta.EnterpriseLibrary.Logging;

	public class FourZeroFourEMailNotifyIgnore
	{
		private enum DetectType
		{
			UserAgent,
			Url,
			UrlReferrer,
			UserHostAddress,
			UserHostName,
			UserLanguages
		}

		private enum PatternType
		{
			SubString
		}

		private string _pattern;
		private DetectType _detectType;
		private PatternType _patternType;

		public FourZeroFourEMailNotifyIgnore Load(
			DataRow row)
		{
			DBHelper.ReadField(out _pattern, row[@"Pattern"]);
			DBHelper.ReadField(out _detectType, row[@"DetectType"], EnumMode.String);
			DBHelper.ReadField(out _patternType, row[@"PatternType"], EnumMode.String);

			return this;
		}

		public static string GetUserHostName(string hostAddress)
		{
			var hostname = hostAddress;
			try
			{
				LogCentral.Current.LogDebug(
					string.Format(
						@"Trying to resolve host name of '{0}'.",
						hostAddress));

				// Example from 
				// http://www.microsoft.com/communities/newsgroups/en-us/default.aspx?dg=microsoft.public.de.german.entwickler.dotnet.asp&tid=83bde397-291d-417e-b2b8-b2a1a6c7e06a&p=1

				var host = Dns.GetHostEntry(hostAddress);
				hostname = host.HostName;
			}
			catch (SocketException e)
			{
				//-- Fallback if lookup failed.
				LogCentral.Current.LogDebug(
					string.Format(
						@"Failed to resolve host name of '{0}' - Using IP address.",
						hostAddress),
					e);
			}

			return hostname;
		}

		public bool IsMatch(HttpRequest request)
		{
			switch (_patternType)
			{
				case PatternType.SubString:
					string check;

					switch (_detectType)
					{
						case DetectType.UserAgent:
							check = request.UserAgent;
							break;
						case DetectType.Url:
							check = request.Url == null ? null : request.Url.OriginalString;
							break;

						case DetectType.UrlReferrer:
							check = request.UrlReferrer == null ? null : request.UrlReferrer.OriginalString;
							break;

						case DetectType.UserHostAddress:
							check = request.UserHostAddress;
							break;

						case DetectType.UserHostName:
							check = GetUserHostName(request.UserHostAddress);
							break;

						case DetectType.UserLanguages:
							check = request.UserLanguages == null ? null : string.Join(@", ", request.UserLanguages);
							break;

						default:
							throw new ArgumentOutOfRangeException(
								@"_detectType",
								@"Invalid detect type.");
					}

					if (string.IsNullOrEmpty(check))
					{
						LogCentral.Current.LogInfo(
							string.Format(
								@"[404 notify e-mail ignore] NOT matching: pattern to check = '{0}', against string '{1}', of detect type '{2}' with pattern type '{3}'.",
								_pattern,
								@"(NULL/empty)",
								_detectType,
								_patternType));

						return false;
					}
					else
					{
						var match =
							check.IndexOf(
								_pattern,
								StringComparison.InvariantCultureIgnoreCase) >= 0;

						if (match)
						{
							LogCentral.Current.LogInfo(
								string.Format(
									@"[404 notify e-mail ignore] IS matching: pattern to check = '{0}', against string '{1}', of detect type '{2}' with pattern type '{3}'.",
									_pattern,
									check,
									_detectType,
									_patternType));

							return true;
						}
						else
						{
							LogCentral.Current.LogInfo(
								string.Format(
									@"[404 notify e-mail ignore] NOT matching: pattern to check = '{0}', against string '{1}', of detect type '{2}' with pattern type '{3}'.",
									_pattern,
									check,
									_detectType,
									_patternType));

							return false;
						}
					}

				default:
					throw new ArgumentOutOfRangeException(
						@"_patternType",
						@"Invalid pattern type.");
			}
		}
	}
}