namespace ZetaResourceEditor.RuntimeBusinessLogic.WebServices
{
    #region Using directives.

    // ----------------------------------------------------------------------
    using System;
    using System.ComponentModel;
    using System.Net;
    using UpdateChecker;
    using Zeta.VoyagerLibrary.Logging;
    using Zeta.VoyagerLibrary.Tools;
    using Zeta.VoyagerLibrary.Tools.Storage;
    using ZetaUploader;

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
                        if (_current == null)
                        {
                            _current = new WebServiceManager();
                        }
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
            set
            {
                PersistanceHelper.SaveValue(
                    @"WebProxyUsage",
                    value.ToString());
            }
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
                if (WebProxyUsage == WebProxyUsage.NoProxy)
                {
                    return null;
                }
                else if (WebProxyUsage == WebProxyUsage.DefaultProxy)
                {
                    return WebRequest.GetSystemWebProxy();
                }
                else
                {
                    var s =
                        StringHelper.DeserializeFromString(
                                PersistanceHelper.RestoreValue(@"WebServiceProxy") as string)
                            as WebProxySerializator;

                    return s?.WebProxy;
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
                _zetaUploaderWS = null;
            }
        }

        /// <summary>
        /// Returns a ready-to-use (with optional proxy) web service client
        /// instance to access the error reporting web service.
        /// </summary>
        /// <value>The update checker WS.</value>
        public UpdateCheckerService UpdateCheckerWS
        {
            get
            {
                if (_updateCheckerWS == null)
                {
                    _updateCheckerWS =
                        new UpdateCheckerService
                        {
                            Timeout = (3600 * 1000),
                            AllowAutoRedirect = true
                        };

                    var proxy = WebServiceProxy;
                    if (proxy != null)
                    {
                        _updateCheckerWS.Proxy = proxy;
                    }

                    LogCentral.Current.LogInfo(
                        $@"Using WebService at URL '{_updateCheckerWS.Url}'.");
                }

                return _updateCheckerWS;
            }
        }

        /// <summary>
        /// Returns a ready-to-use (with optional proxy) web service client
        /// instance to access the zeta uploader web service.
        /// </summary>
        /// <value>The zeta uploader WS.</value>
        public ZetaUploaderCommunication ZetaUploaderWS
        {
            get
            {
                if (_zetaUploaderWS == null)
                {
                    _zetaUploaderWS =
                        new ZetaUploaderCommunication
                        {
                            Timeout = (3600 * 1000),
                            AllowAutoRedirect = true
                        };

                    var proxy = WebServiceProxy;
                    if (proxy != null)
                    {
                        _zetaUploaderWS.Proxy = proxy;
                    }

                    //#if !DEBUG
                    //                    _zetaUploaderWS.Url =
                    //                        @"http://www.zeta-uploader.com/Communication.asmx";
                    //#endif

                    LogCentral.Current.LogInfo(
                        $@"Using WebService at URL '{_zetaUploaderWS.Url}'.");
                }

                return _zetaUploaderWS;
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

                    var c = webProxy.Credentials as NetworkCredential;

                    if (c != null)
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
        private static readonly object TypeLock = new object();

        private UpdateCheckerService _updateCheckerWS;
        private ZetaUploaderCommunication _zetaUploaderWS;

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
}