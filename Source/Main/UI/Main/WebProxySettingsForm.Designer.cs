namespace ZetaResourceEditor.UI.Main
{
	partial class WebProxySettingsForm
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
			panelControl2 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			ProxyPasswordTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			label5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			ProxyDomainNameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			label3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			ProxyUserNameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			ProxyAddressTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			useCustomProxyRadioButton = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			useNoProxyRadioButton = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			useIEProxyRadioButton = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			CmdCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			CmdOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)panelControl2).BeginInit();
			panelControl2.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			((ISupportInitialize)ProxyPasswordTextBox.Properties).BeginInit();
			((ISupportInitialize)ProxyDomainNameTextBox.Properties).BeginInit();
			((ISupportInitialize)ProxyUserNameTextBox.Properties).BeginInit();
			((ISupportInitialize)ProxyAddressTextBox.Properties).BeginInit();
			((ISupportInitialize)useCustomProxyRadioButton.Properties).BeginInit();
			((ISupportInitialize)useNoProxyRadioButton.Properties).BeginInit();
			((ISupportInitialize)useIEProxyRadioButton.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelControl2
			// 
			panelControl2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(panelControl2, 1);
			tablePanel1.SetColumnSpan(panelControl2, 4);
			panelControl2.Controls.Add(tablePanel2);
			panelControl2.Location = new Point(50, 115);
			panelControl2.Margin = new Padding(3, 4, 3, 4);
			panelControl2.Name = "panelControl2";
			panelControl2.Padding = new Padding(10, 12, 10, 12);
			tablePanel1.SetRow(panelControl2, 3);
			panelControl2.Size = new Size(433, 153);
			panelControl2.TabIndex = 3;
			// 
			// tablePanel2
			// 
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F) });
			tablePanel2.Controls.Add(label5);
			tablePanel2.Controls.Add(label3);
			tablePanel2.Controls.Add(label1);
			tablePanel2.Controls.Add(label2);
			tablePanel2.Controls.Add(ProxyAddressTextBox);
			tablePanel2.Controls.Add(ProxyPasswordTextBox);
			tablePanel2.Controls.Add(ProxyUserNameTextBox);
			tablePanel2.Controls.Add(ProxyDomainNameTextBox);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(12, 14);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F) });
			tablePanel2.Size = new Size(409, 125);
			tablePanel2.TabIndex = 0;
			// 
			// ProxyPasswordTextBox
			// 
			ProxyPasswordTextBox.Bold = false;
			tablePanel2.SetColumn(ProxyPasswordTextBox, 1);
			ProxyPasswordTextBox.CueText = null;
			ProxyPasswordTextBox.Location = new Point(132, 96);
			ProxyPasswordTextBox.Margin = new Padding(0, 3, 3, 3);
			ProxyPasswordTextBox.MaximumSize = new Size(0, 24);
			ProxyPasswordTextBox.MinimumSize = new Size(0, 24);
			ProxyPasswordTextBox.Name = "ProxyPasswordTextBox";
			ProxyPasswordTextBox.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			ProxyPasswordTextBox.Properties.Appearance.Options.UseFont = true;
			ProxyPasswordTextBox.Properties.Mask.EditMask = null;
			ProxyPasswordTextBox.Properties.NullValuePrompt = null;
			ProxyPasswordTextBox.Properties.PasswordChar = '●';
			ProxyPasswordTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(ProxyPasswordTextBox, 3);
			ProxyPasswordTextBox.Size = new Size(274, 24);
			ProxyPasswordTextBox.TabIndex = 7;
			// 
			// label5
			// 
			label5.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label5.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(label5, 0);
			label5.Location = new Point(3, 6);
			label5.Margin = new Padding(3, 4, 3, 4);
			label5.Name = "label5";
			tablePanel2.SetRow(label5, 0);
			label5.Size = new Size(126, 17);
			label5.TabIndex = 0;
			label5.Text = "Proxy server &address:";
			// 
			// ProxyDomainNameTextBox
			// 
			ProxyDomainNameTextBox.Bold = false;
			tablePanel2.SetColumn(ProxyDomainNameTextBox, 1);
			ProxyDomainNameTextBox.CueText = null;
			ProxyDomainNameTextBox.Location = new Point(132, 65);
			ProxyDomainNameTextBox.Margin = new Padding(0, 3, 3, 3);
			ProxyDomainNameTextBox.MaximumSize = new Size(0, 24);
			ProxyDomainNameTextBox.MinimumSize = new Size(0, 24);
			ProxyDomainNameTextBox.Name = "ProxyDomainNameTextBox";
			ProxyDomainNameTextBox.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			ProxyDomainNameTextBox.Properties.Appearance.Options.UseFont = true;
			ProxyDomainNameTextBox.Properties.Mask.EditMask = null;
			ProxyDomainNameTextBox.Properties.NullValuePrompt = null;
			ProxyDomainNameTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(ProxyDomainNameTextBox, 2);
			ProxyDomainNameTextBox.Size = new Size(274, 24);
			ProxyDomainNameTextBox.TabIndex = 5;
			// 
			// label3
			// 
			label3.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label3.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(label3, 0);
			label3.Location = new Point(3, 37);
			label3.Margin = new Padding(3, 4, 3, 4);
			label3.Name = "label3";
			tablePanel2.SetRow(label3, 1);
			label3.Size = new Size(66, 17);
			label3.TabIndex = 2;
			label3.Text = "User &name:";
			// 
			// ProxyUserNameTextBox
			// 
			ProxyUserNameTextBox.Bold = false;
			tablePanel2.SetColumn(ProxyUserNameTextBox, 1);
			ProxyUserNameTextBox.CueText = null;
			ProxyUserNameTextBox.Location = new Point(132, 34);
			ProxyUserNameTextBox.Margin = new Padding(0, 3, 3, 3);
			ProxyUserNameTextBox.MaximumSize = new Size(0, 24);
			ProxyUserNameTextBox.MinimumSize = new Size(0, 24);
			ProxyUserNameTextBox.Name = "ProxyUserNameTextBox";
			ProxyUserNameTextBox.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			ProxyUserNameTextBox.Properties.Appearance.Options.UseFont = true;
			ProxyUserNameTextBox.Properties.Mask.EditMask = null;
			ProxyUserNameTextBox.Properties.NullValuePrompt = null;
			ProxyUserNameTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(ProxyUserNameTextBox, 1);
			ProxyUserNameTextBox.Size = new Size(274, 24);
			ProxyUserNameTextBox.TabIndex = 3;
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label1.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(label1, 0);
			label1.Location = new Point(3, 68);
			label1.Margin = new Padding(3, 4, 3, 4);
			label1.Name = "label1";
			tablePanel2.SetRow(label1, 2);
			label1.Size = new Size(84, 17);
			label1.TabIndex = 4;
			label1.Text = "&Domain name:";
			// 
			// ProxyAddressTextBox
			// 
			ProxyAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ProxyAddressTextBox.Bold = false;
			tablePanel2.SetColumn(ProxyAddressTextBox, 1);
			ProxyAddressTextBox.CueText = null;
			ProxyAddressTextBox.Location = new Point(132, 3);
			ProxyAddressTextBox.Margin = new Padding(0, 3, 3, 3);
			ProxyAddressTextBox.MaximumSize = new Size(0, 24);
			ProxyAddressTextBox.MinimumSize = new Size(0, 24);
			ProxyAddressTextBox.Name = "ProxyAddressTextBox";
			ProxyAddressTextBox.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			ProxyAddressTextBox.Properties.Appearance.Options.UseFont = true;
			ProxyAddressTextBox.Properties.Mask.EditMask = null;
			ProxyAddressTextBox.Properties.NullValuePrompt = null;
			ProxyAddressTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(ProxyAddressTextBox, 0);
			ProxyAddressTextBox.Size = new Size(274, 24);
			ProxyAddressTextBox.TabIndex = 1;
			ProxyAddressTextBox.EditValueChanged += ProxyAddressTextBox_EditValueChanged;
			// 
			// label2
			// 
			label2.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label2.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(label2, 0);
			label2.Location = new Point(3, 99);
			label2.Margin = new Padding(3, 4, 3, 4);
			label2.Name = "label2";
			tablePanel2.SetRow(label2, 3);
			label2.Size = new Size(59, 17);
			label2.TabIndex = 6;
			label2.Text = "&Password:";
			// 
			// useCustomProxyRadioButton
			// 
			tablePanel1.SetColumn(useCustomProxyRadioButton, 0);
			tablePanel1.SetColumnSpan(useCustomProxyRadioButton, 5);
			useCustomProxyRadioButton.Location = new Point(16, 84);
			useCustomProxyRadioButton.Margin = new Padding(0, 3, 3, 0);
			useCustomProxyRadioButton.Name = "useCustomProxyRadioButton";
			useCustomProxyRadioButton.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			useCustomProxyRadioButton.Properties.Appearance.Options.UseFont = true;
			useCustomProxyRadioButton.Properties.AutoWidth = true;
			useCustomProxyRadioButton.Properties.Caption = "Use the following &custom HTTP proxy server:";
			useCustomProxyRadioButton.Properties.CheckStyle = CheckStyles.Radio;
			useCustomProxyRadioButton.Properties.RadioGroupIndex = 1;
			tablePanel1.SetRow(useCustomProxyRadioButton, 2);
			useCustomProxyRadioButton.Size = new Size(292, 27);
			useCustomProxyRadioButton.TabIndex = 2;
			useCustomProxyRadioButton.TabStop = false;
			useCustomProxyRadioButton.CheckedChanged += useCustomProxyRadioButton_CheckedChanged;
			// 
			// useNoProxyRadioButton
			// 
			tablePanel1.SetColumn(useNoProxyRadioButton, 0);
			tablePanel1.SetColumnSpan(useNoProxyRadioButton, 5);
			useNoProxyRadioButton.Location = new Point(16, 51);
			useNoProxyRadioButton.Margin = new Padding(0, 3, 3, 3);
			useNoProxyRadioButton.Name = "useNoProxyRadioButton";
			useNoProxyRadioButton.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			useNoProxyRadioButton.Properties.Appearance.Options.UseFont = true;
			useNoProxyRadioButton.Properties.AutoWidth = true;
			useNoProxyRadioButton.Properties.Caption = "Use &no HTTP proxy server";
			useNoProxyRadioButton.Properties.CheckStyle = CheckStyles.Radio;
			useNoProxyRadioButton.Properties.RadioGroupIndex = 1;
			tablePanel1.SetRow(useNoProxyRadioButton, 1);
			useNoProxyRadioButton.Size = new Size(183, 27);
			useNoProxyRadioButton.TabIndex = 1;
			useNoProxyRadioButton.TabStop = false;
			useNoProxyRadioButton.CheckedChanged += useNoProxyRadioButton_CheckedChanged;
			// 
			// useIEProxyRadioButton
			// 
			tablePanel1.SetColumn(useIEProxyRadioButton, 0);
			tablePanel1.SetColumnSpan(useIEProxyRadioButton, 5);
			useIEProxyRadioButton.Location = new Point(16, 18);
			useIEProxyRadioButton.Margin = new Padding(0, 3, 3, 3);
			useIEProxyRadioButton.Name = "useIEProxyRadioButton";
			useIEProxyRadioButton.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			useIEProxyRadioButton.Properties.Appearance.Options.UseFont = true;
			useIEProxyRadioButton.Properties.AutoWidth = true;
			useIEProxyRadioButton.Properties.Caption = "Use the same HTTP proxy as configured in &Internet Explorer";
			useIEProxyRadioButton.Properties.CheckStyle = CheckStyles.Radio;
			useIEProxyRadioButton.Properties.RadioGroupIndex = 1;
			tablePanel1.SetRow(useIEProxyRadioButton, 0);
			useIEProxyRadioButton.Size = new Size(380, 27);
			useIEProxyRadioButton.TabIndex = 0;
			useIEProxyRadioButton.TabStop = false;
			useIEProxyRadioButton.CheckedChanged += useIEProxyRadioButton_CheckedChanged;
			// 
			// CmdCancel
			// 
			CmdCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			CmdCancel.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			CmdCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(CmdCancel, 4);
			CmdCancel.DialogResult = DialogResult.Cancel;
			CmdCancel.Location = new Point(411, 282);
			CmdCancel.Margin = new Padding(0);
			CmdCancel.Name = "CmdCancel";
			tablePanel1.SetRow(CmdCancel, 5);
			CmdCancel.Size = new Size(75, 28);
			CmdCancel.TabIndex = 5;
			CmdCancel.Text = "Cancel";
			CmdCancel.WantDrawFocusRectangle = true;
			// 
			// CmdOK
			// 
			CmdOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			CmdOK.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			CmdOK.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(CmdOK, 2);
			CmdOK.DialogResult = DialogResult.OK;
			CmdOK.Location = new Point(327, 282);
			CmdOK.Margin = new Padding(0);
			CmdOK.Name = "CmdOK";
			tablePanel1.SetRow(CmdOK, 5);
			CmdOK.Size = new Size(75, 28);
			CmdOK.TabIndex = 4;
			CmdOK.Text = "OK";
			CmdOK.WantDrawFocusRectangle = true;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30.9999981F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(CmdOK);
			tablePanel1.Controls.Add(CmdCancel);
			tablePanel1.Controls.Add(panelControl2);
			tablePanel1.Controls.Add(useIEProxyRadioButton);
			tablePanel1.Controls.Add(useCustomProxyRadioButton);
			tablePanel1.Controls.Add(useNoProxyRadioButton);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(502, 326);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// WebProxySettingsForm
			// 
			AcceptButton = CmdOK;
			Appearance.Options.UseFont = true;
			AutoScaleMode = AutoScaleMode.None;
			CancelButton = CmdCancel;
			ClientSize = new Size(502, 326);
			Controls.Add(tablePanel1);
			Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			IconOptions.ShowIcon = false;
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "WebProxySettingsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Configure proxy server";
			Load += WebProxySettingsForm_Load;
			((ISupportInitialize)panelControl2).EndInit();
			panelControl2.ResumeLayout(false);
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			((ISupportInitialize)ProxyPasswordTextBox.Properties).EndInit();
			((ISupportInitialize)ProxyDomainNameTextBox.Properties).EndInit();
			((ISupportInitialize)ProxyUserNameTextBox.Properties).EndInit();
			((ISupportInitialize)ProxyAddressTextBox.Properties).EndInit();
			((ISupportInitialize)useCustomProxyRadioButton.Properties).EndInit();
			((ISupportInitialize)useNoProxyRadioButton.Properties).EndInit();
			((ISupportInitialize)useIEProxyRadioButton.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton CmdOK;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton CmdCancel;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useIEProxyRadioButton;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useCustomProxyRadioButton;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useNoProxyRadioButton;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit ProxyPasswordTextBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit ProxyDomainNameTextBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit ProxyUserNameTextBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit ProxyAddressTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label5;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl2;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
	}
}