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
			this.wizardControl = new DevExpress.XtraWizard.WizardControl();
			this.fileGroupSelectionWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
			this.invertFileGroupsButton = new DevExpress.XtraEditors.SimpleButton();
			this.selectNoFileGroupsButton = new DevExpress.XtraEditors.SimpleButton();
			this.selectAllFileGroupsButton = new DevExpress.XtraEditors.SimpleButton();
			this.fileGroupsListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.destinationFileWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.buttonDecorateSimpleAutomatically = new DevExpress.XtraEditors.SimpleButton();
			this.multipleFilesGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.buttonDecorateAutomatically = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.destinationFileTextEdit = new DevExpress.XtraEditors.MemoEdit();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.errorOccurredWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.optionsButton = new DevExpress.XtraEditors.DropDownButton();
			this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.detailedErrorsButton = new DevExpress.XtraBars.BarButtonItem();
			this.errorTextMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.openFolderAfterGeneratingCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.openFileAfterGeneratingCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.buttonBrowse = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.languagesWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.label3 = new DevExpress.XtraEditors.LabelControl();
			this.referenceLanguageGroupBox = new DevExpress.XtraEditors.ComboBoxEdit();
			this.label2 = new DevExpress.XtraEditors.LabelControl();
			this.selectAllLanguagesToExportButton = new DevExpress.XtraEditors.SimpleButton();
			this.invertLanguagesToExportButton = new DevExpress.XtraEditors.SimpleButton();
			this.selectNoLanguagesToExportButton = new DevExpress.XtraEditors.SimpleButton();
			this.languagesToExportCheckListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.optionsWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.buttonResetOptions = new DevExpress.XtraEditors.SimpleButton();
			this.exportEachLanguageIntoSeparateExcelFileCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportGroupsAsOneWorkSheetCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.exportGroupsAsExcelFilesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportGroupsAsWorkSheetsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.progressWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
			this.progressLabel = new DevExpress.XtraEditors.LabelControl();
			this.successWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
			this.pleaseWaitFinishLabel = new DevExpress.XtraEditors.LabelControl();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.warningTextLabel = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.advancedOptionsWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.buttonResetAdvancedOptions = new DevExpress.XtraEditors.SimpleButton();
			this.advancedOptionsPanel = new DevExpress.XtraEditors.PanelControl();
			this.useCrypticExcelExportSheetNamesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportFileGroupColumnCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportReferenceLanguageColumnCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportCommentColumnCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportNameColumnCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.eliminateDuplicateRowsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportOnlyRowsWithChangedTextsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportCompletelyEmptyRowsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportWithoutDestinationTranslationOnlyCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.btnConnectionStringExpander = new DevExpress.XtraEditors.SimpleButton();
			this.sendWithZetaUploaderWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.buttonZulReset = new DevExpress.XtraEditors.SimpleButton();
			this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.zulBodyTextEdit = new DevExpress.XtraEditors.MemoEdit();
			this.zulSubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.zulReceiversTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.sendFilesToEMailReceiversCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.progressBackgroundWorker = new System.ComponentModel.BackgroundWorker();
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.sendWithZetaUploaderWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zulBodyTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zulSubjectTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zulReceiversTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sendFilesToEMailReceiversCheckEdit.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// wizardControl
			// 
			this.wizardControl.Controls.Add(this.fileGroupSelectionWizardPage);
			this.wizardControl.Controls.Add(this.destinationFileWizardPage);
			this.wizardControl.Controls.Add(this.languagesWizardPage);
			this.wizardControl.Controls.Add(this.optionsWizardPage);
			this.wizardControl.Controls.Add(this.progressWizardPage);
			this.wizardControl.Controls.Add(this.errorOccurredWizardPage);
			this.wizardControl.Controls.Add(this.successWizardPage);
			this.wizardControl.Controls.Add(this.advancedOptionsWizardPage);
			this.wizardControl.Controls.Add(this.sendWithZetaUploaderWizardPage);
			resources.ApplyResources(this.wizardControl, "wizardControl");
			this.wizardControl.Name = "wizardControl";
			this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.fileGroupSelectionWizardPage,
            this.languagesWizardPage,
            this.optionsWizardPage,
            this.advancedOptionsWizardPage,
            this.destinationFileWizardPage,
            this.sendWithZetaUploaderWizardPage,
            this.progressWizardPage,
            this.errorOccurredWizardPage,
            this.successWizardPage});
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
			resources.ApplyResources(this.fileGroupSelectionWizardPage, "fileGroupSelectionWizardPage");
			// 
			// invertFileGroupsButton
			// 
			resources.ApplyResources(this.invertFileGroupsButton, "invertFileGroupsButton");
			this.invertFileGroupsButton.Name = "invertFileGroupsButton";
			this.invertFileGroupsButton.Click += new System.EventHandler(this.invertFileGroupsButton_Click);
			// 
			// selectNoFileGroupsButton
			// 
			resources.ApplyResources(this.selectNoFileGroupsButton, "selectNoFileGroupsButton");
			this.selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
			this.selectNoFileGroupsButton.Click += new System.EventHandler(this.selectNoFileGroupsButton_Click);
			// 
			// selectAllFileGroupsButton
			// 
			resources.ApplyResources(this.selectAllFileGroupsButton, "selectAllFileGroupsButton");
			this.selectAllFileGroupsButton.Name = "selectAllFileGroupsButton";
			this.selectAllFileGroupsButton.Click += new System.EventHandler(this.selectAllFileGroupsButton_Click);
			// 
			// fileGroupsListBox
			// 
			resources.ApplyResources(this.fileGroupsListBox, "fileGroupsListBox");
			this.fileGroupsListBox.CheckOnClick = true;
			this.fileGroupsListBox.Name = "fileGroupsListBox";
			this.fileGroupsListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.fileGroupsListBox_ItemCheck);
			this.fileGroupsListBox.SelectedIndexChanged += new System.EventHandler(this.fileGroupsListBox_SelectedIndexChanged);
			// 
			// labelControl2
			// 
			resources.ApplyResources(this.labelControl2, "labelControl2");
			this.labelControl2.Name = "labelControl2";
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
			resources.ApplyResources(this.destinationFileWizardPage, "destinationFileWizardPage");
			// 
			// buttonDecorateSimpleAutomatically
			// 
			resources.ApplyResources(this.buttonDecorateSimpleAutomatically, "buttonDecorateSimpleAutomatically");
			this.buttonDecorateSimpleAutomatically.Name = "buttonDecorateSimpleAutomatically";
			this.buttonDecorateSimpleAutomatically.Click += new System.EventHandler(this.buttonDecorateSimpleAutomatically_Click);
			// 
			// multipleFilesGroupControl
			// 
			resources.ApplyResources(this.multipleFilesGroupControl, "multipleFilesGroupControl");
			this.multipleFilesGroupControl.Controls.Add(this.buttonDecorateAutomatically);
			this.multipleFilesGroupControl.Controls.Add(this.labelControl9);
			this.multipleFilesGroupControl.Name = "multipleFilesGroupControl";
			// 
			// buttonDecorateAutomatically
			// 
			resources.ApplyResources(this.buttonDecorateAutomatically, "buttonDecorateAutomatically");
			this.buttonDecorateAutomatically.Name = "buttonDecorateAutomatically";
			this.buttonDecorateAutomatically.Click += new System.EventHandler(this.buttonDecorateAutomatically_Click);
			// 
			// labelControl9
			// 
			resources.ApplyResources(this.labelControl9, "labelControl9");
			this.labelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl9.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl9.Name = "labelControl9";
			// 
			// destinationFileTextEdit
			// 
			resources.ApplyResources(this.destinationFileTextEdit, "destinationFileTextEdit");
			this.destinationFileTextEdit.MenuManager = this.barManager;
			this.destinationFileTextEdit.Name = "destinationFileTextEdit";
			this.destinationFileTextEdit.Properties.AcceptsReturn = false;
			this.destinationFileTextEdit.Properties.NullValuePrompt = resources.GetString("destinationFileTextEdit.Properties.NullValuePrompt");
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
			resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
			// 
			// errorOccurredWizardPage
			// 
			this.errorOccurredWizardPage.AllowNext = false;
			this.errorOccurredWizardPage.Controls.Add(this.pictureBox1);
			this.errorOccurredWizardPage.Controls.Add(this.labelControl3);
			this.errorOccurredWizardPage.Controls.Add(this.optionsButton);
			this.errorOccurredWizardPage.Controls.Add(this.errorTextMemoEdit);
			this.errorOccurredWizardPage.Controls.Add(this.barDockControlLeft);
			this.errorOccurredWizardPage.Controls.Add(this.barDockControlRight);
			this.errorOccurredWizardPage.Controls.Add(this.barDockControlBottom);
			this.errorOccurredWizardPage.Controls.Add(this.barDockControlTop);
			this.errorOccurredWizardPage.Name = "errorOccurredWizardPage";
			resources.ApplyResources(this.errorOccurredWizardPage, "errorOccurredWizardPage");
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// labelControl3
			// 
			resources.ApplyResources(this.labelControl3, "labelControl3");
			this.labelControl3.Name = "labelControl3";
			// 
			// optionsButton
			// 
			resources.ApplyResources(this.optionsButton, "optionsButton");
			this.optionsButton.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("optionsButton.Appearance.Font")));
			this.optionsButton.Appearance.Options.UseFont = true;
			this.optionsButton.DropDownControl = this.optionsPopupMenu;
			this.optionsButton.Image = ((System.Drawing.Image)(resources.GetObject("optionsButton.Image")));
			this.optionsButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
			this.optionsButton.Name = "optionsButton";
			this.optionsButton.ShowArrowButton = false;
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
			resources.ApplyResources(this.detailedErrorsButton, "detailedErrorsButton");
			this.detailedErrorsButton.Id = 0;
			this.detailedErrorsButton.ImageIndex = 1;
			this.detailedErrorsButton.Name = "detailedErrorsButton";
			this.detailedErrorsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.detailedErrorsButton_ItemClick);
			// 
			// errorTextMemoEdit
			// 
			resources.ApplyResources(this.errorTextMemoEdit, "errorTextMemoEdit");
			this.errorTextMemoEdit.Name = "errorTextMemoEdit";
			this.errorTextMemoEdit.Properties.NullValuePrompt = resources.GetString("errorTextMemoEdit.Properties.NullValuePrompt");
			// 
			// openFolderAfterGeneratingCheckEdit
			// 
			resources.ApplyResources(this.openFolderAfterGeneratingCheckEdit, "openFolderAfterGeneratingCheckEdit");
			this.openFolderAfterGeneratingCheckEdit.Name = "openFolderAfterGeneratingCheckEdit";
			this.openFolderAfterGeneratingCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("openFolderAfterGeneratingCheckEdit.Properties.AutoHeight")));
			this.openFolderAfterGeneratingCheckEdit.Properties.AutoWidth = true;
			this.openFolderAfterGeneratingCheckEdit.Properties.Caption = resources.GetString("openFolderAfterGeneratingCheckEdit.Properties.Caption");
			// 
			// openFileAfterGeneratingCheckEdit
			// 
			resources.ApplyResources(this.openFileAfterGeneratingCheckEdit, "openFileAfterGeneratingCheckEdit");
			this.openFileAfterGeneratingCheckEdit.Name = "openFileAfterGeneratingCheckEdit";
			this.openFileAfterGeneratingCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("openFileAfterGeneratingCheckEdit.Properties.AutoHeight")));
			this.openFileAfterGeneratingCheckEdit.Properties.AutoWidth = true;
			this.openFileAfterGeneratingCheckEdit.Properties.Caption = resources.GetString("openFileAfterGeneratingCheckEdit.Properties.Caption");
			// 
			// buttonBrowse
			// 
			resources.ApplyResources(this.buttonBrowse, "buttonBrowse");
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl6.Appearance.ForeColor")));
			resources.ApplyResources(this.labelControl6, "labelControl6");
			this.labelControl6.Name = "labelControl6";
			// 
			// labelControl1
			// 
			resources.ApplyResources(this.labelControl1, "labelControl1");
			this.labelControl1.Name = "labelControl1";
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
			resources.ApplyResources(this.languagesWizardPage, "languagesWizardPage");
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// referenceLanguageGroupBox
			// 
			resources.ApplyResources(this.referenceLanguageGroupBox, "referenceLanguageGroupBox");
			this.referenceLanguageGroupBox.Name = "referenceLanguageGroupBox";
			this.referenceLanguageGroupBox.Properties.AutoHeight = ((bool)(resources.GetObject("referenceLanguageGroupBox.Properties.AutoHeight")));
			this.referenceLanguageGroupBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("referenceLanguageGroupBox.Properties.Buttons"))))});
			this.referenceLanguageGroupBox.Properties.DropDownRows = 20;
			this.referenceLanguageGroupBox.Properties.NullValuePrompt = resources.GetString("referenceLanguageGroupBox.Properties.NullValuePrompt");
			this.referenceLanguageGroupBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.referenceLanguageGroupBox.Properties.SelectedIndexChanged += new System.EventHandler(this.referenceLanguageGroupBox_SelectedIndexChanged);
			this.referenceLanguageGroupBox.SelectedIndexChanged += new System.EventHandler(this.referenceLanguageGroupBox_SelectedIndexChanged);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// selectAllLanguagesToExportButton
			// 
			resources.ApplyResources(this.selectAllLanguagesToExportButton, "selectAllLanguagesToExportButton");
			this.selectAllLanguagesToExportButton.Name = "selectAllLanguagesToExportButton";
			this.selectAllLanguagesToExportButton.Click += new System.EventHandler(this.selectAllLanguagesToExportButton_Click);
			// 
			// invertLanguagesToExportButton
			// 
			resources.ApplyResources(this.invertLanguagesToExportButton, "invertLanguagesToExportButton");
			this.invertLanguagesToExportButton.Name = "invertLanguagesToExportButton";
			this.invertLanguagesToExportButton.Click += new System.EventHandler(this.invertLanguagesToExportButton_Click);
			// 
			// selectNoLanguagesToExportButton
			// 
			resources.ApplyResources(this.selectNoLanguagesToExportButton, "selectNoLanguagesToExportButton");
			this.selectNoLanguagesToExportButton.Name = "selectNoLanguagesToExportButton";
			this.selectNoLanguagesToExportButton.Click += new System.EventHandler(this.selectNoLanguagesToExportButton_Click);
			// 
			// languagesToExportCheckListBox
			// 
			resources.ApplyResources(this.languagesToExportCheckListBox, "languagesToExportCheckListBox");
			this.languagesToExportCheckListBox.CheckOnClick = true;
			this.languagesToExportCheckListBox.Name = "languagesToExportCheckListBox";
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
			resources.ApplyResources(this.optionsWizardPage, "optionsWizardPage");
			// 
			// buttonResetOptions
			// 
			resources.ApplyResources(this.buttonResetOptions, "buttonResetOptions");
			this.buttonResetOptions.Name = "buttonResetOptions";
			this.buttonResetOptions.Click += new System.EventHandler(this.buttonResetOptions_Click);
			// 
			// exportEachLanguageIntoSeparateExcelFileCheckEdit
			// 
			resources.ApplyResources(this.exportEachLanguageIntoSeparateExcelFileCheckEdit, "exportEachLanguageIntoSeparateExcelFileCheckEdit");
			this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Name = "exportEachLanguageIntoSeparateExcelFileCheckEdit";
			this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.AutoHeight")));
			this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.AutoWidth = true;
			this.exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.Caption = resources.GetString("exportEachLanguageIntoSeparateExcelFileCheckEdit.Properties.Caption");
			this.exportEachLanguageIntoSeparateExcelFileCheckEdit.CheckedChanged += new System.EventHandler(this.exportEachLanguageIntoSeparateExcelFileCheckEdit_CheckedChanged);
			// 
			// exportGroupsAsOneWorkSheetCheckEdit
			// 
			resources.ApplyResources(this.exportGroupsAsOneWorkSheetCheckEdit, "exportGroupsAsOneWorkSheetCheckEdit");
			this.exportGroupsAsOneWorkSheetCheckEdit.Name = "exportGroupsAsOneWorkSheetCheckEdit";
			this.exportGroupsAsOneWorkSheetCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportGroupsAsOneWorkSheetCheckEdit.Properties.AutoHeight")));
			this.exportGroupsAsOneWorkSheetCheckEdit.Properties.AutoWidth = true;
			this.exportGroupsAsOneWorkSheetCheckEdit.Properties.Caption = resources.GetString("exportGroupsAsOneWorkSheetCheckEdit.Properties.Caption");
			this.exportGroupsAsOneWorkSheetCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.exportGroupsAsOneWorkSheetCheckEdit.Properties.RadioGroupIndex = 0;
			this.exportGroupsAsOneWorkSheetCheckEdit.CheckedChanged += new System.EventHandler(this.exportGroupsAsOneWorkSheetCheckEdit_CheckedChanged);
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			resources.ApplyResources(this.labelControl7, "labelControl7");
			this.labelControl7.Name = "labelControl7";
			// 
			// exportGroupsAsExcelFilesCheckEdit
			// 
			resources.ApplyResources(this.exportGroupsAsExcelFilesCheckEdit, "exportGroupsAsExcelFilesCheckEdit");
			this.exportGroupsAsExcelFilesCheckEdit.Name = "exportGroupsAsExcelFilesCheckEdit";
			this.exportGroupsAsExcelFilesCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportGroupsAsExcelFilesCheckEdit.Properties.AutoHeight")));
			this.exportGroupsAsExcelFilesCheckEdit.Properties.AutoWidth = true;
			this.exportGroupsAsExcelFilesCheckEdit.Properties.Caption = resources.GetString("exportGroupsAsExcelFilesCheckEdit.Properties.Caption");
			this.exportGroupsAsExcelFilesCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.exportGroupsAsExcelFilesCheckEdit.Properties.RadioGroupIndex = 0;
			this.exportGroupsAsExcelFilesCheckEdit.TabStop = false;
			this.exportGroupsAsExcelFilesCheckEdit.CheckedChanged += new System.EventHandler(this.exportGroupsAsExcelFilesCheckEdit_CheckedChanged);
			// 
			// exportGroupsAsWorkSheetsCheckEdit
			// 
			resources.ApplyResources(this.exportGroupsAsWorkSheetsCheckEdit, "exportGroupsAsWorkSheetsCheckEdit");
			this.exportGroupsAsWorkSheetsCheckEdit.MenuManager = this.barManager;
			this.exportGroupsAsWorkSheetsCheckEdit.Name = "exportGroupsAsWorkSheetsCheckEdit";
			this.exportGroupsAsWorkSheetsCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportGroupsAsWorkSheetsCheckEdit.Properties.AutoHeight")));
			this.exportGroupsAsWorkSheetsCheckEdit.Properties.AutoWidth = true;
			this.exportGroupsAsWorkSheetsCheckEdit.Properties.Caption = resources.GetString("exportGroupsAsWorkSheetsCheckEdit.Properties.Caption");
			this.exportGroupsAsWorkSheetsCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.exportGroupsAsWorkSheetsCheckEdit.Properties.RadioGroupIndex = 0;
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
			resources.ApplyResources(this.progressWizardPage, "progressWizardPage");
			// 
			// progressBarControl
			// 
			resources.ApplyResources(this.progressBarControl, "progressBarControl");
			this.progressBarControl.Name = "progressBarControl";
			// 
			// progressLabel
			// 
			resources.ApplyResources(this.progressLabel, "progressLabel");
			this.progressLabel.Name = "progressLabel";
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
			resources.ApplyResources(this.successWizardPage, "successWizardPage");
			// 
			// pleaseWaitFinishLabel
			// 
			this.pleaseWaitFinishLabel.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("pleaseWaitFinishLabel.Appearance.Font")));
			this.pleaseWaitFinishLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.pleaseWaitFinishLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			resources.ApplyResources(this.pleaseWaitFinishLabel, "pleaseWaitFinishLabel");
			this.pleaseWaitFinishLabel.Name = "pleaseWaitFinishLabel";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.pictureBox2, "pictureBox2");
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.TabStop = false;
			// 
			// warningTextLabel
			// 
			resources.ApplyResources(this.warningTextLabel, "warningTextLabel");
			this.warningTextLabel.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("warningTextLabel.Appearance.ForeColor")));
			this.warningTextLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.warningTextLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.warningTextLabel.Name = "warningTextLabel";
			// 
			// labelControl5
			// 
			resources.ApplyResources(this.labelControl5, "labelControl5");
			this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl5.Name = "labelControl5";
			// 
			// advancedOptionsWizardPage
			// 
			this.advancedOptionsWizardPage.Controls.Add(this.buttonResetAdvancedOptions);
			this.advancedOptionsWizardPage.Controls.Add(this.advancedOptionsPanel);
			this.advancedOptionsWizardPage.Controls.Add(this.labelControl8);
			this.advancedOptionsWizardPage.Controls.Add(this.btnConnectionStringExpander);
			this.advancedOptionsWizardPage.Name = "advancedOptionsWizardPage";
			resources.ApplyResources(this.advancedOptionsWizardPage, "advancedOptionsWizardPage");
			// 
			// buttonResetAdvancedOptions
			// 
			resources.ApplyResources(this.buttonResetAdvancedOptions, "buttonResetAdvancedOptions");
			this.buttonResetAdvancedOptions.Name = "buttonResetAdvancedOptions";
			this.buttonResetAdvancedOptions.Click += new System.EventHandler(this.buttonResetAdvancedOptions_Click);
			// 
			// advancedOptionsPanel
			// 
			resources.ApplyResources(this.advancedOptionsPanel, "advancedOptionsPanel");
			this.advancedOptionsPanel.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("advancedOptionsPanel.Appearance.BackColor")));
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
			this.advancedOptionsPanel.Name = "advancedOptionsPanel";
			// 
			// useCrypticExcelExportSheetNamesCheckEdit
			// 
			resources.ApplyResources(this.useCrypticExcelExportSheetNamesCheckEdit, "useCrypticExcelExportSheetNamesCheckEdit");
			this.useCrypticExcelExportSheetNamesCheckEdit.Name = "useCrypticExcelExportSheetNamesCheckEdit";
			this.useCrypticExcelExportSheetNamesCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("useCrypticExcelExportSheetNamesCheckEdit.Properties.AutoHeight")));
			this.useCrypticExcelExportSheetNamesCheckEdit.Properties.AutoWidth = true;
			this.useCrypticExcelExportSheetNamesCheckEdit.Properties.Caption = resources.GetString("useCrypticExcelExportSheetNamesCheckEdit.Properties.Caption");
			this.useCrypticExcelExportSheetNamesCheckEdit.CheckedChanged += new System.EventHandler(this.useCrypticExcelExportSheetNamesCheckEdit_CheckedChanged);
			// 
			// exportFileGroupColumnCheckEdit
			// 
			resources.ApplyResources(this.exportFileGroupColumnCheckEdit, "exportFileGroupColumnCheckEdit");
			this.exportFileGroupColumnCheckEdit.Name = "exportFileGroupColumnCheckEdit";
			this.exportFileGroupColumnCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportFileGroupColumnCheckEdit.Properties.AutoHeight")));
			this.exportFileGroupColumnCheckEdit.Properties.AutoWidth = true;
			this.exportFileGroupColumnCheckEdit.Properties.Caption = resources.GetString("exportFileGroupColumnCheckEdit.Properties.Caption");
			this.exportFileGroupColumnCheckEdit.CheckedChanged += new System.EventHandler(this.exportFileGroupColumnCheckEdit_CheckedChanged);
			// 
			// exportReferenceLanguageColumnCheckEdit
			// 
			resources.ApplyResources(this.exportReferenceLanguageColumnCheckEdit, "exportReferenceLanguageColumnCheckEdit");
			this.exportReferenceLanguageColumnCheckEdit.Name = "exportReferenceLanguageColumnCheckEdit";
			this.exportReferenceLanguageColumnCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportReferenceLanguageColumnCheckEdit.Properties.AutoHeight")));
			this.exportReferenceLanguageColumnCheckEdit.Properties.AutoWidth = true;
			this.exportReferenceLanguageColumnCheckEdit.Properties.Caption = resources.GetString("exportReferenceLanguageColumnCheckEdit.Properties.Caption");
			this.exportReferenceLanguageColumnCheckEdit.CheckedChanged += new System.EventHandler(this.exportReferenceLanguageColumnCheckEdit_CheckedChanged);
			// 
			// exportCommentColumnCheckEdit
			// 
			resources.ApplyResources(this.exportCommentColumnCheckEdit, "exportCommentColumnCheckEdit");
			this.exportCommentColumnCheckEdit.Name = "exportCommentColumnCheckEdit";
			this.exportCommentColumnCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportCommentColumnCheckEdit.Properties.AutoHeight")));
			this.exportCommentColumnCheckEdit.Properties.AutoWidth = true;
			this.exportCommentColumnCheckEdit.Properties.Caption = resources.GetString("exportCommentColumnCheckEdit.Properties.Caption");
			this.exportCommentColumnCheckEdit.CheckedChanged += new System.EventHandler(this.exportCommentColumnCheckEdit_CheckedChanged);
			// 
			// exportNameColumnCheckEdit
			// 
			resources.ApplyResources(this.exportNameColumnCheckEdit, "exportNameColumnCheckEdit");
			this.exportNameColumnCheckEdit.Name = "exportNameColumnCheckEdit";
			this.exportNameColumnCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportNameColumnCheckEdit.Properties.AutoHeight")));
			this.exportNameColumnCheckEdit.Properties.AutoWidth = true;
			this.exportNameColumnCheckEdit.Properties.Caption = resources.GetString("exportNameColumnCheckEdit.Properties.Caption");
			this.exportNameColumnCheckEdit.CheckedChanged += new System.EventHandler(this.exportNameColumnCheckEdit_CheckedChanged);
			// 
			// eliminateDuplicateRowsCheckEdit
			// 
			resources.ApplyResources(this.eliminateDuplicateRowsCheckEdit, "eliminateDuplicateRowsCheckEdit");
			this.eliminateDuplicateRowsCheckEdit.Name = "eliminateDuplicateRowsCheckEdit";
			this.eliminateDuplicateRowsCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("eliminateDuplicateRowsCheckEdit.Properties.AutoHeight")));
			this.eliminateDuplicateRowsCheckEdit.Properties.AutoWidth = true;
			this.eliminateDuplicateRowsCheckEdit.Properties.Caption = resources.GetString("eliminateDuplicateRowsCheckEdit.Properties.Caption");
			this.eliminateDuplicateRowsCheckEdit.CheckedChanged += new System.EventHandler(this.eliminateDuplicateRowsCheckEdit_CheckedChanged);
			// 
			// exportOnlyRowsWithChangedTextsCheckEdit
			// 
			resources.ApplyResources(this.exportOnlyRowsWithChangedTextsCheckEdit, "exportOnlyRowsWithChangedTextsCheckEdit");
			this.exportOnlyRowsWithChangedTextsCheckEdit.Name = "exportOnlyRowsWithChangedTextsCheckEdit";
			this.exportOnlyRowsWithChangedTextsCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportOnlyRowsWithChangedTextsCheckEdit.Properties.AutoHeight")));
			this.exportOnlyRowsWithChangedTextsCheckEdit.Properties.AutoWidth = true;
			this.exportOnlyRowsWithChangedTextsCheckEdit.Properties.Caption = resources.GetString("exportOnlyRowsWithChangedTextsCheckEdit.Properties.Caption");
			this.exportOnlyRowsWithChangedTextsCheckEdit.CheckedChanged += new System.EventHandler(this.exportOnlyRowsWithChangedTextsCheckEdit_CheckedChanged);
			// 
			// exportCompletelyEmptyRowsCheckEdit
			// 
			resources.ApplyResources(this.exportCompletelyEmptyRowsCheckEdit, "exportCompletelyEmptyRowsCheckEdit");
			this.exportCompletelyEmptyRowsCheckEdit.Name = "exportCompletelyEmptyRowsCheckEdit";
			this.exportCompletelyEmptyRowsCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportCompletelyEmptyRowsCheckEdit.Properties.AutoHeight")));
			this.exportCompletelyEmptyRowsCheckEdit.Properties.AutoWidth = true;
			this.exportCompletelyEmptyRowsCheckEdit.Properties.Caption = resources.GetString("exportCompletelyEmptyRowsCheckEdit.Properties.Caption");
			this.exportCompletelyEmptyRowsCheckEdit.CheckedChanged += new System.EventHandler(this.exportWithoutDestinationTranslationOnlyCheckEdit_CheckedChanged);
			// 
			// exportWithoutDestinationTranslationOnlyCheckEdit
			// 
			resources.ApplyResources(this.exportWithoutDestinationTranslationOnlyCheckEdit, "exportWithoutDestinationTranslationOnlyCheckEdit");
			this.exportWithoutDestinationTranslationOnlyCheckEdit.Name = "exportWithoutDestinationTranslationOnlyCheckEdit";
			this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportWithoutDestinationTranslationOnlyCheckEdit.Properties.AutoHeight")));
			this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties.AutoWidth = true;
			this.exportWithoutDestinationTranslationOnlyCheckEdit.Properties.Caption = resources.GetString("exportWithoutDestinationTranslationOnlyCheckEdit.Properties.Caption");
			this.exportWithoutDestinationTranslationOnlyCheckEdit.CheckedChanged += new System.EventHandler(this.exportWithoutDestinationTranslationOnlyCheckEdit_CheckedChanged);
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl4.Appearance.ForeColor")));
			this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			resources.ApplyResources(this.labelControl4, "labelControl4");
			this.labelControl4.Name = "labelControl4";
			// 
			// labelControl8
			// 
			resources.ApplyResources(this.labelControl8, "labelControl8");
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Click += new System.EventHandler(this.btnConnectionStringExpander_Click);
			// 
			// btnConnectionStringExpander
			// 
			this.btnConnectionStringExpander.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnConnectionStringExpander.Appearance.Font")));
			this.btnConnectionStringExpander.Appearance.Options.UseFont = true;
			resources.ApplyResources(this.btnConnectionStringExpander, "btnConnectionStringExpander");
			this.btnConnectionStringExpander.Name = "btnConnectionStringExpander";
			this.btnConnectionStringExpander.Click += new System.EventHandler(this.btnConnectionStringExpander_Click);
			// 
			// sendWithZetaUploaderWizardPage
			// 
			this.sendWithZetaUploaderWizardPage.Controls.Add(this.buttonZulReset);
			this.sendWithZetaUploaderWizardPage.Controls.Add(this.hyperLinkEdit1);
			this.sendWithZetaUploaderWizardPage.Controls.Add(this.labelControl10);
			this.sendWithZetaUploaderWizardPage.Controls.Add(this.zulBodyTextEdit);
			this.sendWithZetaUploaderWizardPage.Controls.Add(this.zulSubjectTextEdit);
			this.sendWithZetaUploaderWizardPage.Controls.Add(this.zulReceiversTextEdit);
			this.sendWithZetaUploaderWizardPage.Controls.Add(this.sendFilesToEMailReceiversCheckEdit);
			this.sendWithZetaUploaderWizardPage.Name = "sendWithZetaUploaderWizardPage";
			resources.ApplyResources(this.sendWithZetaUploaderWizardPage, "sendWithZetaUploaderWizardPage");
			// 
			// buttonZulReset
			// 
			resources.ApplyResources(this.buttonZulReset, "buttonZulReset");
			this.buttonZulReset.Name = "buttonZulReset";
			this.buttonZulReset.Click += new System.EventHandler(this.buttonZulReset_Click);
			// 
			// hyperLinkEdit1
			// 
			resources.ApplyResources(this.hyperLinkEdit1, "hyperLinkEdit1");
			this.hyperLinkEdit1.MenuManager = this.barManager;
			this.hyperLinkEdit1.Name = "hyperLinkEdit1";
			this.hyperLinkEdit1.Properties.AllowFocused = false;
			this.hyperLinkEdit1.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("hyperLinkEdit1.Properties.Appearance.BackColor")));
			this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.hyperLinkEdit1.TabStop = false;
			this.hyperLinkEdit1.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hyperLinkEdit1_OpenLink);
			// 
			// labelControl10
			// 
			resources.ApplyResources(this.labelControl10, "labelControl10");
			this.labelControl10.Name = "labelControl10";
			// 
			// zulBodyTextEdit
			// 
			resources.ApplyResources(this.zulBodyTextEdit, "zulBodyTextEdit");
			this.zulBodyTextEdit.MenuManager = this.barManager;
			this.zulBodyTextEdit.Name = "zulBodyTextEdit";
			// 
			// zulSubjectTextEdit
			// 
			resources.ApplyResources(this.zulSubjectTextEdit, "zulSubjectTextEdit");
			this.zulSubjectTextEdit.Name = "zulSubjectTextEdit";
			// 
			// zulReceiversTextEdit
			// 
			resources.ApplyResources(this.zulReceiversTextEdit, "zulReceiversTextEdit");
			this.zulReceiversTextEdit.MenuManager = this.barManager;
			this.zulReceiversTextEdit.Name = "zulReceiversTextEdit";
			this.zulReceiversTextEdit.EditValueChanged += new System.EventHandler(this.zulReceiversTextEdit_EditValueChanged);
			// 
			// sendFilesToEMailReceiversCheckEdit
			// 
			resources.ApplyResources(this.sendFilesToEMailReceiversCheckEdit, "sendFilesToEMailReceiversCheckEdit");
			this.sendFilesToEMailReceiversCheckEdit.Name = "sendFilesToEMailReceiversCheckEdit";
			this.sendFilesToEMailReceiversCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("sendFilesToEMailReceiversCheckEdit.Properties.AutoHeight")));
			this.sendFilesToEMailReceiversCheckEdit.Properties.AutoWidth = true;
			this.sendFilesToEMailReceiversCheckEdit.Properties.Caption = resources.GetString("sendFilesToEMailReceiversCheckEdit.Properties.Caption");
			this.sendFilesToEMailReceiversCheckEdit.CheckedChanged += new System.EventHandler(this.sendFilesToEMailReceiversCheckEdit_CheckedChanged);
			// 
			// progressBackgroundWorker
			// 
			this.progressBackgroundWorker.WorkerReportsProgress = true;
			this.progressBackgroundWorker.WorkerSupportsCancellation = true;
			this.progressBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.progressBackgroundWorker_DoWork);
			this.progressBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.progressBackgroundWorker_ProgressChanged);
			this.progressBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.progressBackgroundWorker_RunWorkerCompleted);
			// 
			// ExcelExportWizardForm
			// 
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ExcelExportWizardForm.Appearance.Font")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.wizardControl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExcelExportWizardForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
			this.sendWithZetaUploaderWizardPage.ResumeLayout(false);
			this.sendWithZetaUploaderWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zulBodyTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zulSubjectTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zulReceiversTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sendFilesToEMailReceiversCheckEdit.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraWizard.WizardControl wizardControl;
		private DevExpress.XtraWizard.WelcomeWizardPage fileGroupSelectionWizardPage;
		private DevExpress.XtraEditors.SimpleButton selectNoFileGroupsButton;
		private DevExpress.XtraEditors.SimpleButton selectAllFileGroupsButton;
		private DevExpress.XtraEditors.CheckedListBoxControl fileGroupsListBox;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraWizard.WizardPage destinationFileWizardPage;
		private DevExpress.XtraEditors.SimpleButton buttonBrowse;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraWizard.WizardPage languagesWizardPage;
		private DevExpress.XtraEditors.SimpleButton invertFileGroupsButton;
		private DevExpress.XtraEditors.SimpleButton selectAllLanguagesToExportButton;
		private DevExpress.XtraEditors.SimpleButton invertLanguagesToExportButton;
		private DevExpress.XtraEditors.SimpleButton selectNoLanguagesToExportButton;
		private DevExpress.XtraEditors.CheckedListBoxControl languagesToExportCheckListBox;
		private DevExpress.XtraEditors.ComboBoxEdit referenceLanguageGroupBox;
		private DevExpress.XtraEditors.LabelControl label2;
		private DevExpress.XtraEditors.LabelControl label3;
		private DevExpress.XtraEditors.CheckEdit openFolderAfterGeneratingCheckEdit;
		private DevExpress.XtraEditors.CheckEdit openFileAfterGeneratingCheckEdit;
		private DevExpress.XtraWizard.WizardPage optionsWizardPage;
		private DevExpress.XtraWizard.WizardPage progressWizardPage;
		private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
		private System.ComponentModel.BackgroundWorker progressBackgroundWorker;
		private DevExpress.XtraEditors.LabelControl progressLabel;
		private DevExpress.XtraWizard.WizardPage errorOccurredWizardPage;
		private DevExpress.XtraEditors.DropDownButton optionsButton;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private DevExpress.XtraBars.BarButtonItem detailedErrorsButton;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraEditors.MemoEdit errorTextMemoEdit;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraWizard.CompletionWizardPage successWizardPage;
		private DevExpress.XtraEditors.MemoEdit destinationFileTextEdit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.CheckEdit exportGroupsAsOneWorkSheetCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportGroupsAsWorkSheetsCheckEdit;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl pleaseWaitFinishLabel;
		private DevExpress.XtraEditors.SimpleButton buttonResetOptions;
		private DevExpress.XtraEditors.CheckEdit exportGroupsAsExcelFilesCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportEachLanguageIntoSeparateExcelFileCheckEdit;
		private DevExpress.XtraEditors.GroupControl multipleFilesGroupControl;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.SimpleButton buttonDecorateAutomatically;
		private DevExpress.XtraEditors.SimpleButton buttonDecorateSimpleAutomatically;
		private DevExpress.XtraEditors.LabelControl warningTextLabel;
		private DevExpress.XtraWizard.WizardPage advancedOptionsWizardPage;
		private DevExpress.XtraEditors.SimpleButton buttonResetAdvancedOptions;
		private DevExpress.XtraEditors.PanelControl advancedOptionsPanel;
		private DevExpress.XtraEditors.CheckEdit useCrypticExcelExportSheetNamesCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportFileGroupColumnCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportReferenceLanguageColumnCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportCommentColumnCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportNameColumnCheckEdit;
		private DevExpress.XtraEditors.CheckEdit eliminateDuplicateRowsCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportOnlyRowsWithChangedTextsCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportWithoutDestinationTranslationOnlyCheckEdit;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		protected DevExpress.XtraEditors.SimpleButton btnConnectionStringExpander;
		private DevExpress.XtraWizard.WizardPage sendWithZetaUploaderWizardPage;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.MemoEdit zulBodyTextEdit;
		private DevExpress.XtraEditors.TextEdit zulSubjectTextEdit;
		private DevExpress.XtraEditors.TextEdit zulReceiversTextEdit;
		private DevExpress.XtraEditors.CheckEdit sendFilesToEMailReceiversCheckEdit;
		private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
		private DevExpress.XtraEditors.SimpleButton buttonZulReset;
		private DevExpress.XtraEditors.CheckEdit exportCompletelyEmptyRowsCheckEdit;
	}
}