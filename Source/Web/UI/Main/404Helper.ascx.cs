using System;
using System.Web.UI;
using Zeta.EnterpriseLibrary.Logging;
using Zeta.EnterpriseLibrary.Web;

public partial class UI_Main_404Helper :
	UserControl
{
	public string CategoryName
	{
		get
		{
			return ViewState[@"CategoryName"] as string;
		}
		set
		{
			ViewState[@"CategoryName"] = value;
		}
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		checkHandleRedirect();
	}

	private void checkHandleRedirect()
	{
		var cn = CategoryName;

		if (!string.IsNullOrEmpty(cn))
		{
			LogCentral.Current.LogInfo(
				string.Format(
					@"[404 root] About to gather 404 redirects for category '{0}'.",
					cn.Trim()));

			var redirects =
				Host.Current.ElementManager.FourZeroFourManager.GetFourZeroFourRedirects(cn.Trim());

			foreach (var redirect in redirects)
			{
				var gotoUrl = redirect.MatchUrl(Request.Url.Query);

				if (!string.IsNullOrEmpty(gotoUrl))
				{
					LogCentral.Current.LogInfo(
						string.Format(
							@"[404 root] About to 404 redirect to '{0}'.",
							gotoUrl));

					new QueryString(gotoUrl).Redirect(
						redirect.IsPermanent
							? RedirectMethod.Permanent
							: RedirectMethod.Temporary);
					return;
				}
			}

			LogCentral.Current.LogInfo(
				string.Format(
					@"[404 root] No matching to 404 redirect found for '{0}'.",
					Request.Url.Query));
		}
	}
}