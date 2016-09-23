namespace Web.UI.Main
{
    using System;
    using System.Configuration;
    using System.Net.Mail;
    using App_GlobalResources;
    using Code;
    using Code.Base;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Logging;
    using Zeta.VoyagerLibrary.Tools.EMail;
    using Zeta.VoyagerLibrary.WebForms;
    using ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.FourZeroFour;
    using ZetaResourceEditorWebsite.RuntimeWeb.Code.Sys;

    public partial class Page404Core :
        PageBase
    {
		private void Page_Load(object sender, EventArgs e)
		{
			var lc =
				Request.UserLanguages != null &&
				Request.UserLanguages.Length > 0
					? Request.UserLanguages[0]
					: @"en";

			lc = lc?.ToLowerInvariant() ?? @"en";
			lc = lc.StartsWith(@"de", StringComparison.InvariantCultureIgnoreCase) ? @"de" : @"en";

			var new404 =ReplaceTilde(ConfigurationManager.AppSettings[$@"handler404.{lc}"]);
			new404 = new404.TrimEnd('&', '?');

			new404 += new404.Contains(@"?") ? @"&" : @"?";
			new404 += Request.Url.Query;

			LogCentral.Current.LogInfo(
			    $@"[404] (Language: '{lc}') about to 404 redirect from '{Request.Url.OriginalString}' to '{new404}', Referer was '{Request
			        .UrlReferrer?.OriginalString ?? string.Empty}'.");

			// Notify shop owner.
			if (ConvertHelper.ToBoolean(ConfigurationManager.AppSettings[@"notify404ByMail"]))
			{
				if ( !ConvertHelper.ToBoolean(ConfigurationManager.AppSettings[@"notify404ByMailIgnoreCrawler"]) /*||
					!Request.IsCrawler*/)
				{
					var cn = ConfigurationManager.AppSettings[@"notify404MailIgnoreCategoryName"];
					
					// Only send if NOT in the exclude/ignore list.
					if (!Host.Current.ElementManager.FourZeroFourManager
						.GetFourZeroFourEMailNotifyIgnores(cn).IsMatch(Request))
					{
						var receivers = ConfigurationManager.AppSettings[@"receivers404Mail"];

						send404Mail(
							receivers,
							Request.Url.Query.Replace(@"?404;", string.Empty),
							Request.UrlReferrer?.OriginalString ?? string.Empty,
							new404,
							Request.UserAgent,
							FourZeroFourEMailNotifyIgnore.GetUserHostName(Request.UserHostAddress),
							Request.UserHostAddress);
					}
				}
			}

			new QueryString(new404).Redirect();
		}

		private static void send404Mail(
			string receivers,
			string url,
			string refererUrl,
			string redirectUrl,
			string userAgent,
			string userHostName,
			string userHostAddress)
		{
			var subject = Resources.Str_404EMailMessageSubject;
			var body =
				replacePlaceholders(
					Resources.Str_404EMailMessageBody,
					url,
					refererUrl,
					redirectUrl,
					userAgent,
					userHostName,
					userHostAddress);

			using (var message = new MailMessage())
			{
				message.IsBodyHtml = true;
				message.Subject = subject;
				message.Body = body;

				message.From = Host.Current.ElementManager.OwnerEMailAddress;
				message.To.Add(receivers);

				MailHelper.WriteMailToFile(
					message,
					@"Zeta Producer Shop - Main_404.html");
				EMailHelper.SendEMailMessage(message);
			}
		}

		private static string replacePlaceholders(
			string text,
			string url,
			string refererUrl,
			string redirectUrl,
			string userAgent,
			string userHostName,
			string userHostAddress)
		{
			if (string.IsNullOrEmpty(text))
			{
				return text;
			}
			else
			{
				text = text.Replace(@"{Url.Url}", url ?? @"-");
				text = text.Replace(@"{Url.Referrer}", refererUrl ?? @"-");
				text = text.Replace(@"{Url.Redirect}", redirectUrl ?? @"-");
				text = text.Replace(@"{Url.UserAgent}", userAgent ?? @"-");
				text = text.Replace(@"{Url.UserHostAddress}", userHostAddress ?? @"-");
				text = text.Replace(@"{Url.UserHostName}", userHostName ?? @"-");

				return text;
			}
		}
	}
}