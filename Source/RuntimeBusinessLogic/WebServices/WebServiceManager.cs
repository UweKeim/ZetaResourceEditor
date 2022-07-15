namespace ZetaResourceEditor.RuntimeBusinessLogic.WebServices;

#region Using directives.

// ----------------------------------------------------------------------
using System.ComponentModel;
using System.Net;
using ServiceReference1;
using Zeta.VoyagerLibrary.Core.Tools.Storage;
using Zeta.VoyagerLibrary.Core.Tools.Text;

// ----------------------------------------------------------------------

#endregion

/////////////////////////////////////////////////////////////////////////

/// <summary>
/// Class for handling and managing the different web services that
/// the application consumes.
/// </summary>
public sealed class WebServiceManager
{
    #region Public properties.

    // ------------------------------------------------------------------

    /// <summary>
    /// Singleton access.
    /// </summary>
    /// <value>The current instance.</value>
    public static WebServiceManager Current
    {
        get
        {
            if (_current == null)
            {
                // According to 
                // http://www.dofactory.com/Patterns/PatternSingleton.aspx,
                // it is sufficient to lock only the creation.
                // 
                // Quote:
                //		Support multithreaded applications through
                //		'Double checked locking' pattern which (once
                //		the instance exists) avoids locking each
                //		time the method is invoked 					
                //
                // http://geekswithblogs.net/akraus1/articles/90803.aspx
                // has the correct way of locking: declaring as "volatile".
                //
                // http://www.ibm.com/developerworks/java/library/j-dcl.html
                // has an in-deep discussion.
                lock (TypeLock)
                {
                    _current ??= new WebServiceManager();
                }
            }

            return _current;
        }
    }

    /// <summary>
    /// Gets or sets the web proxy usage.
    /// </summary>
    /// <value>The web proxy usage.</value>
    public WebProxyUsage WebProxyUsage
    {
        get
        {
            var v =
                PersistanceHelper.RestoreValue(@"WebProxyUsage") as string;

            if (string.IsNullOrEmpty(v))
            {
                return WebProxyUsage.DefaultProxy;
            }
            else
            {
                return (WebProxyUsage)Enum.Parse(
                    typeof(WebProxyUsage),
                    v,
                    true);
            }
        }
        set => PersistanceHelper.SaveValue(
            @"WebProxyUsage",
            value.ToString());
    }

    /// <summary>
    /// The proxy server used for web service requests.
    /// Returns NULL if none.
    /// </summary>
    /// <value>The web service proxy.</value>
    [Browsable(false)]
    public IWebProxy WebServiceProxy
    {
        get
        {
            switch (WebProxyUsage)
            {
                case WebProxyUsage.NoProxy:
                    return null;
                case WebProxyUsage.DefaultProxy:
                    return WebRequest.GetSystemWebProxy();
                default:
                {
                    var s =
                        StringHelper.DeserializeFromString(
                                PersistanceHelper.RestoreValue(@"WebServiceProxy") as string)
                            as WebProxySerializator;

                    return s?.WebProxy;
                }
            }
        }
        set
        {
            if (value == null)
            {
                WebProxyUsage = WebProxyUsage.NoProxy;

                PersistanceHelper.SaveValue(
                    @"WebServiceProxy",
                    string.Empty);
            }
            else
            {
                if (value == WebRequest.GetSystemWebProxy())
                {
                    WebProxyUsage = WebProxyUsage.DefaultProxy;

                    PersistanceHelper.SaveValue(
                        @"WebServiceProxy",
                        string.Empty);
                }
                else
                {
                    WebProxyUsage = WebProxyUsage.CustomProxy;

                    PersistanceHelper.SaveValue(
                        @"WebServiceProxy",
                        StringHelper.SerializeToString(
                            new WebProxySerializator((WebProxy)value)));
                }
            }

            // Reset web services.
            _updateCheckerWS = null;
        }
    }

