namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	using System;
	using System.ComponentModel;
	using System.Diagnostics.CodeAnalysis;

	public class BrowserExtendedNavigatingEventArgs : CancelEventArgs
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

		private readonly string _frame;
		/// <summary>
		/// The name of the frame to navigate to
		/// </summary>
		[SuppressMessage( @"Microsoft.Performance", @"CA1811:AvoidUncalledPrivateCode" )]
		public string Frame
		{
			get
			{
				return _frame;
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

		/// <summary>
		/// Creates a new instance of WebBrowserExtendedNavigatingEventArgs
		/// </summary>
		/// <param name="automation">Pointer to the automation object of the browser</param>
		/// <param name="url">The URL to go to</param>
		/// <param name="frame">The name of the frame</param>
		/// <param name="navigationContext">The new window flags</param>
		public BrowserExtendedNavigatingEventArgs( 
			object automation, 
			Uri url, 
			string frame, 
			UrlContexts navigationContext )
		{
			_url = url;
			_frame = frame;
			_navigationContext = navigationContext;
			AutomationObject = automation;
		}
	}
}