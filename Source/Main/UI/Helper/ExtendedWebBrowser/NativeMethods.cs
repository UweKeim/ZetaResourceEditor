namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Runtime.InteropServices;
	using System.Drawing;
	using System.Runtime.InteropServices.ComTypes;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Encapsulate native P/Invoke methods.
	/// </summary>
	public sealed class NativeMethods
	{
		#region Public properties.
		// ------------------------------------------------------------------

		public static readonly int WM_KEYDOWN = 0x100;
		public static readonly int WM_SYSKEYDOWN = 0x104;

		public static readonly int VARIANT_FALSE = 0 + 0;
		public static readonly int VARIANT_TRUE = -1;

		public static readonly int BOOL_FALSE = 0 + 0;
		public static readonly int BOOL_TRUE = 1;

		public static HandleRef NullHandleRef;

		public static readonly int E_INVALIDARG = unchecked( (int)0x80070057 );

		public static readonly Guid SID_SHTMLEditServices =
			new Guid( 0x3050f7f9, 0x98b5, 0x11cf, 0xbb, 0x82, 0x00, 0xaa, 0x00, 0xbd, 0xce, 0x0b );

		// ------------------------------------------------------------------
		#endregion

		#region Public enums.
		// ------------------------------------------------------------------

		/// <summary>
		/// For IDocHostUIHander.
		/// </summary>
		public enum ContextMenuKind
		{
			#region Enum members.

			CONTEXT_MENU_DEFAULT = 0,
			CONTEXT_MENU_IMAGE = 1,
			CONTEXT_MENU_CONTROL = 2,
			CONTEXT_MENU_TABLE = 3,

			CONTEXT_MENU_TEXTSELECT = 4,
			CONTEXT_MENU_ANCHOR = 5,
			CONTEXT_MENU_UNKNOWN = 6

			#endregion
		}

		/// <summary>
		/// Flags for the DOCHOSTUIINFO.dwFlags.
		/// </summary>
		[Flags]
		public enum DOCHOSTUIFLAG
		{
			#region Enum members.

			DOCHOSTUIFLAG_DIALOG = 0x00000001,
			DOCHOSTUIFLAG_DISABLE_HELP_MENU = 0x00000002,
			DOCHOSTUIFLAG_NO3DBORDER = 0x00000004,
			DOCHOSTUIFLAG_SCROLL_NO = 0x00000008,
			DOCHOSTUIFLAG_DISABLE_SCRIPT_INACTIVE = 0x00000010,
			DOCHOSTUIFLAG_OPENNEWWIN = 0x00000020,
			DOCHOSTUIFLAG_DISABLE_OFFSCREEN = 0x00000040,
			DOCHOSTUIFLAG_FLAT_SCROLLBAR = 0x00000080,
			DOCHOSTUIFLAG_DIV_BLOCKDEFAULT = 0x00000100,
			DOCHOSTUIFLAG_ACTIVATE_CLIENTHIT_ONLY = 0x00000200,
			DOCHOSTUIFLAG_OVERRIDEBEHAVIORFACTORY = 0x00000400,
			DOCHOSTUIFLAG_CODEPAGELINKEDFONTS = 0x00000800,
			DOCHOSTUIFLAG_URL_ENCODING_DISABLE_UTF8 = 0x00001000,
			DOCHOSTUIFLAG_URL_ENCODING_ENABLE_UTF8 = 0x00002000,
			DOCHOSTUIFLAG_ENABLE_FORMS_AUTOCOMPLETE = 0x00004000,
			DOCHOSTUIFLAG_ENABLE_INPLACE_NAVIGATION = 0x00010000,
			DOCHOSTUIFLAG_IME_ENABLE_RECONVERSION = 0x00020000,
			DOCHOSTUIFLAG_THEME = 0x00040000,
			DOCHOSTUIFLAG_NOTHEME = 0x00080000,
			DOCHOSTUIFLAG_NOPICS = 0x00100000,
			DOCHOSTUIFLAG_NO3DOUTERBORDER = 0x00200000,
			DOCHOSTUIFLAG_DISABLE_EDIT_NS_FIXUP = 0x00400000,
			DOCHOSTUIFLAG_LOCAL_MACHINE_ACCESS_CHECK = 0x00800000,
			DOCHOSTUIFLAG_DISABLE_UNTRUSTEDPROTOCOL = 0x01000000

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region MSG structure.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[Serializable, StructLayout( LayoutKind.Sequential )]
		public struct MSG
		{
			#region Public variables.

			public IntPtr hwnd;
			public int message;
			public IntPtr wParam;
			public IntPtr lParam;
			public int time;
			public int pt_x;
			public int pt_y;

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region POINT class.
		// ------------------------------------------------------------------

		/// <summary>
		/// POINT structure.
		/// </summary>
		[StructLayout( LayoutKind.Sequential )]
		public class POINT
		{
			#region Public variables.

			public int x;
			public int y;

			#endregion

			#region Public methods.

			public POINT()
			{
			}

			public POINT( int x, int y )
			{
				this.x = x;
				this.y = y;
			}

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region OLECMDF.

		public enum OLECMDF
		{
			// Fields
			OLECMDF_DEFHIDEONCTXTMENU = 0x20,
			OLECMDF_ENABLED = 2,
			OLECMDF_INVISIBLE = 0x10,
			OLECMDF_LATCHED = 4,
			OLECMDF_NINCHED = 8,
			OLECMDF_SUPPORTED = 1
		}

		#endregion

		#region OLECMDID.

		public enum OLECMDID
		{
			// Fields
			OLECMDID_PAGESETUP = 8,
			OLECMDID_PRINT = 6,
			OLECMDID_PRINTPREVIEW = 7,
			OLECMDID_PROPERTIES = 10,
			OLECMDID_SAVEAS = 4,
			// OLECMDID_SHOWSCRIPTERROR = 40
		}

		#endregion

		#region OLECMDEXECOPT.

		public enum OLECMDEXECOPT
		{
			// Fields
			OLECMDEXECOPT_DODEFAULT = 0,
			OLECMDEXECOPT_DONTPROMPTUSER = 2,
			OLECMDEXECOPT_PROMPTUSER = 1,
			OLECMDEXECOPT_SHOWHELP = 3
		}

		#endregion

		#region OLECMD class.
		// ------------------------------------------------------------------

		/// <summary>
		/// OLECMD class.
		/// </summary>
		[StructLayout( LayoutKind.Sequential )]
		public class OLECMD
		{
			#region Public variables.

			[MarshalAs( UnmanagedType.U4 )]
			public int cmdID;

			[MarshalAs( UnmanagedType.U4 )]
			public int cmdf;

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region COMRECT structure.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[StructLayout( LayoutKind.Sequential )]
		public class COMRECT
		{
			#region Public variables.

			public int left;
			public int top;
			public int right;
			public int bottom;

			#endregion

			#region Public methods.

			public COMRECT()
			{
			}

			public COMRECT( Rectangle r )
			{
				left = r.X;
				top = r.Y;
				right = r.Right;
				bottom = r.Bottom;
			}

			public COMRECT( int left, int top, int right, int bottom )
			{
				this.left = left;
				this.top = top;
				this.right = right;
				this.bottom = bottom;
			}

			public static COMRECT FromXYWH( int x, int y, int width, int height )
			{
				return new COMRECT( x, y, x + width, y + height );
			}

			public override string ToString()
			{
				return string.Concat(
					new object[] 
					{ 
						@"Left = ", left, 
						@" Top = ", top, 
						@" Right = ", right, 
						@" Bottom = ", bottom 
					} );
			}

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region DOCHOSTUIINFO class.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[StructLayout( LayoutKind.Sequential ),
		ComVisible( true )]
		public class DOCHOSTUIINFO
		{
			#region Public variables.

			[MarshalAs( UnmanagedType.U4 )]
			public int cbSize;
			[MarshalAs( UnmanagedType.I4 )]
			public int dwFlags;
			[MarshalAs( UnmanagedType.I4 )]
			public int dwDoubleClick;
			[MarshalAs( UnmanagedType.I4 )]
			public int dwReserved1;
			[MarshalAs( UnmanagedType.I4 )]
			public int dwReserved2;

			#endregion

			#region Public methods.

			public DOCHOSTUIINFO()
			{
				cbSize = Marshal.SizeOf( typeof( DOCHOSTUIINFO ) );
			}

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region tagOleMenuGroupWidths class.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[StructLayout( LayoutKind.Sequential )]
		public sealed class tagOleMenuGroupWidths
		{
			#region Public variables.

			[MarshalAs( UnmanagedType.ByValArray, SizeConst = 6 )]
			public int[] widths;

			#endregion

			#region Public methods.

			public tagOleMenuGroupWidths()
			{
				widths = new int[6];
			}

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region SRESULTS class.
		// ------------------------------------------------------------------

		/// <summary>
		/// SRESULTS class.
		/// </summary>
		public static class SRESULTS
		{
			#region Public properties.

			public static readonly int S_OK = 0 + 0;
			public static readonly int S_FALSE = 1;

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region IOleCommandTarget interface.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[ComImport,
		InterfaceType( ComInterfaceType.InterfaceIsIUnknown ),
		Guid( @"B722BCCB-4E68-101B-A2BC-00AA00404770" ),
		ComVisible( true )]
		public interface IOleCommandTarget
		{
			#region Interface members.

			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int QueryStatus(
				ref Guid pguidCmdGroup,
				int cCmds,
				[In, Out] 
				OLECMD prgCmds,
				[In, Out] IntPtr pCmdText );
			[return: MarshalAs( UnmanagedType.I4 )]
			[PreserveSig]
			int Exec(
				ref Guid pguidCmdGroup,
				int nCmdID,
				int nCmdexecopt,
				[In, MarshalAs( UnmanagedType.LPArray )] object[] pvaIn,
				int pvaOut );

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region IPersistStreamInit interface.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[ComVisible( true ),
		ComImport,
		Guid( @"7FD52380-4E07-101B-AE2D-08002B2EC713" ),
		InterfaceTypeAttribute( ComInterfaceType.InterfaceIsIUnknown )]
		public interface IPersistStreamInit
		{
			#region Interface members.

			// IPersist interface
			void GetClassID( ref Guid pClassID );

			[PreserveSig]
			int IsDirty();
			[PreserveSig]
			int Load( IStream pstm );
			[PreserveSig]
			int Save( IStream pstm, bool fClearDirty );
			[PreserveSig]
			int GetSizeMax(
			[InAttribute, Out, MarshalAs( UnmanagedType.U8 )]
			ref long pcbSize );
			[PreserveSig]
			int InitNew();

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region IServiceProvider interface.
		// ------------------------------------------------------------------

		/// <summary>
		/// See file "WMCore.cs" from http://www.LimeGreenSocks.com/DShow/w.zip.
		/// </summary>
		[Guid( @"6d5140c1-7436-11ce-8034-00aa006009fa" ),
		InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
		public interface IServiceProvider
		{
			#region Interface members.

			[PreserveSig]
			int QueryService(
				[In, MarshalAs( UnmanagedType.LPStruct )] Guid guidService,
				[In, MarshalAs( UnmanagedType.LPStruct )] Guid riid,
				[Out, MarshalAs( UnmanagedType.IUnknown )] out object ppvObject
				);

			#endregion
		}

		// ------------------------------------------------------------------
		#endregion

		#region Shell32.
		// ------------------------------------------------------------------

		/// <summary>
		/// http://support.microsoft.com/default.aspx/kb/319350
		/// </summary>
		[StructLayout( LayoutKind.Sequential )]
		public struct SHFILEINFO
		{
			public IntPtr hIcon;
			public IntPtr iIcon;
			public uint dwAttributes;
			[MarshalAs( UnmanagedType.ByValTStr, SizeConst = 260 )]
			public string szDisplayName;
			[MarshalAs( UnmanagedType.ByValTStr, SizeConst = 80 )]
			public string szTypeName;
		};

		public const uint SHGFI_ICON = 0x100;
		public const uint SHGFI_LARGEICON = 0x0; // Large icon.
		public const uint SHGFI_SMALLICON = 0x1; // Small icon.

		/// <summary>
		/// http://support.microsoft.com/default.aspx/kb/319350
		/// </summary>
		[DllImport( @"shell32.dll" )]
		public static extern IntPtr SHGetFileInfo(
			string pszPath,
			uint dwFileAttributes,
			ref SHFILEINFO psfi,
			uint cbSizeFileInfo,
			uint uFlags );

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}