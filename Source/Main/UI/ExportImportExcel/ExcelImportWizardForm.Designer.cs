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
            this.wizardControl = new ExtendedControlsLibrary.Skinning.CustomWizard.NoHeaderWizardControl();
            this.importFileWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.labelControl7 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.cmdImportFormatInfo = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.sourceFileTextEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.buttonOpen = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonBrowse = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.successWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.simpleButton1 = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.summaryAfterSuccessfulImportLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.fileGroupsWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.invertFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectNoFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectAllFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.fileGroupsListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
            this.labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.languagesWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.labelControl6 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.label3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.selectAllLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.invertLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectNoLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.languagesToImportCheckListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
            this.progressWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.progressLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.errorOccurredWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.optionsButton = new ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton();
            this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.detailedErrorsButton = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.errorTextMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.progressBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTextMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // wizardControl
            //
            this.wizardControl.AllowAutoScaling = DevExpress.Utils.DefaultBoolean.False;
            this.wizardControl.AllowTransitionAnimation = false;
            this.wizardControl.Controls.Add(this.importFileWizardPage);
            this.wizardControl.Controls.Add(this.successWizardPage);
            this.wizardControl.Controls.Add(this.fileGroupsWizardPage);
            this.wizardControl.Controls.Add(this.languagesWizardPage);
            this.wizardControl.Controls.Add(this.progressWizardPage);
            this.wizardControl.Controls.Add(this.errorOccurredWizardPage);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.Location = new System.Drawing.Point(0, 0);
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.importFileWizardPage,
            this.fileGroupsWizardPage,
            this.languagesWizardPage,
            this.progressWizardPage,
            this.errorOccurredWizardPage,
            this.successWizardPage});
            this.wizardControl.Size = new System.Drawing.Size(579, 424);
            this.wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl_SelectedPageChanged);
            this.wizardControl.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_CancelClick);
            this.wizardControl.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_FinishClick);
            this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
            this.wizardControl.PrevClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_PrevClick);
            //
            // importFileWizardPage
            //
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
            this.importFileWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.importFileWizardPage.Size = new System.Drawing.Size(535, 294);
            this.importFileWizardPage.Text = "Specify import file from Microsoft Excel";
            //
            // labelControl7
            //
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(212, 226);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(311, 53);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Information about the required structure of a Microsoft Office Excel document in " +
    "order to successfully import";
            //
            // cmdImportFormatInfo
            //
            this.cmdImportFormatInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdImportFormatInfo.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmdImportFormatInfo.Appearance.Options.UseFont = true;
            this.cmdImportFormatInfo.Location = new System.Drawing.Point(15, 226);
            this.cmdImportFormatInfo.Name = "cmdImportFormatInfo";
            this.cmdImportFormatInfo.Size = new System.Drawing.Size(180, 28);
            this.cmdImportFormatInfo.TabIndex = 12;
            this.cmdImportFormatInfo.Text = "Import format information";
            this.cmdImportFormatInfo.WantDrawFocusRectangle = true;
            this.cmdImportFormatInfo.Click += new System.EventHandler(this.cmdImportFormatInfo_Click);
            //
            // sourceFileTextEdit
            //
            this.sourceFileTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceFileTextEdit.CueText = null;
            this.sourceFileTextEdit.Location = new System.Drawing.Point(12, 31);
            this.sourceFileTextEdit.Name = "sourceFileTextEdit";
            this.sourceFileTextEdit.Properties.AcceptsReturn = false;
            this.sourceFileTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sourceFileTextEdit.Properties.Appearance.Options.UseFont = true;
            this.sourceFileTextEdit.Properties.NullValuePrompt = null;
            this.sourceFileTextEdit.Size = new System.Drawing.Size(511, 40);
            this.sourceFileTextEdit.TabIndex = 7;
            this.sourceFileTextEdit.EditValueChanged += new System.EventHandler(this.sourceFileTextEdit_EditValueChanged);
            //
            // buttonOpen
            //
            this.buttonOpen.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonOpen.Appearance.Options.UseFont = true;
            this.buttonOpen.Location = new System.Drawing.Point(9, 77);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 28);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "&Open";
            this.buttonOpen.WantDrawFocusRectangle = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            //
            // buttonBrowse
            //
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonBrowse.Appearance.Options.UseFont = true;
            this.buttonBrowse.Location = new System.Drawing.Point(448, 77);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 28);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.WantDrawFocusRectangle = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            //
            // labelControl2
            //
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(251, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Microsoft Office Excel document to import:";
            //
            // barDockControlLeft
            //
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(9, 9);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 276);
            //
            // barDockControlRight
            //
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(526, 9);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 276);
            //
            // barDockControlBottom
            //
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(9, 285);
            this.barDockControlBottom.Size = new System.Drawing.Size(517, 0);
            //
            // barDockControlTop
            //
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(9, 9);
            this.barDockControlTop.Size = new System.Drawing.Size(517, 0);
            //
            // successWizardPage
            //
            this.successWizardPage.AllowBack = false;
            this.successWizardPage.AllowCancel = false;
            this.successWizardPage.AllowNext = false;
            this.successWizardPage.Controls.Add(this.simpleButton1);
            this.successWizardPage.Controls.Add(this.pictureBox2);
            this.successWizardPage.Controls.Add(this.summaryAfterSuccessfulImportLabel);
            this.successWizardPage.Controls.Add(this.labelControl5);
            this.successWizardPage.Name = "successWizardPage";
            this.successWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.successWizardPage.Size = new System.Drawing.Size(535, 294);
            this.successWizardPage.Text = "Import completed successfully";
            //
            // simpleButton1
            //
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(75, 254);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(225, 28);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "No rows imported — Find out why";
            this.simpleButton1.WantDrawFocusRectangle = true;
            this.simpleButton1.Click += new System.EventHandler(this.cmdImportFormatInfo_Click);
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
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            //
            // summaryAfterSuccessfulImportLabel
            //
            this.summaryAfterSuccessfulImportLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryAfterSuccessfulImportLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.summaryAfterSuccessfulImportLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.summaryAfterSuccessfulImportLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.summaryAfterSuccessfulImportLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.summaryAfterSuccessfulImportLabel.Location = new System.Drawing.Point(75, 60);
            this.summaryAfterSuccessfulImportLabel.Name = "summaryAfterSuccessfulImportLabel";
            this.summaryAfterSuccessfulImportLabel.Size = new System.Drawing.Size(448, 174);
            this.summaryAfterSuccessfulImportLabel.TabIndex = 9;
            this.summaryAfterSuccessfulImportLabel.Text = "<SUMMARY>";
            //
            // labelControl5
            //
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(75, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(448, 37);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Your data was successfully imported from the Microsoft Office Excel document you " +
    "specified.";
            //
            // fileGroupsWizardPage
            //
            this.fileGroupsWizardPage.Controls.Add(this.invertFileGroupsButton);
            this.fileGroupsWizardPage.Controls.Add(this.selectNoFileGroupsButton);
            this.fileGroupsWizardPage.Controls.Add(this.selectAllFileGroupsButton);
            this.fileGroupsWizardPage.Controls.Add(this.fileGroupsListBox);
            this.fileGroupsWizardPage.Controls.Add(this.labelControl4);
            this.fileGroupsWizardPage.Controls.Add(this.labelControl1);
            this.fileGroupsWizardPage.Name = "fileGroupsWizardPage";
            this.fileGroupsWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.fileGroupsWizardPage.Size = new System.Drawing.Size(535, 294);
            this.fileGroupsWizardPage.Text = "Select files groups to import";
            //
            // invertFileGroupsButton
            //
            this.invertFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invertFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invertFileGroupsButton.Appearance.Options.UseFont = true;
            this.invertFileGroupsButton.Location = new System.Drawing.Point(174, 254);
            this.invertFileGroupsButton.Name = "invertFileGroupsButton";
            this.invertFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.invertFileGroupsButton.TabIndex = 9;
            this.invertFileGroupsButton.Text = "Flip";
            this.invertFileGroupsButton.WantDrawFocusRectangle = true;
            this.invertFileGroupsButton.Click += new System.EventHandler(this.invertFileGroupsButton_Click);
            //
            // selectNoFileGroupsButton
            //
            this.selectNoFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectNoFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectNoFileGroupsButton.Appearance.Options.UseFont = true;
            this.selectNoFileGroupsButton.Location = new System.Drawing.Point(93, 254);
            this.selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
            this.selectNoFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.selectNoFileGroupsButton.TabIndex = 8;
            this.selectNoFileGroupsButton.Text = "None";
            this.selectNoFileGroupsButton.WantDrawFocusRectangle = true;
            this.selectNoFileGroupsButton.Click += new System.EventHandler(this.selectNoFileGroupsButton_Click);
            //
            // selectAllFileGroupsButton
            //
            this.selectAllFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectAllFileGroupsButton.Appearance.Options.UseFont = true;
            this.selectAllFileGroupsButton.Location = new System.Drawing.Point(12, 254);
            this.selectAllFileGroupsButton.Name = "selectAllFileGroupsButton";
            this.selectAllFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.selectAllFileGroupsButton.TabIndex = 7;
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
            this.fileGroupsListBox.Location = new System.Drawing.Point(12, 59);
            this.fileGroupsListBox.Name = "fileGroupsListBox";
            this.fileGroupsListBox.Size = new System.Drawing.Size(511, 189);
            this.fileGroupsListBox.TabIndex = 6;
            this.fileGroupsListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.fileGroupsListBox_ItemCheck);
            this.fileGroupsListBox.SelectedIndexChanged += new System.EventHandler(this.fileGroupsListBox_SelectedIndexChanged);
            //
            // labelControl4
            //
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl4.Location = new System.Drawing.Point(12, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(220, 17);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Check the groups you want to import:";
            //
            // labelControl1
            //
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(504, 17);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "The following matching file groups were found in the Microsoft Office Excel docum" +
    "ent.";
            //
            // languagesWizardPage
            //
            this.languagesWizardPage.Controls.Add(this.labelControl6);
            this.languagesWizardPage.Controls.Add(this.label3);
            this.languagesWizardPage.Controls.Add(this.selectAllLanguagesToExportButton);
            this.languagesWizardPage.Controls.Add(this.invertLanguagesToExportButton);
            this.languagesWizardPage.Controls.Add(this.selectNoLanguagesToExportButton);
            this.languagesWizardPage.Controls.Add(this.languagesToImportCheckListBox);
            this.languagesWizardPage.Name = "languagesWizardPage";
            this.languagesWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.languagesWizardPage.Size = new System.Drawing.Size(535, 294);
            this.languagesWizardPage.Text = "Specify languages to import";
            //
            // labelControl6
            //
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl6.Location = new System.Drawing.Point(12, 40);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(238, 17);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Check the languages you want to import:";
            //
            // label3
            //
            this.label3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "The following matching languages were found in the Microsoft Office Excel documen" +
    "t.";
            //
            // selectAllLanguagesToExportButton
            //
            this.selectAllLanguagesToExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllLanguagesToExportButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectAllLanguagesToExportButton.Appearance.Options.UseFont = true;
            this.selectAllLanguagesToExportButton.Location = new System.Drawing.Point(12, 254);
            this.selectAllLanguagesToExportButton.Name = "selectAllLanguagesToExportButton";
            this.selectAllLanguagesToExportButton.Size = new System.Drawing.Size(75, 28);
            this.selectAllLanguagesToExportButton.TabIndex = 11;
            this.selectAllLanguagesToExportButton.Text = "All";
            this.selectAllLanguagesToExportButton.WantDrawFocusRectangle = true;
            this.selectAllLanguagesToExportButton.Click += new System.EventHandler(this.selectAllLanguagesToExportButton_Click);
            //
            // invertLanguagesToExportButton
            //
            this.invertLanguagesToExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invertLanguagesToExportButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invertLanguagesToExportButton.Appearance.Options.UseFont = true;
            this.invertLanguagesToExportButton.Location = new System.Drawing.Point(174, 254);
            this.invertLanguagesToExportButton.Name = "invertLanguagesToExportButton";
            this.invertLanguagesToExportButton.Size = new System.Drawing.Size(75, 28);
            this.invertLanguagesToExportButton.TabIndex = 13;
            this.invertLanguagesToExportButton.Text = "Flip";
            this.invertLanguagesToExportButton.WantDrawFocusRectangle = true;
            this.invertLanguagesToExportButton.Click += new System.EventHandler(this.invertLanguagesToExportButton_Click);
            //
            // selectNoLanguagesToExportButton
            //
            this.selectNoLanguagesToExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectNoLanguagesToExportButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectNoLanguagesToExportButton.Appearance.Options.UseFont = true;
            this.selectNoLanguagesToExportButton.Location = new System.Drawing.Point(93, 254);
            this.selectNoLanguagesToExportButton.Name = "selectNoLanguagesToExportButton";
            this.selectNoLanguagesToExportButton.Size = new System.Drawing.Size(75, 28);
            this.selectNoLanguagesToExportButton.TabIndex = 12;
            this.selectNoLanguagesToExportButton.Text = "None";
            this.selectNoLanguagesToExportButton.WantDrawFocusRectangle = true;
            this.selectNoLanguagesToExportButton.Click += new System.EventHandler(this.selectNoLanguagesToExportButton_Click);
            //
            // languagesToImportCheckListBox
            //
            this.languagesToImportCheckListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesToImportCheckListBox.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.languagesToImportCheckListBox.Appearance.Options.UseFont = true;
            this.languagesToImportCheckListBox.CheckOnClick = true;
            this.languagesToImportCheckListBox.Location = new System.Drawing.Point(12, 59);
            this.languagesToImportCheckListBox.Name = "languagesToImportCheckListBox";
            this.languagesToImportCheckListBox.Size = new System.Drawing.Size(511, 189);
            this.languagesToImportCheckListBox.TabIndex = 10;
            this.languagesToImportCheckListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.languagesToImportCheckListBox_ItemCheck);
            this.languagesToImportCheckListBox.SelectedIndexChanged += new System.EventHandler(this.languagesToImportCheckListBox_SelectedIndexChanged);
            //
            // progressWizardPage
            //
            this.progressWizardPage.AllowBack = false;
            this.progressWizardPage.AllowNext = false;
            this.progressWizardPage.Controls.Add(this.progressBarControl);
            this.progressWizardPage.Controls.Add(this.progressLabel);
            this.progressWizardPage.Name = "progressWizardPage";
            this.progressWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.progressWizardPage.Size = new System.Drawing.Size(535, 294);
            this.progressWizardPage.Text = "Data is being imported. Please wait...";
            //
            // progressBarControl
            //
            this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(12, 12);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(511, 18);
            this.progressBarControl.TabIndex = 2;
            //
            // progressLabel
            //
            this.progressLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.progressLabel.Location = new System.Drawing.Point(12, 36);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(179, 17);
            this.progressLabel.TabIndex = 3;
            this.progressLabel.Text = "<Progress information, if any>";
            this.progressLabel.Visible = false;
            //
            // errorOccurredWizardPage
            //
            this.errorOccurredWizardPage.AllowNext = false;
            this.errorOccurredWizardPage.Controls.Add(this.optionsButton);
            this.errorOccurredWizardPage.Controls.Add(this.errorTextMemoEdit);
            this.errorOccurredWizardPage.Name = "errorOccurredWizardPage";
            this.errorOccurredWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.errorOccurredWizardPage.Size = new System.Drawing.Size(535, 294);
            this.errorOccurredWizardPage.Text = "An error has occurred";
            //
            // optionsButton
            //
            this.optionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.optionsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.optionsButton.Appearance.Options.UseFont = true;
            this.optionsButton.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.optionsButton.DropDownControl = this.optionsPopupMenu;
            this.optionsButton.Image = ((System.Drawing.Image)(resources.GetObject("optionsButton.Image")));
            this.optionsButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.optionsButton.Location = new System.Drawing.Point(12, 254);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 28);
            this.optionsButton.TabIndex = 10;
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
            this.detailedErrorsButton.ImageIndex = 1;
            this.detailedErrorsButton.Name = "detailedErrorsButton";
            this.detailedErrorsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.detailedErrorsButton_ItemClick);
            //
            // barManager
            //
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this.importFileWizardPage;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.detailedErrorsButton});
            this.barManager.MaxItemId = 3;
            //
            // errorTextMemoEdit
            //
            this.errorTextMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorTextMemoEdit.CueText = null;
            this.errorTextMemoEdit.Location = new System.Drawing.Point(12, 12);
            this.errorTextMemoEdit.Name = "errorTextMemoEdit";
            this.errorTextMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.errorTextMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.errorTextMemoEdit.Properties.NullValuePrompt = null;
            this.errorTextMemoEdit.Size = new System.Drawing.Size(511, 236);
            this.errorTextMemoEdit.TabIndex = 9;
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
            this.panel1.Size = new System.Drawing.Size(579, 424);
            this.panel1.TabIndex = 3;
            //
            // ExcelImportWizardForm
            //
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(579, 424);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(595, 460);
            this.Name = "ExcelImportWizardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import data from Microsoft Excel";
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
            ((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTextMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomWizard.NoHeaderWizardControl wizardControl;
		private DevExpress.XtraWizard.WelcomeWizardPage importFileWizardPage;
		private DevExpress.XtraWizard.CompletionWizardPage successWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonBrowse;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit sourceFileTextEdit;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarButtonItem detailedErrorsButton;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private System.ComponentModel.BackgroundWorker progressBackgroundWorker;
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
		private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl progressLabel;
		private DevExpress.XtraWizard.WizardPage errorOccurredWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton optionsButton;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit errorTextMemoEdit;
		private System.Windows.Forms.PictureBox pictureBox2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl5;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl6;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOpen;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl summaryAfterSuccessfulImportLabel;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl7;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton cmdImportFormatInfo;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton simpleButton1;
        private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panel1;
    }
}