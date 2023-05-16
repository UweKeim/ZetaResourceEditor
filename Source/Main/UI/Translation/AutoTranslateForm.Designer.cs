namespace ZetaResourceEditor.UI.Translation
{
	partial class AutoTranslateForm
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
			components = new Container();
			updateUITimer = new System.Windows.Forms.Timer(components);
			buttonDefault = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			prefixTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			prefixCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			buttonAll = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonInvert = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonNone = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			languagesToTranslateCheckListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
			referenceLanguageGroupBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			fileGroupTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			label3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			buttonTranslate = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			useOnlyExistingTranslationsCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			useExistingTranslationsCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			buttonSettings = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)prefixTextBox.Properties).BeginInit();
			((ISupportInitialize)prefixCheckBox.Properties).BeginInit();
			((ISupportInitialize)languagesToTranslateCheckListBox).BeginInit();
			((ISupportInitialize)referenceLanguageGroupBox.Properties).BeginInit();
			((ISupportInitialize)fileGroupTextBox.Properties).BeginInit();
			((ISupportInitialize)useOnlyExistingTranslationsCheckEdit.Properties).BeginInit();
			((ISupportInitialize)useExistingTranslationsCheckBox.Properties).BeginInit();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((ISupportInitialize)tablePanel4).BeginInit();
			tablePanel4.SuspendLayout();
			((ISupportInitialize)tablePanel5).BeginInit();
			tablePanel5.SuspendLayout();
			SuspendLayout();
			// 
			// updateUITimer
			// 
			updateUITimer.Tick += updateUITimer_Tick;
			// 
			// buttonDefault
			// 
			buttonDefault.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonDefault.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(buttonDefault, 2);
			buttonDefault.Dock = DockStyle.Fill;
			buttonDefault.Location = new Point(334, 0);
			buttonDefault.Margin = new Padding(0);
			buttonDefault.Name = "buttonDefault";
			tablePanel3.SetRow(buttonDefault, 0);
			buttonDefault.Size = new Size(75, 26);
			buttonDefault.TabIndex = 2;
			buttonDefault.Text = "Default";
			buttonDefault.Click += buttonDefault_Click;
			// 
			// prefixTextBox
			// 
			prefixTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tablePanel3.SetColumn(prefixTextBox, 1);
			prefixTextBox.CueText = null;
			prefixTextBox.Location = new Point(184, 1);
			prefixTextBox.Margin = new Padding(0, 0, 3, 0);
			prefixTextBox.MaximumSize = new Size(0, 24);
			prefixTextBox.MinimumSize = new Size(0, 24);
			prefixTextBox.Name = "prefixTextBox";
			prefixTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			prefixTextBox.Properties.Appearance.Options.UseFont = true;
			prefixTextBox.Properties.Mask.EditMask = null;
			prefixTextBox.Properties.NullValuePrompt = null;
			prefixTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel3.SetRow(prefixTextBox, 0);
			prefixTextBox.Size = new Size(147, 24);
			prefixTextBox.TabIndex = 1;
			prefixTextBox.TextChanged += prefixTextBox_TextChanged;
			// 
			// prefixCheckBox
			// 
			prefixCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tablePanel3.SetColumn(prefixCheckBox, 0);
			prefixCheckBox.Location = new Point(0, 2);
			prefixCheckBox.Margin = new Padding(0, 0, 6, 0);
			prefixCheckBox.Name = "prefixCheckBox";
			prefixCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			prefixCheckBox.Properties.Appearance.Options.UseFont = true;
			prefixCheckBox.Properties.AutoWidth = true;
			prefixCheckBox.Properties.Caption = "Prefix translated texts with:";
			tablePanel3.SetRow(prefixCheckBox, 0);
			prefixCheckBox.Size = new Size(178, 21);
			prefixCheckBox.TabIndex = 0;
			prefixCheckBox.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// buttonAll
			// 
			buttonAll.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonAll.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(buttonAll, 0);
			buttonAll.Dock = DockStyle.Fill;
			buttonAll.Location = new Point(0, 125);
			buttonAll.Margin = new Padding(0, 0, 9, 0);
			buttonAll.Name = "buttonAll";
			tablePanel5.SetRow(buttonAll, 2);
			buttonAll.Size = new Size(75, 28);
			buttonAll.TabIndex = 2;
			buttonAll.Text = "All";
			buttonAll.Click += buttonAll_Click;
			// 
			// buttonInvert
			// 
			buttonInvert.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonInvert.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(buttonInvert, 2);
			buttonInvert.Dock = DockStyle.Fill;
			buttonInvert.Location = new Point(168, 125);
			buttonInvert.Margin = new Padding(0, 0, 9, 0);
			buttonInvert.Name = "buttonInvert";
			tablePanel5.SetRow(buttonInvert, 2);
			buttonInvert.Size = new Size(75, 28);
			buttonInvert.TabIndex = 4;
			buttonInvert.Text = "Flip";
			buttonInvert.Click += buttonInvert_Click;
			// 
			// buttonNone
			// 
			buttonNone.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNone.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(buttonNone, 1);
			buttonNone.Dock = DockStyle.Fill;
			buttonNone.Location = new Point(84, 125);
			buttonNone.Margin = new Padding(0, 0, 9, 0);
			buttonNone.Name = "buttonNone";
			tablePanel5.SetRow(buttonNone, 2);
			buttonNone.Size = new Size(75, 28);
			buttonNone.TabIndex = 3;
			buttonNone.Text = "None";
			buttonNone.Click += buttonNone_Click;
			// 
			// languagesToTranslateCheckListBox
			// 
			languagesToTranslateCheckListBox.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			languagesToTranslateCheckListBox.Appearance.Options.UseFont = true;
			languagesToTranslateCheckListBox.CheckOnClick = true;
			tablePanel5.SetColumn(languagesToTranslateCheckListBox, 0);
			tablePanel5.SetColumnSpan(languagesToTranslateCheckListBox, 4);
			languagesToTranslateCheckListBox.Dock = DockStyle.Fill;
			languagesToTranslateCheckListBox.Location = new Point(0, 20);
			languagesToTranslateCheckListBox.Margin = new Padding(0, 0, 0, 6);
			languagesToTranslateCheckListBox.Name = "languagesToTranslateCheckListBox";
			tablePanel5.SetRow(languagesToTranslateCheckListBox, 1);
			languagesToTranslateCheckListBox.Size = new Size(462, 99);
			languagesToTranslateCheckListBox.TabIndex = 1;
			languagesToTranslateCheckListBox.ItemCheck += languagesToTranslateCheckListBox_ItemCheck;
			languagesToTranslateCheckListBox.SelectedIndexChanged += languagesToTranslateCheckListBox_SelectedIndexChanged;
			// 
			// referenceLanguageGroupBox
			// 
			referenceLanguageGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel2.SetColumn(referenceLanguageGroupBox, 1);
			referenceLanguageGroupBox.CueText = null;
			referenceLanguageGroupBox.Location = new Point(136, 40);
			referenceLanguageGroupBox.Margin = new Padding(0, 0, 0, 6);
			referenceLanguageGroupBox.MinimumSize = new Size(0, 24);
			referenceLanguageGroupBox.Name = "referenceLanguageGroupBox";
			referenceLanguageGroupBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			referenceLanguageGroupBox.Properties.Appearance.Options.UseFont = true;
			referenceLanguageGroupBox.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
			referenceLanguageGroupBox.Properties.DropDownRows = 20;
			referenceLanguageGroupBox.Properties.NullValuePrompt = null;
			referenceLanguageGroupBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			referenceLanguageGroupBox.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			referenceLanguageGroupBox.Properties.SelectedIndexChanged += referenceLanguageGroupBox_SelectedIndexChanged;
			tablePanel2.SetRow(referenceLanguageGroupBox, 1);
			referenceLanguageGroupBox.Size = new Size(337, 24);
			referenceLanguageGroupBox.TabIndex = 3;
			// 
			// fileGroupTextBox
			// 
			fileGroupTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel2.SetColumn(fileGroupTextBox, 1);
			fileGroupTextBox.CueText = null;
			fileGroupTextBox.Location = new Point(136, 10);
			fileGroupTextBox.Margin = new Padding(0, 0, 0, 6);
			fileGroupTextBox.MaximumSize = new Size(0, 24);
			fileGroupTextBox.MinimumSize = new Size(0, 24);
			fileGroupTextBox.Name = "fileGroupTextBox";
			fileGroupTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			fileGroupTextBox.Properties.Appearance.Options.UseFont = true;
			fileGroupTextBox.Properties.Mask.EditMask = null;
			fileGroupTextBox.Properties.NullValuePrompt = null;
			fileGroupTextBox.Properties.ReadOnly = true;
			fileGroupTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(fileGroupTextBox, 0);
			fileGroupTextBox.Size = new Size(337, 24);
			fileGroupTextBox.TabIndex = 1;
			fileGroupTextBox.TextChanged += fileGroupTextBox_TextChanged;
			// 
			// label3
			// 
			label3.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(label3, 0);
			tablePanel5.SetColumnSpan(label3, 4);
			label3.Location = new Point(0, 0);
			label3.Margin = new Padding(0, 0, 0, 3);
			label3.Name = "label3";
			tablePanel5.SetRow(label3, 0);
			label3.Size = new Size(136, 17);
			label3.TabIndex = 0;
			label3.Text = "L&anguages to translate:";
			// 
			// label2
			// 
			label2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(label2, 0);
			label2.Location = new Point(11, 43);
			label2.Margin = new Padding(0, 0, 6, 0);
			label2.Name = "label2";
			tablePanel2.SetRow(label2, 1);
			label2.Size = new Size(119, 17);
			label2.TabIndex = 2;
			label2.Text = "&Reference language:";
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(label1, 0);
			label1.Location = new Point(11, 13);
			label1.Margin = new Padding(0, 0, 6, 0);
			label1.Name = "label1";
			tablePanel2.SetRow(label1, 0);
			label1.Size = new Size(62, 17);
			label1.TabIndex = 0;
			label1.Text = "File group:";
			// 
			// buttonTranslate
			// 
			buttonTranslate.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonTranslate.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(buttonTranslate, 2);
			buttonTranslate.Dock = DockStyle.Fill;
			buttonTranslate.Location = new Point(262, 0);
			buttonTranslate.Margin = new Padding(0, 0, 9, 0);
			buttonTranslate.Name = "buttonTranslate";
			tablePanel4.SetRow(buttonTranslate, 0);
			buttonTranslate.Size = new Size(116, 28);
			buttonTranslate.TabIndex = 2;
			buttonTranslate.Text = "Translate now";
			buttonTranslate.Click += buttonTranslate_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(buttonCancel, 3);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(387, 0);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel4.SetRow(buttonCancel, 0);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 3;
			buttonCancel.Text = "Cancel";
			// 
			// useOnlyExistingTranslationsCheckEdit
			// 
			useOnlyExistingTranslationsCheckEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tablePanel2.SetColumn(useOnlyExistingTranslationsCheckEdit, 0);
			tablePanel2.SetColumnSpan(useOnlyExistingTranslationsCheckEdit, 2);
			useOnlyExistingTranslationsCheckEdit.Location = new Point(11, 291);
			useOnlyExistingTranslationsCheckEdit.Margin = new Padding(0);
			useOnlyExistingTranslationsCheckEdit.Name = "useOnlyExistingTranslationsCheckEdit";
			useOnlyExistingTranslationsCheckEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			useOnlyExistingTranslationsCheckEdit.Properties.Appearance.Options.UseFont = true;
			useOnlyExistingTranslationsCheckEdit.Properties.AutoWidth = true;
			useOnlyExistingTranslationsCheckEdit.Properties.Caption = "Use only existing translations, if available, never call translation service";
			tablePanel2.SetRow(useOnlyExistingTranslationsCheckEdit, 5);
			useOnlyExistingTranslationsCheckEdit.Size = new Size(432, 21);
			useOnlyExistingTranslationsCheckEdit.TabIndex = 7;
			useOnlyExistingTranslationsCheckEdit.CheckedChanged += useOnlyExistingTranslationsCheckEdit_CheckedChanged;
			// 
			// useExistingTranslationsCheckBox
			// 
			useExistingTranslationsCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tablePanel2.SetColumn(useExistingTranslationsCheckBox, 0);
			tablePanel2.SetColumnSpan(useExistingTranslationsCheckBox, 2);
			useExistingTranslationsCheckBox.Location = new Point(11, 264);
			useExistingTranslationsCheckBox.Margin = new Padding(0, 0, 0, 6);
			useExistingTranslationsCheckBox.Name = "useExistingTranslationsCheckBox";
			useExistingTranslationsCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			useExistingTranslationsCheckBox.Properties.Appearance.Options.UseFont = true;
			useExistingTranslationsCheckBox.Properties.AutoWidth = true;
			useExistingTranslationsCheckBox.Properties.Caption = "Use existing translations, if available";
			tablePanel2.SetRow(useExistingTranslationsCheckBox, 4);
			useExistingTranslationsCheckBox.Size = new Size(233, 21);
			useExistingTranslationsCheckBox.TabIndex = 6;
			useExistingTranslationsCheckBox.CheckedChanged += useExistingTranslationsCheckBox_CheckedChanged;
			// 
			// buttonSettings
			// 
			buttonSettings.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSettings.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(buttonSettings, 0);
			buttonSettings.Dock = DockStyle.Fill;
			buttonSettings.Location = new Point(0, 0);
			buttonSettings.Margin = new Padding(0, 0, 9, 0);
			buttonSettings.Name = "buttonSettings";
			tablePanel4.SetRow(buttonSettings, 0);
			buttonSettings.Size = new Size(75, 28);
			buttonSettings.TabIndex = 0;
			buttonSettings.Text = "Settings";
			buttonSettings.Click += buttonSettings_Click;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl1, 1);
			labelControl1.Dock = DockStyle.Left;
			labelControl1.Enabled = false;
			labelControl1.Location = new Point(87, 3);
			labelControl1.Name = "labelControl1";
			tablePanel4.SetRow(labelControl1, 0);
			labelControl1.Size = new Size(18, 22);
			labelControl1.TabIndex = 1;
			labelControl1.Text = "<>";
			// 
			// tablePanel2
			// 
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel2.Controls.Add(tablePanel3);
			tablePanel2.Controls.Add(tablePanel4);
			tablePanel2.Controls.Add(tablePanel5);
			tablePanel2.Controls.Add(useOnlyExistingTranslationsCheckEdit);
			tablePanel2.Controls.Add(label1);
			tablePanel2.Controls.Add(useExistingTranslationsCheckBox);
			tablePanel2.Controls.Add(label2);
			tablePanel2.Controls.Add(fileGroupTextBox);
			tablePanel2.Controls.Add(referenceLanguageGroupBox);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(0, 0);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 18F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel2.Size = new Size(484, 369);
			tablePanel2.TabIndex = 0;
			tablePanel2.UseSkinIndents = true;
			// 
			// tablePanel3
			// 
			tablePanel3.AutoSize = true;
			tablePanel2.SetColumn(tablePanel3, 0);
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel2.SetColumnSpan(tablePanel3, 2);
			tablePanel3.Controls.Add(prefixCheckBox);
			tablePanel3.Controls.Add(prefixTextBox);
			tablePanel3.Controls.Add(buttonDefault);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(11, 232);
			tablePanel3.Margin = new Padding(0, 0, 0, 6);
			tablePanel3.Name = "tablePanel3";
			tablePanel2.SetRow(tablePanel3, 3);
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
			tablePanel3.Size = new Size(462, 26);
			tablePanel3.TabIndex = 5;
			// 
			// tablePanel4
			// 
			tablePanel4.AutoSize = true;
			tablePanel2.SetColumn(tablePanel4, 0);
			tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 125F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel2.SetColumnSpan(tablePanel4, 2);
			tablePanel4.Controls.Add(buttonSettings);
			tablePanel4.Controls.Add(labelControl1);
			tablePanel4.Controls.Add(buttonTranslate);
			tablePanel4.Controls.Add(buttonCancel);
			tablePanel4.Dock = DockStyle.Fill;
			tablePanel4.Location = new Point(11, 330);
			tablePanel4.Margin = new Padding(0);
			tablePanel4.Name = "tablePanel4";
			tablePanel2.SetRow(tablePanel4, 7);
			tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
			tablePanel4.Size = new Size(462, 28);
			tablePanel4.TabIndex = 8;
			// 
			// tablePanel5
			// 
			tablePanel2.SetColumn(tablePanel5, 0);
			tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel2.SetColumnSpan(tablePanel5, 2);
			tablePanel5.Controls.Add(buttonAll);
			tablePanel5.Controls.Add(buttonNone);
			tablePanel5.Controls.Add(buttonInvert);
			tablePanel5.Controls.Add(languagesToTranslateCheckListBox);
			tablePanel5.Controls.Add(label3);
			tablePanel5.Dock = DockStyle.Fill;
			tablePanel5.Location = new Point(11, 70);
			tablePanel5.Margin = new Padding(0, 0, 0, 9);
			tablePanel5.Name = "tablePanel5";
			tablePanel2.SetRow(tablePanel5, 2);
			tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel5.Size = new Size(462, 153);
			tablePanel5.TabIndex = 4;
			// 
			// AutoTranslateForm
			// 
			AcceptButton = buttonTranslate;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(484, 369);
			Controls.Add(tablePanel2);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(486, 401);
			Name = "AutoTranslateForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Automatically translate missing languages";
			FormClosing += autoTranslateForm_FormClosing;
			Load += autoTranslateForm_Load;
			Shown += autoTranslateForm_Shown;
			((ISupportInitialize)prefixTextBox.Properties).EndInit();
			((ISupportInitialize)prefixCheckBox.Properties).EndInit();
			((ISupportInitialize)languagesToTranslateCheckListBox).EndInit();
			((ISupportInitialize)referenceLanguageGroupBox.Properties).EndInit();
			((ISupportInitialize)fileGroupTextBox.Properties).EndInit();
			((ISupportInitialize)useOnlyExistingTranslationsCheckEdit.Properties).EndInit();
			((ISupportInitialize)useExistingTranslationsCheckBox.Properties).EndInit();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			tablePanel3.PerformLayout();
			((ISupportInitialize)tablePanel4).EndInit();
			tablePanel4.ResumeLayout(false);
			tablePanel4.PerformLayout();
			((ISupportInitialize)tablePanel5).EndInit();
			tablePanel5.ResumeLayout(false);
			tablePanel5.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Timer updateUITimer;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonTranslate;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit prefixTextBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit prefixCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonAll;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonInvert;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonNone;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl languagesToTranslateCheckListBox;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit referenceLanguageGroupBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit fileGroupTextBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonDefault;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonSettings;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useExistingTranslationsCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useOnlyExistingTranslationsCheckEdit;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
		private DevExpress.Utils.Layout.TablePanel tablePanel4;
		private DevExpress.Utils.Layout.TablePanel tablePanel5;
	}
}