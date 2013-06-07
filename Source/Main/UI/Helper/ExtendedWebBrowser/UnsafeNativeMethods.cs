namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;
	using System.Security;
	using System.Windows.Forms;
	using IDataObject=System.Runtime.InteropServices.ComTypes.IDataObject;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Encapsulate native P/Invoke methods that must be compiled
	/// with the "unsafe" switch.
	/// </summary>
	public sealed class UnsafeNativeMethods
	{
		#region IDocHostUIHandler interface.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[ComImport, Guid( @"BD3F23C0-D43E-11CF-893B-00AA00BDCE1A" ),
		ComVisible( true ),
		InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
		public interface IDocHostUIHandler
		{
			#region Interface members.

			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int ShowContextMenu( [In, MarshalAs( UnmanagedType.U4 )] int dwID, [In] NativeMethods.POINT pt, [In, MarshalAs( UnmanagedType.Interface )] object pcmdtReserved, [In, MarshalAs( UnmanagedType.Interface )] object pdispReserved );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int GetHostInfo( [In, Out] NativeMethods.DOCHOSTUIINFO info );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int ShowUI( [In, MarshalAs( UnmanagedType.I4 )] int dwID, [In] IOleInPlaceActiveObject activeObject, [In] NativeMethods.IOleCommandTarget commandTarget, [In] IOleInPlaceFrame frame, [In] IOleInPlaceUIWindow doc );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int HideUI();
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int UpdateUI();
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int EnableModeless( [In, MarshalAs( UnmanagedType.Bool )] bool fEnable );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int OnDocWindowActivate( [In, MarshalAs( UnmanagedType.Bool )] bool fActivate );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int OnFrameWindowActivate( [In, MarshalAs( UnmanagedType.Bool )] bool fActivate );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int ResizeBorder( [In] NativeMethods.COMRECT rect, [In] IOleInPlaceUIWindow doc, bool fFrameWindow );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int TranslateAccelerator( [In] ref NativeMethods.MSG msg, [In] ref Guid group, [In, MarshalAs( UnmanagedType.I4 )] int nCmdID );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int GetOptionKeyPath( [Out, MarshalAs( UnmanagedType.LPArray )] string[] pbstrKey, [In, MarshalAs( UnmanagedType.U4 )] int dw );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int GetDropTarget( [In, MarshalAs( UnmanagedType.Interface )] IOleDropTarget pDropTarget, [MarshalAs( UnmanagedType.Interface )] out IOleDropTarget ppDropTarget );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int GetExternal( [MarshalAs( UnmanagedType.Interface )] out object ppDispatch );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int TranslateUrl( [In, MarshalAs( UnmanagedType.U4 )] int dwTranslate, [In, MarshalAs( UnmanagedType.LPWStr )] string strURLIn, [MarshalAs( UnmanagedType.LPWStr )] out string pstrURLOut );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int FilterDataObject( IDataObject pDO, out IDataObject ppDORet );

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region ICustomDoc interface.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[ComImport,
		InterfaceType( ComInterfaceType.InterfaceIsIUnknown ),
		GuidAttribute( @"3050f3f0-98b5-11cf-bb82-00aa00bdce0b" )]
		internal interface ICustomDoc
		{
			#region Interface members.

			[PreserveSig]
			void SetUIHandler( IDocHostUIHandler pUIHandler );

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region IOleInPlaceActiveObject interface.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[ComImport,
		Guid( @"00000117-0000-0000-C000-000000000046" ),
		SuppressUnmanagedCodeSecurity,
		InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
		public interface IOleInPlaceActiveObject
		{
			#region Interface members.

			[PreserveSig]
			int GetWindow( out IntPtr hwnd );
			void ContextSensitiveHelp( int fEnterMode );
			[PreserveSig]
			int TranslateAccelerator( [In] ref NativeMethods.MSG lpmsg );
			void OnFrameWindowActivate( bool fActivate );
			void OnDocWindowActivate( int fActivate );
			void ResizeBorder( [In] NativeMethods.COMRECT prcBorder, [In] IOleInPlaceUIWindow pUIWindow, bool fFrameWindow );
			void EnableModeless( int fEnable );

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region IOleInPlaceUIWindow interface.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[ComImport,
		InterfaceType( ComInterfaceType.InterfaceIsIUnknown ),
		Guid( @"00000115-0000-0000-C000-000000000046" )]
		public interface IOleInPlaceUIWindow
		{
			#region Interface members.

			IntPtr GetWindow();
			[PreserveSig]
			int ContextSensitiveHelp( int fEnterMode );
			[PreserveSig]
			int GetBorder( [Out] NativeMethods.COMRECT lprectBorder );
			[PreserveSig]
			int RequestBorderSpace( [In] NativeMethods.COMRECT pborderwidths );
			[PreserveSig]
			int SetBorderSpace( [In] NativeMethods.COMRECT pborderwidths );
			void SetActiveObject( [In, MarshalAs( UnmanagedType.Interface )] IOleInPlaceActiveObject pActiveObject, [In, MarshalAs( UnmanagedType.LPWStr )] string pszObjName );

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region IOleDropTarget interface.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[ComImport,
		Guid( @"00000122-0000-0000-C000-000000000046" ),
		InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
		public interface IOleDropTarget
		{
			#region Interface members.

			[PreserveSig]
			int OleDragEnter( [In, MarshalAs( UnmanagedType.Interface )] object pDataObj, [In, MarshalAs( UnmanagedType.U4 )] int grfKeyState, [In, MarshalAs( UnmanagedType.U8 )] long pt, [In, Out] ref int pdwEffect );
			[PreserveSig]
			int OleDragOver( [In, MarshalAs( UnmanagedType.U4 )] int grfKeyState, [In, MarshalAs( UnmanagedType.U8 )] long pt, [In, Out] ref int pdwEffect );
			[PreserveSig]
			int OleDragLeave();
			[PreserveSig]
			int OleDrop( [In, MarshalAs( UnmanagedType.Interface )] object pDataObj, [In, MarshalAs( UnmanagedType.U4 )] int grfKeyState, [In, MarshalAs( UnmanagedType.U8 )] long pt, [In, Out] ref int pdwEffect );

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region IOleInPlaceFrame interface.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[ComImport,
		Guid( @"00000116-0000-0000-C000-000000000046" ),
		InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
		public interface IOleInPlaceFrame
		{
			#region Interface members.

			IntPtr GetWindow();
			[PreserveSig]
			int ContextSensitiveHelp( int fEnterMode );
			[PreserveSig]
			int GetBorder( [Out] NativeMethods.COMRECT lprectBorder );
			[PreserveSig]
			int RequestBorderSpace( [In] NativeMethods.COMRECT pborderwidths );
			[PreserveSig]
			int SetBorderSpace( [In] NativeMethods.COMRECT pborderwidths );
			[PreserveSig]
			int SetActiveObject( [In, MarshalAs( UnmanagedType.Interface )] IOleInPlaceActiveObject pActiveObject, [In, MarshalAs( UnmanagedType.LPWStr )] string pszObjName );
			[PreserveSig]
			int InsertMenus( [In] IntPtr hmenuShared, [In, Out] NativeMethods.tagOleMenuGroupWidths lpMenuWidths );
			[PreserveSig]
			int SetMenu( [In] IntPtr hmenuShared, [In] IntPtr holemenu, [In] IntPtr hwndActiveObject );
			[PreserveSig]
			int RemoveMenus( [In] IntPtr hmenuShared );
			[PreserveSig]
			int SetStatusText( [In, MarshalAs( UnmanagedType.LPWStr )] string pszStatusText );
			[PreserveSig]
			int EnableModeless( bool fEnable );
			[PreserveSig]
			int TranslateAccelerator( [In] ref NativeMethods.MSG lpmsg, [In, MarshalAs( UnmanagedType.U2 )] short wID );

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region DWebBrowserEvents2 interface.
		// ------------------------------------------------------------------

		[ComImport, TypeLibType( (short)0x1010 ), InterfaceType( (short)2 ), Guid( @"34A715A0-6587-11D0-924A-0020AFC7AC4D" )]
		public interface DWebBrowserEvents2
		{
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x66 )]
			void StatusTextChange( [In, MarshalAs( UnmanagedType.BStr )] string Text );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x6c )]
			void ProgressChange( [In] int Progress, [In] int ProgressMax );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x69 )]
			void CommandStateChange( [In] int command, [In] bool enable );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x6a )]
			void DownloadBegin();
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x68 )]
			void DownloadComplete();
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x71 )]
			void TitleChange( [In, MarshalAs( UnmanagedType.BStr )] string Text );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x70 )]
			void PropertyChange( [In, MarshalAs( UnmanagedType.BStr )] string szProperty );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 250 )]
			void BeforeNavigate2( [In, MarshalAs( UnmanagedType.IDispatch )] object pDisp, [In, MarshalAs( UnmanagedType.Struct )] ref object url, [In, MarshalAs( UnmanagedType.Struct )] ref object Flags, [In, MarshalAs( UnmanagedType.Struct )] ref object TargetFrameName, [In, MarshalAs( UnmanagedType.Struct )] ref object PostData, [In, MarshalAs( UnmanagedType.Struct )] ref object Headers, [In, Out] ref bool Cancel );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0xfb )]
			void NewWindow2( [In, Out, MarshalAs( UnmanagedType.IDispatch )] ref object ppDisp, [In, Out] ref bool Cancel );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0xfc )]
			void NavigateComplete2( [In, MarshalAs( UnmanagedType.IDispatch )] object pDisp, [In, MarshalAs( UnmanagedType.Struct )] ref object url );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x103 )]
			void DocumentComplete( [In, MarshalAs( UnmanagedType.IDispatch )] object pDisp, [In, MarshalAs( UnmanagedType.Struct )] ref object url );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0xfd )]
			void OnQuit();
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0xfe )]
			void OnVisible( [In] bool Visible );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0xff )]
			void OnToolBar( [In] bool ToolBar );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x100 )]
			void OnMenuBar( [In] bool MenuBar );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x101 )]
			void OnStatusBar( [In] bool StatusBar );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x102 )]
			void OnFullScreen( [In] bool FullScreen );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 260 )]
			void OnTheaterMode( [In] bool TheaterMode );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x106 )]
			void WindowSetResizable( [In] bool Resizable );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x108 )]
			void WindowSetLeft( [In] int Left );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x109 )]
			void WindowSetTop( [In] int Top );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x10a )]
			void WindowSetWidth( [In] int Width );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x10b )]
			void WindowSetHeight( [In] int Height );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x107 )]
			void WindowClosing( [In] bool IsChildWindow, [In, Out] ref bool Cancel );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x10c )]
			void ClientToHostWindow( [In, Out] ref int cx, [In, Out] ref int cy );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x10d )]
			void SetSecureLockIcon( [In] int SecureLockIcon );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 270 )]
			void FileDownload( [In, Out] ref bool Cancel );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x10f )]
			void NavigateError( [In, MarshalAs( UnmanagedType.IDispatch )] object pDisp, [In, MarshalAs( UnmanagedType.Struct )] ref object url, [In, MarshalAs( UnmanagedType.Struct )] ref object Frame, [In, MarshalAs( UnmanagedType.Struct )] ref object StatusCode, [In, Out] ref bool Cancel );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0xe1 )]
			void PrintTemplateInstantiation( [In, MarshalAs( UnmanagedType.IDispatch )] object pDisp );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0xe2 )]
			void PrintTemplateTeardown( [In, MarshalAs( UnmanagedType.IDispatch )] object pDisp );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0xe3 )]
			void UpdatePageStatus( [In, MarshalAs( UnmanagedType.IDispatch )] object pDisp, [In, MarshalAs( UnmanagedType.Struct )] ref object nPage, [In, MarshalAs( UnmanagedType.Struct )] ref object fDone );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x110 )]
			void PrivacyImpactedStateChange( [In] bool bImpacted );
			[PreserveSig, MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime ), DispId( 0x111 )]
			void NewWindow3( [In, Out, MarshalAs( UnmanagedType.IDispatch )] ref object ppDisp, [In, Out] ref bool cancel, [In] uint dwFlags, [In, MarshalAs( UnmanagedType.BStr )] string bstrUrlContext, [In, MarshalAs( UnmanagedType.BStr )] string bstrUrl );
		}

		// ------------------------------------------------------------------
		#endregion

		#region IWebBrowser2 interface.
		// ------------------------------------------------------------------

		[ComImport, 
		SuppressUnmanagedCodeSecurity, 
		TypeLibType( TypeLibTypeFlags.FOleAutomation | (TypeLibTypeFlags.FDual | TypeLibTypeFlags.FHidden) ), 
		Guid( @"D30C1661-CDAF-11d0-8A3E-00C04FC9E26E" )]
		public interface IWebBrowser2
		{
			[DispId( 100 )]
			void GoBack();
			[DispId( 0x65 )]
			void GoForward();
			[DispId( 0x66 )]
			void GoHome();
			[DispId( 0x67 )]
			void GoSearch();
			[DispId( 0x68 )]
			void Navigate( [In] string Url, [In] ref object flags, [In] ref object targetFrameName, [In] ref object postData, [In] ref object headers );
			[DispId( -550 )]
			void Refresh();
			[DispId( 0x69 )]
			void Refresh2( [In] ref object level );
			[DispId( 0x6a )]
			void Stop();
			[DispId( 200 )]
			object Application
			{
				[return: MarshalAs( UnmanagedType.IDispatch )]
				get;
			}
			[DispId( 0xc9 )]
			object Parent
			{
				[return: MarshalAs( UnmanagedType.IDispatch )]
				get;
			}
			[DispId( 0xca )]
			object Container
			{
				[return: MarshalAs( UnmanagedType.IDispatch )]
				get;
			}
			[DispId( 0xcb )]
			object Document
			{
				[return: MarshalAs( UnmanagedType.IDispatch )]
				get;
			}
			[DispId( 0xcc )]
			bool TopLevelContainer
			{
				get;
			}
			[DispId( 0xcd )]
			string Type
			{
				get;
			}
			[DispId( 0xce )]
			int Left
			{
				get;
				set;
			}
			[DispId( 0xcf )]
			int Top
			{
				get;
				set;
			}
			[DispId( 0xd0 )]
			int Width
			{
				get;
				set;
			}
			[DispId( 0xd1 )]
			int Height
			{
				get;
				set;
			}
			[DispId( 210 )]
			string LocationName
			{
				get;
			}
			[DispId( 0xd3 )]
			string LocationURL
			{
				get;
			}
			[DispId( 0xd4 )]
			bool Busy
			{
				get;
			}
			[DispId( 300 )]
			void Quit();
			[DispId( 0x12d )]
			void ClientToWindow( out int pcx, out int pcy );
			[DispId( 0x12e )]
			void PutProperty( [In] string property, [In] object vtValue );
			[DispId( 0x12f )]
			object GetProperty( [In] string property );
			[DispId( 0 )]
			string Name
			{
				get;
			}
			[DispId( -515 )]
			int HWND
			{
				get;
			}
			[DispId( 400 )]
			string FullName
			{
				get;
			}
			[DispId( 0x191 )]
			string Path
			{
				get;
			}
			[DispId( 0x192 )]
			bool Visible
			{
				get;
				set;
			}
			[DispId( 0x193 )]
			bool StatusBar
			{
				get;
				set;
			}
			[DispId( 0x194 )]
			string StatusText
			{
				get;
				set;
			}
			[DispId( 0x195 )]
			int ToolBar
			{
				get;
				set;
			}
			[DispId( 0x196 )]
			bool MenuBar
			{
				get;
				set;
			}
			[DispId( 0x197 )]
			bool FullScreen
			{
				get;
				set;
			}
			[DispId( 500 )]
			void Navigate2( [In] ref object URL, [In] ref object flags, [In] ref object targetFrameName, [In] ref object postData, [In] ref object headers );

			[DispId( 0x1f5 )]
			NativeMethods.OLECMDF QueryStatusWB( [In] NativeMethods.OLECMDID cmdID );

			[DispId( 0x1f6 )]
			void ExecWB( [In] NativeMethods.OLECMDID cmdID, [In] NativeMethods.OLECMDEXECOPT cmdexecopt, ref object pvaIn, IntPtr pvaOut );

			[DispId( 0x1f7 )]
			void ShowBrowserBar( [In] ref object pvaClsid, [In] ref object pvarShow, [In] ref object pvarSize );

			[DispId( -525 )]
			WebBrowserReadyState ReadyState
			{
				get;
			}
			[DispId( 550 )]
			bool Offline
			{
				get;
				set;
			}
			[DispId( 0x227 )]
			bool Silent
			{
				get;
				set;
			}
			[DispId( 0x228 )]
			bool RegisterAsBrowser
			{
				get;
				set;
			}
			[DispId( 0x229 )]
			bool RegisterAsDropTarget
			{
				get;
				set;
			}
			[DispId( 0x22a )]
			bool TheaterMode
			{
				get;
				set;
			}
			[DispId( 0x22b )]
			bool AddressBar
			{
				get;
				set;
			}
			[DispId( 0x22c )]
			bool Resizable
			{
				get;
				set;
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hWndFrom"></param>
		/// <param name="hWndTo"></param>
		/// <param name="pt"></param>
		/// <param name="cPoints"></param>
		/// <returns></returns>
		[DllImport(
			@"user32.dll",
			CharSet = CharSet.Auto,
			ExactSpelling = true )]
		public static extern int MapWindowPoints(
			HandleRef hWndFrom,
			HandleRef hWndTo,
			[In, Out] NativeMethods.POINT pt,
			int cPoints );

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}