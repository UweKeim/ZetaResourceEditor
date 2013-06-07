<%@ Page Language="C#" AutoEventWireup="true" %>

<%@ Import Namespace="System.Net.Mail" %>
<%@ Import Namespace="ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.FourZeroFour"%>
<%@ Import Namespace="ZetaResourceEditorWebsite.RuntimeWeb.Code.Sys" %>
<%@ Import Namespace="Zeta.EnterpriseLibrary.Common" %>
<%@ Import Namespace="Zeta.EnterpriseLibrary.Web" %>
<%@ Import Namespace="Zeta.EnterpriseLibrary.Logging" %>
<%@ Import Namespace="Zeta.EnterpriseLibrary.Tools.EMail" %>

<script runat="server">
	private void Page_Load(object sender, EventArgs e)
	{
		var lc =
			Request.UserLanguages != null &&
			Request.UserLanguages.Length > 0
				? Request.UserLanguages[0]
				: @"en";

		lc = lc == null ? @"en" : lc.ToLowerInvariant();
		lc = lc.StartsWith(@"de", StringComparison.InvariantCultureIgnoreCase) ? @"de" : @"en";

		var new404 =
			Zeta.EnterpriseLibrary.Web.Base.PageBase.ReplaceTilde(
				ConfigurationManager.AppSettings[
					string.Format(@"handler404.{0}", lc)]);
		new404 = new404.TrimEnd('&', '?');

		new404 += new404.Contains(@"?") ? @"&" : @"?";
		new404 += Request.Url.Query;

		LogCentral.Current.LogInfo(
			string.Format(
				@"[404] (Language: '{0}') about to 404 redirect from '{1}' to '{2}', Referer was '{3}'.",
				lc,
				Request.Url.OriginalString,
				new404,
				Request.UrlReferrer == null ? string.Empty : Request.UrlReferrer.OriginalString));

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
						Request.UrlReferrer == null ? string.Empty : Request.UrlReferrer.OriginalString,
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
		var subject = Resources.Resources.Str_404EMailMessageSubject;
		var body =
			replacePlaceholders(
				Resources.Resources.Str_404EMailMessageBody,
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
</script>

