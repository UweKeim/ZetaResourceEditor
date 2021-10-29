namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.UrlRewrite;

using System;
using Intelligencia.UrlRewriter.Logging;
using Zeta.VoyagerLibrary.Logging;

public class Log4NetRewriteLogger :
    IRewriteLogger
{
    public void Debug( object message )
    {
        LogCentral.Current.LogInfo( makeLoggingMessage( message ) );
    }

    public void Info( object message )
    {
        LogCentral.Current.LogInfo( makeLoggingMessage( message ) );
    }

    public void Warn( object message )
    {
        LogCentral.Current.LogWarn( makeLoggingMessage( message ) );
    }

    public void Error( object message )
    {
        LogCentral.Current.LogError( makeLoggingMessage( message ) );
    }

    public void Error( object message, Exception exception )
    {
        LogCentral.Current.LogError( makeLoggingMessage( message ) );
    }

    public void Fatal( object message, Exception exception )
    {
        LogCentral.Current.LogFatal( makeLoggingMessage( message ) );
    }

    private static string makeLoggingMessage(object message)
    {
        return $@"[URL Rewriter] {message ?? string.Empty}";
    }
}