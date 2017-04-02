namespace ZetaResourceEditor.UI.Helper.ExtendedFolderBrowser
{
	#region Using directives.
	// ----------------------------------------------------------------------
    using System;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Text;

    // ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Wrapper for P/Invoke routines, enums and structs.
	/// </summary>
	public sealed class Win32
	{
		#region Enums.
		// ------------------------------------------------------------------

		/// <summary>
		/// Custom draw draw state.
		/// </summary>
		public enum CDDS
		{
			CDDS_PREPAINT = 0x00000001,
			CDDS_POSTPAINT = 0x00000002,
			CDDS_PREERASE = 0x00000003,
			CDDS_POSTERASE = 0x00000004,
			CDDS_ITEM = 0x00010000,
			CDDS_ITEMPREPAINT = (CDDS_ITEM | CDDS_PREPAINT),
			CDDS_ITEMPOSTPAINT = (CDDS_ITEM | CDDS_POSTPAINT),
			CDDS_ITEMPREERASE = (CDDS_ITEM | CDDS_PREERASE),
			CDDS_ITEMPOSTERASE = (CDDS_ITEM | CDDS_POSTERASE),
			CDDS_SUBITEM = 0x00020000
		}

		/// <summary>
		/// Notification messages.
		/// </summary>
		public enum NM
		{
			NM_FIRST = (0 - 0),
			NM_CUSTOMDRAW = (NM_FIRST - 12)
		}

		/// <summary>
		/// Reflected messages.
		/// </summary>
		public enum OCM
		{
			OCM__BASE = 0x0400 + 0x1c00,
			OCM_COMMAND = (OCM__BASE + 0x0111),
			OCM_CTLCOLORBTN = (OCM__BASE + 0x0135),
			OCM_CTLCOLOREDIT = (OCM__BASE + 0x0133),
			OCM_CTLCOLORDLG = (OCM__BASE + 0x0136),
			OCM_CTLCOLORLISTBOX = (OCM__BASE + 0x0134),
			OCM_CTLCOLORMSGBOX = (OCM__BASE + 0x0132),
			OCM_CTLCOLORSCROLLBAR = (OCM__BASE + 0x0137),
			OCM_CTLCOLORSTATIC = (OCM__BASE + 0x0138),
			OCM_CTLCOLOR = (OCM__BASE + 0x0019),
			OCM_DRAWITEM = (OCM__BASE + 0x002B),
			OCM_MEASUREITEM = (OCM__BASE + 0x002C),
			OCM_DELETEITEM = (OCM__BASE + 0x002D),
			OCM_VKEYTOITEM = (OCM__BASE + 0x002E),
			OCM_CHARTOITEM = (OCM__BASE + 0x002F),
			OCM_COMPAREITEM = (OCM__BASE + 0x0039),
			OCM_HSCROLL = (OCM__BASE + 0x0114),
			OCM_VSCROLL = (OCM__BASE + 0x0115),
			OCM_PARENTNOTIFY = (OCM__BASE + 0x0210),
			OCM_NOTIFY = (OCM__BASE + 0x004E)
		}

		/// <summary>
		/// Custom draw return flags.
		/// </summary>
		public enum CDRF
		{
			CDRF_DODEFAULT = 0x00000000,
			CDRF_NEWFONT = 0x00000002,
			CDRF_SKIPDEFAULT = 0x00000004,
			CDRF_NOTIFYPOSTPAINT = 0x00000010,
			CDRF_NOTIFYITEMDRAW = 0x00000020
		}

		/// <summary>
		/// Notification codes from within a WM_NOTIFY message.
		/// </summary>
		public enum LVN
		{
			LVN_FIRST = (0 - 100),
			LVN_LAST = (0 - 199),
			LVN_ITEMCHANGING = (LVN_FIRST - 0),
			LVN_ITEMCHANGED = (LVN_FIRST - 1),
			LVN_INSERTITEM = (LVN_FIRST - 2),
			LVN_DELETEITEM = (LVN_FIRST - 3),
			LVN_DELETEALLITEMS = (LVN_FIRST - 4),
			LVN_BEGINLABELEDITA = (LVN_FIRST - 5),
			LVN_BEGINLABELEDITW = (LVN_FIRST - 75),
			LVN_ENDLABELEDITA = (LVN_FIRST - 6),
			LVN_ENDLABELEDITW = (LVN_FIRST - 76),
			LVN_COLUMNCLICK = (LVN_FIRST - 8),
			LVN_BEGINDRAG = (LVN_FIRST - 9),
			LVN_BEGINRDRAG = (LVN_FIRST - 11),
			LVN_ODCACHEHINT = (LVN_FIRST - 13),
			LVN_ODFINDITEMA = (LVN_FIRST - 52),
			LVN_ODFINDITEMW = (LVN_FIRST - 79),
			LVN_ITEMACTIVATE = (LVN_FIRST - 14),
			LVN_ODSTATECHANGED = (LVN_FIRST - 15)
		}

		/// <summary>
		/// System icons for LoadIcon().
		/// </summary>
		public enum IDI
		{
			IDI_APPLICATION = 32512,
			IDI_HAND = 32513,
			IDI_QUESTION = 32514,
			IDI_EXCLAMATION = 32515,
			IDI_ASTERISK = 32516,
			IDI_ERROR = IDI_HAND
		}

		// ------------------------------------------------------------------
		#endregion

		#region Messages.
		// ------------------------------------------------------------------

		/// <summary>
		/// Windows message codes WM_.
		/// </summary>
		public enum WM
		{
			WM_NULL = 0x0000,
			WM_CREATE = 0x0001,
			WM_DESTROY = 0x0002,
			WM_MOVE = 0x0003,
			WM_SIZE = 0x0005,
			WM_ACTIVATE = 0x0006,
			WM_SETFOCUS = 0x0007,
			WM_KILLFOCUS = 0x0008,
			WM_ENABLE = 0x000A,
			WM_SETREDRAW = 0x000B,
			WM_SETTEXT = 0x000C,
			WM_GETTEXT = 0x000D,
			WM_GETTEXTLENGTH = 0x000E,
			WM_PAINT = 0x000F,
			WM_CLOSE = 0x0010,
			WM_QUERYENDSESSION = 0x0011,
			WM_QUIT = 0x0012,
			WM_QUERYOPEN = 0x0013,
			WM_ERASEBKGND = 0x0014,
			WM_SYSCOLORCHANGE = 0x0015,
			WM_ENDSESSION = 0x0016,
			WM_SHOWWINDOW = 0x0018,
			WM_CTLCOLOR = 0x0019,
			WM_WININICHANGE = 0x001A,
			WM_SETTINGCHANGE = 0x001A,
			WM_DEVMODECHANGE = 0x001B,
			WM_ACTIVATEAPP = 0x001C,
			WM_FONTCHANGE = 0x001D,
			WM_TIMECHANGE = 0x001E,
			WM_CANCELMODE = 0x001F,
			WM_SETCURSOR = 0x0020,
			WM_MOUSEACTIVATE = 0x0021,
			WM_CHILDACTIVATE = 0x0022,
			WM_QUEUESYNC = 0x0023,
			WM_GETMINMAXINFO = 0x0024,
			WM_PAINTICON = 0x0026,
			WM_ICONERASEBKGND = 0x0027,
			WM_NEXTDLGCTL = 0x0028,
			WM_SPOOLERSTATUS = 0x002A,
			WM_DRAWITEM = 0x002B,
			WM_MEASUREITEM = 0x002C,
			WM_DELETEITEM = 0x002D,
			WM_VKEYTOITEM = 0x002E,
			WM_CHARTOITEM = 0x002F,
			WM_SETFONT = 0x0030,
			WM_GETFONT = 0x0031,
			WM_SETHOTKEY = 0x0032,
			WM_GETHOTKEY = 0x0033,
			WM_QUERYDRAGICON = 0x0037,
			WM_COMPAREITEM = 0x0039,
			WM_GETOBJECT = 0x003D,
			WM_COMPACTING = 0x0041,
			WM_COMMNOTIFY = 0x0044,
			WM_WINDOWPOSCHANGING = 0x0046,
			WM_WINDOWPOSCHANGED = 0x0047,
			WM_POWER = 0x0048,
			WM_COPYDATA = 0x004A,
			WM_CANCELJOURNAL = 0x004B,
			WM_NOTIFY = 0x004E,
			WM_INPUTLANGCHANGEREQUEST = 0x0050,
			WM_INPUTLANGCHANGE = 0x0051,
			WM_TCARD = 0x0052,
			WM_HELP = 0x0053,
			WM_USERCHANGED = 0x0054,
			WM_NOTIFYFORMAT = 0x0055,
			WM_CONTEXTMENU = 0x007B,
			WM_STYLECHANGING = 0x007C,
			WM_STYLECHANGED = 0x007D,
			WM_DISPLAYCHANGE = 0x007E,
			WM_GETICON = 0x007F,
			WM_SETICON = 0x0080,
			WM_NCCREATE = 0x0081,
			WM_NCDESTROY = 0x0082,
			WM_NCCALCSIZE = 0x0083,
			WM_NCHITTEST = 0x0084,
			WM_NCPAINT = 0x0085,
			WM_NCACTIVATE = 0x0086,
			WM_GETDLGCODE = 0x0087,
			WM_SYNCPAINT = 0x0088,
			WM_NCMOUSEMOVE = 0x00A0,
			WM_NCLBUTTONDOWN = 0x00A1,
			WM_NCLBUTTONUP = 0x00A2,
			WM_NCLBUTTONDBLCLK = 0x00A3,
			WM_NCRBUTTONDOWN = 0x00A4,
			WM_NCRBUTTONUP = 0x00A5,
			WM_NCRBUTTONDBLCLK = 0x00A6,
			WM_NCMBUTTONDOWN = 0x00A7,
			WM_NCMBUTTONUP = 0x00A8,
			WM_NCMBUTTONDBLCLK = 0x00A9,
			WM_KEYDOWN = 0x0100,
			WM_KEYUP = 0x0101,
			WM_CHAR = 0x0102,
			WM_DEADCHAR = 0x0103,
			WM_SYSKEYDOWN = 0x0104,
			WM_SYSKEYUP = 0x0105,
			WM_SYSCHAR = 0x0106,
			WM_SYSDEADCHAR = 0x0107,
			WM_KEYLAST = 0x0108,
			WM_IME_STARTCOMPOSITION = 0x010D,
			WM_IME_ENDCOMPOSITION = 0x010E,
			WM_IME_COMPOSITION = 0x010F,
			WM_IME_KEYLAST = 0x010F,
			WM_INITDIALOG = 0x0110,
			WM_COMMAND = 0x0111,
			WM_SYSCOMMAND = 0x0112,
			WM_TIMER = 0x0113,
			WM_HSCROLL = 0x0114,
			WM_VSCROLL = 0x0115,
			WM_INITMENU = 0x0116,
			WM_INITMENUPOPUP = 0x0117,
			WM_MENUSELECT = 0x011F,
			WM_MENUCHAR = 0x0120,
			WM_ENTERIDLE = 0x0121,
			WM_MENURBUTTONUP = 0x0122,
			WM_MENUDRAG = 0x0123,
			WM_MENUGETOBJECT = 0x0124,
			WM_UNINITMENUPOPUP = 0x0125,
			WM_MENUCOMMAND = 0x0126,
			WM_CTLCOLORMSGBOX = 0x0132,
			WM_CTLCOLOREDIT = 0x0133,
			WM_CTLCOLORLISTBOX = 0x0134,
			WM_CTLCOLORBTN = 0x0135,
			WM_CTLCOLORDLG = 0x0136,
			WM_CTLCOLORSCROLLBAR = 0x0137,
			WM_CTLCOLORSTATIC = 0x0138,
			WM_MOUSEMOVE = 0x0200,
			WM_LBUTTONDOWN = 0x0201,
			WM_LBUTTONUP = 0x0202,
			WM_LBUTTONDBLCLK = 0x0203,
			WM_RBUTTONDOWN = 0x0204,
			WM_RBUTTONUP = 0x0205,
			WM_RBUTTONDBLCLK = 0x0206,
			WM_MBUTTONDOWN = 0x0207,
			WM_MBUTTONUP = 0x0208,
			WM_MBUTTONDBLCLK = 0x0209,
			WM_MOUSEWHEEL = 0x020A,
			WM_PARENTNOTIFY = 0x0210,
			WM_ENTERMENULOOP = 0x0211,
			WM_EXITMENULOOP = 0x0212,
			WM_NEXTMENU = 0x0213,
			WM_SIZING = 0x0214,
			WM_CAPTURECHANGED = 0x0215,
			WM_MOVING = 0x0216,
			WM_DEVICECHANGE = 0x0219,
			WM_MDICREATE = 0x0220,
			WM_MDIDESTROY = 0x0221,
			WM_MDIACTIVATE = 0x0222,
			WM_MDIRESTORE = 0x0223,
			WM_MDINEXT = 0x0224,
			WM_MDIMAXIMIZE = 0x0225,
			WM_MDITILE = 0x0226,
			WM_MDICASCADE = 0x0227,
			WM_MDIICONARRANGE = 0x0228,
			WM_MDIGETACTIVE = 0x0229,
			WM_MDISETMENU = 0x0230,
			WM_ENTERSIZEMOVE = 0x0231,
			WM_EXITSIZEMOVE = 0x0232,
			WM_DROPFILES = 0x0233,
			WM_MDIREFRESHMENU = 0x0234,
			WM_IME_SETCONTEXT = 0x0281,
			WM_IME_NOTIFY = 0x0282,
			WM_IME_CONTROL = 0x0283,
			WM_IME_COMPOSITIONFULL = 0x0284,
			WM_IME_SELECT = 0x0285,
			WM_IME_CHAR = 0x0286,
			WM_IME_REQUEST = 0x0288,
			WM_IME_KEYDOWN = 0x0290,
			WM_IME_KEYUP = 0x0291,
			WM_MOUSEHOVER = 0x02A1,
			WM_MOUSELEAVE = 0x02A3,
			WM_CUT = 0x0300,
			WM_COPY = 0x0301,
			WM_PASTE = 0x0302,
			WM_CLEAR = 0x0303,
			WM_UNDO = 0x0304,
			WM_RENDERFORMAT = 0x0305,
			WM_RENDERALLFORMATS = 0x0306,
			WM_DESTROYCLIPBOARD = 0x0307,
			WM_DRAWCLIPBOARD = 0x0308,
			WM_PAINTCLIPBOARD = 0x0309,
			WM_VSCROLLCLIPBOARD = 0x030A,
			WM_SIZECLIPBOARD = 0x030B,
			WM_ASKCBFORMATNAME = 0x030C,
			WM_CHANGECBCHAIN = 0x030D,
			WM_HSCROLLCLIPBOARD = 0x030E,
			WM_QUERYNEWPALETTE = 0x030F,
			WM_PALETTEISCHANGING = 0x0310,
			WM_PALETTECHANGED = 0x0311,
			WM_HOTKEY = 0x0312,
			WM_PRINT = 0x0317,
			WM_PRINTCLIENT = 0x0318,
			WM_HANDHELDFIRST = 0x0358,
			WM_HANDHELDLAST = 0x035F,
			WM_AFXFIRST = 0x0360,
			WM_AFXLAST = 0x037F,
			WM_PENWINFIRST = 0x0380,
			WM_PENWINLAST = 0x038F,
			WM_APP = 0x8000,
			WM_USER = 0x0400,
			WM_REFLECT = WM_USER + 0x1c00
		}

		// ------------------------------------------------------------------
		#endregion

		#region BROWSEINFO.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public class BROWSEINFO
		{
			public IntPtr hwndOwner;
			public IntPtr pidlRoot;
			public IntPtr pszDisplayName;
			public string lpszTitle;
			public int ulFlags;
			public BrowseCallbackProc lpfn;
			public IntPtr lParam;
			public int iImage;
		}

		/// <summary>
		/// 
		/// </summary>
		public delegate int BrowseCallbackProc(
			IntPtr hwnd,
			int msg,
			IntPtr lParam,
			IntPtr lpData);

		/// <summary>
		/// 
		/// </summary>
		[ComImport,
		SuppressUnmanagedCodeSecurity,
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
		Guid(@"00000002-0000-0000-c000-000000000046")]
		public interface IMalloc
		{
			[PreserveSig]
			IntPtr Alloc(int cb);
			[PreserveSig]
			IntPtr Realloc(IntPtr pv, int cb);
			[PreserveSig]
			void Free(IntPtr pv);
			[PreserveSig]
			int GetSize(IntPtr pv);
			[PreserveSig]
			int DidAlloc(IntPtr pv);
			[PreserveSig]
			void HeapMinimize();
		}

		public const int MaxPath = 260;

		/// <summary>
		/// 
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		internal class Shell32
		{
			/// <summary>
			/// SHs the browse for folder.
			/// </summary>
			/// <param name="lpbi">The lpbi.</param>
			/// <returns></returns>
			[DllImport(@"shell32.dll", CharSet = CharSet.Auto)]
			public static extern IntPtr SHBrowseForFolder(
				[In] BROWSEINFO lpbi);

			/// <summary>
			/// SHs the get malloc.
			/// </summary>
			/// <param name="ppMalloc">The pp malloc.</param>
			/// <returns></returns>
			[DllImport(@"shell32.dll")]
			public static extern int SHGetMalloc(
				[Out, MarshalAs(UnmanagedType.LPArray)] IMalloc[] ppMalloc);

			/// <summary>
			/// SHs the get path from ID list.
			/// </summary>
			/// <param name="pidl">The pidl.</param>
			/// <param name="pszPath">The PSZ path.</param>
			/// <returns></returns>
			[DllImport(@"shell32.dll", CharSet = CharSet.Auto)]
			public static extern bool SHGetPathFromIDList(
				IntPtr pidl,
				IntPtr pszPath);

			/// <summary>
			/// SHs the get special folder location.
			/// </summary>
			/// <param name="hwnd">The HWND.</param>
			/// <param name="csidl">The csidl.</param>
			/// <param name="ppidl">The ppidl.</param>
			/// <returns></returns>
			[DllImport(@"shell32.dll")]
			public static extern int SHGetSpecialFolderLocation(
				IntPtr hwnd, int csidl,
				ref IntPtr ppidl);
		}

		public const int BIF_EDITBOX = 0x10;
		public const int BFFM_ENABLEOK = 0x465;
		public const int BFFM_INITIALIZED = 1;
		public const int BFFM_SELCHANGED = 2;
		public const int BFFM_IUNKNOWN = 5;
		public const int BFFM_VALIDATEFAILED = 3;
		public static readonly int BFFM_SETSELECTION;
		public const int BFFM_SETSELECTIONA = 0x466;
		public const int BFFM_SETSELECTIONW = 0x467;

		public const int TV_FIRST = 0x1100;
		public const int TVM_GETNEXTITEM = TV_FIRST + 10;
		public const int TVM_ENSUREVISIBLE = TV_FIRST + 20;

		public const int TVGN_CARET = 9;

		public const string WC_TREEVIEW = @"SysTreeView32";

		public delegate bool EnumWindowProc(IntPtr hWnd, IntPtr parameter);

		[DllImport(@"user32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr i);

		[DllImport(@"user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

		[DllImport(@"user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(HandleRef hwnd, out RECT lpRect);

		[DllImport(@"user32.dll", SetLastError = true)]
		internal static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool bRepaint);

		/// <summary>
		/// Constructor.
		/// </summary>
		static Win32()
		{
			BFFM_SETSELECTION = Marshal.SystemDefaultCharSize == 1 ? BFFM_SETSELECTIONA : BFFM_SETSELECTIONW;
		}

		// ------------------------------------------------------------------
		#endregion

		#region Structs.
		// ------------------------------------------------------------------

		[StructLayout(LayoutKind.Sequential)]
		public struct NMHDR
		{
			public IntPtr hwndFrom;
			public int idFrom;
			public int code;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct NMCUSTOMDRAW
		{
			public NMHDR hdr;
			public int dwDrawStage;
			public IntPtr hdc;
			public RECT rc;
			public int dwItemSpec;
			public int uItemState;
			public int lItemlParam;
		}

		// ------------------------------------------------------------------
		#endregion

		#region P/Invoke.
		// ------------------------------------------------------------------

		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport(@"user32.dll", SetLastError = true)]
		public static extern bool PostMessage(HandleRef hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		/// <summary>
		/// Loads the icon.
		/// </summary>
		/// <param name="hInstance">The h instance.</param>
		/// <param name="lpIconName">Name of the lp icon.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll")]
		public static extern IntPtr LoadIcon(
			IntPtr hInstance,
			IntPtr lpIconName);

		/// <summary>
		/// Loads the icon.
		/// </summary>
		/// <param name="hInstance">The h instance.</param>
		/// <param name="lpIconName">Name of the lp icon.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll")]
		public static extern IntPtr LoadIcon(
			IntPtr hInstance,
			string lpIconName);

		/// <summary>
		/// Sends the callback message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
		public static extern IntPtr SendCallbackMessage(HandleRef hWnd, int msg, IntPtr wParam, IntPtr lParam);

		/// <summary>
		/// Sends the DLG item message.
		/// </summary>
		/// <param name="hDlg">The h DLG.</param>
		/// <param name="nIDDlgItem">The n ID DLG item.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendDlgItemMessage(HandleRef hDlg, int nIDDlgItem, int msg, IntPtr wParam, IntPtr lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">if set to <c>true</c> [w param].</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, bool wParam, int lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, int[] lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, int lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">if set to <c>true</c> [w param].</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, [In, Out, MarshalAs(UnmanagedType.Bool)] ref bool wParam, IntPtr lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, ref short wParam, ref short lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, IntPtr lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, string lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="editOle">The edit OLE.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern int SendMessage(HandleRef hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.IUnknown)] out object editOle);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, StringBuilder lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int[] wParam, int[] lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, ref int wParam, ref int lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, HandleRef lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, IntPtr wParam, IntPtr lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, IntPtr wParam, string lParam);

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(
			HandleRef hWnd,
			int msg,
			HandleRef wParam,
			int lParam);

		/// <summary>
		/// Sends the message timeout.
		/// </summary>
		/// <param name="hWnd">The h WND.</param>
		/// <param name="msg">The MSG.</param>
		/// <param name="wParam">The w param.</param>
		/// <param name="lParam">The l param.</param>
		/// <param name="flags">The flags.</param>
		/// <param name="timeout">The timeout.</param>
		/// <param name="pdwResult">The PDW result.</param>
		/// <returns></returns>
		[DllImport(@"user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessageTimeout(
			HandleRef hWnd,
			int msg,
			IntPtr wParam,
			IntPtr lParam,
			int flags,
			int timeout,
			out IntPtr pdwResult);

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Interface for controls doing custom draw.
	/// See http://www.codeproject.com/cs/miscctrl/bk_custlistview.asp.
	/// </summary>
	public interface ICustomDraw
	{
		#region Interface member.
		// ------------------------------------------------------------------

		/// <summary>
		/// Called when [pre paint].
		/// </summary>
		/// <param name="idCtrl">The id CTRL.</param>
		/// <param name="nmcd">The NMCD.</param>
		/// <returns></returns>
		int OnPrePaint(int idCtrl, ref Win32.NMCUSTOMDRAW nmcd);

		/// <summary>
		/// Called when [post paint].
		/// </summary>
		/// <param name="idCtrl">The id CTRL.</param>
		/// <param name="nmcd">The NMCD.</param>
		/// <returns></returns>
		int OnPostPaint(int idCtrl, ref Win32.NMCUSTOMDRAW nmcd);

		/// <summary>
		/// Called when [pre erase].
		/// </summary>
		/// <param name="idCtrl">The id CTRL.</param>
		/// <param name="nmcd">The NMCD.</param>
		/// <returns></returns>
		int OnPreErase(int idCtrl, ref Win32.NMCUSTOMDRAW nmcd);

		/// <summary>
		/// Called when [post erase].
		/// </summary>
		/// <param name="idCtrl">The id CTRL.</param>
		/// <param name="nmcd">The NMCD.</param>
		/// <returns></returns>
		int OnPostErase(int idCtrl, ref Win32.NMCUSTOMDRAW nmcd);

		/// <summary>
		/// Called when [item pre paint].
		/// </summary>
		/// <param name="idCtrl">The id CTRL.</param>
		/// <param name="nmcd">The NMCD.</param>
		/// <returns></returns>
		int OnItemPrePaint(int idCtrl, ref Win32.NMCUSTOMDRAW nmcd);

		/// <summary>
		/// Called when [item post paint].
		/// </summary>
		/// <param name="idCtrl">The id CTRL.</param>
		/// <param name="nmcd">The NMCD.</param>
		/// <returns></returns>
		int OnItemPostPaint(int idCtrl, ref Win32.NMCUSTOMDRAW nmcd);

		/// <summary>
		/// Called when [item pre erase].
		/// </summary>
		/// <param name="idCtrl">The id CTRL.</param>
		/// <param name="nmcd">The NMCD.</param>
		/// <returns></returns>
		int OnItemPreErase(int idCtrl, ref Win32.NMCUSTOMDRAW nmcd);

		/// <summary>
		/// Called when [item post erase].
		/// </summary>
		/// <param name="idCtrl">The id CTRL.</param>
		/// <param name="nmcd">The NMCD.</param>
		/// <returns></returns>
		int OnItemPostErase(int idCtrl, ref Win32.NMCUSTOMDRAW nmcd);

		/// <summary>
		/// Gets the window handle.
		/// </summary>
		/// <value>The window handle.</value>
		IntPtr WindowHandle
		{
			get;
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Class for actually handling custom draw.
	/// Use this class inside your control that wants to support
	/// custom drawing.
	/// See http://www.codeproject.com/cs/miscctrl/bk_custlistview.asp.
	/// </summary>
	public class CustomDrawHandler
	{
		#region Public members.
		// ------------------------------------------------------------------

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="interfaceCustDraw">The interface cust draw.</param>
		public CustomDrawHandler(
			ICustomDraw interfaceCustDraw)
		{
			_interfaceCustDraw = interfaceCustDraw;
		}

		/// <summary>
		/// Check whether the message was handled.
		/// </summary>
		/// <value><c>true</c> if [message handled]; otherwise, <c>false</c>.</value>
		public bool MessageHandled { get; private set; }

	    /// <summary>
		/// Call this inside your Window proc in the control that
		/// wants to do custom drawing.
		/// </summary>
		/// <param name="msg">The MSG.</param>
		/// <returns></returns>
		/// <remarks>
		/// Example:
		/// protected override void WndProc(ref Message m)
		/// {
		/// myCustDrawHandler.HandleReflectedCustDrawMessage( ref m );
		/// if ( !myCustDrawHandler.MessageHandled )
		/// {
		/// base.WndProc (ref m);
		/// }
		/// }
		/// </remarks>
		public IntPtr HandleReflectedCustDrawMessage(
			ref System.Windows.Forms.Message msg)
		{
			IntPtr ret = IntPtr.Zero;
			MessageHandled = false;

			if (msg.Msg == (int)Win32.OCM.OCM_NOTIFY)
			{
				var hrd = (Win32.NMHDR)msg.GetLParam(typeof(Win32.NMHDR));

				if ((hrd.code == (int)Win32.NM.NM_CUSTOMDRAW) && (hrd.hwndFrom == _interfaceCustDraw.WindowHandle))
				{
					var nmcd = (Win32.NMCUSTOMDRAW)msg.GetLParam(typeof(Win32.NMCUSTOMDRAW));
					msg.Result = (IntPtr)OnCustomDraw(msg.WParam.ToInt32(), ref nmcd);
					MessageHandled = true;
				}
			}
			return ret;
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private member.
		// ------------------------------------------------------------------

		/// <summary>
		/// Called when [custom draw].
		/// </summary>
		/// <param name="idCtrl">The id CTRL.</param>
		/// <param name="nmcd">The NMCD.</param>
		/// <returns></returns>
		private int OnCustomDraw(
			int idCtrl,
			ref Win32.NMCUSTOMDRAW nmcd)
		{
			int nResult = 0;
			switch (nmcd.dwDrawStage)
			{
				case (int)Win32.CDDS.CDDS_PREPAINT:
					nResult = _interfaceCustDraw.OnPrePaint(idCtrl, ref nmcd);
					break;
				case (int)Win32.CDDS.CDDS_POSTPAINT:
					nResult = _interfaceCustDraw.OnPostPaint(idCtrl, ref nmcd);
					break;
				case (int)Win32.CDDS.CDDS_PREERASE:
					nResult = _interfaceCustDraw.OnPreErase(idCtrl, ref nmcd);
					break;
				case (int)Win32.CDDS.CDDS_POSTERASE:
					nResult = _interfaceCustDraw.OnPostErase(idCtrl, ref nmcd);
					break;
				case (int)Win32.CDDS.CDDS_ITEMPREPAINT:
					nResult = _interfaceCustDraw.OnItemPrePaint(idCtrl, ref nmcd);
					break;
				case (int)Win32.CDDS.CDDS_ITEMPOSTPAINT:
					nResult = _interfaceCustDraw.OnItemPostPaint(idCtrl, ref nmcd);
					break;
				case (int)Win32.CDDS.CDDS_ITEMPREERASE:
					nResult = _interfaceCustDraw.OnItemPreErase(idCtrl, ref nmcd);
					break;
				case (int)Win32.CDDS.CDDS_ITEMPOSTERASE:
					nResult = _interfaceCustDraw.OnItemPostErase(idCtrl, ref nmcd);
					break;
			}
			return nResult;
		}

		private readonly ICustomDraw _interfaceCustDraw;

	    // ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}