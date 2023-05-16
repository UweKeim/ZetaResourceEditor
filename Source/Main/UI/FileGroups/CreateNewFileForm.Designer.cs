namespace ZetaResourceEditor.UI.FileGroups
{
	partial class CreateNewFileForm
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
			labelCsProjectToAdd = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			AddFileAsDependantUponCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			IncludeFileInCsprojChecBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			buttonSettings = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			labelControl3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			buttonDefault = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			prefixTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			prefixCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			copyTextsCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			automaticallyTranslateCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			newLanguageComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			referenceLanguageComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			fileGroupTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			newFileNameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)AddFileAsDependantUponCheckBox.Properties).BeginInit();
			((ISupportInitialize)IncludeFileInCsprojChecBox.Properties).BeginInit();
			((ISupportInitialize)prefixTextBox.Properties).BeginInit();
			((ISupportInitialize)prefixCheckBox.Properties).BeginInit();
			((ISupportInitialize)copyTextsCheckBox.Properties).BeginInit();
			((ISupportInitialize)automaticallyTranslateCheckBox.Properties).BeginInit();
			((ISupportInitialize)newLanguageComboBox.Properties).BeginInit();
			((ISupportInitialize)referenceLanguageComboBox.Properties).BeginInit();
			((ISupportInitialize)fileGroupTextBox.Properties).BeginInit();
			((ISupportInitialize)newFileNameTextBox.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((ISupportInitialize)tablePanel4).BeginInit();
			tablePanel4.SuspendLayout();
			SuspendLayout();
			// 
			// labelCsProjectToAdd
			// 
			labelCsProjectToAdd.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelCsProjectToAdd.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(labelCsProjectToAdd, 1);
			labelCsProjectToAdd.Location = new Point(148, 3);
			labelCsProjectToAdd.Name = "labelCsProjectToAdd";
			tablePanel3.SetRow(labelCsProjectToAdd, 0);
			labelCsProjectToAdd.Size = new Size(18, 17);
			labelCsProjectToAdd.TabIndex = 1;
			labelCsProjectToAdd.Text = "<>";
			// 
			// AddFileAsDependantUponCheckBox
			// 
			tablePanel1.SetColumn(AddFileAsDependantUponCheckBox, 1);
			AddFileAsDependantUponCheckBox.Location = new Point(136, 245);
			AddFileAsDependantUponCheckBox.Margin = new Padding(0, 0, 6, 0);
			AddFileAsDependantUponCheckBox.Name = "AddFileAsDependantUponCheckBox";
			AddFileAsDependantUponCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			AddFileAsDependantUponCheckBox.Properties.Appearance.Options.UseFont = true;
			AddFileAsDependantUponCheckBox.Properties.AutoWidth = true;
			AddFileAsDependantUponCheckBox.Properties.Caption = "&Add file as dependantUpon (to main resource file)";
			tablePanel1.SetRow(AddFileAsDependantUponCheckBox, 8);
			AddFileAsDependantUponCheckBox.Size = new Size(316, 21);
			AddFileAsDependantUponCheckBox.TabIndex = 12;
			// 
			// IncludeFileInCsprojChecBox
			// 
			tablePanel3.SetColumn(IncludeFileInCsprojChecBox, 0);
			IncludeFileInCsprojChecBox.Location = new Point(0, 1);
			IncludeFileInCsprojChecBox.Margin = new Padding(0, 0, 6, 0);
			IncludeFileInCsprojChecBox.Name = "IncludeFileInCsprojChecBox";
			IncludeFileInCsprojChecBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			IncludeFileInCsprojChecBox.Properties.Appearance.Options.UseFont = true;
			IncludeFileInCsprojChecBox.Properties.AutoWidth = true;
			IncludeFileInCsprojChecBox.Properties.Caption = "&Include file in csproj";
			tablePanel3.SetRow(IncludeFileInCsprojChecBox, 0);
			IncludeFileInCsprojChecBox.Size = new Size(139, 21);
			IncludeFileInCsprojChecBox.TabIndex = 0;
			IncludeFileInCsprojChecBox.CheckedChanged += IncludeFileInCsprojChecBox_CheckedChanged;
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
			// labelControl3
			// 
			labelControl3.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl3.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl3, 1);
			labelControl3.Dock = DockStyle.Fill;
			labelControl3.Enabled = false;
			labelControl3.Location = new Point(87, 3);
			labelControl3.Name = "labelControl3";
			tablePanel2.SetRow(labelControl3, 0);
			labelControl3.Size = new Size(295, 22);
			labelControl3.TabIndex = 1;
			labelControl3.Text = "<>";
			// 
			// buttonDefault
			// 
			buttonDefault.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonDefault.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(buttonDefault, 2);
			buttonDefault.Dock = DockStyle.Fill;
			buttonDefault.Location = new Point(334, 0);
			buttonDefault.Margin = new Padding(0);
			buttonDefault.Name = "buttonDefault";
			tablePanel4.SetRow(buttonDefault, 0);
			buttonDefault.Size = new Size(75, 26);
			buttonDefault.TabIndex = 2;
			buttonDefault.Text = "Default";
			buttonDefault.Click += buttonDefault_Click;
			// 
			// prefixTextBox
			// 
			tablePanel4.SetColumn(prefixTextBox, 1);
			prefixTextBox.CueText = null;
			prefixTextBox.Location = new Point(184, 1);
			prefixTextBox.Margin = new Padding(0, 0, 6, 0);
			prefixTextBox.MaximumSize = new Size(0, 24);
			prefixTextBox.MinimumSize = new Size(0, 24);
			prefixTextBox.Name = "prefixTextBox";
			prefixTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			prefixTextBox.Properties.Appearance.Options.UseFont = true;
			prefixTextBox.Properties.Mask.EditMask = null;
			prefixTextBox.Properties.NullValuePrompt = null;
			prefixTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel4.SetRow(prefixTextBox, 0);
			prefixTextBox.Size = new Size(144, 24);
			prefixTextBox.TabIndex = 1;
			prefixTextBox.EditValueChanged += prefixTextBox_EditValueChanged;
			// 
			// prefixCheckBox
			// 
			tablePanel4.SetColumn(prefixCheckBox, 0);
			prefixCheckBox.Location = new Point(0, 2);
			prefixCheckBox.Margin = new Padding(0, 0, 6, 0);
			prefixCheckBox.Name = "prefixCheckBox";
			prefixCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			prefixCheckBox.Properties.Appearance.Options.UseFont = true;
			prefixCheckBox.Properties.AutoWidth = true;
			prefixCheckBox.Properties.Caption = "Prefix translated texts with:";
			tablePanel4.SetRow(prefixCheckBox, 0);
			prefixCheckBox.Size = new Size(178, 21);
			prefixCheckBox.TabIndex = 0;
			prefixCheckBox.CheckedChanged += prefixCheckBox_CheckedChanged;
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(buttonCancel, 3);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(469, 0);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel2.SetRow(buttonCancel, 0);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 3;
			buttonCancel.Text = "Cancel";
			// 
			// copyTextsCheckBox
			// 
			tablePanel1.SetColumn(copyTextsCheckBox, 1);
			copyTextsCheckBox.Location = new Point(136, 130);
			copyTextsCheckBox.Margin = new Padding(0, 0, 6, 6);
			copyTextsCheckBox.Name = "copyTextsCheckBox";
			copyTextsCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			copyTextsCheckBox.Properties.Appearance.Options.UseFont = true;
			copyTextsCheckBox.Properties.AutoWidth = true;
			copyTextsCheckBox.Properties.Caption = "&Copy texts from reference language";
			tablePanel1.SetRow(copyTextsCheckBox, 4);
			copyTextsCheckBox.Size = new Size(233, 21);
			copyTextsCheckBox.TabIndex = 8;
			copyTextsCheckBox.CheckedChanged += copyTextsCheckBox_CheckedChanged;
			// 
			// buttonOK
			// 
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(buttonOK, 2);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Dock = DockStyle.Fill;
			buttonOK.Location = new Point(385, 0);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel2.SetRow(buttonOK, 0);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 2;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
			// 
			// automaticallyTranslateCheckBox
			// 
			tablePanel1.SetColumn(automaticallyTranslateCheckBox, 1);
			automaticallyTranslateCheckBox.Location = new Point(136, 157);
			automaticallyTranslateCheckBox.Margin = new Padding(0, 0, 6, 6);
			automaticallyTranslateCheckBox.Name = "automaticallyTranslateCheckBox";
			automaticallyTranslateCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			automaticallyTranslateCheckBox.Properties.Appearance.Options.UseFont = true;
			automaticallyTranslateCheckBox.Properties.AutoWidth = true;
			automaticallyTranslateCheckBox.Properties.Caption = "&Automatically translate from reference language";
			tablePanel1.SetRow(automaticallyTranslateCheckBox, 5);
			automaticallyTranslateCheckBox.Size = new Size(303, 21);
			automaticallyTranslateCheckBox.TabIndex = 9;
			automaticallyTranslateCheckBox.CheckedChanged += automaticallyTranslateCheckBox_CheckedChanged;
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label1, 0);
			label1.Location = new Point(11, 13);
			label1.Margin = new Padding(0, 0, 6, 0);
			label1.Name = "label1";
			tablePanel1.SetRow(label1, 0);
			label1.Size = new Size(62, 17);
			label1.TabIndex = 0;
			label1.Text = "File group:";
			// 
			// newLanguageComboBox
			// 
			newLanguageComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(newLanguageComboBox, 1);
			newLanguageComboBox.CueText = null;
			newLanguageComboBox.Location = new Point(136, 70);
			newLanguageComboBox.Margin = new Padding(0, 0, 0, 6);
			newLanguageComboBox.Name = "newLanguageComboBox";
			newLanguageComboBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			newLanguageComboBox.Properties.Appearance.Options.UseFont = true;
			newLanguageComboBox.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
			newLanguageComboBox.Properties.DropDownRows = 20;
			newLanguageComboBox.Properties.NullValuePrompt = null;
			newLanguageComboBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			newLanguageComboBox.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			newLanguageComboBox.Properties.SelectedIndexChanged += referenceLanguageGroupBox_SelectedIndexChanged;
			tablePanel1.SetRow(newLanguageComboBox, 2);
			newLanguageComboBox.Size = new Size(419, 24);
			newLanguageComboBox.TabIndex = 5;
			newLanguageComboBox.SelectedIndexChanged += newLanguageComboBox_SelectedIndexChanged;
			newLanguageComboBox.TextChanged += newLanguageComboBox_TextChanged;
			// 
			// label2
			// 
			label2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label2, 0);
			label2.Location = new Point(11, 43);
			label2.Margin = new Padding(0, 0, 6, 0);
			label2.Name = "label2";
			tablePanel1.SetRow(label2, 1);
			label2.Size = new Size(119, 17);
			label2.TabIndex = 2;
			label2.Text = "&Reference language:";
			// 
			// referenceLanguageComboBox
			// 
			referenceLanguageComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(referenceLanguageComboBox, 1);
			referenceLanguageComboBox.CueText = null;
			referenceLanguageComboBox.Location = new Point(136, 40);
			referenceLanguageComboBox.Margin = new Padding(0, 0, 0, 6);
			referenceLanguageComboBox.Name = "referenceLanguageComboBox";
			referenceLanguageComboBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			referenceLanguageComboBox.Properties.Appearance.Options.UseFont = true;
			referenceLanguageComboBox.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
			referenceLanguageComboBox.Properties.DropDownRows = 20;
			referenceLanguageComboBox.Properties.NullValuePrompt = null;
			referenceLanguageComboBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			referenceLanguageComboBox.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			referenceLanguageComboBox.Properties.SelectedIndexChanged += referenceLanguageGroupBox_SelectedIndexChanged;
			tablePanel1.SetRow(referenceLanguageComboBox, 1);
			referenceLanguageComboBox.Size = new Size(419, 24);
			referenceLanguageComboBox.TabIndex = 3;
			referenceLanguageComboBox.SelectedIndexChanged += referenceLanguageComboBox_SelectedIndexChanged;
			// 
			// fileGroupTextBox
			// 
			fileGroupTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(fileGroupTextBox, 1);
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
			tablePanel1.SetRow(fileGroupTextBox, 0);
			fileGroupTextBox.Size = new Size(419, 24);
			fileGroupTextBox.TabIndex = 1;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl2.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl2, 0);
			labelControl2.Location = new Point(11, 103);
			labelControl2.Margin = new Padding(0, 0, 6, 0);
			labelControl2.Name = "labelControl2";
			tablePanel1.SetRow(labelControl2, 3);
			labelControl2.Size = new Size(86, 17);
			labelControl2.TabIndex = 6;
			labelControl2.Text = "New file name:";
			// 
			// newFileNameTextBox
			// 
			newFileNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(newFileNameTextBox, 1);
			newFileNameTextBox.CueText = null;
			newFileNameTextBox.Location = new Point(136, 100);
			newFileNameTextBox.Margin = new Padding(0, 0, 0, 6);
			newFileNameTextBox.MaximumSize = new Size(0, 24);
			newFileNameTextBox.MinimumSize = new Size(0, 24);
			newFileNameTextBox.Name = "newFileNameTextBox";
			newFileNameTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			newFileNameTextBox.Properties.Appearance.Options.UseFont = true;
			newFileNameTextBox.Properties.Mask.EditMask = null;
			newFileNameTextBox.Properties.NullValuePrompt = null;
			newFileNameTextBox.Properties.ReadOnly = true;
			newFileNameTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(newFileNameTextBox, 3);
			newFileNameTextBox.Size = new Size(419, 24);
			newFileNameTextBox.TabIndex = 7;
			newFileNameTextBox.TextChanged += newFileNameTextBox_TextChanged;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl1, 0);
			labelControl1.Location = new Point(11, 73);
			labelControl1.Margin = new Padding(0, 0, 6, 0);
			labelControl1.Name = "labelControl1";
			tablePanel1.SetRow(labelControl1, 2);
			labelControl1.Size = new Size(87, 17);
			labelControl1.TabIndex = 4;
			labelControl1.Text = "&New language:";
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.Controls.Add(tablePanel2);
			tablePanel1.Controls.Add(tablePanel3);
			tablePanel1.Controls.Add(tablePanel4);
			tablePanel1.Controls.Add(label1);
			tablePanel1.Controls.Add(fileGroupTextBox);
			tablePanel1.Controls.Add(label2);
			tablePanel1.Controls.Add(AddFileAsDependantUponCheckBox);
			tablePanel1.Controls.Add(referenceLanguageComboBox);
			tablePanel1.Controls.Add(labelControl1);
			tablePanel1.Controls.Add(newLanguageComboBox);
			tablePanel1.Controls.Add(automaticallyTranslateCheckBox);
			tablePanel1.Controls.Add(copyTextsCheckBox);
			tablePanel1.Controls.Add(labelControl2);
			tablePanel1.Controls.Add(newFileNameTextBox);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(566, 331);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// tablePanel2
			// 
			tablePanel1.SetColumn(tablePanel2, 0);
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.SetColumnSpan(tablePanel2, 2);
			tablePanel2.Controls.Add(buttonSettings);
			tablePanel2.Controls.Add(buttonOK);
			tablePanel2.Controls.Add(buttonCancel);
			tablePanel2.Controls.Add(labelControl3);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(11, 292);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel1.SetRow(tablePanel2, 10);
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel2.Size = new Size(544, 28);
			tablePanel2.TabIndex = 1;
			// 
			// tablePanel3
			// 
			tablePanel3.AutoSize = true;
			tablePanel1.SetColumn(tablePanel3, 1);
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F) });
			tablePanel3.Controls.Add(IncludeFileInCsprojChecBox);
			tablePanel3.Controls.Add(labelCsProjectToAdd);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(136, 216);
			tablePanel3.Margin = new Padding(0, 0, 0, 6);
			tablePanel3.Name = "tablePanel3";
			tablePanel1.SetRow(tablePanel3, 7);
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel3.Size = new Size(419, 23);
			tablePanel3.TabIndex = 11;
			// 
			// tablePanel4
			// 
			tablePanel4.AutoSize = true;
			tablePanel1.SetColumn(tablePanel4, 1);
			tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel4.Controls.Add(prefixCheckBox);
			tablePanel4.Controls.Add(prefixTextBox);
			tablePanel4.Controls.Add(buttonDefault);
			tablePanel4.Dock = DockStyle.Fill;
			tablePanel4.Location = new Point(136, 184);
			tablePanel4.Margin = new Padding(0, 0, 0, 6);
			tablePanel4.Name = "tablePanel4";
			tablePanel1.SetRow(tablePanel4, 6);
			tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel4.Size = new Size(419, 26);
			tablePanel4.TabIndex = 10;
			// 
			// CreateNewFileForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(566, 331);
			Controls.Add(tablePanel1);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MaximumSize = new Size(1024, 363);
			MinimizeBox = false;
			MinimumSize = new Size(568, 363);
			Name = "CreateNewFileForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Create new files for language";
			FormClosing += CreateNewFileForm_FormClosing;
			Load += CreateNewFileForm_Load;
			((ISupportInitialize)AddFileAsDependantUponCheckBox.Properties).EndInit();
			((ISupportInitialize)IncludeFileInCsprojChecBox.Properties).EndInit();
			((ISupportInitialize)prefixTextBox.Properties).EndInit();
			((ISupportInitialize)prefixCheckBox.Properties).EndInit();
			((ISupportInitialize)copyTextsCheckBox.Properties).EndInit();
			((ISupportInitialize)automaticallyTranslateCheckBox.Properties).EndInit();
			((ISupportInitialize)newLanguageComboBox.Properties).EndInit();
			((ISupportInitialize)referenceLanguageComboBox.Properties).EndInit();
			((ISupportInitialize)fileGroupTextBox.Properties).EndInit();
			((ISupportInitialize)newFileNameTextBox.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			tablePanel3.PerformLayout();
			((ISupportInitialize)tablePanel4).EndInit();
			tablePanel4.ResumeLayout(false);
			tablePanel4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit referenceLanguageComboBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit fileGroupTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit newLanguageComboBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit newFileNameTextBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit automaticallyTranslateCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit copyTextsCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonDefault;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit prefixTextBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit prefixCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonSettings;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl3;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit AddFileAsDependantUponCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit IncludeFileInCsprojChecBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelCsProjectToAdd;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
		private DevExpress.Utils.Layout.TablePanel tablePanel4;
	}
}