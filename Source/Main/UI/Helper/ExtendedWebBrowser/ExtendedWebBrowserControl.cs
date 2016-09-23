namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Collections.Generic;
	using System.Security.Permissions;
	using System.Text;
	using System.Windows.Forms;
	using System.Text.RegularExpressions;
	using Zeta.VoyagerLibrary.Common;
	using Zeta.VoyagerLibrary.Logging;
	using System.Diagnostics;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Extended web browser control with several enhancements.
	/// </summary>
	[ComVisible( true )]
	public class ExtendedWebBrowserControl :
		WebBrowser
	{
		#region Extended support to set text correctly, even when not fully initialized.
		// ------------------------------------------------------------------

		public Uri LastNavigatedUrl
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets | sets the HTML contents of the page 
		/// displayed in the WebBrowser control.
		/// </summary>
		public new virtual string DocumentText
		{
			get
			{
				return base.DocumentText;
			}
			set
			{
				if ( !IsDisposed )
				{
					// Set BOTH to get the OnDocumentCompleted event raised.
					base.DocumentText = value;
					SetDocumentHtml( value );
				}
			}
		}

		public override string Text
		{
			get
			{
				return DocumentText;
			}
			set
			{
				DocumentText = value;
			}
		}

		/*
		public string Charset
		{
			get
			{
				if ( DomDocument == null )
				{
					return string.Empty;
				}
				else
				{
					return DomDocument.charset;
				}
			}
			set
			{
				if ( !IsDisposed )
				{
					SetCharset( value );
				}
			}
		}
		*/

		private int _documentCompleteCount;

		/// <summary>
		/// Raises the DocumentCompleted event.
		/// </summary>
		protected override void OnDocumentCompleted(
			WebBrowserDocumentCompletedEventArgs e )
		{
			IsLoaded = true;

			base.OnDocumentCompleted( e );

			if ( _pendingCallsToOnDocumentComplete > 0 )
			{
				_pendingCallsToOnDocumentComplete--;
			}

			_documentCompleteCount++;
			if ( EventSink != null )
			{
				EventSink.OnDocumentComplete( this, _documentCompleteCount );
			}

			// If some delayed text need to be set.
			if ( !string.IsNullOrEmpty( _postPoneSetDocumentHtml ) )
			{
				var html = _postPoneSetDocumentHtml;
				_postPoneSetDocumentHtml = string.Empty;

				// Causes another call to OnDocumentComplete,
				// when fully loaded.
				SetDocumentHtml( html );
			}

			/*
			if ( !string.IsNullOrEmpty( postPoneSetCharset ) )
			{
				string charset = postPoneSetCharset;
				postPoneSetCharset = string.Empty;

				SetCharset( charset );
			}
			*/
		}

		/// <summary>
		/// Indicated whether fully initialized.
		/// </summary>
		protected bool IsReady
		{
			get
			{
				return Document != null;
			}
		}

		/*
		private void SetCharset(
			string charset )
		{
			// if not yet ready, postpone until ready.
			if ( !IsReady && postPoneSetCharset != charset )
			{
				postPoneSetCharset = charset;
			}
			else if ( IsReady )
			{
				if ( charset == null )
				{
					charset = string.Empty;
				}

				DomDocument.charset = charset;

				postPoneSetCharset = string.Empty;
			}
		}
		*/

		/// <summary>
		/// Put a HTML code into the main window's HTML view.
		/// </summary>
		private void SetDocumentHtml(
			string html )
		{
			// if not yet ready, postpone until ready.
			if ( !IsReady && _postPoneSetDocumentHtml != html )
			{
				_postPoneSetDocumentHtml = html;
			}
			else if ( IsReady )
			{
				// need to do this since html could be a pointer to 
				// PostPoneSetDocumentHtml.

				// --

				_pendingCallsToOnDocumentComplete++;
				try
				{
					if ( html == null )
					{
						html = string.Empty;
					}

					var documentEncoding = GetHtmlEncoding( html );

					if ( !string.IsNullOrEmpty( documentEncoding ) )
					{
						if ( Document != null )
						{
							if ( string.Compare( Document.Encoding, documentEncoding, true ) != 0 )
							{
								Document.Encoding = documentEncoding;
							}
						}
					}

					if ( Document != null )
					{
						Document.Write( html );
					}
					base.DocumentText = html;
				}
				finally
				{
					_pendingCallsToOnDocumentComplete--;
				}

				_postPoneSetDocumentHtml = string.Empty;
			}
		}

		/// <summary>
		/// Gets the HTML encoding.
		/// </summary>
		/// <param name="html">The HTML.</param>
		/// <returns></returns>
		protected virtual string GetHtmlEncoding(
			string html )
		{
			return DetectEncodingName( html );
		}

		/// <summary>
		/// &lt;meta http-equiv="Content-Type" content="text/html; charset=utf-8"&gridTemplate;.
		/// </summary>
		private const string HtmlContentEncodingPattern =
			@"<meta\s+http-equiv\s*=\s*[""'\s]?Content-Type\b.*?charset\s*=\s*([^""'\s>]*)";

		/// <summary>
		/// Detects the name of the encoding.
		/// </summary>
		/// <param name="html">The HTML.</param>
		/// <returns></returns>
		private static string DetectEncodingName(
			string html )
		{
			if ( string.IsNullOrEmpty( html ) )
			{
				return null;
			}
			else
			{
				// Find.
				var match = Regex.Match(
					html,
					HtmlContentEncodingPattern,
					RegexOptions.Singleline |
					RegexOptions.IgnoreCase );

				var groups = GetEffectiveMatchGroups( match );

				return !match.Success || groups.Count < 2 ? null : groups[1].Value;
			}
		}

		/// <summary>
		/// The Match.Groups collection seems to sometimes collect
		/// unsuccessfull entries. Don't count those.
		/// </summary>
		/// <param name="match">The match.</param>
		/// <returns></returns>
		public static List<Group> GetEffectiveMatchGroups(
			Match match )
		{
			var result = new List<Group>();

			if ( match != null && match.Success )
			{
				foreach ( Group group in match.Groups )
				{
					if ( group.Success )
					{
						result.Add( group );
					}
				}
			}

			return result;
		}

		/// <summary>
		/// Helper variables for storing infos to set when finally loaded.
		/// </summary>
		private string _postPoneSetDocumentHtml = string.Empty;
		/*
		private string postPoneSetCharset = string.Empty;
		*/
		private int _pendingCallsToOnDocumentComplete;

		// ------------------------------------------------------------------
		#endregion

		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		///
		/// </summary>
		public ExtendedWebBrowserControl()
		{
			ScriptErrorsSuppressed = true;
		}

		/// <summary>
		/// Shows a blank page.
		/// </summary>
		public void Clear()
		{
			if ( IsReady )
			{
				Navigate( @"about:blank" );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public void CreateNewDocument()
		{
			DocumentText = string.Empty;
		}

		// ------------------------------------------------------------------
		#endregion

		#region Reading and writing values from a script to the web browser.
		// ------------------------------------------------------------------

		/// <summary>
		/// This can be called from JavaScript that is being loaded into
		/// the HTML control. See "WebBrowser.ObjectForScripting" in the 
		/// documentation manual for further details.
		/// </summary>
		/// <remarks>
		/// Although this method is public, it should not be called from
		/// your C# code but only from your JavaScript on the HTML page.
		/// </remarks>
		public virtual string GetValueFromScript(
			string key )
		{
			var args = new ScriptValueGetEventArgs( key );

			OnScriptValueGet( args );

			return args.Value;
		}

		/// <summary>
		/// This can be called from JavaScript that is being loaded into
		/// the HTML control. See "WebBrowser.ObjectForScripting" in the 
		/// documentation manual for further details.
		/// </summary>
		/// <remarks>
		/// Although this method is public, it should not be called from
		/// your C# code but only from your JavaScript on the HTML page.
		/// </remarks>
		public virtual void SetValueFromScript(
			string key,
			string value )
		{
			var args = new ScriptValueSetEventArgs( key, value );

			OnScriptValueSet( args );
		}

		/// <summary>
		/// Subscribable event. Called when a JavaScript within the 
		/// web browser wants to get a value.
		/// </summary>
		public event EventHandler<ScriptValueGetEventArgs> ScriptValueGet;

		/// <summary>
		/// Subscribable event. Called when a JavaScript within the 
		/// web browser wants to set a value.
		/// </summary>
		public event EventHandler<ScriptValueSetEventArgs> ScriptValueSet;

		/// <summary>
		/// 
		/// </summary>
		protected virtual void OnScriptValueGet(
			ScriptValueGetEventArgs args )
		{
			if ( ScriptValueGet != null )
			{
				ScriptValueGet( this, args );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		protected virtual void OnScriptValueSet(
			ScriptValueSetEventArgs args )
		{
			if ( ScriptValueSet != null )
			{
				ScriptValueSet( this, args );
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// True when the html source is completely loaded 
		/// (either from memory or from file).
		/// </summary>
		protected bool IsLoaded
		{
			get;
			private set;
		}

		/// <summary>
		/// Get/set the event sink that receives notifications.
		/// </summary>
		/// <value>The event sink.</value>
		public IExtendedWebBrowserEventSink EventSink
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the default encoding.
		/// </summary>
		/// <value>The default encoding.</value>
		public static string DefaultEncoding
		{
			get
			{
				return @"unicode";
			}
		}

		/// <summary>
		/// Get the body tag HTML text from the clipboard (if any).
		/// Returns null if currently no HTML text on the clipboard.
		/// </summary>
		public virtual string DocumentTextBody
		{
			get
			{
				return ExtractHtmlBody( DocumentText );
			}
			set
			{
				var container = DocumentTextNonBody;

				if ( string.IsNullOrEmpty( container ) ||
					!container.Contains( @"{content}" ) )
				{
					DocumentText = value;
				}
				else
				{
					DocumentText =
						container.Replace( @"{content}", value );
				}
			}
		}

		/// <summary>
		/// Extracts the HTML body.
		/// </summary>
		/// <param name="htmlCode">The HTML code.</param>
		/// <returns></returns>
		public static string ExtractHtmlBody(
			string htmlCode )
		{
			if ( string.IsNullOrEmpty( htmlCode ) )
			{
				return htmlCode;
			}
			else
			{
				var regex = new Regex(
					@".*?<body[^>]*>(.*?)</body>",
					RegexOptions.Singleline |
						RegexOptions.IgnoreCase );

				// TODO: Precompile in external DLL, since it seems to be very slow.
				var m = regex.Match( htmlCode );

				return m.Success ? m.Groups[1].Value : htmlCode;
			}
		}

		/// <summary>
		/// Returns the automation object for the web browser
		/// </summary>
		public object Application
		{
			get
			{
				return WebBrowser2.Application;
			}
		}

		/// <summary>
		/// Gets the web browser 2.
		/// </summary>
		/// <value>The web browser 2.</value>
		public UnsafeNativeMethods.IWebBrowser2 WebBrowser2
		{
			get;
			private set;
		}

		// ------------------------------------------------------------------
		#endregion

		#region Extended, error-free clipboard HTML handling.
		// ------------------------------------------------------------------

		/// <summary>
		/// Get the selected HTML text from the clipboard (if any).
		/// Returns null if currently no HTML text on the clipboard.
		/// </summary>
		public static string ClipboardHtmlText
		{
			get
			{
				if ( Clipboard.ContainsText( TextDataFormat.Html ) )
				{
					string htmlCode;
					byte[] originalBuffer;

					GetHtmlFromClipboard( out htmlCode, out originalBuffer );

					//split Html to htmlInfo (and htmlSource)
					var htmlInfo = htmlCode.Substring( 0, htmlCode.IndexOf( '<' ) - 1 );

					const string startFragmentText = @"StartFragment:";
					const string endFragmentText = @"EndFragment:";

					//get Fragment positions
					var tmp = htmlInfo.Substring( htmlInfo.IndexOf( startFragmentText ) +
						startFragmentText.Length );
					tmp = tmp.Substring( 0, tmp.IndexOf( '\r' ) );
					var posStartSelection = Convert.ToInt32( tmp );

					tmp = htmlInfo.Substring( htmlInfo.IndexOf( endFragmentText ) +
						endFragmentText.Length );
					tmp = tmp.Substring( 0, tmp.IndexOf( '\r' ) );
					var posEndSelection = Convert.ToInt32( tmp );

					// get Fragment. Always UTF-8 as of spec.
					var s = Encoding.UTF8.GetString(
						originalBuffer,
						posStartSelection,
						posEndSelection - posStartSelection );

					return s;
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Get the body tag HTML text from the clipboard (if any).
		/// Returns null if currently no HTML text on the clipboard.
		/// </summary>
		public static string ClipboardHtmlTextBody
		{
			get
			{
				var htmlCode = ClipboardHtmlText;

				if ( string.IsNullOrEmpty( htmlCode ) )
				{
					return htmlCode;
				}
				else
				{
					var regex = new Regex(
						@".*?<body[^>]*>(.*?)</body>",
						RegexOptions.Singleline |
						RegexOptions.IgnoreCase );

					var m = regex.Match( htmlCode );

					if ( m.Success )
					{
						var groups =
							GetEffectiveMatchGroups(
							m );

						return groups[1].Value;
					}
					else
					{
						return htmlCode;
					}
				}
			}
		}

		/// <summary>
		/// Access the HTML text on the clipboard (if any).
		/// Returns null if currently no HTML text on the clipboard.
		/// </summary>
		public static string ClipboardHtmlTextComplete
		{
			get
			{
				if ( Clipboard.ContainsText( TextDataFormat.Html ) )
				{
					string htmlCode;
					byte[] originalBuffer;

					GetHtmlFromClipboard( out htmlCode, out originalBuffer );

					return htmlCode;
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// See http://66.249.93.104/search?q=cache:yfQWT9XlYogJ:www.eggheadcafe.com/aspnet_answers/NETFrameworkNETWindowsForms/Apr2006/post26606306.asp+IDataObject+html+utf-8&hl=de&gl=de&ct=clnk&cd=1&client=firefox-a
		/// See http://bakamachine.blogspot.com/2006/05/workarond-for-dataobject-html.html
		/// </summary>
		/// <remarks>Added 2006-06-12, Uwe Keim.</remarks>
		/// <returns></returns>
		private static void GetHtmlFromClipboard(
			out string htmlCode,
			out byte[] originalBuffer )
		{
			originalBuffer = GetHtmlFromDataObject( Clipboard.GetDataObject() );
			htmlCode = Encoding.UTF8.GetString( originalBuffer );
		}

		/// <summary>
		/// Extracts data of type Dataformat.Html from an IdataObject data container
		/// This method shouldn't throw any exception but writes relevant exception informations in the debug window
		/// </summary>
		/// <param name="data">IdataObject data container</param>
		/// <returns>A byte[] array with the decoded string or null if the method fails</returns>
		/// <remarks>Added 2006-06-12, Uwe Keim.</remarks>
		private static byte[] GetHtmlFromDataObject(
			System.Windows.Forms.IDataObject data )
		{
			var interopData =
				(System.Runtime.InteropServices.ComTypes.IDataObject)data;

			var format =
				new FORMATETC
				{
					cfFormat = ((short)DataFormats.GetFormat( DataFormats.Html ).Id),
					dwAspect = DVASPECT.DVASPECT_CONTENT,
					lindex = (-1),
					tymed = TYMED.TYMED_HGLOBAL
				};

			STGMEDIUM stgmedium;
			stgmedium.tymed = TYMED.TYMED_HGLOBAL;
			stgmedium.pUnkForRelease = null;

			//try
			//{
			var queryResult = interopData.QueryGetData( ref format );
			//}
			//catch ( Exception exp )
			//{
			//	Debug.WriteLine( "HtmlFromIDataObject.GetHtml . QueryGetData(ref format) threw an exception: "
			//		+ Environment.NewLine + exp.ToString() );
			//	return null;
			//}

			if ( queryResult != 0 )
			{
// ReSharper disable InvocationIsSkipped
				Debug.WriteLine(
					string.Format(
					@"HtmlFromIDataObject.GetHtml . QueryGetData(ref format) returned a code != 0 code: {0}",
					queryResult ) );
// ReSharper restore InvocationIsSkipped
				return null;
			}

			//try
			//{
			interopData.GetData( ref format, out stgmedium );
			//}
			//catch ( Exception exp )
			//{
			//	System.Diagnostics.Debug.WriteLine( "HtmlFromIDataObject.GetHtml . GetData(ref format, out stgmedium) threw this exception: "
			//		+ Environment.NewLine + exp.ToString() );
			//	return null;
			//}

			if ( stgmedium.unionmember == IntPtr.Zero )
			{
// ReSharper disable InvocationIsSkipped
				Debug.WriteLine(
					@"HtmlFromIDataObject.GetHtml . stgmedium.unionmember returned an IntPtr pointing to zero" );
// ReSharper restore InvocationIsSkipped
				return null;
			}

			var pointer = stgmedium.unionmember;

			var handleRef = new HandleRef( null, pointer );

			byte[] rawArray;

			try
			{
				var ptr1 = new IntPtr( GlobalLock( handleRef ) );

				var length = GlobalSize( handleRef );

				rawArray = new byte[length];

				Marshal.Copy( ptr1, rawArray, 0, length );
			}
			//catch ( Exception exp )
			//{
			//	Debug.WriteLine( "HtmlFromIDataObject.GetHtml . Html Import threw an exception: " + Environment.NewLine + exp.ToString() );
			//}
			finally
			{
				GlobalUnlock( handleRef );

			}

			return rawArray;
		}

		[DllImport( @"kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true )]
		private static extern int GlobalLock( HandleRef handle );

		[DllImport( @"kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true )]
		private static extern bool GlobalUnlock( HandleRef handle );

		[DllImport( @"kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true )]
		private static extern int GlobalSize( HandleRef handle );

		// ------------------------------------------------------------------
		#endregion

		#region Private variables.
		// ------------------------------------------------------------------

		private AxHost.ConnectionPointCookie _cookie;
		private WebBrowserExtendedEvents _events;

		/*
				private const bool _wantSetHtmlEditDesigner = false;
		*/

		// ------------------------------------------------------------------
		#endregion

		#region Public events.
		// ------------------------------------------------------------------

		/// <summary>
		/// Set a static global handler for commands, when you do not
		/// want to derive from this class or do not want to set the
		/// instance handler.
		/// </summary>
		public static event AppCommandEventHandler StaticAppCommand = null;

		/// <summary>
		/// Called when the static app command handler did not fire.
		/// </summary>
		public event AppCommandEventHandler AppCommand = null;

		/// <summary>
		/// Event handler indicating that the GUI needs to be updated
		/// (enabled/disable controls etc.).
		/// </summary>
		public event EventHandler UINeedsUpdate;

		/// <summary>
		/// Fires when downloading of a document begins
		/// </summary>
		public event EventHandler Downloading;

		/// <summary>
		/// Fires before navigation occurs in the given object (on either a 
		/// window or frameset element).
		/// </summary>
		public event EventHandler<BrowserExtendedNavigatingEventArgs> StartNavigate;

		/// <summary>
		/// Raised when a new window is to be created. Extends
		///  DWebBrowserEvents2::NewWindow2 with additional information about 
		/// the new window.
		/// </summary>
		public event EventHandler<BrowserExtendedNavigatingEventArgs> StartNewWindow;

		/// <summary>
		/// Raised when a navigate Error occurs. Extends
		/// DWebBrowserEvents2::NavigateError with additional information .
		/// </summary>
		public event EventHandler<BrowserExtendedNavigateErrorEventArgs> NavigateError;

		/// <summary>
		/// Fires when downloading is completed
		/// </summary>
		/// <remarks>
		/// Here you could start monitoring for script errors. 
		/// </remarks>
		public event EventHandler DownloadComplete;

		// ------------------------------------------------------------------
		#endregion

		#region Private properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// The framework around the body text.
		/// </summary>
		protected virtual string DocumentTextNonBody
		{
			get
			{
				// Must override in derived class.
				return string.Empty;
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Class WebBrowserExtendedEvents.
		// ------------------------------------------------------------------

		//This class will capture events from the WebBrowser
		private class WebBrowserExtendedEvents :
			UnsafeNativeMethods.DWebBrowserEvents2
		{
			private readonly ExtendedWebBrowserControl _browser;

			public WebBrowserExtendedEvents( ExtendedWebBrowserControl browser )
			{
				_browser = browser;
			}

			#region DWebBrowserEvents2 Members

			//Implement whichever events you wish
			public void BeforeNavigate2(
				object pDisp,
				ref object url,
				ref object flags,
				ref object targetFrameName,
				ref object postData,
				ref object headers,
// ReSharper disable RedundantAssignment
				ref bool cancel )
// ReSharper restore RedundantAssignment
			{
				var urlUri = new Uri( url.ToString() );

				string tFrame = null;
				if ( targetFrameName != null )
				{
					tFrame = targetFrameName.ToString();
				}

				var args =
					new BrowserExtendedNavigatingEventArgs( pDisp, urlUri, tFrame, UrlContexts.None );

				_browser.OnStartNavigate( args );

				cancel = args.Cancel;
				//pDisp = args.AutomationObject;
			}

			//The NewWindow2 event, used on Windows XP SP1 and below
// ReSharper disable RedundantAssignment
			public void NewWindow2( ref object pDisp, ref bool cancel )
// ReSharper restore RedundantAssignment
			{
				var args =
					new BrowserExtendedNavigatingEventArgs( pDisp, null, null, UrlContexts.None );
				_browser.OnStartNewWindow( args );
				cancel = args.Cancel;
				pDisp = args.AutomationObject;
			}

			// NewWindow3 event, used on Windows XP SP2 and higher
			public void NewWindow3(
				ref object ppDisp,
// ReSharper disable RedundantAssignment
				ref bool cancel,
// ReSharper restore RedundantAssignment
				uint dwFlags,
				string bstrUrlContext,
				string bstrUrl )
			{
				var args =
					new BrowserExtendedNavigatingEventArgs( ppDisp, new Uri( bstrUrl ), null, (UrlContexts)dwFlags );
				_browser.OnStartNewWindow( args );
				cancel = args.Cancel;
				ppDisp = args.AutomationObject;
			}

			// Fired when downloading begins
			public void DownloadBegin()
			{
				_browser.OnDownloading( EventArgs.Empty );
			}

			// Fired when downloading is completed
			public void DownloadComplete()
			{
				_browser.OnDownloadComplete( EventArgs.Empty );
			}

			#region Unused events

			// This event doesn't fire. 
			[DispId( 0x00000107 )]
			public void WindowClosing( bool isChildWindow, ref bool cancel )
			{
			}

			public void OnQuit()
			{

			}

			public void StatusTextChange( string text )
			{
			}

			public void ProgressChange( int progress, int progressMax )
			{
			}

			public void TitleChange( string text )
			{
			}

			public void PropertyChange( string szProperty )
			{
			}

			public void NavigateComplete2( object pDisp, ref object url )
			{
			}

			public void DocumentComplete( object pDisp, ref object url )
			{
			}

			public void OnVisible( bool visible )
			{
			}

			public void OnToolBar( bool toolBar )
			{
			}

			public void OnMenuBar( bool menuBar )
			{
			}

			public void OnStatusBar( bool statusBar )
			{
			}

			public void OnFullScreen( bool fullScreen )
			{
			}

			public void OnTheaterMode( bool theaterMode )
			{
			}

			public void WindowSetResizable( bool resizable )
			{
			}

			public void WindowSetLeft( int left )
			{
			}

			public void WindowSetTop( int top )
			{
			}

			public void WindowSetWidth( int width )
			{
			}

			public void WindowSetHeight( int height )
			{
			}

			public void SetSecureLockIcon( int secureLockIcon )
			{
			}

			public void FileDownload( ref bool cancel )
			{
			}

			public void NavigateError(
				object pDisp,
				ref object url,
				ref object frame,
				ref object statusCode,
// ReSharper disable RedundantAssignment
				ref bool cancel )
// ReSharper restore RedundantAssignment
			{
				var urlUri = new Uri( url.ToString() );

				var neStatus =
					(NavigateErrorStatusCode)(uint)ConvertHelper.ToInt64( statusCode );

				var args =
					new BrowserExtendedNavigateErrorEventArgs( pDisp, urlUri, neStatus, UrlContexts.None );

				_browser.OnNavigateError( args );

				cancel = args.Cancel;
			}

			public void PrintTemplateInstantiation( object pDisp )
			{
			}

			public void PrintTemplateTeardown( object pDisp )
			{
			}

			public void UpdatePageStatus( object pDisp, ref object nPage, ref object fDone )
			{
			}

			public void PrivacyImpactedStateChange( bool bImpacted )
			{
			}

			public void CommandStateChange( int command, bool enable )
			{
			}

			public void ClientToHostWindow( ref int cx, ref int cy )
			{
			}
			#endregion

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Raises the <see cref="Downloading"/> event
		/// </summary>
		/// <param name="e">Empty <see cref="EventArgs"/></param>
		/// <remarks>
		/// You could start an animation or a notification that downloading is 
		/// starting
		/// </remarks>
		protected void OnDownloading( EventArgs e )
		{
			if ( Downloading != null )
			{
				Downloading( this, e );
			}
		}

		/// <summary>
		/// Raises the <see cref="DownloadComplete"/> event
		/// </summary>
		/// <param name="e">Empty <see cref="EventArgs"/></param>
		protected virtual void OnDownloadComplete( EventArgs e )
		{
			if ( DownloadComplete != null )
			{
				DownloadComplete( this, e );
			}
		}

		/// <summary>
		/// Raises the <see cref="StartNewWindow"/> event
		/// </summary>
		/// <exception cref="ArgumentNullException">Thrown when BrowserExtendedNavigatingEventArgs is null</exception>
		protected void OnStartNewWindow( BrowserExtendedNavigatingEventArgs e )
		{
			if ( e == null )
			{
				throw new ArgumentNullException( "e" );
			}

			if ( StartNewWindow != null )
			{
				StartNewWindow( this, e );
			}
		}

		/// <summary>
		/// Raises the <see cref="StartNavigate"/> event
		/// </summary>
		/// <exception cref="ArgumentNullException">Thrown when BrowserExtendedNavigatingEventArgs is null</exception>
		protected void OnStartNavigate(
			BrowserExtendedNavigatingEventArgs e )
		{
			if ( e == null )
			{
				throw new ArgumentNullException( @"e" );
			}

			if ( StartNavigate != null )
			{
				StartNavigate( this, e );
			}
		}

		/// <summary>
		/// Raises the <see cref="NavigateError"/> event.
		/// </summary>
		/// <exception cref="ArgumentNullException">Thrown when 
		/// BrowserExtendedNavigateErrorEventArgs is null.</exception>
		protected void OnNavigateError(
			BrowserExtendedNavigateErrorEventArgs e )
		{
			if ( e == null )
			{
				throw new ArgumentNullException( @"e" );
			}

			if ( NavigateError != null )
			{
				NavigateError( this, e );
			}
		}

		/// <summary>
		/// This method will be called to give
		/// you a chance to create your own event sink.
		/// </summary>
		[PermissionSet( SecurityAction.LinkDemand, Name = @"FullTrust" )]
		protected override void CreateSink()
		{
			// Make sure to call the base class or the normal events won't fire.
			base.CreateSink();

			_events = new WebBrowserExtendedEvents( this );
			_cookie = new AxHost.ConnectionPointCookie(
				ActiveXInstance,
				_events,
				typeof( UnsafeNativeMethods.DWebBrowserEvents2 ) );
		}

		/// <summary>
		/// Detaches the event sink.
		/// </summary>
		[PermissionSet( SecurityAction.LinkDemand, Name = @"FullTrust" )]
		protected override void DetachSink()
		{
			if ( null != _cookie )
			{
				_cookie.Disconnect();
				_cookie = null;
			}

			base.DetachSink();
		}

		/// <summary>
		/// This method supports the .NET Framework
		/// infrastructure and is not intended
		/// to be used directly from your code.
		/// Called by the control when the underlying
		/// ActiveX control is created.
		/// </summary>
		/// <param name="nativeActiveXObject">Ein Objekt, das das zugrunde 
		/// liegende ActiveX-Steuerelement darstellt.</param>
		[PermissionSet( SecurityAction.LinkDemand, Name = @"FullTrust" )]
		protected override void AttachInterfaces(
			object nativeActiveXObject )
		{
			WebBrowser2 =
			  (UnsafeNativeMethods.IWebBrowser2)nativeActiveXObject;
			base.AttachInterfaces( nativeActiveXObject );
		}

		/// <summary>
		/// This method supports the .NET Framework infrastructure
		/// and is not intended to be used directly from your code.
		/// Called by the control when the underlying
		/// ActiveX control is discarded.
		/// </summary>
		[PermissionSet( SecurityAction.LinkDemand, Name = @"FullTrust" )]
		protected override void DetachInterfaces()
		{
			WebBrowser2 = null;
			base.DetachInterfaces();
		}

		/// <summary>
		/// Best practice, see C# MSDN documentation of the "lock" keyword.
		/// </summary>
		private static readonly object TypeLock = new object();

		/// <summary>
		/// 
		/// </summary>
		protected override void OnNavigated(
			WebBrowserNavigatedEventArgs e )
		{
			base.OnNavigated( e );

			IsLoaded = true;

			LastNavigatedUrl = e.Url;
		}

		/// <summary>
		/// 
		/// </summary>
		protected override void OnNavigating(
			WebBrowserNavigatingEventArgs e )
		{
			try
			{
				IsLoaded = false;

				var routing = EventHandled.Default;
				if ( EventSink != null )
				{
					routing = EventSink.OnNavigating( this, e );
				}

				if ( routing != EventHandled.StopRouting )
				{
					const string protocol = @"app:";
					if ( e.Url.ToString().StartsWith(
						protocol,
						StringComparison.InvariantCultureIgnoreCase ) )
					{
						OnAppCommand( e.Url );
						e.Cancel = true;
					}

					base.OnNavigating( e );
				}
			}
			catch ( Exception x )
			{
				// The web browser control seems to silently eat exceptions,
				// therefore log at least.
// ReSharper disable InvocationIsSkipped
				LogCentral.Current.LogDebug( x );
// ReSharper restore InvocationIsSkipped
				throw;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		protected virtual void OnAppCommand(
			Uri url )
		{
			HandleDefaultAppCommands(
				new AppCommandEventArgs( url ) );

			if ( AppCommand != null )
			{
				AppCommand( this, new AppCommandEventArgs( url ) );
			}

			lock ( TypeLock )
			{
				if ( StaticAppCommand != null )
				{
					StaticAppCommand( this, new AppCommandEventArgs( url ) );
				}
			}
		}

		/// <summary>
		/// Handles the default app commands.
		/// </summary>
		/// <param name="e">The AppCommandEventArgs
		/// instance containing the event data.</param>
		protected virtual void HandleDefaultAppCommands(
			AppCommandEventArgs e )
		{
			if ( e.CommandName == @"ShellExecuteFile" )
			{
				Process.Start( e.CommandParameters[@"FilePath"] );
			}
		}

		/*
				/// <summary>
				/// Gets the edit services.
				/// </summary>
				/// <returns></returns>
				private mshtml.IHTMLEditServices GetEditServices()
				{
					// an edit designer can only be attached,
					// when the document is ready and the designmode is on.
					Debug.Assert( IsLoaded, @"Document is not loaded." );
					Debug.Assert(
						DomDocument.designMode == @"On",
						string.Format(
						@"Design mode must be 'On' but is '{0}'.",
						DomDocument.designMode ) );

					var sp = (NativeMethods.IServiceProvider)DomDocument;

					object oEsp;

					sp.QueryService(
						NativeMethods.SID_SHTMLEditServices,
						NativeMethods.IID_IHTMLEditServices,
						out oEsp );

					var esp = (mshtml.IHTMLEditServices)oEsp;
					return esp;
				}
		*/

/*
		/// <summary>
		/// 
		/// </summary>
		private static void AddEditDesigner()
		{
			//if ( _wantSetHtmlEditDesigner )
			//{
			//    // An edit designer can only be attached,
			//    // when the document is ready and the designmode is on.
			//    Debug.Assert( IsLoaded, @"Document is not loaded." );
			//    Debug.Assert(
			//        DomDocument.designMode == @"On",
			//        string.Format(
			//        @"Design mode must be 'On' but is '{0}'.",
			//        DomDocument.designMode ) );

			//    mshtml.IHTMLEditDesigner designer = this;
			//    mshtml.IHTMLEditServices esp = GetEditServices();

			//    try
			//    {
			//        esp.AddDesigner( designer );
			//    }
			//    catch ( COMException x )
			//    {
			//        if ( x.ErrorCode == NativeMethods.E_INVALIDARG )
			//        {
			//            LogCentral.Current.LogError(
			//                @"[HTML-V] _com_error exception ocured during adding a designer. A known issue is a contained IFRAME tag.",
			//                x );
			//        }
			//        else
			//        {
			//            throw;
			//        }
			//    }
			//}
		}
*/

/*
		/// <summary>
		/// 
		/// </summary>
		private static void RemoveEditDesigner()
		{
			//if ( _wantSetHtmlEditDesigner )
			//{
			//    NativeMethods.IServiceProvider sp =
			//        DomDocument as NativeMethods.IServiceProvider;
			//    Debug.Assert( sp != null );

			//    object oEsp;

			//    sp.QueryService(
			//        NativeMethods.SID_SHTMLEditServices,
			//        NativeMethods.IID_IHTMLEditServices,
			//        out oEsp );

			//    mshtml.IHTMLEditServices esp = oEsp as mshtml.IHTMLEditServices;

			//    mshtml.IHTMLEditDesigner designer = this;
			//    try
			//    {
			//        Debug.Assert( esp != null );
			//        esp.RemoveDesigner( designer );
			//    }
			//    catch ( COMException x )
			//    {
			//        if ( x.ErrorCode == NativeMethods.E_INVALIDARG )
			//        {
			//            LogCentral.Current.LogError(
			//                @"[HTML-V] _com_error exception ocured during removing a designer. A known issue is a contained IFRAME tag.",
			//                x );
			//        }
			//        else
			//        {
			//            throw;
			//        }
			//    }
			//}
		}
*/

		/// <summary>
		/// Called when [update UI].
		/// </summary>
		protected virtual void OnUpdateUI()
		{
			if ( EventSink != null )
			{
				EventSink.OnUpdateUI( this );
			}

			if ( UINeedsUpdate != null )
			{
				UINeedsUpdate( this, EventArgs.Empty );
			}
		}

		// ------------------------------------------------------------------
		#endregion

		[StructLayout( LayoutKind.Sequential, CharSet = CharSet.Unicode )]
// ReSharper disable InconsistentNaming
		public struct OLECMDTEXT
// ReSharper restore InconsistentNaming
		{
			public uint cmdtextf;
			public uint cwActual;
			public uint cwBuf;
			[MarshalAs( UnmanagedType.ByValTStr, SizeConst = 100 )]
			public char rgwz;
		}

		[StructLayout( LayoutKind.Sequential )]
// ReSharper disable InconsistentNaming
		public struct OLECMD
// ReSharper restore InconsistentNaming
		{
			public uint cmdID;
			public uint cmdf;
		}

		// Interop definition for IOleCommandTarget. 
		[ComImport,
		Guid( @"b722bccb-4e68-101b-a2bc-00aa00404770" ),
		InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
		public interface IOleCommandTarget
		{
			//IMPORTANT: The order of the methods is critical here. You
			//perform early binding in most cases, so the order of the methods
			//here MUST match the order of their vtable layout (which is determined
			//by their layout in IDL). The interop calls key off the vtable ordering,
			//not the symbolic names. Therefore, if you switched these method declarations
			//and tried to call the Exec method on an IOleCommandTarget interface from your
			//application, it would translate into a call to the QueryStatus method instead.
			void QueryStatus( ref Guid pguidCmdGroup, UInt32 cCmds,
				[MarshalAs( UnmanagedType.LPArray, SizeParamIndex = 1 )] OLECMD[] prgCmds, ref OLECMDTEXT cmdText );
			void Exec( ref Guid pguidCmdGroup, uint nCmdId, uint nCmdExecOpt, ref object pvaIn, ref object pvaOut );
		}

/*
		private Guid _cmdGuid = new Guid( @"ED016940-BD5B-11CF-BA4E-00C04FD70816" );
*/

/*
		private enum MiscCommandTarget
		{
			Find = 1,
			ViewSource,
			Options
		}
*/
	}

	/////////////////////////////////////////////////////////////////////////
}