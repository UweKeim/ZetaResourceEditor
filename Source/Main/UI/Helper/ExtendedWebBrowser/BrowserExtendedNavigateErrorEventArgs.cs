namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	using System;
	using System.ComponentModel;
	using System.Diagnostics.CodeAnalysis;

	public class BrowserExtendedNavigateErrorEventArgs : CancelEventArgs
	{
		private readonly Uri _url;
		/// <summary>
		/// The URL to navigate to
		/// </summary>
		[SuppressMessage( @"Microsoft.Performance", @"CA1811:AvoidUncalledPrivateCode" )]
		public Uri Url
		{
			get
			{
				return _url;
			}
		}

		private readonly UrlContexts _navigationContext;
		/// <summary>
		/// The flags when opening a new window
		/// </summary>
		public UrlContexts NavigationContext
		{
			get
			{
				return _navigationContext;
			}
		}

		/// <summary>
		/// The pointer to ppDisp
		/// </summary>
		public object AutomationObject
		{
			get;
			set;
		}

		private readonly NavigateErrorStatusCode _statusCode;

		public NavigateErrorStatusCode StatusCode
		{
			get
			{
				return _statusCode;
			}
		}

		/// <summary>
		/// Creates a new instance of WebBrowserExtendedNavigateErrorEventArgs
		/// </summary>
		/// <param name="automation">Pointer to the automation object of the browser</param>
		/// <param name="url">The URL to go to</param>
		/// <param name="statusCode">The status code.</param>
		/// <param name="navigationContext">The new window flags</param>
		public BrowserExtendedNavigateErrorEventArgs( 
			object automation, 
			Uri url, 
			NavigateErrorStatusCode statusCode,
			UrlContexts navigationContext )
		{
			_url = url;
			_statusCode = statusCode;
			_navigationContext = navigationContext;
			AutomationObject = automation;
		}
	}
}