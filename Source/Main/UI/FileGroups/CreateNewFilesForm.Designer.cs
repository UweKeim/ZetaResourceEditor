namespace ZetaResourceEditor.UI.FileGroups
{
	partial class CreateNewFilesForm
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
			labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			invertFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectNoFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			informationLightUserControl1 = new Helper.InformationLightUserControl();
			selectProjectLanguagesButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectAllFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			destinationLanguagesListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonDefault = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			prefixTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			prefixCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			parentElementTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			referenceLanguageComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			automaticallyTranslateCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			copyTextsCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)AddFileAsDependantUponCheckBox.Properties).BeginInit();
			((ISupportInitialize)IncludeFileInCsprojChecBox.Properties).BeginInit();
			((ISupportInitialize)destinationLanguagesListBox).BeginInit();
			((ISupportInitialize)prefixTextBox.Properties).BeginInit();
			((ISupportInitialize)prefixCheckBox.Properties).BeginInit();
			((ISupportInitialize)parentElementTextBox.Properties).BeginInit();
			((ISupportInitialize)referenceLanguageComboBox.Properties).BeginInit();
			((ISupportInitialize)automaticallyTranslateCheckBox.Properties).BeginInit();
			((ISupportInitialize)copyTextsCheckBox.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)tablePanel5).BeginInit();
			tablePanel5.SuspendLayout();
			((ISupportInitialize)tablePanel4).BeginInit();
			tablePanel4.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			SuspendLayout();
			// 
			// labelCsProjectToAdd
			// 
			labelCsProjectToAdd.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelCsProjectToAdd.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(labelCsProjectToAdd, 1);
			labelCsProjectToAdd.Dock = DockStyle.Left;
			labelCsProjectToAdd.Location = new Point(151, 0);
			labelCsProjectToAdd.Margin = new Padding(0);
			labelCsProjectToAdd.Name = "labelCsProjectToAdd";
			tablePanel5.SetRow(labelCsProjectToAdd, 0);
			labelCsProjectToAdd.Size = new Size(18, 21);
			labelCsProjectToAdd.TabIndex = 1;
			labelCsProjectToAdd.Text = "<>";
			// 
			// AddFileAsDependantUponCheckBox
			// 
			AddFileAsDependantUponCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tablePanel1.SetColumn(AddFileAsDependantUponCheckBox, 1);
			AddFileAsDependantUponCheckBox.Location = new Point(136, 438);
			AddFileAsDependantUponCheckBox.Margin = new Padding(0);
			AddFileAsDependantUponCheckBox.Name = "AddFileAsDependantUponCheckBox";
			AddFileAsDependantUponCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			AddFileAsDependantUponCheckBox.Properties.Appearance.Options.UseFont = true;
			AddFileAsDependantUponCheckBox.Properties.AutoWidth = true;
			AddFileAsDependantUponCheckBox.Properties.Caption = "&Add files as dependantUpon (to main resource file)";
			tablePanel1.SetRow(AddFileAsDependantUponCheckBox, 8);
			AddFileAsDependantUponCheckBox.Size = new Size(322, 21);
			AddFileAsDependantUponCheckBox.TabIndex = 11;
			// 
			// IncludeFileInCsprojChecBox
			// 
			IncludeFileInCsprojChecBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			IncludeFileInCsprojChecBox.AutoSizeInLayoutControl = true;
			tablePanel5.SetColumn(IncludeFileInCsprojChecBox, 0);
			IncludeFileInCsprojChecBox.Location = new Point(0, 0);
			IncludeFileInCsprojChecBox.Margin = new Padding(0, 0, 6, 0);
			IncludeFileInCsprojChecBox.Name = "IncludeFileInCsprojChecBox";
			IncludeFileInCsprojChecBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			IncludeFileInCsprojChecBox.Properties.Appearance.Options.UseFont = true;
			IncludeFileInCsprojChecBox.Properties.AutoWidth = true;
			IncludeFileInCsprojChecBox.Properties.Caption = "&Include files in csproj";
			tablePanel5.SetRow(IncludeFileInCsprojChecBox, 0);
			IncludeFileInCsprojChecBox.Size = new Size(145, 21);
			IncludeFileInCsprojChecBox.TabIndex = 0;
			IncludeFileInCsprojChecBox.CheckedChanged += IncludeFileInCsprojChecBox_CheckedChanged;
			// 
			// buttonSettings
			// 
			buttonSettings.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSettings.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(buttonSettings, 0);
			buttonSettings.Dock = DockStyle.Fill;
			buttonSettings.Location = new Point(0, 0);
			buttonSettings.Margin = new Padding(0, 0, 9, 0);
			buttonSettings.Name = "buttonSettings";
			tablePanel3.SetRow(buttonSettings, 0);
			buttonSettings.Size = new Size(75, 28);
			buttonSettings.TabIndex = 0;
			buttonSettings.Text = "Settings";
			buttonSettings.Click += buttonSettings_Click;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl2.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(labelControl2, 1);
			labelControl2.Dock = DockStyle.Fill;
			labelControl2.Enabled = false;
			labelControl2.Location = new Point(84, 0);
			labelControl2.Margin = new Padding(0);
			labelControl2.Name = "labelControl2";
			tablePanel3.SetRow(labelControl2, 0);
			labelControl2.Size = new Size(288, 28);
			labelControl2.TabIndex = 1;
			labelControl2.Text = "<>";
			// 
			// invertFileGroupsButton
			// 
			invertFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			invertFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(invertFileGroupsButton, 2);
			invertFileGroupsButton.Dock = DockStyle.Fill;
			invertFileGroupsButton.Location = new Point(168, 175);
			invertFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			invertFileGroupsButton.Name = "invertFileGroupsButton";
			tablePanel2.SetRow(invertFileGroupsButton, 1);
			invertFileGroupsButton.Size = new Size(75, 28);
			invertFileGroupsButton.TabIndex = 3;
			invertFileGroupsButton.Text = "Flip";
			invertFileGroupsButton.Click += invertFileGroupsButton_Click;
			// 
			// selectNoFileGroupsButton
			// 
			selectNoFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectNoFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(selectNoFileGroupsButton, 1);
			selectNoFileGroupsButton.Dock = DockStyle.Fill;
			selectNoFileGroupsButton.Location = new Point(84, 175);
			selectNoFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
			tablePanel2.SetRow(selectNoFileGroupsButton, 1);
			selectNoFileGroupsButton.Size = new Size(75, 28);
			selectNoFileGroupsButton.TabIndex = 2;
			selectNoFileGroupsButton.Text = "None";
			selectNoFileGroupsButton.Click += selectNoFileGroupsButton_Click;
			// 
			// informationLightUserControl1
			// 
			informationLightUserControl1.AutoSize = true;
			informationLightUserControl1.BackColor = SystemColors.AppWorkspace;
			tablePanel1.SetColumn(informationLightUserControl1, 0);
			tablePanel1.SetColumnSpan(informationLightUserControl1, 2);
			informationLightUserControl1.DescriptionText = "Create missing language files for all child elements. No duplicates will be created.";
			informationLightUserControl1.Dock = DockStyle.Fill;
			informationLightUserControl1.Location = new Point(11, 10);
			informationLightUserControl1.Margin = new Padding(0, 0, 0, 18);
			informationLightUserControl1.MinimumSize = new Size(167, 28);
			informationLightUserControl1.Name = "informationLightUserControl1";
			informationLightUserControl1.Padding = new Padding(1);
			tablePanel1.SetRow(informationLightUserControl1, 0);
			informationLightUserControl1.Size = new Size(531, 28);
			informationLightUserControl1.TabIndex = 0;
			// 
			// selectProjectLanguagesButton
			// 
			selectProjectLanguagesButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectProjectLanguagesButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(selectProjectLanguagesButton, 3);
			selectProjectLanguagesButton.Dock = DockStyle.Fill;
			selectProjectLanguagesButton.Location = new Point(252, 175);
			selectProjectLanguagesButton.Margin = new Padding(0, 0, 9, 0);
			selectProjectLanguagesButton.Name = "selectProjectLanguagesButton";
			tablePanel2.SetRow(selectProjectLanguagesButton, 1);
			selectProjectLanguagesButton.Size = new Size(75, 28);
			selectProjectLanguagesButton.TabIndex = 4;
			selectProjectLanguagesButton.Text = "Project";
			selectProjectLanguagesButton.Click += selectProjectLanguagesButton_Click;
			// 
			// selectAllFileGroupsButton
			// 
			selectAllFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectAllFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(selectAllFileGroupsButton, 0);
			selectAllFileGroupsButton.Dock = DockStyle.Fill;
			selectAllFileGroupsButton.Location = new Point(0, 175);
			selectAllFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			selectAllFileGroupsButton.Name = "selectAllFileGroupsButton";
			tablePanel2.SetRow(selectAllFileGroupsButton, 1);
			selectAllFileGroupsButton.Size = new Size(75, 28);
			selectAllFileGroupsButton.TabIndex = 1;
			selectAllFileGroupsButton.Text = "All";
			selectAllFileGroupsButton.Click += selectAllFileGroupsButton_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(buttonCancel, 3);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(456, 0);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel3.SetRow(buttonCancel, 0);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 3;
			buttonCancel.Text = "Cancel";
			// 
			// destinationLanguagesListBox
			// 
			destinationLanguagesListBox.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			destinationLanguagesListBox.Appearance.Options.UseFont = true;
			destinationLanguagesListBox.CheckOnClick = true;
			tablePanel2.SetColumn(destinationLanguagesListBox, 0);
			tablePanel2.SetColumnSpan(destinationLanguagesListBox, 5);
			destinationLanguagesListBox.Dock = DockStyle.Fill;
			destinationLanguagesListBox.Location = new Point(0, 0);
			destinationLanguagesListBox.Margin = new Padding(0, 0, 0, 6);
			destinationLanguagesListBox.Name = "destinationLanguagesListBox";
			tablePanel2.SetRow(destinationLanguagesListBox, 0);
			destinationLanguagesListBox.Size = new Size(406, 169);
			destinationLanguagesListBox.TabIndex = 0;
			destinationLanguagesListBox.ItemCheck += destinationLanguagesListBox_ItemCheck;
			destinationLanguagesListBox.SelectedIndexChanged += destinationLanguagesListBox_SelectedIndexChanged;
			// 
			// buttonOK
			// 
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(buttonOK, 2);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Dock = DockStyle.Fill;
			buttonOK.Location = new Point(372, 0);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel3.SetRow(buttonOK, 0);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 2;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
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
			buttonDefault.Size = new Size(60, 26);
			buttonDefault.TabIndex = 2;
			buttonDefault.Text = "Default";
			buttonDefault.Click += buttonDefault_Click;
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label1, 0);
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(11, 59);
			label1.Margin = new Padding(0, 3, 6, 0);
			label1.Name = "label1";
			tablePanel1.SetRow(label1, 1);
			label1.Size = new Size(119, 17);
			label1.TabIndex = 1;
			label1.Text = "Parent element:";
			// 
			// prefixTextBox
			// 
			prefixTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
			// label2
			// 
			label2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label2, 0);
			label2.Dock = DockStyle.Top;
			label2.Location = new Point(11, 89);
			label2.Margin = new Padding(0, 3, 6, 0);
			label2.Name = "label2";
			tablePanel1.SetRow(label2, 2);
			label2.Size = new Size(119, 17);
			label2.TabIndex = 3;
			label2.Text = "&Reference language:";
			// 
			// prefixCheckBox
			// 
			prefixCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl1, 0);
			labelControl1.Dock = DockStyle.Top;
			labelControl1.Location = new Point(11, 119);
			labelControl1.Margin = new Padding(0, 3, 6, 0);
			labelControl1.Name = "labelControl1";
			tablePanel1.SetRow(labelControl1, 3);
			labelControl1.Size = new Size(119, 17);
			labelControl1.TabIndex = 5;
			labelControl1.Text = "&New languages:";
			// 
			// parentElementTextBox
			// 
			parentElementTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(parentElementTextBox, 1);
			parentElementTextBox.CueText = null;
			parentElementTextBox.Location = new Point(136, 56);
			parentElementTextBox.Margin = new Padding(0, 0, 0, 6);
			parentElementTextBox.MaximumSize = new Size(0, 24);
			parentElementTextBox.MinimumSize = new Size(0, 24);
			parentElementTextBox.Name = "parentElementTextBox";
			parentElementTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			parentElementTextBox.Properties.Appearance.Options.UseFont = true;
			parentElementTextBox.Properties.Mask.EditMask = null;
			parentElementTextBox.Properties.NullValuePrompt = null;
			parentElementTextBox.Properties.ReadOnly = true;
			parentElementTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(parentElementTextBox, 1);
			parentElementTextBox.Size = new Size(406, 24);
			parentElementTextBox.TabIndex = 2;
			// 
			// referenceLanguageComboBox
			// 
			referenceLanguageComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(referenceLanguageComboBox, 1);
			referenceLanguageComboBox.CueText = null;
			referenceLanguageComboBox.Location = new Point(136, 86);
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
			tablePanel1.SetRow(referenceLanguageComboBox, 2);
			referenceLanguageComboBox.Size = new Size(406, 24);
			referenceLanguageComboBox.TabIndex = 4;
			referenceLanguageComboBox.SelectedIndexChanged += referenceLanguageComboBox_SelectedIndexChanged;
			// 
			// automaticallyTranslateCheckBox
			// 
			automaticallyTranslateCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tablePanel1.SetColumn(automaticallyTranslateCheckBox, 1);
			automaticallyTranslateCheckBox.Location = new Point(136, 352);
			automaticallyTranslateCheckBox.Margin = new Padding(0, 0, 0, 6);
			automaticallyTranslateCheckBox.Name = "automaticallyTranslateCheckBox";
			automaticallyTranslateCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			automaticallyTranslateCheckBox.Properties.Appearance.Options.UseFont = true;
			automaticallyTranslateCheckBox.Properties.AutoWidth = true;
			automaticallyTranslateCheckBox.Properties.Caption = "&Automatically translate from reference language";
			tablePanel1.SetRow(automaticallyTranslateCheckBox, 5);
			automaticallyTranslateCheckBox.Size = new Size(303, 21);
			automaticallyTranslateCheckBox.TabIndex = 8;
			automaticallyTranslateCheckBox.CheckedChanged += automaticallyTranslateCheckBox_CheckedChanged;
			// 
			// copyTextsCheckBox
			// 
			copyTextsCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tablePanel1.SetColumn(copyTextsCheckBox, 1);
			copyTextsCheckBox.Location = new Point(136, 325);
			copyTextsCheckBox.Margin = new Padding(0, 0, 0, 6);
			copyTextsCheckBox.Name = "copyTextsCheckBox";
			copyTextsCheckBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			copyTextsCheckBox.Properties.Appearance.Options.UseFont = true;
			copyTextsCheckBox.Properties.AutoWidth = true;
			copyTextsCheckBox.Properties.Caption = "&Copy texts from reference language";
			tablePanel1.SetRow(copyTextsCheckBox, 4);
			copyTextsCheckBox.Size = new Size(233, 21);
			copyTextsCheckBox.TabIndex = 7;
			copyTextsCheckBox.CheckedChanged += copyTextsCheckBox_CheckedChanged;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.Controls.Add(tablePanel5);
			tablePanel1.Controls.Add(tablePanel4);
			tablePanel1.Controls.Add(tablePanel3);
			tablePanel1.Controls.Add(informationLightUserControl1);
			tablePanel1.Controls.Add(tablePanel2);
			tablePanel1.Controls.Add(label1);
			tablePanel1.Controls.Add(label2);
			tablePanel1.Controls.Add(AddFileAsDependantUponCheckBox);
			tablePanel1.Controls.Add(labelControl1);
			tablePanel1.Controls.Add(parentElementTextBox);
			tablePanel1.Controls.Add(referenceLanguageComboBox);
			tablePanel1.Controls.Add(copyTextsCheckBox);
			tablePanel1.Controls.Add(automaticallyTranslateCheckBox);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 18F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(553, 516);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// tablePanel5
			// 
			tablePanel5.AutoSize = true;
			tablePanel1.SetColumn(tablePanel5, 1);
			tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel5.Controls.Add(labelCsProjectToAdd);
			tablePanel5.Controls.Add(IncludeFileInCsprojChecBox);
			tablePanel5.Dock = DockStyle.Fill;
			tablePanel5.Location = new Point(136, 411);
			tablePanel5.Margin = new Padding(0, 0, 0, 6);
			tablePanel5.Name = "tablePanel5";
			tablePanel1.SetRow(tablePanel5, 7);
			tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel5.Size = new Size(406, 21);
			tablePanel5.TabIndex = 10;
			// 
			// tablePanel4
			// 
			tablePanel4.AutoSize = true;
			tablePanel1.SetColumn(tablePanel4, 1);
			tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel4.Controls.Add(prefixCheckBox);
			tablePanel4.Controls.Add(prefixTextBox);
			tablePanel4.Controls.Add(buttonDefault);
			tablePanel4.Dock = DockStyle.Fill;
			tablePanel4.Location = new Point(136, 379);
			tablePanel4.Margin = new Padding(0, 0, 0, 6);
			tablePanel4.Name = "tablePanel4";
			tablePanel1.SetRow(tablePanel4, 6);
			tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel4.Size = new Size(406, 26);
			tablePanel4.TabIndex = 9;
			// 
			// tablePanel3
			// 
			tablePanel3.AutoSize = true;
			tablePanel1.SetColumn(tablePanel3, 0);
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.SetColumnSpan(tablePanel3, 2);
			tablePanel3.Controls.Add(buttonCancel);
			tablePanel3.Controls.Add(buttonOK);
			tablePanel3.Controls.Add(labelControl2);
			tablePanel3.Controls.Add(buttonSettings);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(11, 477);
			tablePanel3.Margin = new Padding(0);
			tablePanel3.Name = "tablePanel3";
			tablePanel1.SetRow(tablePanel3, 10);
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel3.Size = new Size(531, 28);
			tablePanel3.TabIndex = 12;
			// 
			// tablePanel2
			// 
			tablePanel1.SetColumn(tablePanel2, 1);
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel2.Controls.Add(destinationLanguagesListBox);
			tablePanel2.Controls.Add(selectAllFileGroupsButton);
			tablePanel2.Controls.Add(selectNoFileGroupsButton);
			tablePanel2.Controls.Add(invertFileGroupsButton);
			tablePanel2.Controls.Add(selectProjectLanguagesButton);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(136, 116);
			tablePanel2.Margin = new Padding(0, 0, 0, 6);
			tablePanel2.Name = "tablePanel2";
			tablePanel1.SetRow(tablePanel2, 3);
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel2.Size = new Size(406, 203);
			tablePanel2.TabIndex = 6;
			// 
			// CreateNewFilesForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(553, 516);
			Controls.Add(tablePanel1);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(555, 548);
			Name = "CreateNewFilesForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Create multiple new files";
			FormClosing += CreateNewFileForm_FormClosing;
			Load += CreateNewFileForm_Load;
			((ISupportInitialize)AddFileAsDependantUponCheckBox.Properties).EndInit();
			((ISupportInitialize)IncludeFileInCsprojChecBox.Properties).EndInit();
			((ISupportInitialize)destinationLanguagesListBox).EndInit();
			((ISupportInitialize)prefixTextBox.Properties).EndInit();
			((ISupportInitialize)prefixCheckBox.Properties).EndInit();
			((ISupportInitialize)parentElementTextBox.Properties).EndInit();
			((ISupportInitialize)referenceLanguageComboBox.Properties).EndInit();
			((ISupportInitialize)automaticallyTranslateCheckBox.Properties).EndInit();
			((ISupportInitialize)copyTextsCheckBox.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			((ISupportInitialize)tablePanel5).EndInit();
			tablePanel5.ResumeLayout(false);
			tablePanel5.PerformLayout();
			((ISupportInitialize)tablePanel4).EndInit();
			tablePanel4.ResumeLayout(false);
			tablePanel4.PerformLayout();
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			tablePanel3.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit referenceLanguageComboBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit automaticallyTranslateCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit copyTextsCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit parentElementTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ZetaResourceEditor.UI.Helper.InformationLightUserControl informationLightUserControl1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonDefault;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit prefixTextBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit prefixCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl destinationLanguagesListBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectProjectLanguagesButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonSettings;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit AddFileAsDependantUponCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit IncludeFileInCsprojChecBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelCsProjectToAdd;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
		private DevExpress.Utils.Layout.TablePanel tablePanel4;
		private DevExpress.Utils.Layout.TablePanel tablePanel5;
	}
}