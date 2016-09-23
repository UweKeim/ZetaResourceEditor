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
            this.button1 = new ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton();
            this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.browseButton = new DevExpress.XtraBars.BarButtonItem();
            this.openButton = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popupImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.locationTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.nameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
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
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Appearance.Options.UseFont = true;
            this.button1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.button1.DropDownControl = this.optionsPopupMenu;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.button1.Location = new System.Drawing.Point(390, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 4;
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
            this.browseButton.Caption = "&Browse...";
            this.browseButton.Id = 0;
            this.browseButton.ImageIndex = 1;
            this.browseButton.Name = "browseButton";
            this.browseButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.browseButton_ItemClick);
            // 
            // openButton
            // 
            this.openButton.Caption = "&Open folder";
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
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(426, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 122);
            this.barDockControlBottom.Size = new System.Drawing.Size(426, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 122);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(426, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 122);
            // 
            // popupImageCollection
            // 
            this.popupImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("popupImageCollection.ImageStream")));
            this.popupImageCollection.Images.SetKeyName(0, "folder_green.png");
            this.popupImageCollection.Images.SetKeyName(1, "folder_window.png");
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTextBox.Bold = false;
            this.locationTextBox.CueText = null;
            this.locationTextBox.Location = new System.Drawing.Point(70, 42);
            this.locationTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.locationTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.locationTextBox.Properties.Appearance.Options.UseFont = true;
            this.locationTextBox.Properties.NullValuePrompt = null;
            this.locationTextBox.Properties.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(317, 24);
            this.locationTextBox.TabIndex = 3;
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Bold = false;
            this.nameTextBox.CueText = null;
            this.nameTextBox.Location = new System.Drawing.Point(70, 12);
            this.nameTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.nameTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.Properties.Appearance.Options.UseFont = true;
            this.nameTextBox.Properties.NullValuePrompt = null;
            this.nameTextBox.Size = new System.Drawing.Size(344, 24);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Location:";
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Name:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(339, 82);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.WantDrawFocusRectangle = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(258, 82);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 28);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.WantDrawFocusRectangle = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.locationTextBox);
            this.panelControl1.Controls.Add(this.buttonOK);
            this.panelControl1.Controls.Add(this.nameTextBox);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.buttonCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
            this.panelControl1.Size = new System.Drawing.Size(426, 122);
            this.panelControl1.TabIndex = 0;
            // 
            // CreateNewProjectForm
            // 
            this.AcceptButton = this.buttonOK;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(426, 122);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 175);
            this.MinimizeBox = false;
            this.Name = "CreateNewProjectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new project";
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
            this.PerformLayout();

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit locationTextBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit nameTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private DevExpress.XtraBars.BarButtonItem openButton;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.Utils.ImageCollection popupImageCollection;
		private DevExpress.XtraBars.BarButtonItem browseButton;
		private ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton button1;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;

	}
}