namespace ZetaResourceEditor.UI.ExportImportExcel
{
	partial class ExcelImportWizardForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelImportWizardForm));
			this.wizardControl = new DevExpress.XtraWizard.WizardControl();
			this.importFileWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.cmdImportFormatInfo = new DevExpress.XtraEditors.SimpleButton();
			this.sourceFileTextEdit = new DevExpress.XtraEditors.MemoEdit();
			this.buttonOpen = new DevExpress.XtraEditors.SimpleButton();
			this.buttonBrowse = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.successWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.summaryAfterSuccessfulImportLabel = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.fileGroupsWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.invertFileGroupsButton = new DevExpress.XtraEditors.SimpleButton();
			this.selectNoFileGroupsButton = new DevExpress.XtraEditors.SimpleButton();
			this.selectAllFileGroupsButton = new DevExpress.XtraEditors.SimpleButton();
			this.fileGroupsListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.languagesWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.label3 = new DevExpress.XtraEditors.LabelControl();
			this.selectAllLanguagesToExportButton = new DevExpress.XtraEditors.SimpleButton();
			this.invertLanguagesToExportButton = new DevExpress.XtraEditors.SimpleButton();
			this.selectNoLanguagesToExportButton = new DevExpress.XtraEditors.SimpleButton();
			this.languagesToImportCheckListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.progressWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
			this.progressLabel = new DevExpress.XtraEditors.LabelControl();
			this.errorOccurredWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.optionsButton = new DevExpress.XtraEditors.DropDownButton();
			this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.detailedErrorsButton = new DevExpress.XtraBars.BarButtonItem();
			this.underylingExceptionButton = new DevExpress.XtraBars.BarButtonItem();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.errorTextMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.progressBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
			this.wizardControl.SuspendLayout();
			this.importFileWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sourceFileTextEdit.Properties)).BeginInit();
			this.successWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.fileGroupsWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileGroupsListBox)).BeginInit();
			this.languagesWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.languagesToImportCheckListBox)).BeginInit();
			this.progressWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
			this.errorOccurredWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorTextMemoEdit.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// wizardControl
			// 
			resources.ApplyResources(this.wizardControl, "wizardControl");
			this.wizardControl.Controls.Add(this.importFileWizardPage);
			this.wizardControl.Controls.Add(this.successWizardPage);
			this.wizardControl.Controls.Add(this.fileGroupsWizardPage);
			this.wizardControl.Controls.Add(this.languagesWizardPage);
			this.wizardControl.Controls.Add(this.progressWizardPage);
			this.wizardControl.Controls.Add(this.errorOccurredWizardPage);
			this.wizardControl.Name = "wizardControl";
			this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.importFileWizardPage,
            this.fileGroupsWizardPage,
            this.languagesWizardPage,
            this.progressWizardPage,
            this.errorOccurredWizardPage,
            this.successWizardPage});
			this.wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
			this.wizardControl.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl_SelectedPageChanged);
			this.wizardControl.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_CancelClick);
			this.wizardControl.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_FinishClick);
			this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
			this.wizardControl.PrevClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_PrevClick);
			// 
			// importFileWizardPage
			// 
			resources.ApplyResources(this.importFileWizardPage, "importFileWizardPage");
			this.importFileWizardPage.Controls.Add(this.labelControl7);
			this.importFileWizardPage.Controls.Add(this.cmdImportFormatInfo);
			this.importFileWizardPage.Controls.Add(this.sourceFileTextEdit);
			this.importFileWizardPage.Controls.Add(this.buttonOpen);
			this.importFileWizardPage.Controls.Add(this.buttonBrowse);
			this.importFileWizardPage.Controls.Add(this.labelControl2);
			this.importFileWizardPage.Controls.Add(this.barDockControlLeft);
			this.importFileWizardPage.Controls.Add(this.barDockControlRight);
			this.importFileWizardPage.Controls.Add(this.barDockControlBottom);
			this.importFileWizardPage.Controls.Add(this.barDockControlTop);
			this.importFileWizardPage.Name = "importFileWizardPage";
			// 
			// labelControl7
			// 
			resources.ApplyResources(this.labelControl7, "labelControl7");
			this.labelControl7.Appearance.DisabledImage = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.DisabledImage")));
			this.labelControl7.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl7.Appearance.ForeColor")));
			this.labelControl7.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("labelControl7.Appearance.GradientMode")));
			this.labelControl7.Appearance.HoverImage = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.HoverImage")));
			this.labelControl7.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.Image")));
			this.labelControl7.Appearance.PressedImage = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.PressedImage")));
			this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl7.Name = "labelControl7";
			// 
			// cmdImportFormatInfo
			// 
			resources.ApplyResources(this.cmdImportFormatInfo, "cmdImportFormatInfo");
			this.cmdImportFormatInfo.Name = "cmdImportFormatInfo";
			this.cmdImportFormatInfo.Click += new System.EventHandler(this.cmdImportFormatInfo_Click);
			// 
			// sourceFileTextEdit
			// 
			resources.ApplyResources(this.sourceFileTextEdit, "sourceFileTextEdit");
			this.sourceFileTextEdit.Name = "sourceFileTextEdit";
			this.sourceFileTextEdit.Properties.AcceptsReturn = false;
			this.sourceFileTextEdit.Properties.AccessibleDescription = resources.GetString("sourceFileTextEdit.Properties.AccessibleDescription");
			this.sourceFileTextEdit.Properties.AccessibleName = resources.GetString("sourceFileTextEdit.Properties.AccessibleName");
			this.sourceFileTextEdit.Properties.NullValuePrompt = resources.GetString("sourceFileTextEdit.Properties.NullValuePrompt");
			this.sourceFileTextEdit.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("sourceFileTextEdit.Properties.NullValuePromptShowForEmptyValue")));
			this.sourceFileTextEdit.EditValueChanged += new System.EventHandler(this.sourceFileTextEdit_EditValueChanged);
			// 
			// buttonOpen
			// 
			resources.ApplyResources(this.buttonOpen, "buttonOpen");
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// buttonBrowse
			// 
			resources.ApplyResources(this.buttonBrowse, "buttonBrowse");
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// labelControl2
			// 
			resources.ApplyResources(this.labelControl2, "labelControl2");
			this.labelControl2.Name = "labelControl2";
			// 
			// barDockControlLeft
			// 
			resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
			this.barDockControlLeft.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("barDockControlLeft.Appearance.GradientMode")));
			this.barDockControlLeft.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("barDockControlLeft.Appearance.Image")));
			this.barDockControlLeft.CausesValidation = false;
			// 
			// barDockControlRight
			// 
			resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
			this.barDockControlRight.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("barDockControlRight.Appearance.GradientMode")));
			this.barDockControlRight.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("barDockControlRight.Appearance.Image")));
			this.barDockControlRight.CausesValidation = false;
			// 
			// barDockControlBottom
			// 
			resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
			this.barDockControlBottom.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("barDockControlBottom.Appearance.GradientMode")));
			this.barDockControlBottom.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("barDockControlBottom.Appearance.Image")));
			this.barDockControlBottom.CausesValidation = false;
			// 
			// barDockControlTop
			// 
			resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
			this.barDockControlTop.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("barDockControlTop.Appearance.GradientMode")));
			this.barDockControlTop.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("barDockControlTop.Appearance.Image")));
			this.barDockControlTop.CausesValidation = false;
			// 
			// successWizardPage
			// 
			resources.ApplyResources(this.successWizardPage, "successWizardPage");
			this.successWizardPage.AllowBack = false;
			this.successWizardPage.AllowCancel = false;
			this.successWizardPage.AllowNext = false;
			this.successWizardPage.Controls.Add(this.simpleButton1);
			this.successWizardPage.Controls.Add(this.pictureBox2);
			this.successWizardPage.Controls.Add(this.summaryAfterSuccessfulImportLabel);
			this.successWizardPage.Controls.Add(this.labelControl5);
			this.successWizardPage.Name = "successWizardPage";
			// 
			// simpleButton1
			// 
			resources.ApplyResources(this.simpleButton1, "simpleButton1");
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Click += new System.EventHandler(this.cmdImportFormatInfo_Click);
			// 
			// pictureBox2
			// 
			resources.ApplyResources(this.pictureBox2, "pictureBox2");
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.TabStop = false;
			// 
			// summaryAfterSuccessfulImportLabel
			// 
			resources.ApplyResources(this.summaryAfterSuccessfulImportLabel, "summaryAfterSuccessfulImportLabel");
			this.summaryAfterSuccessfulImportLabel.Appearance.DisabledImage = ((System.Drawing.Image)(resources.GetObject("summaryAfterSuccessfulImportLabel.Appearance.DisabledImage")));
			this.summaryAfterSuccessfulImportLabel.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("summaryAfterSuccessfulImportLabel.Appearance.GradientMode")));
			this.summaryAfterSuccessfulImportLabel.Appearance.HoverImage = ((System.Drawing.Image)(resources.GetObject("summaryAfterSuccessfulImportLabel.Appearance.HoverImage")));
			this.summaryAfterSuccessfulImportLabel.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("summaryAfterSuccessfulImportLabel.Appearance.Image")));
			this.summaryAfterSuccessfulImportLabel.Appearance.PressedImage = ((System.Drawing.Image)(resources.GetObject("summaryAfterSuccessfulImportLabel.Appearance.PressedImage")));
			this.summaryAfterSuccessfulImportLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.summaryAfterSuccessfulImportLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.summaryAfterSuccessfulImportLabel.Name = "summaryAfterSuccessfulImportLabel";
			// 
			// labelControl5
			// 
			resources.ApplyResources(this.labelControl5, "labelControl5");
			this.labelControl5.Appearance.DisabledImage = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.DisabledImage")));
			this.labelControl5.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("labelControl5.Appearance.GradientMode")));
			this.labelControl5.Appearance.HoverImage = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.HoverImage")));
			this.labelControl5.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.Image")));
			this.labelControl5.Appearance.PressedImage = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.PressedImage")));
			this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl5.Name = "labelControl5";
			// 
			// fileGroupsWizardPage
			// 
			resources.ApplyResources(this.fileGroupsWizardPage, "fileGroupsWizardPage");
			this.fileGroupsWizardPage.Controls.Add(this.invertFileGroupsButton);
			this.fileGroupsWizardPage.Controls.Add(this.selectNoFileGroupsButton);
			this.fileGroupsWizardPage.Controls.Add(this.selectAllFileGroupsButton);
			this.fileGroupsWizardPage.Controls.Add(this.fileGroupsListBox);
			this.fileGroupsWizardPage.Controls.Add(this.labelControl4);
			this.fileGroupsWizardPage.Controls.Add(this.labelControl1);
			this.fileGroupsWizardPage.Name = "fileGroupsWizardPage";
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
			// labelControl4
			// 
			resources.ApplyResources(this.labelControl4, "labelControl4");
			this.labelControl4.Name = "labelControl4";
			// 
			// labelControl1
			// 
			resources.ApplyResources(this.labelControl1, "labelControl1");
			this.labelControl1.Name = "labelControl1";
			// 
			// languagesWizardPage
			// 
			resources.ApplyResources(this.languagesWizardPage, "languagesWizardPage");
			this.languagesWizardPage.Controls.Add(this.labelControl6);
			this.languagesWizardPage.Controls.Add(this.label3);
			this.languagesWizardPage.Controls.Add(this.selectAllLanguagesToExportButton);
			this.languagesWizardPage.Controls.Add(this.invertLanguagesToExportButton);
			this.languagesWizardPage.Controls.Add(this.selectNoLanguagesToExportButton);
			this.languagesWizardPage.Controls.Add(this.languagesToImportCheckListBox);
			this.languagesWizardPage.Name = "languagesWizardPage";
			// 
			// labelControl6
			// 
			resources.ApplyResources(this.labelControl6, "labelControl6");
			this.labelControl6.Name = "labelControl6";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
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
			// languagesToImportCheckListBox
			// 
			resources.ApplyResources(this.languagesToImportCheckListBox, "languagesToImportCheckListBox");
			this.languagesToImportCheckListBox.CheckOnClick = true;
			this.languagesToImportCheckListBox.Name = "languagesToImportCheckListBox";
			this.languagesToImportCheckListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.languagesToImportCheckListBox_ItemCheck);
			this.languagesToImportCheckListBox.SelectedIndexChanged += new System.EventHandler(this.languagesToImportCheckListBox_SelectedIndexChanged);
			// 
			// progressWizardPage
			// 
			resources.ApplyResources(this.progressWizardPage, "progressWizardPage");
			this.progressWizardPage.AllowBack = false;
			this.progressWizardPage.AllowNext = false;
			this.progressWizardPage.Controls.Add(this.progressBarControl);
			this.progressWizardPage.Controls.Add(this.progressLabel);
			this.progressWizardPage.Name = "progressWizardPage";
			// 
			// progressBarControl
			// 
			resources.ApplyResources(this.progressBarControl, "progressBarControl");
			this.progressBarControl.Name = "progressBarControl";
			this.progressBarControl.Properties.AccessibleDescription = resources.GetString("progressBarControl.Properties.AccessibleDescription");
			this.progressBarControl.Properties.AccessibleName = resources.GetString("progressBarControl.Properties.AccessibleName");
			this.progressBarControl.Properties.AutoHeight = ((bool)(resources.GetObject("progressBarControl.Properties.AutoHeight")));
			// 
			// progressLabel
			// 
			resources.ApplyResources(this.progressLabel, "progressLabel");
			this.progressLabel.Name = "progressLabel";
			// 
			// errorOccurredWizardPage
			// 
			resources.ApplyResources(this.errorOccurredWizardPage, "errorOccurredWizardPage");
			this.errorOccurredWizardPage.AllowNext = false;
			this.errorOccurredWizardPage.Controls.Add(this.pictureBox1);
			this.errorOccurredWizardPage.Controls.Add(this.labelControl3);
			this.errorOccurredWizardPage.Controls.Add(this.optionsButton);
			this.errorOccurredWizardPage.Controls.Add(this.errorTextMemoEdit);
			this.errorOccurredWizardPage.Name = "errorOccurredWizardPage";
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
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
			this.optionsButton.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("optionsButton.Appearance.GradientMode")));
			this.optionsButton.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("optionsButton.Appearance.Image")));
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
            new DevExpress.XtraBars.LinkPersistInfo(this.detailedErrorsButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.underylingExceptionButton)});
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
			// underylingExceptionButton
			// 
			resources.ApplyResources(this.underylingExceptionButton, "underylingExceptionButton");
			this.underylingExceptionButton.Id = 1;
			this.underylingExceptionButton.ImageIndex = 0;
			this.underylingExceptionButton.Name = "underylingExceptionButton";
			this.underylingExceptionButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.underylingExceptionButton_ItemClick);
			// 
			// barManager
			// 
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this.importFileWizardPage;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.detailedErrorsButton,
            this.underylingExceptionButton});
			this.barManager.MaxItemId = 3;
			// 
			// errorTextMemoEdit
			// 
			resources.ApplyResources(this.errorTextMemoEdit, "errorTextMemoEdit");
			this.errorTextMemoEdit.Name = "errorTextMemoEdit";
			this.errorTextMemoEdit.Properties.AccessibleDescription = resources.GetString("errorTextMemoEdit.Properties.AccessibleDescription");
			this.errorTextMemoEdit.Properties.AccessibleName = resources.GetString("errorTextMemoEdit.Properties.AccessibleName");
			this.errorTextMemoEdit.Properties.NullValuePrompt = resources.GetString("errorTextMemoEdit.Properties.NullValuePrompt");
			this.errorTextMemoEdit.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("errorTextMemoEdit.Properties.NullValuePromptShowForEmptyValue")));
			// 
			// progressBackgroundWorker
			// 
			this.progressBackgroundWorker.WorkerReportsProgress = true;
			this.progressBackgroundWorker.WorkerSupportsCancellation = true;
			this.progressBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.progressBackgroundWorker_DoWork);
			this.progressBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.progressBackgroundWorker_ProgressChanged);
			this.progressBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.progressBackgroundWorker_RunWorkerCompleted);
			// 
			// ExcelImportWizardForm
			// 
			resources.ApplyResources(this, "$this");
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ExcelImportWizardForm.Appearance.Font")));
			this.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("ExcelImportWizardForm.Appearance.GradientMode")));
			this.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("ExcelImportWizardForm.Appearance.Image")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.wizardControl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExcelImportWizardForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportWizard_FormClosing);
			this.Load += new System.EventHandler(this.ImportWizard_Load);
			((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
			this.wizardControl.ResumeLayout(false);
			this.importFileWizardPage.ResumeLayout(false);
			this.importFileWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sourceFileTextEdit.Properties)).EndInit();
			this.successWizardPage.ResumeLayout(false);
			this.successWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.fileGroupsWizardPage.ResumeLayout(false);
			this.fileGroupsWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileGroupsListBox)).EndInit();
			this.languagesWizardPage.ResumeLayout(false);
			this.languagesWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.languagesToImportCheckListBox)).EndInit();
			this.progressWizardPage.ResumeLayout(false);
			this.progressWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
			this.errorOccurredWizardPage.ResumeLayout(false);
			this.errorOccurredWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorTextMemoEdit.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraWizard.WizardControl wizardControl;
		private DevExpress.XtraWizard.WelcomeWizardPage importFileWizardPage;
		private DevExpress.XtraWizard.CompletionWizardPage successWizardPage;
		private DevExpress.XtraEditors.SimpleButton buttonBrowse;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.MemoEdit sourceFileTextEdit;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarButtonItem detailedErrorsButton;
		private DevExpress.XtraBars.BarButtonItem underylingExceptionButton;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private System.ComponentModel.BackgroundWorker progressBackgroundWorker;
		private DevExpress.XtraWizard.WizardPage fileGroupsWizardPage;
		private DevExpress.XtraEditors.SimpleButton invertFileGroupsButton;
		private DevExpress.XtraEditors.SimpleButton selectNoFileGroupsButton;
		private DevExpress.XtraEditors.SimpleButton selectAllFileGroupsButton;
		private DevExpress.XtraEditors.CheckedListBoxControl fileGroupsListBox;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraWizard.WizardPage languagesWizardPage;
		private DevExpress.XtraEditors.LabelControl label3;
		private DevExpress.XtraEditors.SimpleButton selectAllLanguagesToExportButton;
		private DevExpress.XtraEditors.SimpleButton invertLanguagesToExportButton;
		private DevExpress.XtraEditors.SimpleButton selectNoLanguagesToExportButton;
		private DevExpress.XtraEditors.CheckedListBoxControl languagesToImportCheckListBox;
		private DevExpress.XtraWizard.WizardPage progressWizardPage;
		private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
		private DevExpress.XtraEditors.LabelControl progressLabel;
		private DevExpress.XtraWizard.WizardPage errorOccurredWizardPage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.DropDownButton optionsButton;
		private DevExpress.XtraEditors.MemoEdit errorTextMemoEdit;
		private System.Windows.Forms.PictureBox pictureBox2;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.SimpleButton buttonOpen;
		private DevExpress.XtraEditors.LabelControl summaryAfterSuccessfulImportLabel;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.SimpleButton cmdImportFormatInfo;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}