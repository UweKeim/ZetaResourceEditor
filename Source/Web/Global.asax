<%@ Application Language="C#" %>
<%@ Import Namespace="System.Threading" %>
<%@ Import Namespace="Zeta.EnterpriseLibrary.Common"%>
<%@ Import Namespace="Zeta.EnterpriseLibrary.Web.Base" %>

<script RunAt="server">

	void Application_Start( object sender, EventArgs e )
	{
		Zeta.EnterpriseLibrary.Logging.LogCentral.FindConfigurationFilePath +=
			logCentral_FindConfigurationFilePath;
	}

	private static string logCentral_FindConfigurationFilePath( object sender )
	{
		return HttpContext.Current.Server.MapPath( @"~/Web.config" );
	}

	void Application_End( object sender, EventArgs e )
	{
	}

	void Application_Error( object sender, EventArgs e )
	{
		var requestFilePath =
			Request.FilePath.ToLowerInvariant().Replace( '\\', '/' );

		if ( !requestFilePath.Contains( @"error.aspx" ) )
		{
			var x = Server.GetLastError().GetBaseException();
			if ( !(x is ThreadAbortException) )
			{
				Zeta.EnterpriseLibrary.Logging.LogCentral.Current.LogError(
					@"Application_Error occurred",
					x);

				if (ConvertHelper.ToBoolean(
					ConfigurationManager.AppSettings[@"ownErrorHandling.enable"], true))
				{
					Session[@"TheException"] = x;
					Server.ClearError();

					// --

					Response.Redirect(
						PageBase.ReplaceTilde(
								@"~/UI/Error.aspx"),
						true);
				}
			}
		}
	}

	void Session_Start( object sender, EventArgs e )
	{
	}

	void Session_End( object sender, EventArgs e )
	{
	}
	   
</script>

