namespace ZetaResourceEditor.RuntimeBusinessLogic.WebServices;

/// <summary>
/// Configures the proxy usage.
/// </summary>
public enum WebProxyUsage
{
    #region Enum members.

    /// <summary>
    /// Use no proxy at all.
    /// </summary>
    NoProxy,

    /// <summary>
    /// Use user-configured proxy settings.
    /// </summary>
    CustomProxy,

    /// <summary>
    /// Use default proxy-settings of Internet Explorer.
    /// </summary>
    DefaultProxy

    #endregion
}