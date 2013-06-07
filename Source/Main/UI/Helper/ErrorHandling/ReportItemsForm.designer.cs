namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
	partial class ReportItemsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportItemsForm));
			this.groupBox2 = new DevExpress.XtraEditors.GroupControl();
			this.itemsListView = new DevExpress.XtraEditors.ImageListBoxControl();
			this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
			this.buttonShow = new DevExpress.XtraEditors.SimpleButton();
			this.groupBox1 = new DevExpress.XtraEditors.GroupControl();
			this.additionalRemarksTextBox = new DevExpress.XtraEditors.MemoEdit();
			this.emailAddressTextBox = new DevExpress.XtraEditors.TextEdit();
			this.label4 = new DevExpress.XtraEditors.LabelControl();
			this.label3 = new DevExpress.XtraEditors.LabelControl();
			this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
			this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemsListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.additionalRemarksTextBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emailAddressTextBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Controls.Add(this.itemsListView);
			this.groupBox2.Controls.Add(this.buttonShow);
			this.groupBox2.Name = "groupBox2";
			// 
			// itemsListView
			// 
			resources.ApplyResources(this.itemsListView, "itemsListView");
			this.itemsListView.ImageList = this.imageCollection1;
			this.itemsListView.Name = "itemsListView";
			this.itemsListView.SelectedIndexChanged += new System.EventHandler(this.itemsListView_SelectedIndexChanged);
			this.itemsListView.DoubleClick += new System.EventHandler(this.itemsListView_DoubleClick);
			// 
			// imageCollection1
			// 
			this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
			this.imageCollection1.Images.SetKeyName(0, "document");
			// 
			// buttonShow
			// 
			resources.ApplyResources(this.buttonShow, "buttonShow");
			this.buttonShow.Image = ((System.Drawing.Image)(resources.GetObject("buttonShow.Image")));
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.additionalRemarksTextBox);
			this.groupBox1.Controls.Add(this.emailAddressTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Name = "groupBox1";
			// 
			// additionalRemarksTextBox
			// 
			resources.ApplyResources(this.additionalRemarksTextBox, "additionalRemarksTextBox");
			this.additionalRemarksTextBox.Name = "additionalRemarksTextBox";
			// 
			// emailAddressTextBox
			// 
			resources.ApplyResources(this.emailAddressTextBox, "emailAddressTextBox");
			this.emailAddressTextBox.Name = "emailAddressTextBox";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// buttonOK
			// 
			resources.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Name = "buttonCancel";
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.groupBox2);
			this.panelControl1.Controls.Add(this.buttonCancel);
			this.panelControl1.Controls.Add(this.groupBox1);
			this.panelControl1.Controls.Add(this.buttonOK);
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Name = "panelControl1";
			// 
			// ReportItemsForm
			// 
			this.AcceptButton = this.buttonOK;
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ReportItemsForm.Appearance.Font")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.buttonCancel;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panelControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReportItemsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportIssueForm_FormClosing);
			this.Load += new System.EventHandler(this.ReportIssueForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.itemsListView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.additionalRemarksTextBox.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emailAddressTextBox.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupBox2;
		private DevExpress.XtraEditors.SimpleButton buttonShow;
		private DevExpress.XtraEditors.GroupControl groupBox1;
		private DevExpress.XtraEditors.MemoEdit additionalRemarksTextBox;
		private DevExpress.XtraEditors.TextEdit emailAddressTextBox;
		private DevExpress.XtraEditors.LabelControl label4;
		private DevExpress.XtraEditors.LabelControl label3;
		private DevExpress.XtraEditors.SimpleButton buttonOK;
		private DevExpress.XtraEditors.SimpleButton buttonCancel;
		private DevExpress.XtraEditors.ImageListBoxControl itemsListView;
		private DevExpress.Utils.ImageCollection imageCollection1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
	}
}