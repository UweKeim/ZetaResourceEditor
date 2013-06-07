namespace ZetaResourceEditor.UI.Projects
{
	partial class CreateNewProjectForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewProjectForm));
			this.button1 = new DevExpress.XtraEditors.DropDownButton();
			this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.browseButton = new DevExpress.XtraBars.BarButtonItem();
			this.openButton = new DevExpress.XtraBars.BarButtonItem();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.popupImageCollection = new DevExpress.Utils.ImageCollection(this.components);
			this.locationTextBox = new DevExpress.XtraEditors.TextEdit();
			this.nameTextBox = new DevExpress.XtraEditors.TextEdit();
			this.label2 = new DevExpress.XtraEditors.LabelControl();
			this.label1 = new DevExpress.XtraEditors.LabelControl();
			this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
			this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.lineUserControl1 = new ZetaResourceEditor.UI.Helper.LineUserControl();
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupImageCollection)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.locationTextBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nameTextBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.DropDownControl = this.optionsPopupMenu;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
			this.button1.Name = "button1";
			this.button1.ShowArrowButton = false;
			// 
			// optionsPopupMenu
			// 
			this.optionsPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.browseButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.openButton, true)});
			this.optionsPopupMenu.Manager = this.barManager;
			this.optionsPopupMenu.Name = "optionsPopupMenu";
			this.optionsPopupMenu.BeforePopup += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// browseButton
			// 
			resources.ApplyResources(this.browseButton, "browseButton");
			this.browseButton.Id = 0;
			this.browseButton.ImageIndex = 1;
			this.browseButton.Name = "browseButton";
			this.browseButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.browseButton_ItemClick);
			// 
			// openButton
			// 
			resources.ApplyResources(this.openButton, "openButton");
			this.openButton.Id = 0;
			this.openButton.ImageIndex = 0;
			this.openButton.Name = "openButton";
			this.openButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.openButton_ItemClick);
			// 
			// barManager
			// 
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Images = this.popupImageCollection;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.browseButton,
            this.openButton});
			this.barManager.MaxItemId = 3;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
			// 
			// popupImageCollection
			// 
			this.popupImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("popupImageCollection.ImageStream")));
			this.popupImageCollection.Images.SetKeyName(0, "folder_green.png");
			this.popupImageCollection.Images.SetKeyName(1, "folder_window.png");
			// 
			// locationTextBox
			// 
			resources.ApplyResources(this.locationTextBox, "locationTextBox");
			this.locationTextBox.Name = "locationTextBox";
			this.locationTextBox.Properties.ReadOnly = true;
			this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
			// 
			// nameTextBox
			// 
			resources.ApplyResources(this.nameTextBox, "nameTextBox");
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Name = "buttonCancel";
			// 
			// buttonOK
			// 
			resources.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.button1);
			this.panelControl1.Controls.Add(this.lineUserControl1);
			this.panelControl1.Controls.Add(this.locationTextBox);
			this.panelControl1.Controls.Add(this.buttonOK);
			this.panelControl1.Controls.Add(this.nameTextBox);
			this.panelControl1.Controls.Add(this.label2);
			this.panelControl1.Controls.Add(this.label1);
			this.panelControl1.Controls.Add(this.buttonCancel);
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Name = "panelControl1";
			// 
			// lineUserControl1
			// 
			resources.ApplyResources(this.lineUserControl1, "lineUserControl1");
			this.lineUserControl1.Name = "lineUserControl1";
			this.lineUserControl1.TabStop = false;
			// 
			// CreateNewProjectForm
			// 
			this.AcceptButton = this.buttonOK;
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("CreateNewProjectForm.Appearance.Font")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.buttonCancel;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateNewProjectForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewProjectForm_FormClosing);
			this.Load += new System.EventHandler(this.CreateNewProjectForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupImageCollection)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.locationTextBox.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nameTextBox.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton buttonCancel;
		private DevExpress.XtraEditors.SimpleButton buttonOK;
		private DevExpress.XtraEditors.TextEdit locationTextBox;
		private DevExpress.XtraEditors.TextEdit nameTextBox;
		private DevExpress.XtraEditors.LabelControl label2;
		private DevExpress.XtraEditors.LabelControl label1;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private DevExpress.XtraBars.BarButtonItem openButton;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.Utils.ImageCollection popupImageCollection;
		private DevExpress.XtraBars.BarButtonItem browseButton;
		private DevExpress.XtraEditors.DropDownButton button1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private Helper.LineUserControl lineUserControl1;

	}
}