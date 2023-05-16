namespace ZetaResourceEditor.UI.Main.RightContent
{
	partial class GroupFilesUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(GroupFilesUserControl));
			mainTabControl = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl();
			barDockControlTop = new BarDockControl();
			barDockControlBottom = new BarDockControl();
			barDockControlLeft = new BarDockControl();
			barDockControlRight = new BarDockControl();
			barDockControl1 = new BarDockControl();
			barDockControl2 = new BarDockControl();
			barDockControl3 = new BarDockControl();
			barDockControl4 = new BarDockControl();
			barDockControl5 = new BarDockControl();
			barDockControl6 = new BarDockControl();
			barDockControl7 = new BarDockControl();
			barDockControl8 = new BarDockControl();
			optionsPopupMenu = new PopupMenu(components);
			buttonSave = new BarButtonItem();
			buttonSaveAll = new BarButtonItem();
			buttonOpenFolder = new BarButtonItem();
			buttonClose = new BarButtonItem();
			buttonCloseAllButThis = new BarButtonItem();
			buttonCloseAll = new BarButtonItem();
			barManager = new BarManager(components);
			((ISupportInitialize)mainTabControl).BeginInit();
			((ISupportInitialize)optionsPopupMenu).BeginInit();
			((ISupportInitialize)barManager).BeginInit();
			SuspendLayout();
			// 
			// mainTabControl
			// 
			mainTabControl.AppearancePage.Header.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			mainTabControl.AppearancePage.Header.Options.UseFont = true;
			mainTabControl.Dock = DockStyle.Fill;
			mainTabControl.Location = new Point(0, 0);
			mainTabControl.Name = "mainTabControl";
			mainTabControl.Size = new Size(150, 150);
			mainTabControl.TabIndex = 0;
			mainTabControl.MouseUp += mainTabControl_MouseUp;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = null;
			barDockControlTop.Size = new Size(0, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Location = new Point(0, 0);
			barDockControlBottom.Manager = null;
			barDockControlBottom.Size = new Size(0, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Location = new Point(0, 0);
			barDockControlLeft.Manager = null;
			barDockControlLeft.Size = new Size(0, 0);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Location = new Point(0, 0);
			barDockControlRight.Manager = null;
			barDockControlRight.Size = new Size(0, 0);
			// 
			// barDockControl1
			// 
			barDockControl1.CausesValidation = false;
			barDockControl1.Location = new Point(0, 0);
			barDockControl1.Manager = null;
			barDockControl1.Size = new Size(0, 0);
			// 
			// barDockControl2
			// 
			barDockControl2.CausesValidation = false;
			barDockControl2.Location = new Point(0, 0);
			barDockControl2.Manager = null;
			barDockControl2.Size = new Size(0, 0);
			// 
			// barDockControl3
			// 
			barDockControl3.CausesValidation = false;
			barDockControl3.Location = new Point(0, 0);
			barDockControl3.Manager = null;
			barDockControl3.Size = new Size(0, 0);
			// 
			// barDockControl4
			// 
			barDockControl4.CausesValidation = false;
			barDockControl4.Location = new Point(0, 0);
			barDockControl4.Manager = null;
			barDockControl4.Size = new Size(0, 0);
			// 
			// barDockControl5
			// 
			barDockControl5.CausesValidation = false;
			barDockControl5.Dock = DockStyle.Top;
			barDockControl5.Location = new Point(0, 0);
			barDockControl5.Manager = barManager;
			barDockControl5.Size = new Size(150, 0);
			// 
			// barDockControl6
			// 
			barDockControl6.CausesValidation = false;
			barDockControl6.Dock = DockStyle.Bottom;
			barDockControl6.Location = new Point(0, 150);
			barDockControl6.Manager = barManager;
			barDockControl6.Size = new Size(150, 0);
			// 
			// barDockControl7
			// 
			barDockControl7.CausesValidation = false;
			barDockControl7.Dock = DockStyle.Left;
			barDockControl7.Location = new Point(0, 0);
			barDockControl7.Manager = barManager;
			barDockControl7.Size = new Size(0, 150);
			// 
			// barDockControl8
			// 
			barDockControl8.CausesValidation = false;
			barDockControl8.Dock = DockStyle.Right;
			barDockControl8.Location = new Point(150, 0);
			barDockControl8.Manager = barManager;
			barDockControl8.Size = new Size(0, 150);
			// 
			// optionsPopupMenu
			// 
			optionsPopupMenu.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(buttonSave), new LinkPersistInfo(buttonSaveAll), new LinkPersistInfo(buttonOpenFolder, true), new LinkPersistInfo(buttonClose, true), new LinkPersistInfo(buttonCloseAllButThis), new LinkPersistInfo(buttonCloseAll) });
			optionsPopupMenu.Manager = barManager;
			optionsPopupMenu.Name = "optionsPopupMenu";
			optionsPopupMenu.BeforePopup += optionsPopupMenu_BeforePopup;
			// 
			// buttonSave
			// 
			buttonSave.Caption = "Save";
			buttonSave.Id = 3;
			buttonSave.ImageOptions.Image = (Image)resources.GetObject("buttonSave.ImageOptions.Image");
			buttonSave.Name = "buttonSave";
			buttonSave.ItemClick += buttonSave_ItemClick;
			// 
			// buttonSaveAll
			// 
			buttonSaveAll.Caption = "Save all";
			buttonSaveAll.Id = 4;
			buttonSaveAll.ImageOptions.Image = (Image)resources.GetObject("buttonSaveAll.ImageOptions.Image");
			buttonSaveAll.Name = "buttonSaveAll";
			buttonSaveAll.ItemClick += buttonSaveAll_ItemClick;
			// 
			// buttonOpenFolder
			// 
			buttonOpenFolder.Caption = "Open folder";
			buttonOpenFolder.Id = 5;
			buttonOpenFolder.ImageOptions.Image = (Image)resources.GetObject("buttonOpenFolder.ImageOptions.Image");
			buttonOpenFolder.Name = "buttonOpenFolder";
			buttonOpenFolder.ItemClick += buttonOpenFolder_ItemClick;
			// 
			// buttonClose
			// 
			buttonClose.Caption = "Close";
			buttonClose.Id = 6;
			buttonClose.Name = "buttonClose";
			buttonClose.ItemClick += buttonClose_ItemClick;
			// 
			// buttonCloseAllButThis
			// 
			buttonCloseAllButThis.Caption = "Close all but this";
			buttonCloseAllButThis.Id = 7;
			buttonCloseAllButThis.Name = "buttonCloseAllButThis";
			buttonCloseAllButThis.ItemClick += buttonCloseAllButThis_ItemClick;
			// 
			// buttonCloseAll
			// 
			buttonCloseAll.Caption = "Close all";
			buttonCloseAll.Id = 8;
			buttonCloseAll.Name = "buttonCloseAll";
			buttonCloseAll.ItemClick += buttonCloseAll_ItemClick;
			// 
			// barManager
			// 
			barManager.DockControls.Add(barDockControl5);
			barManager.DockControls.Add(barDockControl6);
			barManager.DockControls.Add(barDockControl7);
			barManager.DockControls.Add(barDockControl8);
			barManager.Form = this;
			barManager.Items.AddRange(new BarItem[] { buttonSave, buttonSaveAll, buttonOpenFolder, buttonClose, buttonCloseAllButThis, buttonCloseAll });
			barManager.MaxItemId = 9;
			// 
			// GroupFilesUserControl
			// 
			Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(mainTabControl);
			Controls.Add(barDockControl7);
			Controls.Add(barDockControl8);
			Controls.Add(barDockControl6);
			Controls.Add(barDockControl5);
			Margin = new Padding(0);
			Name = "GroupFilesUserControl";
			((ISupportInitialize)mainTabControl).EndInit();
			((ISupportInitialize)optionsPopupMenu).EndInit();
			((ISupportInitialize)barManager).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl mainTabControl;
		private BarDockControl barDockControlTop;
		private BarDockControl barDockControlBottom;
		private BarDockControl barDockControlLeft;
		private BarDockControl barDockControlRight;
		private BarDockControl barDockControl1;
		private BarDockControl barDockControl2;
		private BarDockControl barDockControl3;
		private BarDockControl barDockControl4;
		private BarDockControl barDockControl5;
		private BarDockControl barDockControl6;
		private BarDockControl barDockControl7;
		private BarDockControl barDockControl8;
		private PopupMenu optionsPopupMenu;
		private BarManager barManager;
		private BarButtonItem buttonSave;
		private BarButtonItem buttonSaveAll;
		private BarButtonItem buttonOpenFolder;
		private BarButtonItem buttonClose;
		private BarButtonItem buttonCloseAllButThis;
		private BarButtonItem buttonCloseAll;
	}
}
