namespace LicenseGenerator.UI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.propertyDescriptionControl1 = new DevExpress.XtraVerticalGrid.PropertyDescriptionControl();
			this.propertyGrid = new DevExpress.XtraVerticalGrid.PropertyGridControl();
			this.buttonCopyToClipboard = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.licenseMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
			this.DefaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.licenseMemoEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.groupControl1);
			this.panelControl1.Controls.Add(this.buttonClose);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
			this.panelControl1.Size = new System.Drawing.Size(517, 503);
			this.panelControl1.TabIndex = 0;
			// 
			// groupControl1
			// 
			this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupControl1.Controls.Add(this.splitContainerControl1);
			this.groupControl1.Controls.Add(this.buttonCopyToClipboard);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.licenseMemoEdit);
			this.groupControl1.Controls.Add(this.pictureBox1);
			this.groupControl1.Location = new System.Drawing.Point(12, 12);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Padding = new System.Windows.Forms.Padding(9);
			this.groupControl1.Size = new System.Drawing.Size(493, 447);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "License";
			// 
			// propertyDescriptionControl1
			// 
			this.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyDescriptionControl1.Location = new System.Drawing.Point(0, 0);
			this.propertyDescriptionControl1.Name = "propertyDescriptionControl1";
			this.propertyDescriptionControl1.PropertyGrid = this.propertyGrid;
			this.propertyDescriptionControl1.Size = new System.Drawing.Size(404, 60);
			this.propertyDescriptionControl1.TabIndex = 5;
			this.propertyDescriptionControl1.TabStop = false;
			// 
			// propertyGrid
			// 
			this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new System.Drawing.Size(404, 187);
			this.propertyGrid.TabIndex = 0;
			this.propertyGrid.CellValueChanged += new DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(this.propertyGrid_CellValueChanged);
			// 
			// buttonCopyToClipboard
			// 
			this.buttonCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyToClipboard.Image")));
			this.buttonCopyToClipboard.Location = new System.Drawing.Point(75, 407);
			this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
			this.buttonCopyToClipboard.Size = new System.Drawing.Size(125, 26);
			this.buttonCopyToClipboard.TabIndex = 4;
			this.buttonCopyToClipboard.Text = "Copy to clipboard";
			this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(75, 30);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(80, 13);
			this.labelControl2.TabIndex = 0;
			this.labelControl2.Text = "License settings:";
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelControl1.Location = new System.Drawing.Point(75, 317);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(59, 13);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "License key:";
			// 
			// licenseMemoEdit
			// 
			this.licenseMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.licenseMemoEdit.Location = new System.Drawing.Point(75, 336);
			this.licenseMemoEdit.Name = "licenseMemoEdit";
			this.licenseMemoEdit.Properties.ReadOnly = true;
			this.licenseMemoEdit.Size = new System.Drawing.Size(404, 65);
			this.licenseMemoEdit.TabIndex = 3;
			this.licenseMemoEdit.EditValueChanged += new System.EventHandler(this.memoEdit1_EditValueChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox1.Location = new System.Drawing.Point(14, 34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonClose.Location = new System.Drawing.Point(430, 465);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 26);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "Close";
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// DefaultLookAndFeel
			// 
			this.DefaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
			this.splitContainerControl1.Horizontal = false;
			this.splitContainerControl1.Location = new System.Drawing.Point(75, 49);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.propertyGrid);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Controls.Add(this.propertyDescriptionControl1);
			this.splitContainerControl1.Panel2.MinSize = 60;
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(404, 253);
			this.splitContainerControl1.SplitterPosition = 59;
			this.splitContainerControl1.TabIndex = 1;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(517, 503);
			this.Controls.Add(this.panelControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(533, 541);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zeta Resource Editor License Generator";
			this.Load += new System.EventHandler(this.MainForrm_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.licenseMemoEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton buttonClose;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGrid;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.MemoEdit licenseMemoEdit;
		private DevExpress.XtraEditors.SimpleButton buttonCopyToClipboard;
		public DevExpress.LookAndFeel.DefaultLookAndFeel DefaultLookAndFeel;
		private DevExpress.XtraVerticalGrid.PropertyDescriptionControl propertyDescriptionControl1;
		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
	}
}


