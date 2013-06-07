namespace ZetaResourceEditor.RuntimeBusinessLogic.WebServices
{
	#region Using directives.
	// ----------------------------------------------------------------------
	using System;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Net;
	using System.Web.Services.Protocols;
	using UpdateChecker;
	using Zeta.EnterpriseLibrary.Logging;
	using Zeta.EnterpriseLibrary.Tools;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using ZetaUploader;
	using TranslationService = TranslationService.TranslationService;
	using AdService = AdService.AdService;

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
				Debug.Assert(this != null);
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

					if (s == null)
					{
						return null;
					}
					else
					{
						return s.WebProxy;
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
				_adWS = null;
				_translationWS = null;
				_zetaUploaderWS = null;
			}
		}

		/// <summary>
		/// Returns a ready-to-use (with optional proxy) web service client
		/// instance to access the zeta uploader web service.
		/// </summary>
		/// <value>The windows client ad service WS.</value>
		public AdService AdWS
		{
			get
			{
				if (_adWS == null)
				{
					_adWS =
						new AdService
						{
							Timeout = (3600 * 1000),
							AllowAutoRedirect = true
						};

					var proxy = WebServiceProxy;
					if (proxy != null)
					{
						_adWS.Proxy = proxy;
					}

					//#if !DEBUG
					//                    _adWS.Url =
					//                        @"http://www.zeta-uploader.com/WebServices/WindowsClientAdService.asmx";
					//#endif

					LogCentral.Current.LogDebug(
						string.Format(
							@"Using WebService at URL '{0}'.",
							_adWS.Url));
				}

				return _adWS;
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

					//#if !DEBUG
					//                    _updateCheckerWS.Url =
					//                        @"http://www.zeta-uploader.com/WebServices/WindowsClientUpdateChecker.asmx";
					//#endif

					LogCentral.Current.LogDebug(
						string.Format(
						@"Using WebService at URL '{0}'.",
						_updateCheckerWS.Url));
				}

				return _updateCheckerWS;
			}
		}

		/// <summary>
		/// Returns a ready-to-use (with optional proxy) web service client
		/// instance to access the misc helper web service.
		/// </summary>
		/// <value>The personalization WS.</value>
		public TranslationService TranslationWS
		{
			get
			{
				if (_translationWS == null)
				{
					_translationWS =
						new TranslationService
							{
								Timeout = (3600 * 1000),
								AllowAutoRedirect = true
							};

					var proxy = WebServiceProxy;
					if (proxy != null)
					{
						_translationWS.Proxy = proxy;
					}

					//#if !DEBUG
					//                    _translationWS.Url =
					//                        @"http://www.zeta-uploader.com/WebServices/WindowsClientPersonalizationService.asmx";
					//#endif

					LogCentral.Current.LogInfo(
						string.Format(
						@"Using WebService at URL '{0}'.",
						_translationWS.Url));
				}

				return _translationWS;
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

					LogCentral.Current.LogDebug(
						string.Format(
							@"Using WebService at URL '{0}'.",
							_zetaUploaderWS.Url));
				}

				return _zetaUploaderWS;
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Error-safe calling of web service (and related) methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Simple action delegate.
		/// </summary>
		public delegate void SimpleAction();

		/// <summary>
		/// Simple action delegate being called on success.
		/// </summary>
		public delegate void SimpleActionSuccess();

		/// <summary>
		/// Simple action delegate being called on failure.
		/// </summary>
		public delegate void SimpleActionFailure(
			Exception x);

		/// <summary>
		/// Guards the web service call.
		/// Use this to protect sections where a non-existing web connection
		/// does NOT matter.
		/// </summary>
		/// <param name="action">The action.</param>
		public void GuardWebServiceCall(
			SimpleAction action)
		{
			GuardWebServiceCall(action, null, null);
		}

		/// <summary>
		/// Guards the web service call.
		/// Use this to protect sections where a non-existing web connection
		/// does NOT matter.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <param name="onFailure">The on failure.</param>
		public void GuardWebServiceCall(
			SimpleAction action,
			SimpleActionFailure onFailure)
		{
			GuardWebServiceCall(action, onFailure, null);
		}

		/// <summary>
		/// Guards the web service call.
		/// Use this to protect sections where a non-existing web connection
		/// does NOT matter.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <param name="onFailure">The on failure.</param>
		/// <param name="onSuccess">The on success.</param>
		public void GuardWebServiceCall(
			SimpleAction action,
			SimpleActionFailure onFailure,
			SimpleActionSuccess onSuccess)
		{
			Debug.Assert(this != null);

			if (action != null)
			{
				try
				{
					action();
				}
				catch (WebException x)
				{
					LogCentral.Current.LogError(
						string.Format(
						@"Silently caught WebException during guarded web service call."
						),
						x);

					if (onFailure != null)
					{
						onFailure(x);
					}

					return;
				}

				if (onSuccess != null)
				{
					onSuccess();
				}
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

		private AdService _adWS;
		private TranslationService _translationWS;
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

		public void ApplyProxy(SoapHttpClientProtocol request)
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