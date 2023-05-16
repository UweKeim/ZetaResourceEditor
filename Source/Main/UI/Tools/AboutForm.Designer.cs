namespace ZetaResourceEditor.UI.Tools
{
	partial class AboutForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(AboutForm));
			panelControl1 = new PanelControl();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			linkLabel1 = new ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit();
			labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			pictureEdit1 = new PictureEdit();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			label4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelBoldControl();
			buttonClose = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			((ISupportInitialize)panelControl1).BeginInit();
			panelControl1.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			((ISupportInitialize)linkLabel1.Properties).BeginInit();
			((ISupportInitialize)pictureEdit1.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelControl1
			// 
			panelControl1.AutoSize = true;
			tablePanel1.SetColumn(panelControl1, 0);
			tablePanel1.SetColumnSpan(panelControl1, 3);
			panelControl1.Controls.Add(tablePanel2);
			panelControl1.Dock = DockStyle.Fill;
			panelControl1.Location = new Point(11, 97);
			panelControl1.Margin = new Padding(0, 9, 0, 0);
			panelControl1.Name = "panelControl1";
			tablePanel1.SetRow(panelControl1, 2);
			panelControl1.Size = new Size(303, 143);
			panelControl1.TabIndex = 1;
			// 
			// tablePanel2
			// 
			tablePanel2.AutoSize = true;
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F) });
			tablePanel2.Controls.Add(linkLabel1);
			tablePanel2.Controls.Add(labelControl2);
			tablePanel2.Controls.Add(labelControl1);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(2, 2);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30.66666F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 61.33335F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
			tablePanel2.Size = new Size(299, 139);
			tablePanel2.TabIndex = 0;
			tablePanel2.UseSkinIndents = true;
			// 
			// linkLabel1
			// 
			linkLabel1.AllowAutoWidth = true;
			linkLabel1.CausesValidation = false;
			tablePanel2.SetColumn(linkLabel1, 0);
			linkLabel1.Dock = DockStyle.Top;
			linkLabel1.EditValue = "www.zeta-resource-editor.com";
			linkLabel1.Location = new Point(11, 102);
			linkLabel1.Margin = new Padding(0);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Properties.AllowFocused = false;
			linkLabel1.Properties.Appearance.BackColor = Color.Transparent;
			linkLabel1.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			linkLabel1.Properties.Appearance.Options.UseBackColor = true;
			linkLabel1.Properties.Appearance.Options.UseFont = true;
			linkLabel1.Properties.BorderStyle = BorderStyles.NoBorder;
			linkLabel1.Properties.MaskSettings.Set("mask", null);
			linkLabel1.Properties.NullValuePrompt = null;
			linkLabel1.Properties.ReadOnly = true;
			tablePanel2.SetRow(linkLabel1, 2);
			linkLabel1.Size = new Size(277, 22);
			linkLabel1.TabIndex = 0;
			linkLabel1.OpenLink += linkLabel1_OpenLink;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl2.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl2, 0);
			labelControl2.Dock = DockStyle.Top;
			labelControl2.Location = new Point(11, 41);
			labelControl2.Margin = new Padding(0, 0, 0, 9);
			labelControl2.Name = "labelControl2";
			tablePanel2.SetRow(labelControl2, 1);
			labelControl2.Size = new Size(277, 51);
			labelControl2.TabIndex = 2;
			labelControl2.Text = "Manfred-Wörner-Straße 115\r\n73037 Göppingen\r\nGermany";
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl1, 0);
			labelControl1.Dock = DockStyle.Top;
			labelControl1.Location = new Point(11, 10);
			labelControl1.Margin = new Padding(0, 0, 0, 9);
			labelControl1.Name = "labelControl1";
			tablePanel2.SetRow(labelControl1, 0);
			labelControl1.Size = new Size(277, 17);
			labelControl1.TabIndex = 1;
			labelControl1.Text = "Zeta Software GmbH";
			// 
			// pictureEdit1
			// 
			tablePanel1.SetColumn(pictureEdit1, 0);
			pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
			pictureEdit1.Location = new Point(11, 10);
			pictureEdit1.Margin = new Padding(0);
			pictureEdit1.Name = "pictureEdit1";
			pictureEdit1.Properties.Appearance.BackColor = Color.Transparent;
			pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			pictureEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
			pictureEdit1.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
			pictureEdit1.Properties.SizeMode = PictureSizeMode.Squeeze;
			tablePanel1.SetRow(pictureEdit1, 0);
			tablePanel1.SetRowSpan(pictureEdit1, 2);
			pictureEdit1.Size = new Size(87, 78);
			pictureEdit1.TabIndex = 0;
			// 
			// tablePanel1
			// 
			tablePanel1.AutoSize = true;
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.67F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 51.07F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 27.26F) });
			tablePanel1.Controls.Add(label4);
			tablePanel1.Controls.Add(labelControl3);
			tablePanel1.Controls.Add(buttonClose);
			tablePanel1.Controls.Add(panelControl1);
			tablePanel1.Controls.Add(pictureEdit1);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 27.33331F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 51.33308F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 157.3334F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(325, 283);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// label4
			// 
			label4.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label4, 1);
			tablePanel1.SetColumnSpan(label4, 2);
			label4.Location = new Point(98, 36);
			label4.Margin = new Padding(0, 0, 0, 18);
			label4.Name = "label4";
			tablePanel1.SetRow(label4, 1);
			label4.Size = new Size(118, 34);
			label4.TabIndex = 4;
			label4.Text = "Version {VersionNo}\r\nBuilt {BuildDate}";
			// 
			// labelControl3
			// 
			labelControl3.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			labelControl3.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl3, 1);
			tablePanel1.SetColumnSpan(labelControl3, 2);
			labelControl3.Location = new Point(98, 10);
			labelControl3.Margin = new Padding(0, 0, 0, 9);
			labelControl3.Name = "labelControl3";
			tablePanel1.SetRow(labelControl3, 0);
			labelControl3.Size = new Size(127, 17);
			labelControl3.TabIndex = 3;
			labelControl3.Text = "Zeta Resource Editor";
			// 
			// buttonClose
			// 
			buttonClose.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonClose.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonClose, 2);
			buttonClose.DialogResult = DialogResult.OK;
			buttonClose.Dock = DockStyle.Fill;
			buttonClose.Location = new Point(239, 244);
			buttonClose.Margin = new Padding(0);
			buttonClose.Name = "buttonClose";
			tablePanel1.SetRow(buttonClose, 4);
			buttonClose.Size = new Size(75, 28);
			buttonClose.TabIndex = 0;
			buttonClose.Text = "Close";
			// 
			// AboutForm
			// 
			AcceptButton = buttonClose;
			AllowF1Help = false;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonClose;
			ClientSize = new Size(325, 283);
			Controls.Add(tablePanel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Info";
			Load += AboutFormModern_Load;
			((ISupportInitialize)panelControl1).EndInit();
			panelControl1.ResumeLayout(false);
			panelControl1.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			((ISupportInitialize)linkLabel1.Properties).EndInit();
			((ISupportInitialize)pictureEdit1.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
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