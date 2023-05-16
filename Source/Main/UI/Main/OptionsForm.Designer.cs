namespace ZetaResourceEditor.UI.Main
{
	partial class OptionsForm
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
			proxyButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			xtraTabControl1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl();
			xtraTabPage1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			xtraTabPage3 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			panel1 = new Panel();
			labelControl10 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			panel8 = new Panel();
			labelControl3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			panel7 = new Panel();
			labelControl9 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			panel6 = new Panel();
			labelControl8 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			panel2 = new Panel();
			panel3 = new Panel();
			labelControl7 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			panel5 = new Panel();
			labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl6 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			panel4 = new Panel();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)xtraTabControl1).BeginInit();
			xtraTabControl1.SuspendLayout();
			xtraTabPage1.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			xtraTabPage3.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			SuspendLayout();
			// 
			// proxyButton
			// 
			proxyButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			proxyButton.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(proxyButton, 0);
			proxyButton.Dock = DockStyle.Fill;
			proxyButton.Location = new Point(11, 10);
			proxyButton.Margin = new Padding(0);
			proxyButton.Name = "proxyButton";
			tablePanel3.SetRow(proxyButton, 0);
			proxyButton.Size = new Size(200, 28);
			proxyButton.TabIndex = 0;
			proxyButton.Text = "Configure HTTP proxy server";
			proxyButton.Click += proxyButton_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 3);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Location = new Point(402, 412);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 1);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 2;
			buttonCancel.Text = "Cancel";
			// 
			// buttonOK
			// 
			buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonOK, 1);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Location = new Point(318, 412);
			buttonOK.Margin = new Padding(0);
			buttonOK.Name = "buttonOK";
			tablePanel1.SetRow(buttonOK, 1);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 1;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(buttonOK);
			tablePanel1.Controls.Add(xtraTabControl1);
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(488, 451);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// xtraTabControl1
			// 
			xtraTabControl1.AppearancePage.Header.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
			tablePanel1.SetColumn(xtraTabControl1, 0);
			tablePanel1.SetColumnSpan(xtraTabControl1, 4);
			xtraTabControl1.Dock = DockStyle.Fill;
			xtraTabControl1.Location = new Point(11, 10);
			xtraTabControl1.Margin = new Padding(0, 0, 0, 9);
			xtraTabControl1.Name = "xtraTabControl1";
			tablePanel1.SetRow(xtraTabControl1, 0);
			xtraTabControl1.SelectedTabPage = xtraTabPage1;
			xtraTabControl1.Size = new Size(466, 393);
			xtraTabControl1.TabIndex = 0;
			xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage3, xtraTabPage1 });
			// 
			// xtraTabPage1
			// 
			xtraTabPage1.Controls.Add(tablePanel3);
			xtraTabPage1.Margin = new Padding(0);
			xtraTabPage1.Name = "xtraTabPage1";
			xtraTabPage1.Padding = new Padding(9);
			xtraTabPage1.Size = new Size(464, 364);
			xtraTabPage1.Text = "Options";
			// 
			// tablePanel3
			// 
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 200F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F) });
			tablePanel3.Controls.Add(proxyButton);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(9, 9);
			tablePanel3.Margin = new Padding(0);
			tablePanel3.Name = "tablePanel3";
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F) });
			tablePanel3.Size = new Size(446, 346);
			tablePanel3.TabIndex = 0;
			tablePanel3.UseSkinIndents = true;
			// 
			// xtraTabPage3
			// 
			xtraTabPage3.Controls.Add(tablePanel2);
			xtraTabPage3.Margin = new Padding(0);
			xtraTabPage3.Name = "xtraTabPage3";
			xtraTabPage3.Padding = new Padding(9);
			xtraTabPage3.Size = new Size(464, 364);
			xtraTabPage3.Text = "Data grid view color information";
			// 
			// tablePanel2
			// 
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 19F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F) });
			tablePanel2.Controls.Add(panel1);
			tablePanel2.Controls.Add(labelControl10);
			tablePanel2.Controls.Add(panel8);
			tablePanel2.Controls.Add(labelControl3);
			tablePanel2.Controls.Add(panel7);
			tablePanel2.Controls.Add(labelControl9);
			tablePanel2.Controls.Add(panel6);
			tablePanel2.Controls.Add(labelControl8);
			tablePanel2.Controls.Add(panel2);
			tablePanel2.Controls.Add(panel3);
			tablePanel2.Controls.Add(labelControl7);
			tablePanel2.Controls.Add(panel5);
			tablePanel2.Controls.Add(labelControl4);
			tablePanel2.Controls.Add(labelControl6);
			tablePanel2.Controls.Add(labelControl5);
			tablePanel2.Controls.Add(panel4);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(9, 9);
			tablePanel2.Name = "tablePanel2";
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel2.Size = new Size(446, 346);
			tablePanel2.TabIndex = 4;
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			tablePanel2.SetColumn(panel1, 0);
			panel1.Location = new Point(0, 3);
			panel1.Margin = new Padding(0, 3, 3, 3);
			panel1.Name = "panel1";
			tablePanel2.SetRow(panel1, 0);
			panel1.Size = new Size(16, 16);
			panel1.TabIndex = 3;
			// 
			// labelControl10
			// 
			labelControl10.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl10.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl10, 1);
			labelControl10.Location = new Point(22, 164);
			labelControl10.Name = "labelControl10";
			tablePanel2.SetRow(labelControl10, 7);
			labelControl10.Size = new Size(304, 17);
			labelControl10.TabIndex = 2;
			labelControl10.Text = "Foreground color for translation success (plus bold)";
			// 
			// panel8
			// 
			panel8.BorderStyle = BorderStyle.FixedSingle;
			tablePanel2.SetColumn(panel8, 0);
			panel8.Location = new Point(0, 164);
			panel8.Margin = new Padding(0, 3, 3, 3);
			panel8.Name = "panel8";
			tablePanel2.SetRow(panel8, 7);
			panel8.Size = new Size(16, 16);
			panel8.TabIndex = 3;
			// 
			// labelControl3
			// 
			labelControl3.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl3.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl3, 1);
			labelControl3.Location = new Point(22, 3);
			labelControl3.Name = "labelControl3";
			tablePanel2.SetRow(labelControl3, 0);
			labelControl3.Size = new Size(188, 17);
			labelControl3.TabIndex = 2;
			labelControl3.Text = "Foreground color for comments";
			// 
			// panel7
			// 
			panel7.BorderStyle = BorderStyle.FixedSingle;
			tablePanel2.SetColumn(panel7, 0);
			panel7.Location = new Point(0, 141);
			panel7.Margin = new Padding(0, 3, 3, 3);
			panel7.Name = "panel7";
			tablePanel2.SetRow(panel7, 6);
			panel7.Size = new Size(16, 16);
			panel7.TabIndex = 3;
			// 
			// labelControl9
			// 
			labelControl9.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl9.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl9, 1);
			labelControl9.Location = new Point(22, 141);
			labelControl9.Name = "labelControl9";
			tablePanel2.SetRow(labelControl9, 6);
			labelControl9.Size = new Size(296, 17);
			labelControl9.TabIndex = 2;
			labelControl9.Text = "Foreground color for translation errors (plus bold)";
			// 
			// panel6
			// 
			panel6.BorderStyle = BorderStyle.FixedSingle;
			tablePanel2.SetColumn(panel6, 0);
			panel6.Location = new Point(0, 118);
			panel6.Margin = new Padding(0, 3, 3, 3);
			panel6.Name = "panel6";
			tablePanel2.SetRow(panel6, 5);
			panel6.Size = new Size(16, 16);
			panel6.TabIndex = 3;
			// 
			// labelControl8
			// 
			labelControl8.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl8.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl8, 1);
			labelControl8.Location = new Point(22, 118);
			labelControl8.Name = "labelControl8";
			tablePanel2.SetRow(labelControl8, 5);
			labelControl8.Size = new Size(296, 17);
			labelControl8.TabIndex = 2;
			labelControl8.Text = "Foreground color for {0}..{n} placeholder mismatch";
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			tablePanel2.SetColumn(panel2, 0);
			panel2.Location = new Point(0, 26);
			panel2.Margin = new Padding(0, 3, 3, 3);
			panel2.Name = "panel2";
			tablePanel2.SetRow(panel2, 1);
			panel2.Size = new Size(16, 16);
			panel2.TabIndex = 3;
			// 
			// panel3
			// 
			panel3.BorderStyle = BorderStyle.FixedSingle;
			tablePanel2.SetColumn(panel3, 0);
			panel3.Location = new Point(0, 49);
			panel3.Margin = new Padding(0, 3, 3, 3);
			panel3.Name = "panel3";
			tablePanel2.SetRow(panel3, 2);
			panel3.Size = new Size(16, 16);
			panel3.TabIndex = 3;
			// 
			// labelControl7
			// 
			labelControl7.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl7.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl7, 1);
			labelControl7.Location = new Point(22, 95);
			labelControl7.Name = "labelControl7";
			tablePanel2.SetRow(labelControl7, 4);
			labelControl7.Size = new Size(193, 17);
			labelControl7.TabIndex = 2;
			labelControl7.Text = "Background color for empty cells";
			// 
			// panel5
			// 
			panel5.BorderStyle = BorderStyle.FixedSingle;
			tablePanel2.SetColumn(panel5, 0);
			panel5.Location = new Point(0, 95);
			panel5.Margin = new Padding(0, 3, 3, 3);
			panel5.Name = "panel5";
			tablePanel2.SetRow(panel5, 4);
			panel5.Size = new Size(16, 16);
			panel5.TabIndex = 3;
			// 
			// labelControl4
			// 
			labelControl4.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl4.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl4, 1);
			labelControl4.Location = new Point(22, 26);
			labelControl4.Name = "labelControl4";
			tablePanel2.SetRow(labelControl4, 1);
			labelControl4.Size = new Size(257, 17);
			labelControl4.TabIndex = 2;
			labelControl4.Text = "Foreground color for completely empty row";
			// 
			// labelControl6
			// 
			labelControl6.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl6.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl6, 1);
			labelControl6.Location = new Point(22, 72);
			labelControl6.Name = "labelControl6";
			tablePanel2.SetRow(labelControl6, 3);
			labelControl6.Size = new Size(188, 17);
			labelControl6.TabIndex = 2;
			labelControl6.Text = "Background color for NULL cells";
			// 
			// labelControl5
			// 
			labelControl5.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl5.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl5, 1);
			labelControl5.Location = new Point(22, 49);
			labelControl5.Name = "labelControl5";
			tablePanel2.SetRow(labelControl5, 2);
			labelControl5.Size = new Size(153, 17);
			labelControl5.TabIndex = 2;
			labelControl5.Text = "Foreground color for tags";
			// 
			// panel4
			// 
			panel4.BorderStyle = BorderStyle.FixedSingle;
			tablePanel2.SetColumn(panel4, 0);
			panel4.Location = new Point(0, 72);
			panel4.Margin = new Padding(0, 3, 3, 3);
			panel4.Name = "panel4";
			tablePanel2.SetRow(panel4, 3);
			panel4.Size = new Size(16, 16);
			panel4.TabIndex = 3;
			// 
			// OptionsForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(488, 451);
			Controls.Add(tablePanel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(490, 483);
			Name = "OptionsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Options";
			FormClosing += OptionsForm_FormClosing;
			Load += OptionsForm_Load;
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			((ISupportInitialize)xtraTabControl1).EndInit();
			xtraTabControl1.ResumeLayout(false);
			xtraTabPage1.ResumeLayout(false);
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			xtraTabPage3.ResumeLayout(false);
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl xtraTabControl1;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage xtraTabPage1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton proxyButton;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage xtraTabPage3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl8;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl7;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl6;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl5;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl10;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl9;
		private Panel panel8;
		private Panel panel6;
		private Panel panel3;
		private Panel panel7;
		private Panel panel5;
		private Panel panel2;
		private Panel panel4;
		private Panel panel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
	}
}