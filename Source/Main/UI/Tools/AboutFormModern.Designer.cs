namespace ZetaResourceEditor.UI.Tools
{
	partial class AboutFormModern
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutFormModern));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			this.linkLabel1 = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit();
			this.labelControl2 = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			this.labelControl1 = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			this.label4 = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			this.labelControl3 = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelBoldControl();
			this.buttonClose = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
			this.tablePanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.linkLabel1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
			this.tablePanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.tablePanel1.SetColumn(this.panelControl1, 0);
			this.tablePanel1.SetColumnSpan(this.panelControl1, 3);
			this.panelControl1.Controls.Add(this.tablePanel2);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(19, 108);
			this.panelControl1.Name = "panelControl1";
			this.tablePanel1.SetRow(this.panelControl1, 3);
			this.panelControl1.Size = new System.Drawing.Size(287, 151);
			this.panelControl1.TabIndex = 1;
			// 
			// tablePanel2
			// 
			this.tablePanel2.AutoSize = true;
			this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
			this.tablePanel2.Controls.Add(this.linkLabel1);
			this.tablePanel2.Controls.Add(this.labelControl2);
			this.tablePanel2.Controls.Add(this.labelControl1);
			this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablePanel2.Location = new System.Drawing.Point(2, 2);
			this.tablePanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tablePanel2.Name = "tablePanel2";
			this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30.66666F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 61.33335F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
			this.tablePanel2.Size = new System.Drawing.Size(283, 147);
			this.tablePanel2.TabIndex = 0;
			this.tablePanel2.UseSkinIndents = true;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AllowAutoWidth = true;
			this.linkLabel1.CausesValidation = false;
			this.tablePanel2.SetColumn(this.linkLabel1, 0);
			this.linkLabel1.EditValue = "www.zeta-resource-editor.com";
			this.linkLabel1.Location = new System.Drawing.Point(16, 107);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Properties.AllowFocused = false;
			this.linkLabel1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.linkLabel1.Properties.Appearance.Options.UseBackColor = true;
			this.linkLabel1.Properties.Appearance.Options.UseFont = true;
			this.linkLabel1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.linkLabel1.Properties.MaskSettings.Set("mask", null);
			this.linkLabel1.Properties.NullValuePrompt = null;
			this.linkLabel1.Properties.ReadOnly = true;
			this.tablePanel2.SetRow(this.linkLabel1, 2);
			this.linkLabel1.Size = new System.Drawing.Size(251, 23);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.linkLabel1_OpenLink);
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelControl2.Appearance.Options.UseFont = true;
			this.tablePanel2.SetColumn(this.labelControl2, 0);
			this.labelControl2.Location = new System.Drawing.Point(16, 46);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.labelControl2.Name = "labelControl2";
			this.tablePanel2.SetRow(this.labelControl2, 1);
			this.labelControl2.Size = new System.Drawing.Size(166, 51);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Manfred-Wörner-Straße 115\r\n73037 Göppingen\r\nGermany";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.tablePanel2.SetColumn(this.labelControl1, 0);
			this.labelControl1.Location = new System.Drawing.Point(16, 17);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.labelControl1.Name = "labelControl1";
			this.tablePanel2.SetRow(this.labelControl1, 0);
			this.labelControl1.Size = new System.Drawing.Size(121, 17);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Zeta Software GmbH";
			// 
			// pictureEdit1
			// 
			this.tablePanel1.SetColumn(this.pictureEdit1, 0);
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(19, 18);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
			this.tablePanel1.SetRow(this.pictureEdit1, 0);
			this.tablePanel1.SetRowSpan(this.pictureEdit1, 3);
			this.pictureEdit1.Size = new System.Drawing.Size(78, 84);
			this.pictureEdit1.TabIndex = 0;
			// 
			// tablePanel1
			// 
			this.tablePanel1.AutoSize = true;
			this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.67F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.63F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.7F)});
			this.tablePanel1.Controls.Add(this.label4);
			this.tablePanel1.Controls.Add(this.labelControl3);
			this.tablePanel1.Controls.Add(this.buttonClose);
			this.tablePanel1.Controls.Add(this.panelControl1);
			this.tablePanel1.Controls.Add(this.pictureEdit1);
			this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablePanel1.Location = new System.Drawing.Point(0, 0);
			this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tablePanel1.Name = "tablePanel1";
			this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 27.33331F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 51.33308F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Separator, 16.66667F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 157.3334F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Separator, 13.33335F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
			this.tablePanel1.Size = new System.Drawing.Size(325, 320);
			this.tablePanel1.TabIndex = 0;
			this.tablePanel1.UseSkinIndents = true;
			// 
			// label4
			// 
			this.label4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label4.Appearance.Options.UseFont = true;
			this.tablePanel1.SetColumn(this.label4, 1);
			this.tablePanel1.SetColumnSpan(this.label4, 2);
			this.label4.Location = new System.Drawing.Point(100, 46);
			this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.label4.Name = "label4";
			this.tablePanel1.SetRow(this.label4, 1);
			this.label4.Size = new System.Drawing.Size(118, 34);
			this.label4.TabIndex = 4;
			this.label4.Text = "Version {VersionNo}\r\nBuilt {BuildDate}";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.tablePanel1.SetColumn(this.labelControl3, 1);
			this.tablePanel1.SetColumnSpan(this.labelControl3, 2);
			this.labelControl3.Location = new System.Drawing.Point(100, 15);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.labelControl3.Name = "labelControl3";
			this.tablePanel1.SetRow(this.labelControl3, 0);
			this.labelControl3.Size = new System.Drawing.Size(127, 17);
			this.labelControl3.TabIndex = 3;
			this.labelControl3.Text = "Zeta Resource Editor";
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.buttonClose.Appearance.Options.UseFont = true;
			this.tablePanel1.SetColumn(this.buttonClose, 2);
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonClose.Location = new System.Drawing.Point(233, 275);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
			this.buttonClose.Name = "buttonClose";
			this.tablePanel1.SetRow(this.buttonClose, 5);
			this.buttonClose.Size = new System.Drawing.Size(76, 28);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "Close";
			this.buttonClose.WantDrawFocusRectangle = true;
			// 
			// AboutFormModern
			// 
			this.AcceptButton = this.buttonClose;
			this.AllowF1Help = false;
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(325, 320);
			this.Controls.Add(this.tablePanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutFormModern";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Info";
			this.Load += new System.EventHandler(this.AboutFormModern_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
			this.tablePanel2.ResumeLayout(false);
			this.tablePanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.linkLabel1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
			this.tablePanel1.ResumeLayout(false);
			this.tablePanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private PictureEdit pictureEdit1;
		private PanelControl panelControl1;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonClose;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelBoldControl labelControl3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label4;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit linkLabel1;
	}
}