    /// <summary>
    /// Returns a ready-to-use (with optional proxy) web service client
    /// instance to access the error reporting web service.
    /// </summary>
    /// <value>The update checker WS.</value>
    public UpdateCheckerServiceSoapClient UpdateCheckerWS
    {
        get
        {
            if (_updateCheckerWS == null)
            {
                var timeout = TimeSpan.FromSeconds(3600);

                var binding = new System.ServiceModel.BasicHttpBinding
                {
                    MaxBufferSize = int.MaxValue,
                    ReaderQuotas = XmlDictionaryReaderQuotas.Max,
                    MaxReceivedMessageSize = int.MaxValue,
                    AllowCookies = true,
                    SendTimeout = timeout,
                    CloseTimeout = timeout,
                    OpenTimeout = timeout,
                    ReceiveTimeout = timeout,
                    Security =
                    {
                        Mode = System.ServiceModel.BasicHttpSecurityMode.Transport
                    }
                };

                const string url = @"https://www.zeta-resource-editor.com/backend/UpdateCheckerService.asmx";
                var uri = new Uri(url);

                var proxy = WebServiceProxy;
                if (proxy == null)
                {
                    binding.UseDefaultWebProxy = true;
                }
                else
                {
                    binding.ProxyAddress = proxy.GetProxy(uri);
                    binding.BypassProxyOnLocal = proxy.IsBypassed(uri);
                    binding.UseDefaultWebProxy = false;
                    // TODO: Credentials ggf. auch noch setzen, irgendwie?
                }

                var adress = new System.ServiceModel.EndpointAddress(uri);
                LogCentral.Current.LogInfo(
                    $@"Creating SOAP service call to URL '{adress.Uri}' with Proxy '{binding.ProxyAddress}'.");

                _updateCheckerWS = new UpdateCheckerServiceSoapClient(binding, adress);
            }

            return _updateCheckerWS;
        }
    }

    // ------------------------------------------------------------------

    #endregion

    #region Private methods.

    // ------------------------------------------------------------------

    /// <summary>
    /// Initializes a new instance of the <see cref="WebServiceManager"/> 
    /// class. Don't instantiate.
    /// </summary>
    private WebServiceManager()
    {
    }

    // ------------------------------------------------------------------

    #endregion

    #region Class for helping serializing a web proxy.

    // ------------------------------------------------------------------

    /// <summary>
    /// Class for helping serializing a web proxy.
    /// </summary>
    [Serializable]
    private class WebProxySerializator
    {
        #region Public methods.

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="WebProxySerializator"/> class.
        /// </summary>
        /// <param name="webProxy">The web proxy.</param>
        public WebProxySerializator(
            WebProxy webProxy)
        {
            if (webProxy == null)
            {
                _isNull = true;
            }
            else
            {
                _isNull = false;

                _address = webProxy.Address;
                _bypassList = webProxy.BypassList;
                _bypassProxyOnLocal = webProxy.BypassProxyOnLocal;
                _useDefaultCredentials = webProxy.UseDefaultCredentials;

                if (webProxy.Credentials is NetworkCredential c)
                {
                    _domain = c.Domain;
                    _password = c.Password;
                    _userName = c.UserName;
                }
            }
        }

        #endregion

        #region Public properties.

        /// <summary>
        /// Gets the web proxy.
        /// </summary>
        /// <value>The web proxy.</value>
        public WebProxy WebProxy
        {
            get
            {
                if (_isNull)
                {
                    return null;
                }
                else
                {
                    var webProxy =
                        new WebProxy
                        {
                            Address = _address,
                            BypassList = _bypassList,
                            BypassProxyOnLocal = _bypassProxyOnLocal,
                            UseDefaultCredentials = _useDefaultCredentials
                        };

                    if (_domain != null || _password != null || _userName != null)
                    {
                        var c =
                            new NetworkCredential
                            {
                                Domain = _domain,
                                Password = _password,
                                UserName = _userName
                            };

                        webProxy.Credentials = c;
                    }

                    return webProxy;
                }
            }
        }

        #endregion

        #region Private variables.

        private readonly bool _isNull;

        private readonly Uri _address;
        private readonly string[] _bypassList;
        private readonly bool _bypassProxyOnLocal;
        private readonly string _domain;
        private readonly string _password;
        private readonly string _userName;
        private readonly bool _useDefaultCredentials;

        #endregion
    }

    // ------------------------------------------------------------------

    #endregion

    #region Private variables.

    // ------------------------------------------------------------------

    /// <summary>
    /// Best practice, see C# MSDN documentation of the "lock" keyword.
    /// </summary>
    private static readonly object TypeLock = new();

    private UpdateCheckerServiceSoapClient _updateCheckerWS;

    private static volatile WebServiceManager _current;

    // ------------------------------------------------------------------

    #endregion

    public void ApplyProxy(HttpWebRequest request)
    {
        var proxy = WebServiceProxy;
        if (proxy != null)
        {
            request.Proxy = proxy;
        }
    }
}

/////////////////////////////////////////////////////////////////////////