namespace Web
{
    using System;
    using System.Configuration;
    using System.Threading;
    using System.Web;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Logging;
    using Zeta.VoyagerLibrary.WebForms.Base;

    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            LogCentral.FindConfigurationFilePath +=
                logCentral_FindConfigurationFilePath;
        }

        private static LogCentralFindConfigurationFilePathResult logCentral_FindConfigurationFilePath(object sender)
        {
            return new LogCentralFindConfigurationFilePathResult
            {
                LogFileConfigurationPath = HttpContext.Current.Server.MapPath(@"~/Web.config")
            };
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var requestFilePath =
                Request.FilePath.ToLowerInvariant().Replace('\\', '/');

            if (!requestFilePath.Contains(@"error.aspx"))
            {
                var x = Server.GetLastError().GetBaseException();
                if (!(x is ThreadAbortException))
                {
                    LogCentral.Current.LogError(
                        @"Application_Error occurred",
                        x);

                    if (ConvertHelper.ToBoolean(
                        ConfigurationManager.AppSettings[@"ownErrorHandling.enable"], true))
                    {
                        Session[@"TheException"] = x;
                        Server.ClearError();

                        // --

                        Response.Redirect(PageBase.ReplaceTilde(@"~/UI/Error.aspx"), true);
                    }
                }
            }
        }
    }
}