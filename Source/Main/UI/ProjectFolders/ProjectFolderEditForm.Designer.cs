namespace ZetaResourceEditor.UI.ProjectFolders
{
	partial class ProjectFolderEditForm
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(ProjectFolderEditForm));
			xtraTabControl1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl();
			xtraTabPage1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			ignoreChildsDuringExportAndImportCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			parentTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			nameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			xtraTabPage2 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
			pictureBox7 = new PictureBox();
			pictureBox6 = new PictureBox();
			pictureBox8 = new PictureBox();
			neutralLanguageFileNamePatternTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			labelControl6 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			nonNeutralLanguageFileNamePatternTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			labelControl9 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			defaultTypesTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			labelControl10 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl8 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			baseNameDotCountSpinEdit = new ExtendedControlsLibrary.Skinning.CustomSpinEdit.MySpinEdit();
			useParentElementsFilePatternSettingsCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			useTheFollowingFilePatternSettingsCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			defaultToolTipController1 = new DefaultToolTipController(components);
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)xtraTabControl1).BeginInit();
			xtraTabControl1.SuspendLayout();
			xtraTabPage1.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			((ISupportInitialize)ignoreChildsDuringExportAndImportCheckEdit.Properties).BeginInit();
			((ISupportInitialize)parentTextBox.Properties).BeginInit();
			((ISupportInitialize)nameTextBox.Properties).BeginInit();
			xtraTabPage2.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((ISupportInitialize)tablePanel4).BeginInit();
			tablePanel4.SuspendLayout();
			((ISupportInitialize)pictureBox7).BeginInit();
			((ISupportInitialize)pictureBox6).BeginInit();
			((ISupportInitialize)pictureBox8).BeginInit();
			((ISupportInitialize)neutralLanguageFileNamePatternTextEdit.Properties).BeginInit();
			((ISupportInitialize)nonNeutralLanguageFileNamePatternTextEdit.Properties).BeginInit();
			((ISupportInitialize)defaultTypesTextEdit.Properties).BeginInit();
			((ISupportInitialize)baseNameDotCountSpinEdit.Properties).BeginInit();
			((ISupportInitialize)useParentElementsFilePatternSettingsCheckEdit.Properties).BeginInit();
			((ISupportInitialize)useTheFollowingFilePatternSettingsCheckEdit.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// xtraTabControl1
			// 
			xtraTabControl1.AppearancePage.Header.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
			tablePanel1.SetColumn(xtraTabControl1, 0);
			tablePanel1.SetColumnSpan(xtraTabControl1, 3);
			xtraTabControl1.Dock = DockStyle.Fill;
			xtraTabControl1.Location = new Point(11, 10);
			xtraTabControl1.Margin = new Padding(0, 0, 0, 9);
			xtraTabControl1.Name = "xtraTabControl1";
			tablePanel1.SetRow(xtraTabControl1, 0);
			xtraTabControl1.SelectedTabPage = xtraTabPage1;
			xtraTabControl1.Size = new Size(444, 395);
			xtraTabControl1.TabIndex = 0;
			xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
			// 
			// xtraTabPage1
			// 
			xtraTabPage1.Controls.Add(tablePanel2);
			xtraTabPage1.Margin = new Padding(0);
			xtraTabPage1.Name = "xtraTabPage1";
			xtraTabPage1.Padding = new Padding(9);
			xtraTabPage1.Size = new Size(442, 366);
			xtraTabPage1.Text = "Settings";
			// 
			// tablePanel2
			// 
			defaultToolTipController1.SetAllowHtmlText(tablePanel2, DefaultBoolean.Default);
			tablePanel2.AutoSize = true;
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel2.Controls.Add(label1);
			tablePanel2.Controls.Add(label2);
			tablePanel2.Controls.Add(ignoreChildsDuringExportAndImportCheckEdit);
			tablePanel2.Controls.Add(parentTextBox);
			tablePanel2.Controls.Add(nameTextBox);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(9, 9);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel2.Size = new Size(424, 348);
			tablePanel2.TabIndex = 2;
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(label1, 0);
			label1.Location = new Point(0, 3);
			label1.Margin = new Padding(0, 0, 6, 0);
			label1.Name = "label1";
			tablePanel2.SetRow(label1, 0);
			label1.Size = new Size(40, 17);
			label1.TabIndex = 0;
			label1.Text = "Parent:";
			// 
			// label2
			// 
			label2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(label2, 0);
			label2.Location = new Point(0, 36);
			label2.Margin = new Padding(0, 0, 6, 0);
			label2.Name = "label2";
			tablePanel2.SetRow(label2, 1);
			label2.Size = new Size(38, 17);
			label2.TabIndex = 2;
			label2.Text = "&Name:";
			label2.Click += label2_Click;
			// 
			// ignoreChildsDuringExportAndImportCheckEdit
			// 
			tablePanel2.SetColumn(ignoreChildsDuringExportAndImportCheckEdit, 1);
			ignoreChildsDuringExportAndImportCheckEdit.Location = new Point(46, 66);
			ignoreChildsDuringExportAndImportCheckEdit.Margin = new Padding(0);
			ignoreChildsDuringExportAndImportCheckEdit.Name = "ignoreChildsDuringExportAndImportCheckEdit";
			ignoreChildsDuringExportAndImportCheckEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			ignoreChildsDuringExportAndImportCheckEdit.Properties.Appearance.Options.UseFont = true;
			ignoreChildsDuringExportAndImportCheckEdit.Properties.AutoWidth = true;
			ignoreChildsDuringExportAndImportCheckEdit.Properties.Caption = "Ignore child elements during export and import";
			tablePanel2.SetRow(ignoreChildsDuringExportAndImportCheckEdit, 2);
			ignoreChildsDuringExportAndImportCheckEdit.Size = new Size(301, 21);
			ignoreChildsDuringExportAndImportCheckEdit.TabIndex = 4;
			// 
			// parentTextBox
			// 
			tablePanel2.SetColumn(parentTextBox, 1);
			parentTextBox.CueText = null;
			parentTextBox.Dock = DockStyle.Fill;
			parentTextBox.Location = new Point(46, 0);
			parentTextBox.Margin = new Padding(0, 0, 0, 9);
			parentTextBox.MaximumSize = new Size(0, 24);
			parentTextBox.MinimumSize = new Size(0, 24);
			parentTextBox.Name = "parentTextBox";
			parentTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			parentTextBox.Properties.Appearance.Options.UseFont = true;
			parentTextBox.Properties.NullValuePrompt = null;
			parentTextBox.Properties.ReadOnly = true;
			parentTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(parentTextBox, 0);
			parentTextBox.Size = new Size(378, 24);
			parentTextBox.TabIndex = 1;
			// 
			// nameTextBox
			// 
			tablePanel2.SetColumn(nameTextBox, 1);
			nameTextBox.CueText = null;
			nameTextBox.Dock = DockStyle.Fill;
			nameTextBox.Location = new Point(46, 33);
			nameTextBox.Margin = new Padding(0, 0, 0, 9);
			nameTextBox.MaximumSize = new Size(0, 24);
			nameTextBox.MinimumSize = new Size(0, 24);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			nameTextBox.Properties.Appearance.Options.UseFont = true;
			nameTextBox.Properties.NullValuePrompt = null;
			nameTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(nameTextBox, 1);
			nameTextBox.Size = new Size(378, 24);
			nameTextBox.TabIndex = 3;
			nameTextBox.EditValueChanged += nameTextBox_EditValueChanged;
			// 
			// xtraTabPage2
			// 
			xtraTabPage2.Controls.Add(tablePanel3);
			xtraTabPage2.Name = "xtraTabPage2";
			xtraTabPage2.Padding = new Padding(9);
			xtraTabPage2.Size = new Size(442, 366);
			xtraTabPage2.Text = "File name pattern";
			// 
			// tablePanel3
			// 
			defaultToolTipController1.SetAllowHtmlText(tablePanel3, DefaultBoolean.Default);
			tablePanel3.AutoSize = true;
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel3.Controls.Add(tablePanel4);
			tablePanel3.Controls.Add(useParentElementsFilePatternSettingsCheckEdit);
			tablePanel3.Controls.Add(useTheFollowingFilePatternSettingsCheckEdit);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(9, 9);
			tablePanel3.Margin = new Padding(0);
			tablePanel3.Name = "tablePanel3";
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel3.Size = new Size(424, 348);
			tablePanel3.TabIndex = 2;
			// 
			// tablePanel4
			// 
			defaultToolTipController1.SetAllowHtmlText(tablePanel4, DefaultBoolean.Default);
			tablePanel4.AutoSize = true;
			tablePanel3.SetColumn(tablePanel4, 0);
			tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 16F) });
			tablePanel4.Controls.Add(pictureBox7);
			tablePanel4.Controls.Add(pictureBox6);
			tablePanel4.Controls.Add(pictureBox8);
			tablePanel4.Controls.Add(neutralLanguageFileNamePatternTextEdit);
			tablePanel4.Controls.Add(labelControl6);
			tablePanel4.Controls.Add(nonNeutralLanguageFileNamePatternTextEdit);
			tablePanel4.Controls.Add(labelControl9);
			tablePanel4.Controls.Add(defaultTypesTextEdit);
			tablePanel4.Controls.Add(labelControl10);
			tablePanel4.Controls.Add(labelControl8);
			tablePanel4.Controls.Add(labelControl5);
			tablePanel4.Controls.Add(baseNameDotCountSpinEdit);
			tablePanel4.Dock = DockStyle.Fill;
			tablePanel4.Location = new Point(18, 57);
			tablePanel4.Margin = new Padding(18, 0, 0, 0);
			tablePanel4.Name = "tablePanel4";
			tablePanel3.SetRow(tablePanel4, 2);
			tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel4.Size = new Size(406, 192);
			tablePanel4.TabIndex = 2;
			// 
			// pictureBox7
			// 
			defaultToolTipController1.SetAllowHtmlText(pictureBox7, DefaultBoolean.Default);
			tablePanel4.SetColumn(pictureBox7, 3);
			pictureBox7.Cursor = Cursors.Help;
			pictureBox7.Dock = DockStyle.Top;
			pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
			pictureBox7.ImeMode = ImeMode.NoControl;
			pictureBox7.Location = new Point(390, 24);
			pictureBox7.Margin = new Padding(0, 4, 0, 0);
			pictureBox7.Name = "pictureBox7";
			tablePanel4.SetRow(pictureBox7, 1);
			pictureBox7.Size = new Size(16, 16);
			pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox7.TabIndex = 9;
			pictureBox7.TabStop = false;
			// 
			// pictureBox6
			// 
			defaultToolTipController1.SetAllowHtmlText(pictureBox6, DefaultBoolean.Default);
			tablePanel4.SetColumn(pictureBox6, 3);
			pictureBox6.Cursor = Cursors.Help;
			pictureBox6.Dock = DockStyle.Top;
			pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.ImeMode = ImeMode.NoControl;
			pictureBox6.Location = new Point(390, 77);
			pictureBox6.Margin = new Padding(0, 4, 0, 0);
			pictureBox6.Name = "pictureBox6";
			tablePanel4.SetRow(pictureBox6, 3);
			pictureBox6.Size = new Size(16, 16);
			pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox6.TabIndex = 9;
			pictureBox6.TabStop = false;
			// 
			// pictureBox8
			// 
			defaultToolTipController1.SetAllowHtmlText(pictureBox8, DefaultBoolean.Default);
			tablePanel4.SetColumn(pictureBox8, 3);
			pictureBox8.Cursor = Cursors.Help;
			pictureBox8.Dock = DockStyle.Top;
			pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
			pictureBox8.ImeMode = ImeMode.NoControl;
			pictureBox8.Location = new Point(390, 163);
			pictureBox8.Margin = new Padding(0, 4, 0, 0);
			pictureBox8.Name = "pictureBox8";
			tablePanel4.SetRow(pictureBox8, 6);
			pictureBox8.Size = new Size(16, 16);
			pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox8.TabIndex = 9;
			pictureBox8.TabStop = false;
			// 
			// neutralLanguageFileNamePatternTextEdit
			// 
			tablePanel4.SetColumn(neutralLanguageFileNamePatternTextEdit, 0);
			tablePanel4.SetColumnSpan(neutralLanguageFileNamePatternTextEdit, 3);
			neutralLanguageFileNamePatternTextEdit.CueText = null;
			neutralLanguageFileNamePatternTextEdit.Dock = DockStyle.Fill;
			neutralLanguageFileNamePatternTextEdit.Location = new Point(0, 20);
			neutralLanguageFileNamePatternTextEdit.Margin = new Padding(0, 0, 6, 9);
			neutralLanguageFileNamePatternTextEdit.MaximumSize = new Size(0, 24);
			neutralLanguageFileNamePatternTextEdit.MinimumSize = new Size(0, 24);
			neutralLanguageFileNamePatternTextEdit.Name = "neutralLanguageFileNamePatternTextEdit";
			neutralLanguageFileNamePatternTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			neutralLanguageFileNamePatternTextEdit.Properties.Appearance.Options.UseFont = true;
			neutralLanguageFileNamePatternTextEdit.Properties.NullValuePrompt = null;
			neutralLanguageFileNamePatternTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel4.SetRow(neutralLanguageFileNamePatternTextEdit, 1);
			neutralLanguageFileNamePatternTextEdit.Size = new Size(384, 24);
			neutralLanguageFileNamePatternTextEdit.TabIndex = 1;
			// 
			// labelControl6
			// 
			labelControl6.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl6.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl6, 0);
			tablePanel4.SetColumnSpan(labelControl6, 4);
			labelControl6.Location = new Point(0, 139);
			labelControl6.Margin = new Padding(0, 0, 0, 3);
			labelControl6.Name = "labelControl6";
			tablePanel4.SetRow(labelControl6, 5);
			labelControl6.Size = new Size(132, 17);
			labelControl6.TabIndex = 7;
			labelControl6.Text = "Optional default types:";
			// 
			// nonNeutralLanguageFileNamePatternTextEdit
			// 
			tablePanel4.SetColumn(nonNeutralLanguageFileNamePatternTextEdit, 0);
			tablePanel4.SetColumnSpan(nonNeutralLanguageFileNamePatternTextEdit, 3);
			nonNeutralLanguageFileNamePatternTextEdit.CueText = null;
			nonNeutralLanguageFileNamePatternTextEdit.Dock = DockStyle.Fill;
			nonNeutralLanguageFileNamePatternTextEdit.Location = new Point(0, 73);
			nonNeutralLanguageFileNamePatternTextEdit.Margin = new Padding(0, 0, 6, 9);
			nonNeutralLanguageFileNamePatternTextEdit.MaximumSize = new Size(0, 24);
			nonNeutralLanguageFileNamePatternTextEdit.MinimumSize = new Size(0, 24);
			nonNeutralLanguageFileNamePatternTextEdit.Name = "nonNeutralLanguageFileNamePatternTextEdit";
			nonNeutralLanguageFileNamePatternTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			nonNeutralLanguageFileNamePatternTextEdit.Properties.Appearance.Options.UseFont = true;
			nonNeutralLanguageFileNamePatternTextEdit.Properties.NullValuePrompt = null;
			nonNeutralLanguageFileNamePatternTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel4.SetRow(nonNeutralLanguageFileNamePatternTextEdit, 3);
			nonNeutralLanguageFileNamePatternTextEdit.Size = new Size(384, 24);
			nonNeutralLanguageFileNamePatternTextEdit.TabIndex = 3;
			// 
			// labelControl9
			// 
			labelControl9.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl9.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl9, 0);
			labelControl9.Dock = DockStyle.Top;
			labelControl9.Location = new Point(0, 109);
			labelControl9.Margin = new Padding(0, 3, 6, 0);
			labelControl9.Name = "labelControl9";
			tablePanel4.SetRow(labelControl9, 4);
			labelControl9.Size = new Size(115, 17);
			labelControl9.TabIndex = 4;
			labelControl9.Text = "&Base name contains";
			// 
			// defaultTypesTextEdit
			// 
			tablePanel4.SetColumn(defaultTypesTextEdit, 0);
			tablePanel4.SetColumnSpan(defaultTypesTextEdit, 3);
			defaultTypesTextEdit.CueText = null;
			defaultTypesTextEdit.Dock = DockStyle.Fill;
			defaultTypesTextEdit.Location = new Point(0, 159);
			defaultTypesTextEdit.Margin = new Padding(0, 0, 6, 9);
			defaultTypesTextEdit.MaximumSize = new Size(0, 24);
			defaultTypesTextEdit.MinimumSize = new Size(0, 24);
			defaultTypesTextEdit.Name = "defaultTypesTextEdit";
			defaultTypesTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			defaultTypesTextEdit.Properties.Appearance.Options.UseFont = true;
			defaultTypesTextEdit.Properties.NullValuePrompt = null;
			defaultTypesTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel4.SetRow(defaultTypesTextEdit, 6);
			defaultTypesTextEdit.Size = new Size(384, 24);
			defaultTypesTextEdit.TabIndex = 8;
			// 
			// labelControl10
			// 
			labelControl10.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl10.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl10, 2);
			labelControl10.Dock = DockStyle.Top;
			labelControl10.Location = new Point(181, 109);
			labelControl10.Margin = new Padding(0, 3, 0, 0);
			labelControl10.Name = "labelControl10";
			tablePanel4.SetRow(labelControl10, 4);
			labelControl10.Size = new Size(209, 17);
			labelControl10.TabIndex = 6;
			labelControl10.Text = "dots";
			// 
			// labelControl8
			// 
			labelControl8.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl8.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl8, 0);
			tablePanel4.SetColumnSpan(labelControl8, 4);
			labelControl8.Location = new Point(0, 53);
			labelControl8.Margin = new Padding(0, 0, 0, 3);
			labelControl8.Name = "labelControl8";
			tablePanel4.SetRow(labelControl8, 2);
			labelControl8.Size = new Size(254, 17);
			labelControl8.TabIndex = 2;
			labelControl8.Text = "File name pattern for non-neutral language:";
			// 
			// labelControl5
			// 
			labelControl5.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl5.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl5, 0);
			tablePanel4.SetColumnSpan(labelControl5, 4);
			labelControl5.Location = new Point(0, 0);
			labelControl5.Margin = new Padding(0, 0, 0, 3);
			labelControl5.Name = "labelControl5";
			tablePanel4.SetRow(labelControl5, 0);
			labelControl5.Size = new Size(227, 17);
			labelControl5.TabIndex = 0;
			labelControl5.Text = "File name pattern for neutral language:";
			// 
			// baseNameDotCountSpinEdit
			// 
			tablePanel4.SetColumn(baseNameDotCountSpinEdit, 1);
			baseNameDotCountSpinEdit.Dock = DockStyle.Fill;
			baseNameDotCountSpinEdit.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
			baseNameDotCountSpinEdit.Location = new Point(121, 106);
			baseNameDotCountSpinEdit.Margin = new Padding(0, 0, 6, 9);
			baseNameDotCountSpinEdit.Name = "baseNameDotCountSpinEdit";
			baseNameDotCountSpinEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			baseNameDotCountSpinEdit.Properties.Appearance.Options.UseFont = true;
			baseNameDotCountSpinEdit.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
			tablePanel4.SetRow(baseNameDotCountSpinEdit, 4);
			baseNameDotCountSpinEdit.Size = new Size(54, 24);
			baseNameDotCountSpinEdit.TabIndex = 5;
			// 
			// useParentElementsFilePatternSettingsCheckEdit
			// 
			tablePanel3.SetColumn(useParentElementsFilePatternSettingsCheckEdit, 0);
			useParentElementsFilePatternSettingsCheckEdit.EditValue = true;
			useParentElementsFilePatternSettingsCheckEdit.Location = new Point(0, 0);
			useParentElementsFilePatternSettingsCheckEdit.Margin = new Padding(0, 0, 0, 9);
			useParentElementsFilePatternSettingsCheckEdit.Name = "useParentElementsFilePatternSettingsCheckEdit";
			useParentElementsFilePatternSettingsCheckEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			useParentElementsFilePatternSettingsCheckEdit.Properties.Appearance.Options.UseFont = true;
			useParentElementsFilePatternSettingsCheckEdit.Properties.AutoWidth = true;
			useParentElementsFilePatternSettingsCheckEdit.Properties.Caption = "Use settings of parent element";
			useParentElementsFilePatternSettingsCheckEdit.Properties.CheckStyle = CheckStyles.Radio;
			useParentElementsFilePatternSettingsCheckEdit.Properties.RadioGroupIndex = 0;
			tablePanel3.SetRow(useParentElementsFilePatternSettingsCheckEdit, 0);
			useParentElementsFilePatternSettingsCheckEdit.Size = new Size(202, 21);
			useParentElementsFilePatternSettingsCheckEdit.TabIndex = 0;
			useParentElementsFilePatternSettingsCheckEdit.CheckedChanged += useParentElementsFilePatternSettingsCheckEdit_CheckedChanged;
			// 
			// useTheFollowingFilePatternSettingsCheckEdit
			// 
			tablePanel3.SetColumn(useTheFollowingFilePatternSettingsCheckEdit, 0);
			useTheFollowingFilePatternSettingsCheckEdit.Location = new Point(0, 30);
			useTheFollowingFilePatternSettingsCheckEdit.Margin = new Padding(0, 0, 0, 6);
			useTheFollowingFilePatternSettingsCheckEdit.Name = "useTheFollowingFilePatternSettingsCheckEdit";
			useTheFollowingFilePatternSettingsCheckEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			useTheFollowingFilePatternSettingsCheckEdit.Properties.Appearance.Options.UseFont = true;
			useTheFollowingFilePatternSettingsCheckEdit.Properties.AutoWidth = true;
			useTheFollowingFilePatternSettingsCheckEdit.Properties.Caption = "Use the following settings:";
			useTheFollowingFilePatternSettingsCheckEdit.Properties.CheckStyle = CheckStyles.Radio;
			useTheFollowingFilePatternSettingsCheckEdit.Properties.RadioGroupIndex = 0;
			tablePanel3.SetRow(useTheFollowingFilePatternSettingsCheckEdit, 1);
			useTheFollowingFilePatternSettingsCheckEdit.Size = new Size(176, 21);
			useTheFollowingFilePatternSettingsCheckEdit.TabIndex = 1;
			useTheFollowingFilePatternSettingsCheckEdit.TabStop = false;
			useTheFollowingFilePatternSettingsCheckEdit.CheckedChanged += useTheFollowingFilePatternSettingsCheckEdit_CheckedChanged;
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 2);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(380, 414);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 1);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 2;
			buttonCancel.Text = "Cancel";
			// 
			// buttonOK
			// 
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonOK, 1);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Dock = DockStyle.Fill;
			buttonOK.Location = new Point(296, 414);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel1.SetRow(buttonOK, 1);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 1;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
			// 
			// defaultToolTipController1
			// 
			// 
			// 
			// 
			defaultToolTipController1.DefaultController.AutoPopDelay = 50000;
			// 
			// tablePanel1
			// 
			defaultToolTipController1.SetAllowHtmlText(tablePanel1, DefaultBoolean.Default);
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(xtraTabControl1);
			tablePanel1.Controls.Add(buttonOK);
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(466, 453);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// ProjectFolderEditForm
			// 
			AcceptButton = buttonOK;
			defaultToolTipController1.SetAllowHtmlText(this, DefaultBoolean.Default);
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(466, 453);
			Controls.Add(tablePanel1);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(468, 485);
			Name = "ProjectFolderEditForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Edit project folder";
			FormClosing += ProjectFolderEditForm_FormClosing;
			Load += ProjectFolderEditForm_Load;
			Shown += ProjectFolderEditForm_Shown;
			((ISupportInitialize)xtraTabControl1).EndInit();
			xtraTabControl1.ResumeLayout(false);
			xtraTabPage1.ResumeLayout(false);
			xtraTabPage1.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			((ISupportInitialize)ignoreChildsDuringExportAndImportCheckEdit.Properties).EndInit();
			((ISupportInitialize)parentTextBox.Properties).EndInit();
			((ISupportInitialize)nameTextBox.Properties).EndInit();
			xtraTabPage2.ResumeLayout(false);
			xtraTabPage2.PerformLayout();
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			tablePanel3.PerformLayout();
			((ISupportInitialize)tablePanel4).EndInit();
			tablePanel4.ResumeLayout(false);
			tablePanel4.PerformLayout();
			((ISupportInitialize)pictureBox7).EndInit();
			((ISupportInitialize)pictureBox6).EndInit();
			((ISupportInitialize)pictureBox8).EndInit();
			((ISupportInitialize)neutralLanguageFileNamePatternTextEdit.Properties).EndInit();
			((ISupportInitialize)nonNeutralLanguageFileNamePatternTextEdit.Properties).EndInit();
			((ISupportInitialize)defaultTypesTextEdit.Properties).EndInit();
			((ISupportInitialize)baseNameDotCountSpinEdit.Properties).EndInit();
			((ISupportInitialize)useParentElementsFilePatternSettingsCheckEdit.Properties).EndInit();
			((ISupportInitialize)useTheFollowingFilePatternSettingsCheckEdit.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl xtraTabControl1;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage xtraTabPage1;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit parentTextBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit nameTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage xtraTabPage2;
		private DefaultToolTipController defaultToolTipController1;
		private PictureBox pictureBox8;
		private PictureBox pictureBox6;
		private PictureBox pictureBox7;
		private ExtendedControlsLibrary.Skinning.CustomSpinEdit.MySpinEdit baseNameDotCountSpinEdit;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit defaultTypesTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit nonNeutralLanguageFileNamePatternTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit neutralLanguageFileNamePatternTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl10;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl6;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl9;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl8;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl5;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useParentElementsFilePatternSettingsCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useTheFollowingFilePatternSettingsCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit ignoreChildsDuringExportAndImportCheckEdit;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
		private DevExpress.Utils.Layout.TablePanel tablePanel4;
	}
}