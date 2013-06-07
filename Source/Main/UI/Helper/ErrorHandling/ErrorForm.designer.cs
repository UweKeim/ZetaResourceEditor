namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
	partial class ErrorForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
			this.linearGradientPanel1 = new ZetaResourceEditor.UI.Helper.ExtendedControls.LinearGradientPanel();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.buttonContinue = new DevExpress.XtraEditors.SimpleButton();
			this.optionsButton = new DevExpress.XtraEditors.DropDownButton();
			this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.detailedErrorsButton = new DevExpress.XtraBars.BarButtonItem();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
			this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
			this.lineUserControl1 = new ZetaResourceEditor.UI.Helper.LineUserControl();
			this.linearGradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// linearGradientPanel1
			// 
			this.linearGradientPanel1.Controls.Add(this.labelControl2);
			resources.ApplyResources(this.linearGradientPanel1, "linearGradientPanel1");
			this.linearGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.linearGradientPanel1.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(73)))), ((int)(((byte)(29)))));
			this.linearGradientPanel1.GradientStart = System.Drawing.SystemColors.Window;
			this.linearGradientPanel1.Name = "linearGradientPanel1";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
			resources.ApplyResources(this.labelControl2, "labelControl2");
			this.labelControl2.Name = "labelControl2";
			// 
			// buttonContinue
			// 
			resources.ApplyResources(this.buttonContinue, "buttonContinue");
			this.buttonContinue.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("buttonContinue.Appearance.Font")));
			this.buttonContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonContinue.Name = "buttonContinue";
			// 
			// optionsButton
			// 
			resources.ApplyResources(this.optionsButton, "optionsButton");
			this.optionsButton.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("optionsButton.Appearance.Font")));
			this.optionsButton.Appearance.Options.UseFont = true;
			this.optionsButton.DropDownControl = this.optionsPopupMenu;
			this.optionsButton.Image = ((System.Drawing.Image)(resources.GetObject("optionsButton.Image")));
			this.optionsButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
			this.optionsButton.Name = "optionsButton";
			this.optionsButton.ShowArrowButton = false;
			// 
			// optionsPopupMenu
			// 
			this.optionsPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.detailedErrorsButton)});
			this.optionsPopupMenu.Manager = this.barManager;
			this.optionsPopupMenu.Name = "optionsPopupMenu";
			this.optionsPopupMenu.BeforePopup += new System.ComponentModel.CancelEventHandler(this.optionsPopupMenu_BeforePopup);
			// 
			// detailedErrorsButton
			// 
			resources.ApplyResources(this.detailedErrorsButton, "detailedErrorsButton");
			this.detailedErrorsButton.Id = 0;
			this.detailedErrorsButton.Name = "detailedErrorsButton";
			this.detailedErrorsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.detailedErrorsButton_ItemClick);
			// 
			// barManager
			// 
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Images = this.imageCollection1;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.detailedErrorsButton});
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
			// imageCollection1
			// 
			this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
			// 
			// memoEdit1
			// 
			resources.ApplyResources(this.memoEdit1, "memoEdit1");
			this.memoEdit1.Name = "memoEdit1";
			this.memoEdit1.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("memoEdit1.Properties.Appearance.BackColor")));
			this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.memoEdit1.Properties.NullValuePrompt = resources.GetString("memoEdit1.Properties.NullValuePrompt");
			this.memoEdit1.Properties.ReadOnly = true;
			this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.lineUserControl1);
			this.panelControl1.Controls.Add(this.hyperLinkEdit1);
			this.panelControl1.Controls.Add(this.memoEdit1);
			this.panelControl1.Controls.Add(this.buttonContinue);
			this.panelControl1.Controls.Add(this.optionsButton);
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Name = "panelControl1";
			// 
			// hyperLinkEdit1
			// 
			resources.ApplyResources(this.hyperLinkEdit1, "hyperLinkEdit1");
			this.hyperLinkEdit1.Name = "hyperLinkEdit1";
			this.hyperLinkEdit1.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("hyperLinkEdit1.Properties.Appearance.BackColor")));
			this.hyperLinkEdit1.Properties.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("hyperLinkEdit1.Properties.Appearance.ForeColor")));
			this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.hyperLinkEdit1.Properties.Appearance.Options.UseForeColor = true;
			this.hyperLinkEdit1.Properties.Appearance.Options.UseTextOptions = true;
			this.hyperLinkEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.hyperLinkEdit1.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hyperLinkEdit1_OpenLink);
			// 
			// lineUserControl1
			// 
			resources.ApplyResources(this.lineUserControl1, "lineUserControl1");
			this.lineUserControl1.Name = "lineUserControl1";
			this.lineUserControl1.TabStop = false;
			// 
			// ErrorForm
			// 
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ErrorForm.Appearance.Font")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			resources.ApplyResources(this, "$this");
			this.ControlBox = false;
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.linearGradientPanel1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ErrorForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.errorForm_FormClosing);
			this.Load += new System.EventHandler(this.errorForm_Load);
			this.linearGradientPanel1.ResumeLayout(false);
			this.linearGradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ZetaResourceEditor.UI.Helper.ExtendedControls.LinearGradientPanel linearGradientPanel1;
		private DevExpress.XtraEditors.SimpleButton buttonContinue;
		private DevExpress.XtraEditors.DropDownButton optionsButton;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.MemoEdit memoEdit1;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private DevExpress.XtraBars.BarButtonItem detailedErrorsButton;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.Utils.ImageCollection imageCollection1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
		private LineUserControl lineUserControl1;
	}
}