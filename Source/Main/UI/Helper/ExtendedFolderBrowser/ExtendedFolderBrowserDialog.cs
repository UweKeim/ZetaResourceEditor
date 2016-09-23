namespace ZetaResourceEditor.UI.Helper.ExtendedFolderBrowser
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing.Design;
    using System.Runtime.InteropServices;
    using System.Security.Permissions;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    [DefaultEvent(@"HelpRequest"),
	DefaultProperty(@"SelectedPath")]
	public class ExtendedFolderBrowserDialog :
		CommonDialog
	{
		#region Public methods.
		// ------------------------------------------------------------------

		public ExtendedFolderBrowserDialog()
		{
			doReset();
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private methods.
		// ------------------------------------------------------------------

		private int extendedFolderBrowserDialogBrowseCallbackProc(
			IntPtr hwnd,
			int msg,
			IntPtr lParam,
			IntPtr lpData)
		{
			switch (msg)
			{
				case Win32.BFFM_INITIALIZED:
					if (_selectedPath.Length != 0)
					{
						Win32.SendMessage(
							new HandleRef(null, hwnd),
							Win32.BFFM_SETSELECTION,
							1,
							_selectedPath);

						//centerToScreen(hwnd);

						_nativeWindow = new MyNativeWindow(this);
						_nativeWindow.AssignHandle(hwnd);
					}
					break;

				case Win32.BFFM_SELCHANGED:
					{
						//centerToScreen(hwnd);

						var ptr1 = lParam;
						if (ptr1 != IntPtr.Zero)
						{
							// --

							if (_selectedPath.Length != 0)
							{
								// Work-around bug_ in Windows 7 that the selected item is not visible. 
								// http://connect.microsoft.com/VisualStudio/feedback/details/518103/bffm-setselection-does-not-work-with-shbrowseforfolder-on-windows-7
								// http://stackoverflow.com/questions/7014190/why-is-enumchildwindows-skipping-children
								// http://www.ureader.com/msg/14842617.aspx
								// http://stackoverflow.com/questions/3660556/how-to-select-an-item-in-a-treeview-using-win32-api

								var childWindows = GetChildWindows(hwnd);

								if (childWindows.Count > 0)
								{
									var hWndTree = childWindows[0];

									var treeItem =
										Win32.SendMessage(
											new HandleRef(null, hWndTree),
											Win32.TVM_GETNEXTITEM,
											Win32.TVGN_CARET,
											0);

									Win32.SendMessage(
										new HandleRef(null, hWndTree),
										Win32.TVM_ENSUREVISIBLE,
										0,
										treeItem);
								}
							}

							// --

							var ptr2 = Marshal.AllocHGlobal(260 * Marshal.SystemDefaultCharSize);
							var flag1 = Win32.Shell32.SHGetPathFromIDList(ptr1, ptr2);
							var folderPath = Marshal.PtrToStringAuto(ptr2);
							Marshal.FreeHGlobal(ptr2);

							var enable = flag1;
							if (flag1)
							{
								var args =
									new SelectedFolderChangedEventArgs(
										ptr1,
										folderPath);

								OnSelectedFolderChanged(args);

								enable = args.EnableOK;
							}

							Win32.SendMessage(
								new HandleRef(null, hwnd),
								Win32.BFFM_ENABLEOK,
								0,
								enable ? 1 : 0);
						}
						break;
					}
			}
			return 0;
		}

		private void centerToScreen(IntPtr hwnd)
		{
			if (_wantCenterScreen)
			{
				// http://delphi.about.com/od/windowsshellapi/l/aa122803a.htm

				var screen = Screen.FromHandle(hwnd);
				var wa = screen.WorkingArea;

				Win32.RECT rect;
				if (Win32.GetWindowRect(new HandleRef(null, hwnd), out rect))
				{
					var dialogPTX = ((wa.Right - wa.Left) / 2) -
									((rect.right - rect.left) / 2);
					var dialogPTY = ((wa.Bottom - wa.Top) / 2) -
									((rect.bottom - rect.top) / 2);

					Win32.MoveWindow(
						hwnd,
						dialogPTX,
						dialogPTY,
						rect.right - rect.left,
						rect.bottom - rect.top,
						true);
				}
			}
		}

		private static List<IntPtr> GetChildWindows(IntPtr parent)
		{
			var result = new List<IntPtr>();
			var listHandle = GCHandle.Alloc(result);
			try
			{
				var childProc = new Win32.EnumWindowProc(EnumWindow);
				Win32.EnumChildWindows(parent, childProc, GCHandle.ToIntPtr(listHandle));
			}
			finally
			{
				if (listHandle.IsAllocated)
				{
					listHandle.Free();
				}
			}

			return result;
		}

		private static bool EnumWindow(IntPtr handle, IntPtr pointer)
		{
			var gch = GCHandle.FromIntPtr(pointer);
			var list = gch.Target as List<IntPtr>;
			if (list == null)
			{
				throw new InvalidCastException(@"GCHandle Target could not be cast as List<IntPtr>");
			}

			var sb = new StringBuilder(256);
			if (Win32.GetClassName(handle, sb, 256) != 0 &&
				string.Compare(sb.ToString(), Win32.WC_TREEVIEW, StringComparison.OrdinalIgnoreCase) == 0)
			{
				list.Add(handle);
			}

			return true;
		}

		public event EventHandler<SelectedFolderChangedEventArgs> SelectedFolderChanged;

		protected virtual void OnSelectedFolderChanged(
			SelectedFolderChangedEventArgs args)
		{
			if (SelectedFolderChanged != null)
			{
				SelectedFolderChanged(this, args);
			}
		}

		private static Win32.IMalloc getShMalloc()
		{
			var mallocArray1 = new Win32.IMalloc[1];
			Win32.Shell32.SHGetMalloc(mallocArray1);
			return mallocArray1[0];
		}

		public override void Reset()
		{
			doReset();
		}

		private void doReset()
		{
			_rootFolder = Environment.SpecialFolder.Desktop;
			_descriptionText = string.Empty;
			_selectedPath = string.Empty;
			_selectedPathNeedsCheck = false;
			_showNewFolderButton = true;
			_showEditBox = false;
		}


		protected override bool RunDialog(
			IntPtr hWndOwner)
		{
			var ptr1 = IntPtr.Zero;
			var flag1 = false;
			Win32.Shell32.SHGetSpecialFolderLocation(hWndOwner, (int)_rootFolder, ref ptr1);
			if (ptr1 == IntPtr.Zero)
			{
				Win32.Shell32.SHGetSpecialFolderLocation(hWndOwner, 0, ref ptr1);
				if (ptr1 == IntPtr.Zero)
				{
					throw new InvalidOperationException("ExtendedFolderBrowserDialogNoRootFolder");
				}
			}
			var flags = 0x40;
			if (!_showNewFolderButton)
			{
				flags += 0x200;
			}
			if (_showEditBox)
			{
				flags += Win32.BIF_EDITBOX;
			}
			if (Control.CheckForIllegalCrossThreadCalls && (Application.OleRequired() != ApartmentState.STA))
			{
				throw new ThreadStateException("ThreadMustBeSTA");
			}

			var ptr2 = IntPtr.Zero;
			var ptr3 = IntPtr.Zero;
			var ptr4 = IntPtr.Zero;
			try
			{
				var browseinfo1 = new Win32.BROWSEINFO();
				ptr3 = Marshal.AllocHGlobal(260 * Marshal.SystemDefaultCharSize);
				ptr4 = Marshal.AllocHGlobal(260 * Marshal.SystemDefaultCharSize);
				Win32.BrowseCallbackProc proc1 =
					extendedFolderBrowserDialogBrowseCallbackProc;
				browseinfo1.pidlRoot = ptr1;
				browseinfo1.hwndOwner = hWndOwner;
				browseinfo1.pszDisplayName = ptr3;
				browseinfo1.lpszTitle = _descriptionText;
				browseinfo1.ulFlags = flags;
				browseinfo1.lpfn = proc1;
				browseinfo1.lParam = IntPtr.Zero;
				browseinfo1.iImage = 0;
				ptr2 = Win32.Shell32.SHBrowseForFolder(browseinfo1);
				if (ptr2 != IntPtr.Zero)
				{
					Win32.Shell32.SHGetPathFromIDList(ptr2, ptr4);
					_selectedPathNeedsCheck = true;
					_selectedPath = Marshal.PtrToStringAuto(ptr4);
					flag1 = true;
				}
			}
			finally
			{
				var malloc1 = getShMalloc();
				malloc1.Free(ptr1);
				if (ptr2 != IntPtr.Zero)
				{
					malloc1.Free(ptr2);
				}
				if (ptr4 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(ptr4);
				}
				if (ptr3 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(ptr3);
				}

				if (_nativeWindow != null)
				{
					_nativeWindow.ReleaseHandle();
				}
			}
			return flag1;
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		[Browsable(true), Localizable(true), DefaultValue(@"")]
		public string Description
		{
			get
			{
				return _descriptionText;
			}
			set
			{
				_descriptionText = value ?? string.Empty;
			}
		}

		[Localizable(false), DefaultValue(0), Browsable(true)]
		public Environment.SpecialFolder RootFolder
		{
			get
			{
				return _rootFolder;
			}
			set
			{
				if (!Enum.IsDefined(typeof(Environment.SpecialFolder), value))
				{
					throw new InvalidEnumArgumentException(@"value", (int)value, typeof(Environment.SpecialFolder));
				}
				_rootFolder = value;
			}
		}

		[DefaultValue(@""), Browsable(true), Localizable(true),
		Editor(@"System.Windows.Forms.Design.SelectedPathEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
			typeof(UITypeEditor))]
		public string SelectedPath
		{
			get
			{
				if ((!string.IsNullOrEmpty(_selectedPath)) && _selectedPathNeedsCheck)
				{
					new FileIOPermission(FileIOPermissionAccess.PathDiscovery, _selectedPath).Demand();
				}
				return _selectedPath;
			}
			set
			{
				_selectedPath = value ?? string.Empty;
				_selectedPathNeedsCheck = false;
			}
		}

		[Browsable(true), DefaultValue(true), Localizable(false)]
		public bool ShowNewFolderButton
		{
			get
			{
				return _showNewFolderButton;
			}
			set
			{
				_showNewFolderButton = value;
			}
		}

		[Browsable(true), DefaultValue(false), Localizable(false)]
		public bool ShowEditBox
		{
			get { return _showEditBox; }
			set { _showEditBox = value; }
		}

		[Browsable(true), DefaultValue(false), Localizable(false)]
		public bool WantCenterScreen
		{
			get { return _wantCenterScreen; }
			set { _wantCenterScreen = value; }
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private variables.
		// ------------------------------------------------------------------

		private string _descriptionText;
		private Environment.SpecialFolder _rootFolder;
		private string _selectedPath;
		private bool _selectedPathNeedsCheck;
		private bool _showNewFolderButton;
		private bool _showEditBox;
		private bool _wantCenterScreen = true;
		private MyNativeWindow _nativeWindow;

		// ------------------------------------------------------------------
		#endregion

		private class MyNativeWindow : NativeWindow
		{
			private readonly ExtendedFolderBrowserDialog _owner;

			public MyNativeWindow(ExtendedFolderBrowserDialog owner)
			{
				_owner = owner;
			}

			protected override void WndProc(ref Message m)
			{
				if (_owner.WantCenterScreen && m.Msg == (int)Win32.WM.WM_SHOWWINDOW)
				{
					_owner.centerToScreen(m.HWnd);
				}

				base.WndProc(ref m);
			}
		}
	}
}