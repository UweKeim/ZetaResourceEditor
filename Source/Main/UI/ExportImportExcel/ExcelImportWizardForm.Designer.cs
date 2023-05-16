namespace ZetaResourceEditor.UI.ExportImportExcel
{
	partial class ExcelImportWizardForm
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(ExcelImportWizardForm));
			wizardControl = new DevExpress.XtraWizard.WizardControl();
			importFileWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
			tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel7 = new DevExpress.Utils.Layout.TablePanel();
			cmdImportFormatInfo = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			labelControl7 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			buttonOpen = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonBrowse = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			sourceFileTextEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			barDockControlLeft = new BarDockControl();
			barManager = new BarManager(components);
			barDockControlTop = new BarDockControl();
			barDockControlBottom = new BarDockControl();
			barDockControlRight = new BarDockControl();
			detailedErrorsButton = new BarButtonItem();
			successWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			pictureEdit1 = new PictureEdit();
			simpleButton1 = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			summaryAfterSuccessfulImportLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			fileGroupsWizardPage = new DevExpress.XtraWizard.WizardPage();
			tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
			selectAllFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			fileGroupsListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
			invertFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectNoFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			languagesWizardPage = new DevExpress.XtraWizard.WizardPage();
			tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
			selectAllLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			labelControl6 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			selectNoLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			label3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			invertLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			languagesToImportCheckListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
			progressWizardPage = new DevExpress.XtraWizard.WizardPage();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			progressBarControl = new MarqueeProgressBarControl();
			progressLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			errorOccurredWizardPage = new DevExpress.XtraWizard.WizardPage();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			optionsButton = new ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton();
			optionsPopupMenu = new PopupMenu(components);
			errorTextMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			progressBackgroundWorker = new BackgroundWorker();
			panel1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
			((ISupportInitialize)wizardControl).BeginInit();
			wizardControl.SuspendLayout();
			importFileWizardPage.SuspendLayout();
			((ISupportInitialize)tablePanel6).BeginInit();
			tablePanel6.SuspendLayout();
			((ISupportInitialize)tablePanel7).BeginInit();
			tablePanel7.SuspendLayout();
			((ISupportInitialize)sourceFileTextEdit.Properties).BeginInit();
			((ISupportInitialize)barManager).BeginInit();
			successWizardPage.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((ISupportInitialize)pictureEdit1.Properties).BeginInit();
			fileGroupsWizardPage.SuspendLayout();
			((ISupportInitialize)tablePanel5).BeginInit();
			tablePanel5.SuspendLayout();
			((ISupportInitialize)fileGroupsListBox).BeginInit();
			languagesWizardPage.SuspendLayout();
			((ISupportInitialize)tablePanel4).BeginInit();
			tablePanel4.SuspendLayout();
			((ISupportInitialize)languagesToImportCheckListBox).BeginInit();
			progressWizardPage.SuspendLayout();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)progressBarControl.Properties).BeginInit();
			errorOccurredWizardPage.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			((ISupportInitialize)optionsPopupMenu).BeginInit();
			((ISupportInitialize)errorTextMemoEdit.Properties).BeginInit();
			((ISupportInitialize)panel1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// wizardControl
			// 
			wizardControl.AllowTransitionAnimation = false;
			wizardControl.Controls.Add(importFileWizardPage);
			wizardControl.Controls.Add(successWizardPage);
			wizardControl.Controls.Add(fileGroupsWizardPage);
			wizardControl.Controls.Add(languagesWizardPage);
			wizardControl.Controls.Add(progressWizardPage);
			wizardControl.Controls.Add(errorOccurredWizardPage);
			wizardControl.Dock = DockStyle.Fill;
			wizardControl.Name = "wizardControl";
			wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] { importFileWizardPage, fileGroupsWizardPage, languagesWizardPage, progressWizardPage, errorOccurredWizardPage, successWizardPage });
			wizardControl.Size = new Size(579, 424);
			wizardControl.Text = "";
			wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
			wizardControl.SelectedPageChanged += wizardControl_SelectedPageChanged;
			wizardControl.CancelClick += wizardControl_CancelClick;
			wizardControl.FinishClick += wizardControl_FinishClick;
			wizardControl.NextClick += wizardControl_NextClick;
			wizardControl.PrevClick += wizardControl_PrevClick;
			// 
			// importFileWizardPage
			// 
			importFileWizardPage.Controls.Add(tablePanel6);
			importFileWizardPage.Controls.Add(barDockControlLeft);
			importFileWizardPage.Controls.Add(barDockControlRight);
			importFileWizardPage.Controls.Add(barDockControlBottom);
			importFileWizardPage.Controls.Add(barDockControlTop);
			importFileWizardPage.Margin = new Padding(0);
			importFileWizardPage.Name = "importFileWizardPage";
			importFileWizardPage.Size = new Size(538, 257);
			importFileWizardPage.Text = "Specify import file from Microsoft Excel";
			// 
			// tablePanel6
			// 
			tablePanel6.AutoSize = true;
			tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel6.Controls.Add(tablePanel7);
			tablePanel6.Controls.Add(labelControl7);
			tablePanel6.Controls.Add(buttonOpen);
			tablePanel6.Controls.Add(buttonBrowse);
			tablePanel6.Controls.Add(labelControl2);
			tablePanel6.Controls.Add(sourceFileTextEdit);
			tablePanel6.Dock = DockStyle.Fill;
			tablePanel6.Location = new Point(0, 0);
			tablePanel6.Margin = new Padding(0);
			tablePanel6.Name = "tablePanel6";
			tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 28F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel6.Size = new Size(538, 257);
			tablePanel6.TabIndex = 0;
			// 
			// tablePanel7
			// 
			tablePanel7.AutoSize = true;
			tablePanel6.SetColumn(tablePanel7, 0);
			tablePanel7.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 180F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel6.SetColumnSpan(tablePanel7, 3);
			tablePanel7.Controls.Add(cmdImportFormatInfo);
			tablePanel7.Dock = DockStyle.Fill;
			tablePanel7.Location = new Point(0, 200);
			tablePanel7.Margin = new Padding(0, 0, 0, 9);
			tablePanel7.Name = "tablePanel7";
			tablePanel6.SetRow(tablePanel7, 4);
			tablePanel7.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel7.Size = new Size(538, 28);
			tablePanel7.TabIndex = 4;
			// 
			// cmdImportFormatInfo
			// 
			cmdImportFormatInfo.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			cmdImportFormatInfo.Appearance.Options.UseFont = true;
			tablePanel7.SetColumn(cmdImportFormatInfo, 0);
			cmdImportFormatInfo.Dock = DockStyle.Fill;
			cmdImportFormatInfo.Location = new Point(0, 0);
			cmdImportFormatInfo.Margin = new Padding(0);
			cmdImportFormatInfo.Name = "cmdImportFormatInfo";
			tablePanel7.SetRow(cmdImportFormatInfo, 0);
			cmdImportFormatInfo.Size = new Size(180, 28);
			cmdImportFormatInfo.TabIndex = 0;
			cmdImportFormatInfo.Text = "Import format information";
			cmdImportFormatInfo.Click += cmdImportFormatInfo_Click;
			// 
			// labelControl7
			// 
			labelControl7.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl7.Appearance.Options.UseFont = true;
			labelControl7.Appearance.Options.UseTextOptions = true;
			labelControl7.Appearance.TextOptions.VAlignment = VertAlignment.Top;
			labelControl7.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
			labelControl7.AutoSizeMode = LabelAutoSizeMode.None;
			tablePanel6.SetColumn(labelControl7, 0);
			tablePanel6.SetColumnSpan(labelControl7, 3);
			labelControl7.Dock = DockStyle.Fill;
			labelControl7.Enabled = false;
			labelControl7.Location = new Point(0, 237);
			labelControl7.Margin = new Padding(0);
			labelControl7.Name = "labelControl7";
			tablePanel6.SetRow(labelControl7, 5);
			labelControl7.Size = new Size(538, 20);
			labelControl7.TabIndex = 5;
			labelControl7.Text = "Information about the required structure of a Microsoft Office Excel document in order to successfully import";
			// 
			// buttonOpen
			// 
			buttonOpen.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOpen.Appearance.Options.UseFont = true;
			tablePanel6.SetColumn(buttonOpen, 0);
			buttonOpen.Location = new Point(0, 77);
			buttonOpen.Margin = new Padding(0);
			buttonOpen.Name = "buttonOpen";
			tablePanel6.SetRow(buttonOpen, 2);
			buttonOpen.Size = new Size(75, 28);
			buttonOpen.TabIndex = 2;
			buttonOpen.Text = "&Open";
			buttonOpen.Click += buttonOpen_Click;
			// 
			// buttonBrowse
			// 
			buttonBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonBrowse.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonBrowse.Appearance.Options.UseFont = true;
			tablePanel6.SetColumn(buttonBrowse, 2);
			buttonBrowse.Location = new Point(463, 77);
			buttonBrowse.Margin = new Padding(0);
			buttonBrowse.Name = "buttonBrowse";
			tablePanel6.SetRow(buttonBrowse, 2);
			buttonBrowse.Size = new Size(75, 28);
			buttonBrowse.TabIndex = 3;
			buttonBrowse.Text = "Browse";
			buttonBrowse.Click += buttonBrowse_Click;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl2.Appearance.Options.UseFont = true;
			tablePanel6.SetColumn(labelControl2, 0);
			tablePanel6.SetColumnSpan(labelControl2, 3);
			labelControl2.Dock = DockStyle.Fill;
			labelControl2.Location = new Point(0, 0);
			labelControl2.Margin = new Padding(0, 0, 0, 3);
			labelControl2.Name = "labelControl2";
			tablePanel6.SetRow(labelControl2, 0);
			labelControl2.Size = new Size(538, 17);
			labelControl2.TabIndex = 0;
			labelControl2.Text = "Microsoft Office Excel document to import:";
			// 
			// sourceFileTextEdit
			// 
			tablePanel6.SetColumn(sourceFileTextEdit, 0);
			tablePanel6.SetColumnSpan(sourceFileTextEdit, 3);
			sourceFileTextEdit.CueText = null;
			sourceFileTextEdit.Dock = DockStyle.Fill;
			sourceFileTextEdit.Location = new Point(0, 20);
			sourceFileTextEdit.Margin = new Padding(0, 0, 0, 9);
			sourceFileTextEdit.MinimumSize = new Size(0, 48);
			sourceFileTextEdit.Name = "sourceFileTextEdit";
			sourceFileTextEdit.Properties.AcceptsReturn = false;
			sourceFileTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			sourceFileTextEdit.Properties.Appearance.Options.UseFont = true;
			sourceFileTextEdit.Properties.NullValuePrompt = null;
			sourceFileTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel6.SetRow(sourceFileTextEdit, 1);
			sourceFileTextEdit.Size = new Size(538, 48);
			sourceFileTextEdit.TabIndex = 1;
			sourceFileTextEdit.EditValueChanged += sourceFileTextEdit_EditValueChanged;
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 0);
			barDockControlLeft.Manager = barManager;
			barDockControlLeft.Size = new Size(0, 257);
			// 
			// barManager
			// 
			barManager.DockControls.Add(barDockControlTop);
			barManager.DockControls.Add(barDockControlBottom);
			barManager.DockControls.Add(barDockControlLeft);
			barManager.DockControls.Add(barDockControlRight);
			barManager.Form = importFileWizardPage;
			barManager.Items.AddRange(new BarItem[] { detailedErrorsButton });
			barManager.MaxItemId = 3;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager;
			barDockControlTop.Size = new Size(538, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 257);
			barDockControlBottom.Manager = barManager;
			barDockControlBottom.Size = new Size(538, 0);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(538, 0);
			barDockControlRight.Manager = barManager;
			barDockControlRight.Size = new Size(0, 257);
			// 
			// detailedErrorsButton
			// 
			detailedErrorsButton.Caption = "Details";
			detailedErrorsButton.Id = 0;
			detailedErrorsButton.ImageOptions.ImageIndex = 1;
			detailedErrorsButton.Name = "detailedErrorsButton";
			detailedErrorsButton.ItemClick += detailedErrorsButton_ItemClick;
			// 
			// successWizardPage
			// 
			successWizardPage.AllowBack = false;
			successWizardPage.AllowCancel = false;
			successWizardPage.AllowNext = false;
			successWizardPage.Controls.Add(tablePanel3);
			successWizardPage.Margin = new Padding(0);
			successWizardPage.Name = "successWizardPage";
			successWizardPage.Size = new Size(538, 257);
			successWizardPage.Text = "Import completed successfully";
			// 
			// tablePanel3
			// 
			tablePanel3.AutoSize = true;
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 239F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel3.Controls.Add(pictureEdit1);
			tablePanel3.Controls.Add(simpleButton1);
			tablePanel3.Controls.Add(summaryAfterSuccessfulImportLabel);
			tablePanel3.Controls.Add(labelControl5);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(0, 0);
			tablePanel3.Margin = new Padding(0);
			tablePanel3.Name = "tablePanel3";
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel3.Size = new Size(538, 257);
			tablePanel3.TabIndex = 15;
			// 
			// pictureEdit1
			// 
			tablePanel3.SetColumn(pictureEdit1, 0);
			pictureEdit1.Dock = DockStyle.Top;
			pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
			pictureEdit1.Location = new Point(0, 0);
			pictureEdit1.Margin = new Padding(0, 0, 16, 0);
			pictureEdit1.Name = "pictureEdit1";
			pictureEdit1.Properties.Appearance.BackColor = Color.Transparent;
			pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			pictureEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
			pictureEdit1.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
			pictureEdit1.Properties.SizeMode = PictureSizeMode.Squeeze;
			tablePanel3.SetRow(pictureEdit1, 0);
			tablePanel3.SetRowSpan(pictureEdit1, 3);
			pictureEdit1.Size = new Size(48, 48);
			pictureEdit1.TabIndex = 15;
			// 
			// simpleButton1
			// 
			simpleButton1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			simpleButton1.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(simpleButton1, 1);
			simpleButton1.Dock = DockStyle.Fill;
			simpleButton1.Location = new Point(64, 229);
			simpleButton1.Margin = new Padding(0);
			simpleButton1.Name = "simpleButton1";
			tablePanel3.SetRow(simpleButton1, 2);
			simpleButton1.Size = new Size(239, 28);
			simpleButton1.TabIndex = 14;
			simpleButton1.Text = "No rows imported — Find out why";
			simpleButton1.Click += cmdImportFormatInfo_Click;
			// 
			// summaryAfterSuccessfulImportLabel
			// 
			summaryAfterSuccessfulImportLabel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			summaryAfterSuccessfulImportLabel.Appearance.Options.UseFont = true;
			summaryAfterSuccessfulImportLabel.Appearance.Options.UseTextOptions = true;
			summaryAfterSuccessfulImportLabel.Appearance.TextOptions.VAlignment = VertAlignment.Top;
			summaryAfterSuccessfulImportLabel.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
			summaryAfterSuccessfulImportLabel.AutoSizeMode = LabelAutoSizeMode.None;
			tablePanel3.SetColumn(summaryAfterSuccessfulImportLabel, 1);
			tablePanel3.SetColumnSpan(summaryAfterSuccessfulImportLabel, 2);
			summaryAfterSuccessfulImportLabel.Dock = DockStyle.Fill;
			summaryAfterSuccessfulImportLabel.Location = new Point(64, 46);
			summaryAfterSuccessfulImportLabel.Margin = new Padding(0, 0, 0, 9);
			summaryAfterSuccessfulImportLabel.Name = "summaryAfterSuccessfulImportLabel";
			tablePanel3.SetRow(summaryAfterSuccessfulImportLabel, 1);
			summaryAfterSuccessfulImportLabel.Size = new Size(474, 174);
			summaryAfterSuccessfulImportLabel.TabIndex = 9;
			summaryAfterSuccessfulImportLabel.Text = "<SUMMARY>";
			// 
			// labelControl5
			// 
			labelControl5.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl5.Appearance.Options.UseFont = true;
			labelControl5.Appearance.Options.UseTextOptions = true;
			labelControl5.Appearance.TextOptions.VAlignment = VertAlignment.Top;
			labelControl5.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
			labelControl5.AutoSizeMode = LabelAutoSizeMode.None;
			tablePanel3.SetColumn(labelControl5, 1);
			tablePanel3.SetColumnSpan(labelControl5, 2);
			labelControl5.Dock = DockStyle.Fill;
			labelControl5.Location = new Point(64, 0);
			labelControl5.Margin = new Padding(0, 0, 0, 9);
			labelControl5.Name = "labelControl5";
			tablePanel3.SetRow(labelControl5, 0);
			labelControl5.Size = new Size(474, 37);
			labelControl5.TabIndex = 9;
			labelControl5.Text = "Your data was successfully imported from the Microsoft Office Excel document you specified.";
			// 
			// fileGroupsWizardPage
			// 
			fileGroupsWizardPage.Controls.Add(tablePanel5);
			fileGroupsWizardPage.Margin = new Padding(0);
			fileGroupsWizardPage.Name = "fileGroupsWizardPage";
			fileGroupsWizardPage.Size = new Size(538, 257);
			fileGroupsWizardPage.Text = "Select files groups to import";
			// 
			// tablePanel5
			// 
			tablePanel5.AutoSize = true;
			tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel5.Controls.Add(selectAllFileGroupsButton);
			tablePanel5.Controls.Add(labelControl1);
			tablePanel5.Controls.Add(labelControl4);
			tablePanel5.Controls.Add(fileGroupsListBox);
			tablePanel5.Controls.Add(invertFileGroupsButton);
			tablePanel5.Controls.Add(selectNoFileGroupsButton);
			tablePanel5.Dock = DockStyle.Fill;
			tablePanel5.Location = new Point(0, 0);
			tablePanel5.Margin = new Padding(0);
			tablePanel5.Name = "tablePanel5";
			tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel5.Size = new Size(538, 257);
			tablePanel5.TabIndex = 10;
			// 
			// selectAllFileGroupsButton
			// 
			selectAllFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectAllFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(selectAllFileGroupsButton, 0);
			selectAllFileGroupsButton.Dock = DockStyle.Fill;
			selectAllFileGroupsButton.Location = new Point(0, 229);
			selectAllFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			selectAllFileGroupsButton.Name = "selectAllFileGroupsButton";
			tablePanel5.SetRow(selectAllFileGroupsButton, 3);
			selectAllFileGroupsButton.Size = new Size(75, 28);
			selectAllFileGroupsButton.TabIndex = 7;
			selectAllFileGroupsButton.Text = "All";
			selectAllFileGroupsButton.Click += selectAllFileGroupsButton_Click;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(labelControl1, 0);
			tablePanel5.SetColumnSpan(labelControl1, 4);
			labelControl1.Dock = DockStyle.Fill;
			labelControl1.Location = new Point(0, 0);
			labelControl1.Margin = new Padding(0, 0, 0, 18);
			labelControl1.Name = "labelControl1";
			tablePanel5.SetRow(labelControl1, 0);
			labelControl1.Size = new Size(538, 17);
			labelControl1.TabIndex = 5;
			labelControl1.Text = "The following matching file groups were found in the Microsoft Office Excel document.";
			// 
			// labelControl4
			// 
			labelControl4.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl4.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(labelControl4, 0);
			tablePanel5.SetColumnSpan(labelControl4, 4);
			labelControl4.Dock = DockStyle.Fill;
			labelControl4.Location = new Point(0, 35);
			labelControl4.Margin = new Padding(0, 0, 0, 3);
			labelControl4.Name = "labelControl4";
			tablePanel5.SetRow(labelControl4, 1);
			labelControl4.Size = new Size(538, 17);
			labelControl4.TabIndex = 5;
			labelControl4.Text = "Check the groups you want to import:";
			// 
			// fileGroupsListBox
			// 
			fileGroupsListBox.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			fileGroupsListBox.Appearance.Options.UseFont = true;
			fileGroupsListBox.CheckOnClick = true;
			tablePanel5.SetColumn(fileGroupsListBox, 0);
			tablePanel5.SetColumnSpan(fileGroupsListBox, 4);
			fileGroupsListBox.Dock = DockStyle.Fill;
			fileGroupsListBox.Location = new Point(0, 55);
			fileGroupsListBox.Margin = new Padding(0, 0, 0, 9);
			fileGroupsListBox.Name = "fileGroupsListBox";
			tablePanel5.SetRow(fileGroupsListBox, 2);
			fileGroupsListBox.Size = new Size(538, 165);
			fileGroupsListBox.TabIndex = 6;
			fileGroupsListBox.ItemCheck += fileGroupsListBox_ItemCheck;
			fileGroupsListBox.SelectedIndexChanged += fileGroupsListBox_SelectedIndexChanged;
			// 
			// invertFileGroupsButton
			// 
			invertFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			invertFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(invertFileGroupsButton, 2);
			invertFileGroupsButton.Dock = DockStyle.Fill;
			invertFileGroupsButton.Location = new Point(168, 229);
			invertFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			invertFileGroupsButton.Name = "invertFileGroupsButton";
			tablePanel5.SetRow(invertFileGroupsButton, 3);
			invertFileGroupsButton.Size = new Size(75, 28);
			invertFileGroupsButton.TabIndex = 9;
			invertFileGroupsButton.Text = "Flip";
			invertFileGroupsButton.Click += invertFileGroupsButton_Click;
			// 
			// selectNoFileGroupsButton
			// 
			selectNoFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectNoFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(selectNoFileGroupsButton, 1);
			selectNoFileGroupsButton.Dock = DockStyle.Fill;
			selectNoFileGroupsButton.Location = new Point(84, 229);
			selectNoFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
			tablePanel5.SetRow(selectNoFileGroupsButton, 3);
			selectNoFileGroupsButton.Size = new Size(75, 28);
			selectNoFileGroupsButton.TabIndex = 8;
			selectNoFileGroupsButton.Text = "None";
			selectNoFileGroupsButton.Click += selectNoFileGroupsButton_Click;
			// 
			// languagesWizardPage
			// 
			languagesWizardPage.Controls.Add(tablePanel4);
			languagesWizardPage.Margin = new Padding(0);
			languagesWizardPage.Name = "languagesWizardPage";
			languagesWizardPage.Size = new Size(538, 257);
			languagesWizardPage.Text = "Specify languages to import";
			// 
			// tablePanel4
			// 
			tablePanel4.AutoSize = true;
			tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel4.Controls.Add(selectAllLanguagesToExportButton);
			tablePanel4.Controls.Add(labelControl6);
			tablePanel4.Controls.Add(selectNoLanguagesToExportButton);
			tablePanel4.Controls.Add(label3);
			tablePanel4.Controls.Add(invertLanguagesToExportButton);
			tablePanel4.Controls.Add(languagesToImportCheckListBox);
			tablePanel4.Dock = DockStyle.Fill;
			tablePanel4.Location = new Point(0, 0);
			tablePanel4.Margin = new Padding(0);
			tablePanel4.Name = "tablePanel4";
			tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel4.Size = new Size(538, 257);
			tablePanel4.TabIndex = 15;
			// 
			// selectAllLanguagesToExportButton
			// 
			selectAllLanguagesToExportButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectAllLanguagesToExportButton.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(selectAllLanguagesToExportButton, 0);
			selectAllLanguagesToExportButton.Dock = DockStyle.Fill;
			selectAllLanguagesToExportButton.Location = new Point(0, 229);
			selectAllLanguagesToExportButton.Margin = new Padding(0, 0, 9, 0);
			selectAllLanguagesToExportButton.Name = "selectAllLanguagesToExportButton";
			tablePanel4.SetRow(selectAllLanguagesToExportButton, 3);
			selectAllLanguagesToExportButton.Size = new Size(75, 28);
			selectAllLanguagesToExportButton.TabIndex = 3;
			selectAllLanguagesToExportButton.Text = "All";
			selectAllLanguagesToExportButton.Click += selectAllLanguagesToExportButton_Click;
			// 
			// labelControl6
			// 
			labelControl6.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl6.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl6, 0);
			tablePanel4.SetColumnSpan(labelControl6, 4);
			labelControl6.Location = new Point(0, 35);
			labelControl6.Margin = new Padding(0, 0, 0, 3);
			labelControl6.Name = "labelControl6";
			tablePanel4.SetRow(labelControl6, 1);
			labelControl6.Size = new Size(238, 17);
			labelControl6.TabIndex = 1;
			labelControl6.Text = "Check the languages you want to import:";
			// 
			// selectNoLanguagesToExportButton
			// 
			selectNoLanguagesToExportButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectNoLanguagesToExportButton.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(selectNoLanguagesToExportButton, 1);
			selectNoLanguagesToExportButton.Dock = DockStyle.Fill;
			selectNoLanguagesToExportButton.Location = new Point(84, 229);
			selectNoLanguagesToExportButton.Margin = new Padding(0, 0, 9, 0);
			selectNoLanguagesToExportButton.Name = "selectNoLanguagesToExportButton";
			tablePanel4.SetRow(selectNoLanguagesToExportButton, 3);
			selectNoLanguagesToExportButton.Size = new Size(75, 28);
			selectNoLanguagesToExportButton.TabIndex = 4;
			selectNoLanguagesToExportButton.Text = "None";
			selectNoLanguagesToExportButton.Click += selectNoLanguagesToExportButton_Click;
			// 
			// label3
			// 
			label3.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(label3, 0);
			tablePanel4.SetColumnSpan(label3, 4);
			label3.Location = new Point(0, 0);
			label3.Margin = new Padding(0, 0, 0, 18);
			label3.Name = "label3";
			tablePanel4.SetRow(label3, 0);
			label3.Size = new Size(501, 17);
			label3.TabIndex = 0;
			label3.Text = "The following matching languages were found in the Microsoft Office Excel document.";
			// 
			// invertLanguagesToExportButton
			// 
			invertLanguagesToExportButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			invertLanguagesToExportButton.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(invertLanguagesToExportButton, 2);
			invertLanguagesToExportButton.Dock = DockStyle.Fill;
			invertLanguagesToExportButton.Location = new Point(168, 229);
			invertLanguagesToExportButton.Margin = new Padding(0, 0, 9, 0);
			invertLanguagesToExportButton.Name = "invertLanguagesToExportButton";
			tablePanel4.SetRow(invertLanguagesToExportButton, 3);
			invertLanguagesToExportButton.Size = new Size(75, 28);
			invertLanguagesToExportButton.TabIndex = 5;
			invertLanguagesToExportButton.Text = "Flip";
			invertLanguagesToExportButton.Click += invertLanguagesToExportButton_Click;
			// 
			// languagesToImportCheckListBox
			// 
			languagesToImportCheckListBox.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			languagesToImportCheckListBox.Appearance.Options.UseFont = true;
			languagesToImportCheckListBox.CheckOnClick = true;
			tablePanel4.SetColumn(languagesToImportCheckListBox, 0);
			tablePanel4.SetColumnSpan(languagesToImportCheckListBox, 4);
			languagesToImportCheckListBox.Dock = DockStyle.Fill;
			languagesToImportCheckListBox.Location = new Point(0, 55);
			languagesToImportCheckListBox.Margin = new Padding(0, 0, 0, 9);
			languagesToImportCheckListBox.Name = "languagesToImportCheckListBox";
			tablePanel4.SetRow(languagesToImportCheckListBox, 2);
			languagesToImportCheckListBox.Size = new Size(538, 165);
			languagesToImportCheckListBox.TabIndex = 2;
			languagesToImportCheckListBox.ItemCheck += languagesToImportCheckListBox_ItemCheck;
			languagesToImportCheckListBox.SelectedIndexChanged += languagesToImportCheckListBox_SelectedIndexChanged;
			// 
			// progressWizardPage
			// 
			progressWizardPage.AllowBack = false;
			progressWizardPage.AllowNext = false;
			progressWizardPage.Controls.Add(tablePanel1);
			progressWizardPage.Margin = new Padding(0);
			progressWizardPage.Name = "progressWizardPage";
			progressWizardPage.Size = new Size(538, 257);
			progressWizardPage.Text = "Data is being imported. Please wait...";
			// 
			// tablePanel1
			// 
			tablePanel1.AutoSize = true;
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.Controls.Add(progressBarControl);
			tablePanel1.Controls.Add(progressLabel);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.Size = new Size(538, 257);
			tablePanel1.TabIndex = 4;
			// 
			// progressBarControl
			// 
			tablePanel1.SetColumn(progressBarControl, 0);
			progressBarControl.Dock = DockStyle.Fill;
			progressBarControl.EditValue = 0;
			progressBarControl.Location = new Point(0, 0);
			progressBarControl.Margin = new Padding(0, 0, 0, 9);
			progressBarControl.Name = "progressBarControl";
			tablePanel1.SetRow(progressBarControl, 0);
			progressBarControl.Size = new Size(538, 18);
			progressBarControl.TabIndex = 2;
			// 
			// progressLabel
			// 
			progressLabel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			progressLabel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(progressLabel, 0);
			progressLabel.Dock = DockStyle.Fill;
			progressLabel.Location = new Point(0, 27);
			progressLabel.Margin = new Padding(0);
			progressLabel.Name = "progressLabel";
			tablePanel1.SetRow(progressLabel, 1);
			progressLabel.Size = new Size(538, 17);
			progressLabel.TabIndex = 3;
			progressLabel.Text = "<Progress information, if any>";
			progressLabel.Visible = false;
			// 
			// errorOccurredWizardPage
			// 
			errorOccurredWizardPage.AllowNext = false;
			errorOccurredWizardPage.Controls.Add(tablePanel2);
			errorOccurredWizardPage.Margin = new Padding(0);
			errorOccurredWizardPage.Name = "errorOccurredWizardPage";
			errorOccurredWizardPage.Size = new Size(538, 257);
			errorOccurredWizardPage.Text = "An error has occurred";
			// 
			// tablePanel2
			// 
			tablePanel2.AutoSize = true;
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel2.Controls.Add(optionsButton);
			tablePanel2.Controls.Add(errorTextMemoEdit);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(0, 0);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel2.Size = new Size(538, 257);
			tablePanel2.TabIndex = 11;
			// 
			// optionsButton
			// 
			optionsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			optionsButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(optionsButton, 0);
			optionsButton.Dock = DockStyle.Fill;
			optionsButton.DropDownArrowStyle = DropDownArrowStyle.Hide;
			optionsButton.DropDownControl = optionsPopupMenu;
			optionsButton.ImageOptions.Image = (Image)resources.GetObject("optionsButton.ImageOptions.Image");
			optionsButton.ImageOptions.Location = ImageLocation.MiddleRight;
			optionsButton.Location = new Point(0, 229);
			optionsButton.Margin = new Padding(0);
			optionsButton.Name = "optionsButton";
			tablePanel2.SetRow(optionsButton, 1);
			optionsButton.Size = new Size(85, 28);
			optionsButton.TabIndex = 10;
			optionsButton.Text = "&Options";
			// 
			// optionsPopupMenu
			// 
			optionsPopupMenu.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(detailedErrorsButton) });
			optionsPopupMenu.Manager = barManager;
			optionsPopupMenu.Name = "optionsPopupMenu";
			optionsPopupMenu.BeforePopup += optionsPopupMenu_BeforePopup;
			// 
			// errorTextMemoEdit
			// 
			tablePanel2.SetColumn(errorTextMemoEdit, 0);
			tablePanel2.SetColumnSpan(errorTextMemoEdit, 2);
			errorTextMemoEdit.CueText = null;
			errorTextMemoEdit.Dock = DockStyle.Fill;
			errorTextMemoEdit.Location = new Point(0, 0);
			errorTextMemoEdit.Margin = new Padding(0, 0, 0, 9);
			errorTextMemoEdit.Name = "errorTextMemoEdit";
			errorTextMemoEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			errorTextMemoEdit.Properties.Appearance.Options.UseFont = true;
			errorTextMemoEdit.Properties.NullValuePrompt = null;
			errorTextMemoEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(errorTextMemoEdit, 0);
			errorTextMemoEdit.Size = new Size(538, 220);
			errorTextMemoEdit.TabIndex = 9;
			// 
			// progressBackgroundWorker
			// 
			progressBackgroundWorker.WorkerReportsProgress = true;
			progressBackgroundWorker.WorkerSupportsCancellation = true;
			progressBackgroundWorker.DoWork += progressBackgroundWorker_DoWork;
			progressBackgroundWorker.ProgressChanged += progressBackgroundWorker_ProgressChanged;
			progressBackgroundWorker.RunWorkerCompleted += progressBackgroundWorker_RunWorkerCompleted;
			// 
			// panel1
			// 
			panel1.Appearance.BackColor = Color.Transparent;
			panel1.Appearance.Options.UseBackColor = true;
			panel1.BorderStyle = BorderStyles.NoBorder;
			panel1.Controls.Add(wizardControl);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(579, 424);
			panel1.TabIndex = 0;
			// 
			// ExcelImportWizardForm
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(579, 424);
			Controls.Add(panel1);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(581, 456);
			Name = "ExcelImportWizardForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Import data from Microsoft Excel";
			FormClosing += ImportWizard_FormClosing;
			Load += ImportWizard_Load;
			((ISupportInitialize)wizardControl).EndInit();
			wizardControl.ResumeLayout(false);
			importFileWizardPage.ResumeLayout(false);
			importFileWizardPage.PerformLayout();
			((ISupportInitialize)tablePanel6).EndInit();
			tablePanel6.ResumeLayout(false);
			tablePanel6.PerformLayout();
			((ISupportInitialize)tablePanel7).EndInit();
			tablePanel7.ResumeLayout(false);
			((ISupportInitialize)sourceFileTextEdit.Properties).EndInit();
			((ISupportInitialize)barManager).EndInit();
			successWizardPage.ResumeLayout(false);
			successWizardPage.PerformLayout();
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			tablePanel3.PerformLayout();
			((ISupportInitialize)pictureEdit1.Properties).EndInit();
			fileGroupsWizardPage.ResumeLayout(false);
			fileGroupsWizardPage.PerformLayout();
			((ISupportInitialize)tablePanel5).EndInit();
			tablePanel5.ResumeLayout(false);
			tablePanel5.PerformLayout();
			((ISupportInitialize)fileGroupsListBox).EndInit();
			languagesWizardPage.ResumeLayout(false);
			languagesWizardPage.PerformLayout();
			((ISupportInitialize)tablePanel4).EndInit();
			tablePanel4.ResumeLayout(false);
			tablePanel4.PerformLayout();
			((ISupportInitialize)languagesToImportCheckListBox).EndInit();
			progressWizardPage.ResumeLayout(false);
			progressWizardPage.PerformLayout();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			((ISupportInitialize)progressBarControl.Properties).EndInit();
			errorOccurredWizardPage.ResumeLayout(false);
			errorOccurredWizardPage.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			((ISupportInitialize)optionsPopupMenu).EndInit();
			((ISupportInitialize)errorTextMemoEdit.Properties).EndInit();
			((ISupportInitialize)panel1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraWizard.WizardControl wizardControl;
		private DevExpress.XtraWizard.WelcomeWizardPage importFileWizardPage;
		private DevExpress.XtraWizard.CompletionWizardPage successWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonBrowse;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit sourceFileTextEdit;
		private BarDockControl barDockControlTop;
		private BarDockControl barDockControlBottom;
		private BarDockControl barDockControlLeft;
		private BarDockControl barDockControlRight;
		private BarManager barManager;
		private BarButtonItem detailedErrorsButton;
		private PopupMenu optionsPopupMenu;
		private BackgroundWorker progressBackgroundWorker;
		private DevExpress.XtraWizard.WizardPage fileGroupsWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl fileGroupsListBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private DevExpress.XtraWizard.WizardPage languagesWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label3;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl languagesToImportCheckListBox;
		private DevExpress.XtraWizard.WizardPage progressWizardPage;
		private MarqueeProgressBarControl progressBarControl;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl progressLabel;
		private DevExpress.XtraWizard.WizardPage errorOccurredWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton optionsButton;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit errorTextMemoEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl5;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl6;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOpen;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl summaryAfterSuccessfulImportLabel;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl7;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton cmdImportFormatInfo;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton simpleButton1;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
		private DevExpress.Utils.Layout.TablePanel tablePanel4;
		private DevExpress.Utils.Layout.TablePanel tablePanel5;
		private DevExpress.Utils.Layout.TablePanel tablePanel6;
		private DevExpress.Utils.Layout.TablePanel tablePanel7;
		private PictureEdit pictureEdit1;
	}
}