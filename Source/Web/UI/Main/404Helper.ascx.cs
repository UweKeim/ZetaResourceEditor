namespace Web.UI.Main;

using Code;
using System;
using System.Web.UI;
using Zeta.VoyagerLibrary.Logging;
using Zeta.VoyagerLibrary.WebForms;

public partial class UI_Main_404Helper :
    UserControl
{
    public string CategoryName
    {
        get => ViewState[@"CategoryName"] as string;
        set => ViewState[@"CategoryName"] = value;
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
                $@"[404 root] About to gather 404 redirects for category '{cn.Trim()}'.");

            var redirects =
                Host.Current.ElementManager.FourZeroFourManager.GetFourZeroFourRedirects(cn.Trim());

            foreach (var redirect in redirects)
            {
                var gotoUrl = redirect.MatchUrl(Request.Url.Query);

                if (!string.IsNullOrEmpty(gotoUrl))
                {
                    LogCentral.Current.LogInfo(
                        $@"[404 root] About to 404 redirect to '{gotoUrl}'.");

                    new QueryString(gotoUrl).Redirect(
                        redirect.IsPermanent
                            ? RedirectMethod.Permanent
                            : RedirectMethod.Temporary);
                    return;
                }
            }

            LogCentral.Current.LogInfo(
                $@"[404 root] No matching to 404 redirect found for '{Request.Url.Query}'.");
        }
    }
}