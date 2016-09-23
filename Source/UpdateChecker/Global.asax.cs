namespace UpdateChecker
{
    using System;
    using System.Threading;
    using System.Web;

    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Zeta.VoyagerLibrary.Logging.LogCentral.FindConfigurationFilePath +=
                logCentral_FindConfigurationFilePath;
        }

        private static string logCentral_FindConfigurationFilePath(object sender)
        {
            return HttpContext.Current.Server.MapPath(@"~/Web.config");
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
                    Zeta.VoyagerLibrary.Logging.LogCentral.Current.LogError(
                        @"Application_Error occurred",
                        x);

                    //if (ConvertHelper.ToBoolean(
                    //    ConfigurationManager.AppSettings[@"ownErrorHandling.enable"], true))
                    //{
                    //    Session[@"TheException"] = x;
                    //    Server.ClearError();

                    //    // --

                    //    Response.Redirect(
                    //        PageBase.ReplaceTilde(
                    //                @"~/UI/Error.aspx"),
                    //        true);
                    //}
                }
            }
        }
    }
}