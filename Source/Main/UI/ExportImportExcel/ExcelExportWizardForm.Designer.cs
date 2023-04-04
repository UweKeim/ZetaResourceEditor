namespace ZetaResourceEditor.UI.ExportImportExcel
{
	partial class ExcelExportWizardForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelExportWizardForm));
            this.wizardControl = new ExtendedControlsLibrary.Skinning.CustomWizard.NoHeaderWizardControl();
            this.fileGroupSelectionWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.invertFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectNoFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectAllFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.fileGroupsListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
            this.labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.destinationFileWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.buttonDecorateSimpleAutomatically = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.multipleFilesGroupControl = new ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl();
            this.buttonDecorateAutomatically = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.labelControl9 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.destinationFileTextEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.errorOccurredWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.optionsButton = new ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton();
            this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.detailedErrorsButton = new DevExpress.XtraBars.BarButtonItem();
            this.errorTextMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.openFolderAfterGeneratingCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.openFileAfterGeneratingCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.buttonBrowse = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.labelControl6 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.languagesWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.label3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.referenceLanguageGroupBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.selectAllLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.invertLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectNoLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.languagesToExportCheckListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
            this.optionsWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.buttonResetOptions = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportGroupsAsOneWorkSheetCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.labelControl7 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.exportGroupsAsExcelFilesCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportGroupsAsWorkSheetsCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.progressWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.progressLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.successWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.pleaseWaitFinishLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.warningTextLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.advancedOptionsWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.buttonResetAdvancedOptions = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.advancedOptionsPanel = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.useCrypticExcelExportSheetNamesCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportFileGroupColumnCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportReferenceLanguageColumnCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportCommentColumnCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportNameColumnCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.eliminateDuplicateRowsCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportOnlyRowsWithChangedTextsCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportCompletelyEmptyRowsCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportWithoutDestinationTranslationOnlyCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl8 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.btnConnectionStringExpander = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.progressBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.fileGroupSelectionWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupsListBox)).BeginInit();
            this.destinationFileWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multipleFilesGroupControl)).BeginInit();
            this.multipleFilesGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationFileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.errorOccurredWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTextMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderAfterGeneratingCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileAfterGeneratingCheckEdit.Properties)).BeginInit();
            this.languagesWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceLanguageGroupBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesToExportCheckListBox)).BeginInit();
            this.optionsWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGroupsAsOneWorkSheetCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGroupsAsExcelFilesCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGroupsAsWorkSheetsCheckEdit.Properties)).BeginInit();
            this.progressWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            this.successWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.advancedOptionsWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedOptionsPanel)).BeginInit();
            this.advancedOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useCrypticExcelExportSheetNamesCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFileGroupColumnCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportReferenceLanguageColumnCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportCommentColumnCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportNameColumnCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminateDuplicateRowsCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportOnlyRowsWithChangedTextsCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportCompletelyEmptyRowsCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl
            // 
            this.wizardControl.AllowAutoScaling = DevExpress.Utils.DefaultBoolean.False;
            this.wizardControl.AllowTransitionAnimation = false;
            this.wizardControl.Controls.Add(this.fileGroupSelectionWizardPage);
            this.wizardControl.Controls.Add(this.destinationFileWizardPage);
            this.wizardControl.Controls.Add(this.languagesWizardPage);
            this.wizardControl.Controls.Add(this.optionsWizardPage);
            this.wizardControl.Controls.Add(this.progressWizardPage);
            this.wizardControl.Controls.Add(this.errorOccurredWizardPage);
            this.wizardControl.Controls.Add(this.successWizardPage);
            this.wizardControl.Controls.Add(this.advancedOptionsWizardPage);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.FinishText = "Finish";
            this.wizardControl.HelpText = "Help";
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.NextText = "Next >";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.fileGroupSelectionWizardPage,
            this.languagesWizardPage,
            this.optionsWizardPage,
            this.advancedOptionsWizardPage,
            this.destinationFileWizardPage,
            this.progressWizardPage,
            this.errorOccurredWizardPage,
            this.successWizardPage});
            this.wizardControl.PreviousText = "< Back";
            this.wizardControl.Size = new System.Drawing.Size(611, 601);
            this.wizardControl.Text = "";
            this.wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl_SelectedPageChanged);
            this.wizardControl.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl_SelectedPageChanging);
            this.wizardControl.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_CancelClick);
            this.wizardControl.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_FinishClick);
            this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
            this.wizardControl.PrevClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_PrevClick);
            // 
            // fileGroupSelectionWizardPage
            // 
            this.fileGroupSelectionWizardPage.Controls.Add(this.invertFileGroupsButton);
            this.fileGroupSelectionWizardPage.Controls.Add(this.selectNoFileGroupsButton);
            this.fileGroupSelectionWizardPage.Controls.Add(this.selectAllFileGroupsButton);
            this.fileGroupSelectionWizardPage.Controls.Add(this.fileGroupsListBox);
            this.fileGroupSelectionWizardPage.Controls.Add(this.labelControl2);
            this.fileGroupSelectionWizardPage.Name = "fileGroupSelectionWizardPage";
            this.fileGroupSelectionWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.fileGroupSelectionWizardPage.Size = new System.Drawing.Size(567, 472);
            this.fileGroupSelectionWizardPage.Text = "Select file groups to export to Microsoft Excel";
            // 
            // invertFileGroupsButton
            // 
            this.invertFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invertFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invertFileGroupsButton.Appearance.Options.UseFont = true;
            this.invertFileGroupsButton.Location = new System.Drawing.Point(174, 432);
            this.invertFileGroupsButton.Name = "invertFileGroupsButton";
            this.invertFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.invertFileGroupsButton.TabIndex = 4;
            this.invertFileGroupsButton.Text = "Flip";
            this.invertFileGroupsButton.WantDrawFocusRectangle = true;
            this.invertFileGroupsButton.Click += new System.EventHandler(this.invertFileGroupsButton_Click);
            // 
            // selectNoFileGroupsButton
            // 
            this.selectNoFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectNoFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectNoFileGroupsButton.Appearance.Options.UseFont = true;
            this.selectNoFileGroupsButton.Location = new System.Drawing.Point(93, 432);
            this.selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
            this.selectNoFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.selectNoFileGroupsButton.TabIndex = 3;
            this.selectNoFileGroupsButton.Text = "None";
            this.selectNoFileGroupsButton.WantDrawFocusRectangle = true;
            this.selectNoFileGroupsButton.Click += new System.EventHandler(this.selectNoFileGroupsButton_Click);
            // 
            // selectAllFileGroupsButton
            // 
            this.selectAllFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectAllFileGroupsButton.Appearance.Options.UseFont = true;
            this.selectAllFileGroupsButton.Location = new System.Drawing.Point(12, 432);
            this.selectAllFileGroupsButton.Name = "selectAllFileGroupsButton";
            this.selectAllFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.selectAllFileGroupsButton.TabIndex = 2;
            this.selectAllFileGroupsButton.Text = "All";
            this.selectAllFileGroupsButton.WantDrawFocusRectangle = true;
            this.selectAllFileGroupsButton.Click += new System.EventHandler(this.selectAllFileGroupsButton_Click);
            // 
            // fileGroupsListBox
            // 
            this.fileGroupsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGroupsListBox.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileGroupsListBox.Appearance.Options.UseFont = true;
            this.fileGroupsListBox.CheckOnClick = true;
            this.fileGroupsListBox.Location = new System.Drawing.Point(12, 31);
            this.fileGroupsListBox.Name = "fileGroupsListBox";
            this.fileGroupsListBox.Size = new System.Drawing.Size(543, 395);
            this.fileGroupsListBox.TabIndex = 1;
            this.fileGroupsListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.fileGroupsListBox_ItemCheck);
            this.fileGroupsListBox.SelectedIndexChanged += new System.EventHandler(this.fileGroupsListBox_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "File groups:";
            // 
            // destinationFileWizardPage
            // 
            this.destinationFileWizardPage.Controls.Add(this.buttonDecorateSimpleAutomatically);
            this.destinationFileWizardPage.Controls.Add(this.multipleFilesGroupControl);
            this.destinationFileWizardPage.Controls.Add(this.destinationFileTextEdit);
            this.destinationFileWizardPage.Controls.Add(this.openFolderAfterGeneratingCheckEdit);
            this.destinationFileWizardPage.Controls.Add(this.openFileAfterGeneratingCheckEdit);
            this.destinationFileWizardPage.Controls.Add(this.buttonBrowse);
            this.destinationFileWizardPage.Controls.Add(this.labelControl6);
            this.destinationFileWizardPage.Controls.Add(this.labelControl1);
            this.destinationFileWizardPage.Name = "destinationFileWizardPage";
            this.destinationFileWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.destinationFileWizardPage.Size = new System.Drawing.Size(567, 472);
            this.destinationFileWizardPage.Text = "Specify export files";
            // 
            // buttonDecorateSimpleAutomatically
            // 
            this.buttonDecorateSimpleAutomatically.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecorateSimpleAutomatically.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonDecorateSimpleAutomatically.Appearance.Options.UseFont = true;
            this.buttonDecorateSimpleAutomatically.Location = new System.Drawing.Point(400, 77);
            this.buttonDecorateSimpleAutomatically.Name = "buttonDecorateSimpleAutomatically";
            this.buttonDecorateSimpleAutomatically.Size = new System.Drawing.Size(75, 28);
            this.buttonDecorateSimpleAutomatically.TabIndex = 2;
            this.buttonDecorateSimpleAutomatically.Text = "Suggest";
            this.buttonDecorateSimpleAutomatically.WantDrawFocusRectangle = true;
            this.buttonDecorateSimpleAutomatically.Click += new System.EventHandler(this.buttonDecorateSimpleAutomatically_Click);
            // 
            // multipleFilesGroupControl
            // 
            this.multipleFilesGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multipleFilesGroupControl.Controls.Add(this.buttonDecorateAutomatically);
            this.multipleFilesGroupControl.Controls.Add(this.labelControl9);
            this.multipleFilesGroupControl.HasPadding = true;
            this.multipleFilesGroupControl.Location = new System.Drawing.Point(12, 273);
            this.multipleFilesGroupControl.Name = "multipleFilesGroupControl";
            this.multipleFilesGroupControl.Size = new System.Drawing.Size(543, 187);
            this.multipleFilesGroupControl.TabIndex = 8;
            this.multipleFilesGroupControl.Text = "Placeholders";
            // 
            // buttonDecorateAutomatically
            // 
            this.buttonDecorateAutomatically.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecorateAutomatically.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonDecorateAutomatically.Appearance.Options.UseFont = true;
            this.buttonDecorateAutomatically.Location = new System.Drawing.Point(454, 145);
            this.buttonDecorateAutomatically.Name = "buttonDecorateAutomatically";
            this.buttonDecorateAutomatically.Size = new System.Drawing.Size(75, 28);
            this.buttonDecorateAutomatically.TabIndex = 1;
            this.buttonDecorateAutomatically.Text = "Suggest";
            this.buttonDecorateAutomatically.WantDrawFocusRectangle = true;
            this.buttonDecorateAutomatically.Click += new System.EventHandler(this.buttonDecorateAutomatically_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl9.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(14, 34);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(515, 139);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = resources.GetString("labelControl9.Text");
            // 
            // destinationFileTextEdit
            // 
            this.destinationFileTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationFileTextEdit.CueText = null;
            this.destinationFileTextEdit.Location = new System.Drawing.Point(12, 31);
            this.destinationFileTextEdit.MenuManager = this.barManager;
            this.destinationFileTextEdit.Name = "destinationFileTextEdit";
            this.destinationFileTextEdit.Properties.AcceptsReturn = false;
            this.destinationFileTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.destinationFileTextEdit.Properties.Appearance.Options.UseFont = true;
            this.destinationFileTextEdit.Properties.NullValuePrompt = null;
            this.destinationFileTextEdit.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.destinationFileTextEdit.Size = new System.Drawing.Size(543, 40);
            this.destinationFileTextEdit.TabIndex = 1;
            this.destinationFileTextEdit.EditValueChanged += new System.EventHandler(this.destinationFileTextEdit_EditValueChanged);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this.errorOccurredWizardPage;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.detailedErrorsButton});
            this.barManager.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(9, 9);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(549, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(9, 463);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(549, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(9, 9);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(558, 9);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
            // 
            // errorOccurredWizardPage
            // 
            this.errorOccurredWizardPage.AllowNext = false;
            this.errorOccurredWizardPage.Controls.Add(this.optionsButton);
            this.errorOccurredWizardPage.Controls.Add(this.errorTextMemoEdit);
            this.errorOccurredWizardPage.Controls.Add(this.barDockControlLeft);
            this.errorOccurredWizardPage.Controls.Add(this.barDockControlRight);
            this.errorOccurredWizardPage.Controls.Add(this.barDockControlBottom);
            this.errorOccurredWizardPage.Controls.Add(this.barDockControlTop);
            this.errorOccurredWizardPage.Name = "errorOccurredWizardPage";
            this.errorOccurredWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.errorOccurredWizardPage.Size = new System.Drawing.Size(567, 472);
            this.errorOccurredWizardPage.Text = "An error has occurred";
            // 
            // optionsButton
            // 
            this.optionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.optionsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.optionsButton.Appearance.Options.UseFont = true;
            this.optionsButton.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.optionsButton.DropDownControl = this.optionsPopupMenu;
            this.optionsButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("optionsButton.ImageOptions.Image")));
            this.optionsButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.optionsButton.Location = new System.Drawing.Point(15, 429);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 28);
            this.optionsButton.TabIndex = 2;
            this.optionsButton.Text = "&Options";
            // 
            // optionsPopupMenu
            // 
            this.optionsPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.detailedErrorsButton)});
            this.optionsPopupMenu.Manager = this.barManager;
            this.optionsPopupMenu.Name = "optionsPopupMenu";
            this.optionsPopupMenu.BeforePopup += new System.ComponentModel.CancelEventHandler(this.optionsPopupMenu_BeforePopup);
            // 
            // detailedErrorsButton
            // 
            this.detailedErrorsButton.Caption = "Details";
            this.detailedErrorsButton.Id = 0;
            this.detailedErrorsButton.ImageOptions.ImageIndex = 1;
            this.detailedErrorsButton.Name = "detailedErrorsButton";
            this.detailedErrorsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.detailedErrorsButton_ItemClick);
            // 
            // errorTextMemoEdit
            // 
            this.errorTextMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorTextMemoEdit.CueText = null;
            this.errorTextMemoEdit.Location = new System.Drawing.Point(15, 15);
            this.errorTextMemoEdit.Name = "errorTextMemoEdit";
            this.errorTextMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.errorTextMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.errorTextMemoEdit.Properties.NullValuePrompt = null;
            this.errorTextMemoEdit.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.errorTextMemoEdit.Size = new System.Drawing.Size(537, 408);
            this.errorTextMemoEdit.TabIndex = 1;
            // 
            // openFolderAfterGeneratingCheckEdit
            // 
            this.openFolderAfterGeneratingCheckEdit.Location = new System.Drawing.Point(12, 137);
            this.openFolderAfterGeneratingCheckEdit.Name = "openFolderAfterGeneratingCheckEdit";
            this.openFolderAfterGeneratingCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.openFolderAfterGeneratingCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.openFolderAfterGeneratingCheckEdit.Properties.AutoHeight = false;
            this.openFolderAfterGeneratingCheckEdit.Properties.AutoWidth = true;
            this.openFolderAfterGeneratingCheckEdit.Properties.Caption = "Open containing folder(s) after exporting";
            this.openFolderAfterGeneratingCheckEdit.Size = new System.Drawing.Size(263, 19);
            this.openFolderAfterGeneratingCheckEdit.TabIndex = 6;
            // 
            // openFileAfterGeneratingCheckEdit
            // 
            this.openFileAfterGeneratingCheckEdit.EditValue = true;
            this.openFileAfterGeneratingCheckEdit.Location = new System.Drawing.Point(12, 112);
            this.openFileAfterGeneratingCheckEdit.Name = "openFileAfterGeneratingCheckEdit";
            this.openFileAfterGeneratingCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.openFileAfterGeneratingCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.openFileAfterGeneratingCheckEdit.Properties.AutoHeight = false;
            this.openFileAfterGeneratingCheckEdit.Properties.AutoWidth = true;
            this.openFileAfterGeneratingCheckEdit.Properties.Caption = "Open file(s) after exporting";
            this.openFileAfterGeneratingCheckEdit.Size = new System.Drawing.Size(181, 19);
            this.openFileAfterGeneratingCheckEdit.TabIndex = 5;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonBrowse.Appearance.Options.UseFont = true;
            this.buttonBrowse.Location = new System.Drawing.Point(480, 77);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 28);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.WantDrawFocusRectangle = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Enabled = false;
            this.labelControl6.Location = new System.Drawing.Point(12, 77);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(164, 17);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "(Will be overwritten if exists)";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(276, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Microsoft Office Excel document to export into:";
            // 
            // languagesWizardPage
            // 
            this.languagesWizardPage.Controls.Add(this.label3);
            this.languagesWizardPage.Controls.Add(this.referenceLanguageGroupBox);
            this.languagesWizardPage.Controls.Add(this.label2);
            this.languagesWizardPage.Controls.Add(this.selectAllLanguagesToExportButton);
            this.languagesWizardPage.Controls.Add(this.invertLanguagesToExportButton);
            this.languagesWizardPage.Controls.Add(this.selectNoLanguagesToExportButton);
            this.languagesWizardPage.Controls.Add(this.languagesToExportCheckListBox);
            this.languagesWizardPage.Name = "languagesWizardPage";
            this.languagesWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.languagesWizardPage.Size = new System.Drawing.Size(567, 472);
            this.languagesWizardPage.Text = "Specify languages to export";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "L&anguages to export:";
            // 
            // referenceLanguageGroupBox
            // 
            this.referenceLanguageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.referenceLanguageGroupBox.CueText = null;
            this.referenceLanguageGroupBox.Location = new System.Drawing.Point(12, 31);
            this.referenceLanguageGroupBox.Name = "referenceLanguageGroupBox";
            this.referenceLanguageGroupBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.referenceLanguageGroupBox.Properties.Appearance.Options.UseFont = true;
            this.referenceLanguageGroupBox.Properties.AutoHeight = false;
            this.referenceLanguageGroupBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.referenceLanguageGroupBox.Properties.DropDownRows = 20;
            this.referenceLanguageGroupBox.Properties.NullValuePrompt = null;
            this.referenceLanguageGroupBox.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.referenceLanguageGroupBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.referenceLanguageGroupBox.Properties.SelectedIndexChanged += new System.EventHandler(this.referenceLanguageGroupBox_SelectedIndexChanged);
            this.referenceLanguageGroupBox.Size = new System.Drawing.Size(543, 24);
            this.referenceLanguageGroupBox.TabIndex = 1;
            this.referenceLanguageGroupBox.SelectedIndexChanged += new System.EventHandler(this.referenceLanguageGroupBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Reference language:";
            // 
            // selectAllLanguagesToExportButton
            // 
            this.selectAllLanguagesToExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllLanguagesToExportButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectAllLanguagesToExportButton.Appearance.Options.UseFont = true;
            this.selectAllLanguagesToExportButton.Location = new System.Drawing.Point(12, 432);
            this.selectAllLanguagesToExportButton.Name = "selectAllLanguagesToExportButton";
            this.selectAllLanguagesToExportButton.Size = new System.Drawing.Size(75, 28);
            this.selectAllLanguagesToExportButton.TabIndex = 4;
            this.selectAllLanguagesToExportButton.Text = "All";
            this.selectAllLanguagesToExportButton.WantDrawFocusRectangle = true;
            this.selectAllLanguagesToExportButton.Click += new System.EventHandler(this.selectAllLanguagesToExportButton_Click);
            // 
            // invertLanguagesToExportButton
            // 
            this.invertLanguagesToExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invertLanguagesToExportButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invertLanguagesToExportButton.Appearance.Options.UseFont = true;
            this.invertLanguagesToExportButton.Location = new System.Drawing.Point(174, 432);
            this.invertLanguagesToExportButton.Name = "invertLanguagesToExportButton";
            this.invertLanguagesToExportButton.Size = new System.Drawing.Size(75, 28);
            this.invertLanguagesToExportButton.TabIndex = 6;
            this.invertLanguagesToExportButton.Text = "Flip";
            this.invertLanguagesToExportButton.WantDrawFocusRectangle = true;
            this.invertLanguagesToExportButton.Click += new System.EventHandler(this.invertLanguagesToExportButton_Click);
            // 
            // selectNoLanguagesToExportButton
            // 
            this.selectNoLanguagesToExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectNoLanguagesToExportButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectNoLanguagesToExportButton.Appearance.Options.UseFont = true;
            this.selectNoLanguagesToExportButton.Location = new System.Drawing.Point(93, 432);
            this.selectNoLanguagesToExportButton.Name = "selectNoLanguagesToExportButton";
            this.selectNoLanguagesToExportButton.Size = new System.Drawing.Size(75, 28);
            this.selectNoLanguagesToExportButton.TabIndex = 5;
            this.selectNoLanguagesToExportButton.Text = "None";
            this.selectNoLanguagesToExportButton.WantDrawFocusRectangle = true;
            this.selectNoLanguagesToExportButton.Click += new System.EventHandler(this.selectNoLanguagesToExportButton_Click);
            // 
            // languagesToExportCheckListBox
            // 
            this.languagesToExportCheckListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesToExportCheckListBox.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.languagesToExportCheckListBox.Appearance.Options.UseFont = true;
            this.languagesToExportCheckListBox.CheckOnClick = true;
            this.languagesToExportCheckListBox.Location = new System.Drawing.Point(12, 86);
            this.languagesToExportCheckListBox.Name = "languagesToExportCheckListBox";
            this.languagesToExportCheckListBox.Size = new System.Drawing.Size(543, 340);
            this.languagesToExportCheckListBox.TabIndex = 3;
            this.languagesToExportCheckListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.languagesToExportCheckListBox_ItemCheck);
            this.languagesToExportCheckListBox.SelectedIndexChanged += new System.EventHandler(this.languagesToExportCheckListBox_SelectedIndexChanged);
            // 
            // optionsWizardPage
            // 
            this.optionsWizardPage.Controls.Add(this.buttonResetOptions);
            this.optionsWizardPage.Controls.Add(this.exportEachLanguageIntoSeparateExcelFileCheckEdit);
            this.optionsWizardPage.Controls.Add(this.exportGroupsAsOneWorkSheetCheckEdit);
            this.optionsWizardPage.Controls.Add(this.labelControl7);
            this.optionsWizardPage.Controls.Add(this.exportGroupsAsExcelFilesCheckEdit);
            this.optionsWizardPage.Controls.Add(this.exportGroupsAsWorkSheetsCheckEdit);
            this.optionsWizardPage.Name = "optionsWizardPage";
            this.optionsWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.optionsWizardPage.Size = new System.Drawing.Size(567, 472);
            this.optionsWizardPage.Text = "Specify export options";
            // 
            // buttonResetOptions
            // 
            this.buttonResetOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetOptions.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonResetOptions.Appearance.Options.UseFont = true;
            this.buttonResetOptions.Location = new System.Drawing.Point(405, 432);
            this.buttonResetOptions.Name = "buttonResetOptions";
            this.buttonResetOptions.Size = new System.Drawing.Size(150, 28);
            this.buttonResetOptions.TabIndex = 8;
            this.buttonResetOptions.Text = "Reset to default values";
            this.buttonResetOptions.WantDrawFocusRectangle = true;
            this.buttonResetOptions.Click += new System.EventHandler(this.buttonResetOptions_Click);
            // 
            // exportEachLanguageIntoSeparateExcelFileCheckEdit
            // 
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Location = new System.Drawing.Point(12, 123);
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Name = "exportEachLanguageIntoSeparateExcelFileCheckEdit";
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.AutoHeight = false;
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.AutoWidth = true;
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.Caption = "Export each language into a separate Excel file";
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Size = new System.Drawing.Size(296, 19);
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.TabIndex = 4;
            this.exportEachLanguageIntoSeparateExcelFileCheckEdit.CheckedChanged += new System.EventHandler(this.exportEachLanguageIntoSeparateExcelFileCheckEdit_CheckedChanged);
            // 
            // exportGroupsAsOneWorkSheetCheckEdit
            // 
            this.exportGroupsAsOneWorkSheetCheckEdit.EditValue = true;
            this.exportGroupsAsOneWorkSheetCheckEdit.Location = new System.Drawing.Point(28, 35);
            this.exportGroupsAsOneWorkSheetCheckEdit.Name = "exportGroupsAsOneWorkSheetCheckEdit";
            this.exportGroupsAsOneWorkSheetCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportGroupsAsOneWorkSheetCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportGroupsAsOneWorkSheetCheckEdit.Properties.AutoHeight = false;
            this.exportGroupsAsOneWorkSheetCheckEdit.Properties.AutoWidth = true;
            this.exportGroupsAsOneWorkSheetCheckEdit.Properties.Caption = "Export all file groups together into one work sheet";
            this.exportGroupsAsOneWorkSheetCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.exportGroupsAsOneWorkSheetCheckEdit.Properties.RadioGroupIndex = 0;
            this.exportGroupsAsOneWorkSheetCheckEdit.Size = new System.Drawing.Size(318, 19);
            this.exportGroupsAsOneWorkSheetCheckEdit.TabIndex = 1;
            this.exportGroupsAsOneWorkSheetCheckEdit.CheckedChanged += new System.EventHandler(this.exportGroupsAsOneWorkSheetCheckEdit_CheckedChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl7.Location = new System.Drawing.Point(12, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(149, 17);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Excel document structure:";
            // 
            // exportGroupsAsExcelFilesCheckEdit
            // 
            this.exportGroupsAsExcelFilesCheckEdit.Location = new System.Drawing.Point(28, 85);
            this.exportGroupsAsExcelFilesCheckEdit.Name = "exportGroupsAsExcelFilesCheckEdit";
            this.exportGroupsAsExcelFilesCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportGroupsAsExcelFilesCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportGroupsAsExcelFilesCheckEdit.Properties.AutoHeight = false;
            this.exportGroupsAsExcelFilesCheckEdit.Properties.AutoWidth = true;
            this.exportGroupsAsExcelFilesCheckEdit.Properties.Caption = "Export each file group into a separate Excel document";
            this.exportGroupsAsExcelFilesCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.exportGroupsAsExcelFilesCheckEdit.Properties.RadioGroupIndex = 0;
            this.exportGroupsAsExcelFilesCheckEdit.Size = new System.Drawing.Size(340, 19);
            this.exportGroupsAsExcelFilesCheckEdit.TabIndex = 3;
            this.exportGroupsAsExcelFilesCheckEdit.TabStop = false;
            this.exportGroupsAsExcelFilesCheckEdit.CheckedChanged += new System.EventHandler(this.exportGroupsAsExcelFilesCheckEdit_CheckedChanged);
            // 
            // exportGroupsAsWorkSheetsCheckEdit
            // 
            this.exportGroupsAsWorkSheetsCheckEdit.Location = new System.Drawing.Point(28, 60);
            this.exportGroupsAsWorkSheetsCheckEdit.MenuManager = this.barManager;
            this.exportGroupsAsWorkSheetsCheckEdit.Name = "exportGroupsAsWorkSheetsCheckEdit";
            this.exportGroupsAsWorkSheetsCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportGroupsAsWorkSheetsCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportGroupsAsWorkSheetsCheckEdit.Properties.AutoHeight = false;
            this.exportGroupsAsWorkSheetsCheckEdit.Properties.AutoWidth = true;
            this.exportGroupsAsWorkSheetsCheckEdit.Properties.Caption = "Export each file group into a separate work sheet";
            this.exportGroupsAsWorkSheetsCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.exportGroupsAsWorkSheetsCheckEdit.Properties.RadioGroupIndex = 0;
            this.exportGroupsAsWorkSheetsCheckEdit.Size = new System.Drawing.Size(312, 19);
            this.exportGroupsAsWorkSheetsCheckEdit.TabIndex = 2;
            this.exportGroupsAsWorkSheetsCheckEdit.TabStop = false;
            this.exportGroupsAsWorkSheetsCheckEdit.CheckedChanged += new System.EventHandler(this.exportGroupsAsWorkSheetsCheckEdit_CheckedChanged);
            // 
            // progressWizardPage
            // 
            this.progressWizardPage.AllowBack = false;
            this.progressWizardPage.AllowNext = false;
            this.progressWizardPage.Controls.Add(this.progressBarControl);
            this.progressWizardPage.Controls.Add(this.progressLabel);
            this.progressWizardPage.Name = "progressWizardPage";
            this.progressWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.progressWizardPage.Size = new System.Drawing.Size(567, 472);
            this.progressWizardPage.Text = "Data is being exported. Please wait...";
            // 
            // progressBarControl
            // 
            this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(12, 12);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(543, 18);
            this.progressBarControl.TabIndex = 0;
            // 
            // progressLabel
            // 
            this.progressLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.progressLabel.Appearance.Options.UseFont = true;
            this.progressLabel.Location = new System.Drawing.Point(12, 36);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(179, 17);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "<Progress information, if any>";
            this.progressLabel.Visible = false;
            // 
            // successWizardPage
            // 
            this.successWizardPage.AllowBack = false;
            this.successWizardPage.AllowCancel = false;
            this.successWizardPage.AllowNext = false;
            this.successWizardPage.Controls.Add(this.pleaseWaitFinishLabel);
            this.successWizardPage.Controls.Add(this.pictureBox2);
            this.successWizardPage.Controls.Add(this.warningTextLabel);
            this.successWizardPage.Controls.Add(this.labelControl5);
            this.successWizardPage.Name = "successWizardPage";
            this.successWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.successWizardPage.Size = new System.Drawing.Size(567, 472);
            this.successWizardPage.Text = "Export finished successfully";
            // 
            // pleaseWaitFinishLabel
            // 
            this.pleaseWaitFinishLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pleaseWaitFinishLabel.Appearance.Options.UseFont = true;
            this.pleaseWaitFinishLabel.Appearance.Options.UseTextOptions = true;
            this.pleaseWaitFinishLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.pleaseWaitFinishLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.pleaseWaitFinishLabel.Location = new System.Drawing.Point(75, 60);
            this.pleaseWaitFinishLabel.Name = "pleaseWaitFinishLabel";
            this.pleaseWaitFinishLabel.Size = new System.Drawing.Size(229, 17);
            this.pleaseWaitFinishLabel.TabIndex = 9;
            this.pleaseWaitFinishLabel.Text = "Folder/file will be opened. Please wait...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // warningTextLabel
            // 
            this.warningTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warningTextLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.warningTextLabel.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.warningTextLabel.Appearance.Options.UseFont = true;
            this.warningTextLabel.Appearance.Options.UseForeColor = true;
            this.warningTextLabel.Appearance.Options.UseTextOptions = true;
            this.warningTextLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.warningTextLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.warningTextLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.warningTextLabel.Location = new System.Drawing.Point(75, 91);
            this.warningTextLabel.Name = "warningTextLabel";
            this.warningTextLabel.Size = new System.Drawing.Size(480, 369);
            this.warningTextLabel.TabIndex = 0;
            this.warningTextLabel.Text = "<WARNING TEXT, IF ANY>";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(75, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(480, 36);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Your data was successfully exported to the Microsoft Office Excel document you sp" +
    "ecified.";
            // 
            // advancedOptionsWizardPage
            // 
            this.advancedOptionsWizardPage.Controls.Add(this.buttonResetAdvancedOptions);
            this.advancedOptionsWizardPage.Controls.Add(this.advancedOptionsPanel);
            this.advancedOptionsWizardPage.Controls.Add(this.labelControl8);
            this.advancedOptionsWizardPage.Controls.Add(this.btnConnectionStringExpander);
            this.advancedOptionsWizardPage.Name = "advancedOptionsWizardPage";
            this.advancedOptionsWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.advancedOptionsWizardPage.Size = new System.Drawing.Size(567, 472);
            this.advancedOptionsWizardPage.Text = "Advanced options";
            // 
            // buttonResetAdvancedOptions
            // 
            this.buttonResetAdvancedOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetAdvancedOptions.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonResetAdvancedOptions.Appearance.Options.UseFont = true;
            this.buttonResetAdvancedOptions.Location = new System.Drawing.Point(405, 432);
            this.buttonResetAdvancedOptions.Name = "buttonResetAdvancedOptions";
            this.buttonResetAdvancedOptions.Size = new System.Drawing.Size(150, 28);
            this.buttonResetAdvancedOptions.TabIndex = 3;
            this.buttonResetAdvancedOptions.Text = "Reset to default values";
            this.buttonResetAdvancedOptions.WantDrawFocusRectangle = true;
            this.buttonResetAdvancedOptions.Click += new System.EventHandler(this.buttonResetAdvancedOptions_Click);
            // 
            // advancedOptionsPanel
            // 
            this.advancedOptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedOptionsPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.advancedOptionsPanel.Appearance.Options.UseBackColor = true;
            this.advancedOptionsPanel.Controls.Add(this.useCrypticExcelExportSheetNamesCheckEdit);
            this.advancedOptionsPanel.Controls.Add(this.exportFileGroupColumnCheckEdit);
            this.advancedOptionsPanel.Controls.Add(this.exportReferenceLanguageColumnCheckEdit);
            this.advancedOptionsPanel.Controls.Add(this.exportCommentColumnCheckEdit);
            this.advancedOptionsPanel.Controls.Add(this.exportNameColumnCheckEdit);
            this.advancedOptionsPanel.Controls.Add(this.eliminateDuplicateRowsCheckEdit);
            this.advancedOptionsPanel.Controls.Add(this.exportOnlyRowsWithChangedTextsCheckEdit);
            this.advancedOptionsPanel.Controls.Add(this.exportCompletelyEmptyRowsCheckEdit);
            this.advancedOptionsPanel.Controls.Add(this.exportWithoutDestinationTranslationOnlyCheckEdit);
            this.advancedOptionsPanel.Controls.Add(this.labelControl4);
            this.advancedOptionsPanel.Location = new System.Drawing.Point(12, 37);
            this.advancedOptionsPanel.Name = "advancedOptionsPanel";
            this.advancedOptionsPanel.Padding = new System.Windows.Forms.Padding(9);
            this.advancedOptionsPanel.Size = new System.Drawing.Size(543, 305);
            this.advancedOptionsPanel.TabIndex = 2;
            this.advancedOptionsPanel.Visible = false;
            // 
            // useCrypticExcelExportSheetNamesCheckEdit
            // 
            this.useCrypticExcelExportSheetNamesCheckEdit.Location = new System.Drawing.Point(14, 139);
            this.useCrypticExcelExportSheetNamesCheckEdit.Name = "useCrypticExcelExportSheetNamesCheckEdit";
            this.useCrypticExcelExportSheetNamesCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.useCrypticExcelExportSheetNamesCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.useCrypticExcelExportSheetNamesCheckEdit.Properties.AutoHeight = false;
            this.useCrypticExcelExportSheetNamesCheckEdit.Properties.AutoWidth = true;
            this.useCrypticExcelExportSheetNamesCheckEdit.Properties.Caption = "Use unique (but cryptic) Microsoft Office Excel sheet names";
            this.useCrypticExcelExportSheetNamesCheckEdit.Size = new System.Drawing.Size(369, 19);
            this.useCrypticExcelExportSheetNamesCheckEdit.TabIndex = 5;
            this.useCrypticExcelExportSheetNamesCheckEdit.CheckedChanged += new System.EventHandler(this.useCrypticExcelExportSheetNamesCheckEdit_CheckedChanged);
            // 
            // exportFileGroupColumnCheckEdit
            // 
            this.exportFileGroupColumnCheckEdit.EditValue = true;
            this.exportFileGroupColumnCheckEdit.Location = new System.Drawing.Point(14, 14);
            this.exportFileGroupColumnCheckEdit.Name = "exportFileGroupColumnCheckEdit";
            this.exportFileGroupColumnCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportFileGroupColumnCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportFileGroupColumnCheckEdit.Properties.AutoHeight = false;
            this.exportFileGroupColumnCheckEdit.Properties.AutoWidth = true;
            this.exportFileGroupColumnCheckEdit.Properties.Caption = "Export file group column";
            this.exportFileGroupColumnCheckEdit.Size = new System.Drawing.Size(168, 19);
            this.exportFileGroupColumnCheckEdit.TabIndex = 0;
            this.exportFileGroupColumnCheckEdit.CheckedChanged += new System.EventHandler(this.exportFileGroupColumnCheckEdit_CheckedChanged);
            // 
            // exportReferenceLanguageColumnCheckEdit
            // 
            this.exportReferenceLanguageColumnCheckEdit.Location = new System.Drawing.Point(14, 89);
            this.exportReferenceLanguageColumnCheckEdit.Name = "exportReferenceLanguageColumnCheckEdit";
            this.exportReferenceLanguageColumnCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportReferenceLanguageColumnCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportReferenceLanguageColumnCheckEdit.Properties.AutoHeight = false;
            this.exportReferenceLanguageColumnCheckEdit.Properties.AutoWidth = true;
            this.exportReferenceLanguageColumnCheckEdit.Properties.Caption = "Export reference language column";
            this.exportReferenceLanguageColumnCheckEdit.Size = new System.Drawing.Size(224, 19);
            this.exportReferenceLanguageColumnCheckEdit.TabIndex = 3;
            this.exportReferenceLanguageColumnCheckEdit.CheckedChanged += new System.EventHandler(this.exportReferenceLanguageColumnCheckEdit_CheckedChanged);
            // 
            // exportCommentColumnCheckEdit
            // 
            this.exportCommentColumnCheckEdit.Location = new System.Drawing.Point(14, 64);
            this.exportCommentColumnCheckEdit.Name = "exportCommentColumnCheckEdit";
            this.exportCommentColumnCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportCommentColumnCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportCommentColumnCheckEdit.Properties.AutoHeight = false;
            this.exportCommentColumnCheckEdit.Properties.AutoWidth = true;
            this.exportCommentColumnCheckEdit.Properties.Caption = "Export comment column";
            this.exportCommentColumnCheckEdit.Size = new System.Drawing.Size(165, 19);
            this.exportCommentColumnCheckEdit.TabIndex = 2;
            this.exportCommentColumnCheckEdit.CheckedChanged += new System.EventHandler(this.exportCommentColumnCheckEdit_CheckedChanged);
            // 
            // exportNameColumnCheckEdit
            // 
            this.exportNameColumnCheckEdit.EditValue = true;
            this.exportNameColumnCheckEdit.Location = new System.Drawing.Point(14, 39);
            this.exportNameColumnCheckEdit.Name = "exportNameColumnCheckEdit";
            this.exportNameColumnCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportNameColumnCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportNameColumnCheckEdit.Properties.AutoHeight = false;
            this.exportNameColumnCheckEdit.Properties.AutoWidth = true;
            this.exportNameColumnCheckEdit.Properties.Caption = "Export name column";
            this.exportNameColumnCheckEdit.Size = new System.Drawing.Size(143, 19);
            this.exportNameColumnCheckEdit.TabIndex = 1;
            this.exportNameColumnCheckEdit.CheckedChanged += new System.EventHandler(this.exportNameColumnCheckEdit_CheckedChanged);
            // 
            // eliminateDuplicateRowsCheckEdit
            // 
            this.eliminateDuplicateRowsCheckEdit.EditValue = true;
            this.eliminateDuplicateRowsCheckEdit.Location = new System.Drawing.Point(14, 114);
            this.eliminateDuplicateRowsCheckEdit.Name = "eliminateDuplicateRowsCheckEdit";
            this.eliminateDuplicateRowsCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eliminateDuplicateRowsCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.eliminateDuplicateRowsCheckEdit.Properties.AutoHeight = false;
            this.eliminateDuplicateRowsCheckEdit.Properties.AutoWidth = true;
            this.eliminateDuplicateRowsCheckEdit.Properties.Caption = "Eliminate duplicate rows";
            this.eliminateDuplicateRowsCheckEdit.Size = new System.Drawing.Size(164, 19);
            this.eliminateDuplicateRowsCheckEdit.TabIndex = 4;
            this.eliminateDuplicateRowsCheckEdit.CheckedChanged += new System.EventHandler(this.eliminateDuplicateRowsCheckEdit_CheckedChanged);
            // 
            // exportOnlyRowsWithChangedTextsCheckEdit
            // 
            this.exportOnlyRowsWithChangedTextsCheckEdit.EditValue = true;
            this.exportOnlyRowsWithChangedTextsCheckEdit.Location = new System.Drawing.Point(14, 228);
            this.exportOnlyRowsWithChangedTextsCheckEdit.Name = "exportOnlyRowsWithChangedTextsCheckEdit";
            this.exportOnlyRowsWithChangedTextsCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportOnlyRowsWithChangedTextsCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportOnlyRowsWithChangedTextsCheckEdit.Properties.AutoHeight = false;
            this.exportOnlyRowsWithChangedTextsCheckEdit.Properties.AutoWidth = true;
            this.exportOnlyRowsWithChangedTextsCheckEdit.Properties.Caption = "Export only texts that were modified (in the reference language) since the last e" +
    "xport";
            this.exportOnlyRowsWithChangedTextsCheckEdit.Size = new System.Drawing.Size(516, 19);
            this.exportOnlyRowsWithChangedTextsCheckEdit.TabIndex = 8;
            this.exportOnlyRowsWithChangedTextsCheckEdit.CheckedChanged += new System.EventHandler(this.exportOnlyRowsWithChangedTextsCheckEdit_CheckedChanged);
            // 
            // exportCompletelyEmptyRowsCheckEdit
            // 
            this.exportCompletelyEmptyRowsCheckEdit.EditValue = true;
            this.exportCompletelyEmptyRowsCheckEdit.Location = new System.Drawing.Point(14, 203);
            this.exportCompletelyEmptyRowsCheckEdit.Name = "exportCompletelyEmptyRowsCheckEdit";
            this.exportCompletelyEmptyRowsCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportCompletelyEmptyRowsCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportCompletelyEmptyRowsCheckEdit.Properties.AutoHeight = false;
            this.exportCompletelyEmptyRowsCheckEdit.Properties.AutoWidth = true;
            this.exportCompletelyEmptyRowsCheckEdit.Properties.Caption = "Export rows that are currently completely empty";
            this.exportCompletelyEmptyRowsCheckEdit.Size = new System.Drawing.Size(303, 19);
            this.exportCompletelyEmptyRowsCheckEdit.TabIndex = 7;
            this.exportCompletelyEmptyRowsCheckEdit.CheckedChanged += new System.EventHandler(this.exportWithoutDestinationTranslationOnlyCheckEdit_CheckedChanged);
            // 
            // exportWithoutDestinationTranslationOnlyCheckEdit
            // 
            this.exportWithoutDestinationTranslationOnlyCheckEdit.EditValue = true;
            this.exportWithoutDestinationTranslationOnlyCheckEdit.Location = new System.Drawing.Point(14, 178);
            this.exportWithoutDestinationTranslationOnlyCheckEdit.Name = "exportWithoutDestinationTranslationOnlyCheckEdit";
            this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties.AutoHeight = false;
            this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties.AutoWidth = true;
            this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties.Caption = "Export only rows with no existing translation";
            this.exportWithoutDestinationTranslationOnlyCheckEdit.Size = new System.Drawing.Size(280, 19);
            this.exportWithoutDestinationTranslationOnlyCheckEdit.TabIndex = 6;
            this.exportWithoutDestinationTranslationOnlyCheckEdit.CheckedChanged += new System.EventHandler(this.exportWithoutDestinationTranslationOnlyCheckEdit_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl4.Enabled = false;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(34, 253);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(495, 39);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "(This may result in an empty or no document at all, if all languages are already " +
    "translated)";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(36, 14);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(105, 17);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Advanced options";
            this.labelControl8.Click += new System.EventHandler(this.btnConnectionStringExpander_Click);
            // 
            // btnConnectionStringExpander
            // 
            this.btnConnectionStringExpander.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnConnectionStringExpander.Appearance.Options.UseFont = true;
            this.btnConnectionStringExpander.Location = new System.Drawing.Point(12, 12);
            this.btnConnectionStringExpander.Name = "btnConnectionStringExpander";
            this.btnConnectionStringExpander.Size = new System.Drawing.Size(18, 18);
            this.btnConnectionStringExpander.TabIndex = 0;
            this.btnConnectionStringExpander.Text = "+";
            this.btnConnectionStringExpander.WantDrawFocusRectangle = true;
            this.btnConnectionStringExpander.Click += new System.EventHandler(this.btnConnectionStringExpander_Click);
            // 
            // progressBackgroundWorker
            // 
            this.progressBackgroundWorker.WorkerReportsProgress = true;
            this.progressBackgroundWorker.WorkerSupportsCancellation = true;
            this.progressBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.progressBackgroundWorker_DoWork);
            this.progressBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.progressBackgroundWorker_ProgressChanged);
            this.progressBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.progressBackgroundWorker_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Appearance.Options.UseBackColor = true;
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel1.Controls.Add(this.wizardControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 601);
            this.panel1.TabIndex = 3;
            // 
            // ExcelExportWizardForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(611, 601);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(613, 633);
            this.Name = "ExcelExportWizardForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export data to Microsoft Excel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exportWizard_FormClosing);
            this.Load += new System.EventHandler(this.exportWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.wizardControl.ResumeLayout(false);
            this.fileGroupSelectionWizardPage.ResumeLayout(false);
            this.fileGroupSelectionWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupsListBox)).EndInit();
            this.destinationFileWizardPage.ResumeLayout(false);
            this.destinationFileWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multipleFilesGroupControl)).EndInit();
            this.multipleFilesGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinationFileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.errorOccurredWizardPage.ResumeLayout(false);
            this.errorOccurredWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTextMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderAfterGeneratingCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileAfterGeneratingCheckEdit.Properties)).EndInit();
            this.languagesWizardPage.ResumeLayout(false);
            this.languagesWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceLanguageGroupBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesToExportCheckListBox)).EndInit();
            this.optionsWizardPage.ResumeLayout(false);
            this.optionsWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGroupsAsOneWorkSheetCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGroupsAsExcelFilesCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGroupsAsWorkSheetsCheckEdit.Properties)).EndInit();
            this.progressWizardPage.ResumeLayout(false);
            this.progressWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.successWizardPage.ResumeLayout(false);
            this.successWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.advancedOptionsWizardPage.ResumeLayout(false);
            this.advancedOptionsWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedOptionsPanel)).EndInit();
            this.advancedOptionsPanel.ResumeLayout(false);
            this.advancedOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useCrypticExcelExportSheetNamesCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFileGroupColumnCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportReferenceLanguageColumnCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportCommentColumnCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportNameColumnCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminateDuplicateRowsCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportOnlyRowsWithChangedTextsCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportCompletelyEmptyRowsCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomWizard.NoHeaderWizardControl wizardControl;
		private DevExpress.XtraWizard.WelcomeWizardPage fileGroupSelectionWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl fileGroupsListBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private DevExpress.XtraWizard.WizardPage destinationFileWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonBrowse;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private DevExpress.XtraWizard.WizardPage languagesWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl languagesToExportCheckListBox;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit referenceLanguageGroupBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label3;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit openFolderAfterGeneratingCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit openFileAfterGeneratingCheckEdit;
		private DevExpress.XtraWizard.WizardPage optionsWizardPage;
		private DevExpress.XtraWizard.WizardPage progressWizardPage;
		private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
		private System.ComponentModel.BackgroundWorker progressBackgroundWorker;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl progressLabel;
		private DevExpress.XtraWizard.WizardPage errorOccurredWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton optionsButton;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private DevExpress.XtraBars.BarButtonItem detailedErrorsButton;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit errorTextMemoEdit;
		private DevExpress.XtraWizard.CompletionWizardPage successWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit destinationFileTextEdit;
		private System.Windows.Forms.PictureBox pictureBox2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl5;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl6;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportGroupsAsOneWorkSheetCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportGroupsAsWorkSheetsCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl7;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl pleaseWaitFinishLabel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonResetOptions;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportGroupsAsExcelFilesCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportEachLanguageIntoSeparateExcelFileCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl multipleFilesGroupControl;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl9;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonDecorateAutomatically;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonDecorateSimpleAutomatically;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl warningTextLabel;
		private DevExpress.XtraWizard.WizardPage advancedOptionsWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonResetAdvancedOptions;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl advancedOptionsPanel;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useCrypticExcelExportSheetNamesCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportFileGroupColumnCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportReferenceLanguageColumnCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportCommentColumnCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportNameColumnCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit eliminateDuplicateRowsCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportOnlyRowsWithChangedTextsCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportWithoutDestinationTranslationOnlyCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl8;
		protected ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton btnConnectionStringExpander;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportCompletelyEmptyRowsCheckEdit;
        private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panel1;
    }
}