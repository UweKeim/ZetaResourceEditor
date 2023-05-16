namespace ZetaResourceEditor.UI.Translation
{
	partial class QuickTranslationForm
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(QuickTranslationForm));
			closeButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			groupControl1 = new ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			destinationTextTextBox = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			buttonCopyToClipboard = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			groupControl2 = new ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl();
			tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
			buttonTranslate = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			copyDestinationTextToClipboardCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			sourceLanguageComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			sourceTextTextBox = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			buttonSwap = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			destinationLanguageComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			labelControl3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			buttonSettings = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)groupControl1).BeginInit();
			groupControl1.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((ISupportInitialize)destinationTextTextBox.Properties).BeginInit();
			((ISupportInitialize)groupControl2).BeginInit();
			groupControl2.SuspendLayout();
			((ISupportInitialize)tablePanel4).BeginInit();
			tablePanel4.SuspendLayout();
			((ISupportInitialize)tablePanel5).BeginInit();
			tablePanel5.SuspendLayout();
			((ISupportInitialize)copyDestinationTextToClipboardCheckBox.Properties).BeginInit();
			((ISupportInitialize)sourceLanguageComboBox.Properties).BeginInit();
			((ISupportInitialize)sourceTextTextBox.Properties).BeginInit();
			((ISupportInitialize)destinationLanguageComboBox.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			SuspendLayout();
			// 
			// closeButton
			// 
			closeButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			closeButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(closeButton, 2);
			closeButton.DialogResult = DialogResult.OK;
			closeButton.Dock = DockStyle.Fill;
			closeButton.Location = new Point(379, 0);
			closeButton.Margin = new Padding(0);
			closeButton.Name = "closeButton";
			tablePanel2.SetRow(closeButton, 0);
			closeButton.Size = new Size(75, 28);
			closeButton.TabIndex = 2;
			closeButton.Text = "Close";
			closeButton.Click += buttonClose_Click;
			// 
			// groupControl1
			// 
			tablePanel1.SetColumn(groupControl1, 0);
			groupControl1.Controls.Add(tablePanel3);
			groupControl1.Dock = DockStyle.Fill;
			groupControl1.Location = new Point(11, 260);
			groupControl1.Margin = new Padding(0, 0, 0, 18);
			groupControl1.Name = "groupControl1";
			tablePanel1.SetRow(groupControl1, 1);
			groupControl1.Size = new Size(454, 169);
			groupControl1.TabIndex = 1;
			groupControl1.Text = "Translated text";
			// 
			// tablePanel3
			// 
			tablePanel3.AutoSize = true;
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 140F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel3.Controls.Add(destinationTextTextBox);
			tablePanel3.Controls.Add(buttonCopyToClipboard);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(2, 23);
			tablePanel3.Name = "tablePanel3";
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel3.Size = new Size(450, 144);
			tablePanel3.TabIndex = 2;
			tablePanel3.UseSkinIndents = true;
			// 
			// destinationTextTextBox
			// 
			tablePanel3.SetColumn(destinationTextTextBox, 0);
			tablePanel3.SetColumnSpan(destinationTextTextBox, 2);
			destinationTextTextBox.CueText = null;
			destinationTextTextBox.Dock = DockStyle.Fill;
			destinationTextTextBox.Location = new Point(11, 10);
			destinationTextTextBox.Margin = new Padding(0, 0, 0, 9);
			destinationTextTextBox.Name = "destinationTextTextBox";
			destinationTextTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			destinationTextTextBox.Properties.Appearance.Options.UseFont = true;
			destinationTextTextBox.Properties.NullValuePrompt = null;
			destinationTextTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel3.SetRow(destinationTextTextBox, 0);
			destinationTextTextBox.Size = new Size(428, 86);
			destinationTextTextBox.TabIndex = 0;
			destinationTextTextBox.TextChanged += destinationTextTextBox_TextChanged;
			destinationTextTextBox.KeyDown += destinationTextTextBox_KeyDown;
			// 
			// buttonCopyToClipboard
			// 
			buttonCopyToClipboard.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCopyToClipboard.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(buttonCopyToClipboard, 0);
			buttonCopyToClipboard.DialogResult = DialogResult.Cancel;
			buttonCopyToClipboard.Dock = DockStyle.Fill;
			buttonCopyToClipboard.Location = new Point(11, 105);
			buttonCopyToClipboard.Margin = new Padding(0);
			buttonCopyToClipboard.Name = "buttonCopyToClipboard";
			tablePanel3.SetRow(buttonCopyToClipboard, 1);
			buttonCopyToClipboard.Size = new Size(140, 28);
			buttonCopyToClipboard.TabIndex = 1;
			buttonCopyToClipboard.Text = "&Copy to clipboard";
			buttonCopyToClipboard.Click += buttonCopyToClipboard_Click;
			// 
			// groupControl2
			// 
			tablePanel1.SetColumn(groupControl2, 0);
			groupControl2.Controls.Add(tablePanel4);
			groupControl2.Dock = DockStyle.Fill;
			groupControl2.Location = new Point(11, 10);
			groupControl2.Margin = new Padding(0, 0, 0, 9);
			groupControl2.Name = "groupControl2";
			tablePanel1.SetRow(groupControl2, 0);
			groupControl2.Size = new Size(454, 241);
			groupControl2.TabIndex = 0;
			groupControl2.Text = "Source";
			// 
			// tablePanel4
			// 
			tablePanel4.AutoSize = true;
			tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel4.Controls.Add(tablePanel5);
			tablePanel4.Controls.Add(labelControl1);
			tablePanel4.Controls.Add(labelControl2);
			tablePanel4.Controls.Add(sourceLanguageComboBox);
			tablePanel4.Controls.Add(sourceTextTextBox);
			tablePanel4.Controls.Add(buttonSwap);
			tablePanel4.Controls.Add(destinationLanguageComboBox);
			tablePanel4.Controls.Add(labelControl3);
			tablePanel4.Dock = DockStyle.Fill;
			tablePanel4.Location = new Point(2, 23);
			tablePanel4.Name = "tablePanel4";
			tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel4.Size = new Size(450, 216);
			tablePanel4.TabIndex = 0;
			tablePanel4.UseSkinIndents = true;
			// 
			// tablePanel5
			// 
			tablePanel5.AutoSize = true;
			tablePanel4.SetColumn(tablePanel5, 0);
			tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel4.SetColumnSpan(tablePanel5, 3);
			tablePanel5.Controls.Add(buttonTranslate);
			tablePanel5.Controls.Add(copyDestinationTextToClipboardCheckBox);
			tablePanel5.Dock = DockStyle.Fill;
			tablePanel5.Location = new Point(11, 177);
			tablePanel5.Margin = new Padding(0);
			tablePanel5.Name = "tablePanel5";
			tablePanel4.SetRow(tablePanel5, 4);
			tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel5.Size = new Size(428, 28);
			tablePanel5.TabIndex = 7;
			// 
			// buttonTranslate
			// 
			buttonTranslate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			buttonTranslate.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonTranslate.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(buttonTranslate, 0);
			buttonTranslate.DialogResult = DialogResult.Cancel;
			buttonTranslate.Location = new Point(0, 0);
			buttonTranslate.Margin = new Padding(0, 0, 9, 0);
			buttonTranslate.Name = "buttonTranslate";
			tablePanel5.SetRow(buttonTranslate, 0);
			buttonTranslate.Size = new Size(75, 28);
			buttonTranslate.TabIndex = 0;
			buttonTranslate.Text = "&Translate";
			buttonTranslate.Click += buttonTranslate_Click;
			// 
			// copyDestinationTextToClipboardCheckBox
			// 
			copyDestinationTextToClipboardCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			tablePanel5.SetColumn(copyDestinationTextToClipboardCheckBox, 1);
			copyDestinationTextToClipboardCheckBox.Location = new Point(84, 3);
			copyDestinationTextToClipboardCheckBox.Margin = new Padding(0);
			copyDestinationTextToClipboardCheckBox.Name = "copyDestinationTextToClipboardCheckBox";
			copyDestinationTextToClipboardCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			copyDestinationTextToClipboardCheckBox.Properties.Appearance.Options.UseFont = true;
			copyDestinationTextToClipboardCheckBox.Properties.AutoWidth = true;
			copyDestinationTextToClipboardCheckBox.Properties.Caption = "Copy translated text to &clipboard";
			copyDestinationTextToClipboardCheckBox.Properties.CheckedChanged += copyDestinationTextToClipboardCheckBox_CheckedChanged;
			tablePanel5.SetRow(copyDestinationTextToClipboardCheckBox, 0);
			copyDestinationTextToClipboardCheckBox.Size = new Size(216, 21);
			copyDestinationTextToClipboardCheckBox.TabIndex = 1;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl1, 0);
			labelControl1.Location = new Point(11, 13);
			labelControl1.Margin = new Padding(0, 0, 6, 0);
			labelControl1.Name = "labelControl1";
			tablePanel4.SetRow(labelControl1, 0);
			labelControl1.Size = new Size(101, 17);
			labelControl1.TabIndex = 0;
			labelControl1.Text = "&Source language:";
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl2.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl2, 0);
			labelControl2.Location = new Point(11, 43);
			labelControl2.Margin = new Padding(0, 0, 6, 0);
			labelControl2.Name = "labelControl2";
			tablePanel4.SetRow(labelControl2, 1);
			labelControl2.Size = new Size(126, 17);
			labelControl2.TabIndex = 3;
			labelControl2.Text = "&Destination language:";
			// 
			// sourceLanguageComboBox
			// 
			sourceLanguageComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel4.SetColumn(sourceLanguageComboBox, 1);
			sourceLanguageComboBox.CueText = null;
			sourceLanguageComboBox.Location = new Point(143, 10);
			sourceLanguageComboBox.Margin = new Padding(0, 0, 6, 6);
			sourceLanguageComboBox.Name = "sourceLanguageComboBox";
			sourceLanguageComboBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			sourceLanguageComboBox.Properties.Appearance.Options.UseFont = true;
			sourceLanguageComboBox.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
			sourceLanguageComboBox.Properties.DropDownRows = 20;
			sourceLanguageComboBox.Properties.NullValuePrompt = null;
			sourceLanguageComboBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			sourceLanguageComboBox.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			tablePanel4.SetRow(sourceLanguageComboBox, 0);
			sourceLanguageComboBox.Size = new Size(262, 24);
			sourceLanguageComboBox.TabIndex = 1;
			sourceLanguageComboBox.SelectedIndexChanged += sourceLanguageComboBox_SelectedIndexChanged;
			// 
			// sourceTextTextBox
			// 
			tablePanel4.SetColumn(sourceTextTextBox, 0);
			tablePanel4.SetColumnSpan(sourceTextTextBox, 3);
			sourceTextTextBox.CueText = null;
			sourceTextTextBox.Dock = DockStyle.Fill;
			sourceTextTextBox.Location = new Point(11, 90);
			sourceTextTextBox.Margin = new Padding(0, 0, 0, 9);
			sourceTextTextBox.Name = "sourceTextTextBox";
			sourceTextTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			sourceTextTextBox.Properties.Appearance.Options.UseFont = true;
			sourceTextTextBox.Properties.NullValuePrompt = null;
			sourceTextTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel4.SetRow(sourceTextTextBox, 3);
			sourceTextTextBox.Size = new Size(428, 78);
			sourceTextTextBox.TabIndex = 6;
			sourceTextTextBox.TextChanged += sourceTextTextBox_TextChanged;
			sourceTextTextBox.KeyDown += sourceTextTextBox_KeyDown;
			// 
			// buttonSwap
			// 
			buttonSwap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonSwap.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSwap.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(buttonSwap, 2);
			buttonSwap.ImageOptions.Image = (Image)resources.GetObject("buttonSwap.ImageOptions.Image");
			buttonSwap.ImageOptions.Location = ImageLocation.MiddleCenter;
			buttonSwap.Location = new Point(411, 27);
			buttonSwap.Margin = new Padding(0);
			buttonSwap.Name = "buttonSwap";
			tablePanel4.SetRow(buttonSwap, 0);
			tablePanel4.SetRowSpan(buttonSwap, 2);
			buttonSwap.Size = new Size(28, 26);
			buttonSwap.TabIndex = 2;
			buttonSwap.Click += buttonSwap_Click;
			// 
			// destinationLanguageComboBox
			// 
			destinationLanguageComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel4.SetColumn(destinationLanguageComboBox, 1);
			destinationLanguageComboBox.CueText = null;
			destinationLanguageComboBox.Location = new Point(143, 40);
			destinationLanguageComboBox.Margin = new Padding(0, 0, 6, 6);
			destinationLanguageComboBox.Name = "destinationLanguageComboBox";
			destinationLanguageComboBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			destinationLanguageComboBox.Properties.Appearance.Options.UseFont = true;
			destinationLanguageComboBox.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
			destinationLanguageComboBox.Properties.DropDownRows = 20;
			destinationLanguageComboBox.Properties.NullValuePrompt = null;
			destinationLanguageComboBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			destinationLanguageComboBox.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			tablePanel4.SetRow(destinationLanguageComboBox, 1);
			destinationLanguageComboBox.Size = new Size(262, 24);
			destinationLanguageComboBox.TabIndex = 4;
			destinationLanguageComboBox.SelectedIndexChanged += destinationLanguageComboBox_SelectedIndexChanged;
			// 
			// labelControl3
			// 
			labelControl3.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl3.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl3, 0);
			tablePanel4.SetColumnSpan(labelControl3, 3);
			labelControl3.Location = new Point(11, 70);
			labelControl3.Margin = new Padding(0, 0, 6, 3);
			labelControl3.Name = "labelControl3";
			tablePanel4.SetRow(labelControl3, 2);
			labelControl3.Size = new Size(68, 17);
			labelControl3.TabIndex = 5;
			labelControl3.Text = "Source te&xt:";
			// 
			// labelControl4
			// 
			labelControl4.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl4.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl4, 1);
			labelControl4.Dock = DockStyle.Left;
			labelControl4.Enabled = false;
			labelControl4.Location = new Point(87, 3);
			labelControl4.Name = "labelControl4";
			tablePanel2.SetRow(labelControl4, 0);
			labelControl4.Size = new Size(18, 22);
			labelControl4.TabIndex = 1;
			labelControl4.Text = "<>";
			// 
			// buttonSettings
			// 
			buttonSettings.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSettings.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(buttonSettings, 0);
			buttonSettings.Dock = DockStyle.Fill;
			buttonSettings.Location = new Point(0, 0);
			buttonSettings.Margin = new Padding(0, 0, 9, 0);
			buttonSettings.Name = "buttonSettings";
			tablePanel2.SetRow(buttonSettings, 0);
			buttonSettings.Size = new Size(75, 28);
			buttonSettings.TabIndex = 0;
			buttonSettings.Text = "Settings";
			buttonSettings.Click += buttonSettings_Click;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.Controls.Add(tablePanel2);
			tablePanel1.Controls.Add(groupControl2);
			tablePanel1.Controls.Add(groupControl1);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(476, 486);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// tablePanel2
			// 
			tablePanel2.AutoSize = true;
			tablePanel1.SetColumn(tablePanel2, 0);
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel2.Controls.Add(labelControl4);
			tablePanel2.Controls.Add(closeButton);
			tablePanel2.Controls.Add(buttonSettings);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(11, 447);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel1.SetRow(tablePanel2, 2);
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel2.Size = new Size(454, 28);
			tablePanel2.TabIndex = 2;
			// 
			// QuickTranslationForm
			// 
			AcceptButton = buttonTranslate;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = closeButton;
			ClientSize = new Size(476, 486);
			Controls.Add(tablePanel1);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(478, 518);
			Name = "QuickTranslationForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Quick translate";
			FormClosing += QuickTranslationForm_FormClosing;
			Load += QuickTranslationForm_Load;
			Shown += QuickTranslationForm_Shown;
			((ISupportInitialize)groupControl1).EndInit();
			groupControl1.ResumeLayout(false);
			groupControl1.PerformLayout();
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			tablePanel3.PerformLayout();
			((ISupportInitialize)destinationTextTextBox.Properties).EndInit();
			((ISupportInitialize)groupControl2).EndInit();
			groupControl2.ResumeLayout(false);
			groupControl2.PerformLayout();
			((ISupportInitialize)tablePanel4).EndInit();
			tablePanel4.ResumeLayout(false);
			tablePanel4.PerformLayout();
			((ISupportInitialize)tablePanel5).EndInit();
			tablePanel5.ResumeLayout(false);
			tablePanel5.PerformLayout();
			((ISupportInitialize)copyDestinationTextToClipboardCheckBox.Properties).EndInit();
			((ISupportInitialize)sourceLanguageComboBox.Properties).EndInit();
			((ISupportInitialize)sourceTextTextBox.Properties).EndInit();
			((ISupportInitialize)destinationLanguageComboBox.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton closeButton;
		private ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl groupControl1;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit destinationTextTextBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCopyToClipboard;
		private ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl groupControl2;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit copyDestinationTextToClipboardCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit sourceTextTextBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonTranslate;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit destinationLanguageComboBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit sourceLanguageComboBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonSettings;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonSwap;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
		private DevExpress.Utils.Layout.TablePanel tablePanel4;
		private DevExpress.Utils.Layout.TablePanel tablePanel5;
	}
}