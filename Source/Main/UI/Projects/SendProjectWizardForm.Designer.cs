namespace ZetaResourceEditor.UI.Projects
{
	partial class SendProjectWizardForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendProjectWizardForm));
            this.wizardControl = new ExtendedControlsLibrary.Skinning.CustomWizard.NoHeaderWizardControl();
            this.optionsWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exportLocalSettingsCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportResourceFilesCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.exportProjectFileCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl7 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.receiversWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.buttonZulReset = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.labelControl10 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.zulBodyTextEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.zulSubjectTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.zulReceiversTextEdit = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.successWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.downloadProjectUrlLinkEdit = new ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.progressWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.progressLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.errorOccurredWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.optionsButton = new ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton();
            this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.buttonErrorDetails = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.detailedErrorsButton = new DevExpress.XtraBars.BarButtonItem();
            this.underylingExceptionButton = new DevExpress.XtraBars.BarButtonItem();
            this.errorTextMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.progressBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.optionsWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportLocalSettingsCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportResourceFilesCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportProjectFileCheckEdit.Properties)).BeginInit();
            this.receiversWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zulBodyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zulSubjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zulReceiversTextEdit.Properties)).BeginInit();
            this.successWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadProjectUrlLinkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.wizardControl.Controls.Add(this.optionsWizardPage);
            this.wizardControl.Controls.Add(this.receiversWizardPage);
            this.wizardControl.Controls.Add(this.successWizardPage);
            this.wizardControl.Controls.Add(this.progressWizardPage);
            this.wizardControl.Controls.Add(this.errorOccurredWizardPage);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.Location = new System.Drawing.Point(0, 0);
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.optionsWizardPage,
            this.receiversWizardPage,
            this.progressWizardPage,
            this.errorOccurredWizardPage,
            this.successWizardPage});
            this.wizardControl.Size = new System.Drawing.Size(544, 462);
            this.wizardControl.Text = "";
            this.wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl_SelectedPageChanged);
            this.wizardControl.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_CancelClick);
            this.wizardControl.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_FinishClick);
            this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
            this.wizardControl.PrevClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_PrevClick);
            this.wizardControl.CustomizeCommandButtons += new DevExpress.XtraWizard.WizardCustomizeCommandButtonsEventHandler(this.wizardControl_CustomizeCommandButtons);
            // 
            // optionsWizardPage
            // 
            this.optionsWizardPage.Controls.Add(this.pictureBox3);
            this.optionsWizardPage.Controls.Add(this.exportLocalSettingsCheckEdit);
            this.optionsWizardPage.Controls.Add(this.exportResourceFilesCheckEdit);
            this.optionsWizardPage.Controls.Add(this.exportProjectFileCheckEdit);
            this.optionsWizardPage.Controls.Add(this.labelControl1);
            this.optionsWizardPage.Controls.Add(this.labelControl7);
            this.optionsWizardPage.Name = "optionsWizardPage";
            this.optionsWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.optionsWizardPage.Size = new System.Drawing.Size(500, 332);
            this.optionsWizardPage.Text = "Send project by email";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // exportLocalSettingsCheckEdit
            // 
            this.exportLocalSettingsCheckEdit.EditValue = true;
            this.exportLocalSettingsCheckEdit.Location = new System.Drawing.Point(27, 92);
            this.exportLocalSettingsCheckEdit.Name = "exportLocalSettingsCheckEdit";
            this.exportLocalSettingsCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportLocalSettingsCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportLocalSettingsCheckEdit.Properties.AutoWidth = true;
            this.exportLocalSettingsCheckEdit.Properties.Caption = "My local settings";
            this.exportLocalSettingsCheckEdit.Size = new System.Drawing.Size(120, 21);
            this.exportLocalSettingsCheckEdit.TabIndex = 2;
            this.exportLocalSettingsCheckEdit.CheckedChanged += new System.EventHandler(this.exportLocalSettingsCheckEdit_CheckedChanged);
            // 
            // exportResourceFilesCheckEdit
            // 
            this.exportResourceFilesCheckEdit.EditValue = true;
            this.exportResourceFilesCheckEdit.Location = new System.Drawing.Point(27, 67);
            this.exportResourceFilesCheckEdit.Name = "exportResourceFilesCheckEdit";
            this.exportResourceFilesCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportResourceFilesCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportResourceFilesCheckEdit.Properties.AutoWidth = true;
            this.exportResourceFilesCheckEdit.Properties.Caption = "Resource files (RESX)";
            this.exportResourceFilesCheckEdit.Size = new System.Drawing.Size(145, 21);
            this.exportResourceFilesCheckEdit.TabIndex = 2;
            this.exportResourceFilesCheckEdit.CheckedChanged += new System.EventHandler(this.exportResourceFilesCheckEdit_CheckedChanged);
            // 
            // exportProjectFileCheckEdit
            // 
            this.exportProjectFileCheckEdit.EditValue = true;
            this.exportProjectFileCheckEdit.Location = new System.Drawing.Point(27, 40);
            this.exportProjectFileCheckEdit.Name = "exportProjectFileCheckEdit";
            this.exportProjectFileCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exportProjectFileCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.exportProjectFileCheckEdit.Properties.AutoWidth = true;
            this.exportProjectFileCheckEdit.Properties.Caption = "Project file";
            this.exportProjectFileCheckEdit.Size = new System.Drawing.Size(83, 21);
            this.exportProjectFileCheckEdit.TabIndex = 2;
            this.exportProjectFileCheckEdit.CheckedChanged += new System.EventHandler(this.exportProjectFileCheckEdit_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.Location = new System.Drawing.Point(37, 303);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(359, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Sending a project may (and will) include sensitive information.";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl7.Location = new System.Drawing.Point(12, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(158, 17);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Include the following items:";
            // 
            // receiversWizardPage
            // 
            this.receiversWizardPage.Controls.Add(this.buttonZulReset);
            this.receiversWizardPage.Controls.Add(this.labelControl10);
            this.receiversWizardPage.Controls.Add(this.zulBodyTextEdit);
            this.receiversWizardPage.Controls.Add(this.zulSubjectTextEdit);
            this.receiversWizardPage.Controls.Add(this.zulReceiversTextEdit);
            this.receiversWizardPage.Controls.Add(this.label2);
            this.receiversWizardPage.Name = "receiversWizardPage";
            this.receiversWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.receiversWizardPage.Size = new System.Drawing.Size(500, 332);
            this.receiversWizardPage.Text = "Select receivers";
            // 
            // buttonZulReset
            // 
            this.buttonZulReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZulReset.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonZulReset.Appearance.Options.UseFont = true;
            this.buttonZulReset.Location = new System.Drawing.Point(413, 292);
            this.buttonZulReset.Name = "buttonZulReset";
            this.buttonZulReset.Size = new System.Drawing.Size(75, 28);
            this.buttonZulReset.TabIndex = 10;
            this.buttonZulReset.Text = "Reset";
            this.buttonZulReset.WantDrawFocusRectangle = true;
            this.buttonZulReset.Click += new System.EventHandler(this.buttonZulReset_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl10.Location = new System.Drawing.Point(12, 64);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(166, 17);
            this.labelControl10.TabIndex = 7;
            this.labelControl10.Text = "E-mail subject and message:";
            // 
            // zulBodyTextEdit
            // 
            this.zulBodyTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zulBodyTextEdit.CueText = null;
            this.zulBodyTextEdit.EditValue = "Please download the project files in the link for project \"{ProjectName}\".\r\n\r\nTo " +
    "send me the files back, simply use https://www.zeta-uploader.com\r\n\r\nKind regards" +
    "";
            this.zulBodyTextEdit.Location = new System.Drawing.Point(12, 114);
            this.zulBodyTextEdit.Name = "zulBodyTextEdit";
            this.zulBodyTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.zulBodyTextEdit.Properties.Appearance.Options.UseFont = true;
            this.zulBodyTextEdit.Properties.NullValuePrompt = null;
            this.zulBodyTextEdit.Size = new System.Drawing.Size(476, 172);
            this.zulBodyTextEdit.TabIndex = 9;
            this.zulBodyTextEdit.EditValueChanged += new System.EventHandler(this.zulBodyTextEdit_EditValueChanged);
            // 
            // zulSubjectTextEdit
            // 
            this.zulSubjectTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zulSubjectTextEdit.Bold = false;
            this.zulSubjectTextEdit.CueText = null;
            this.zulSubjectTextEdit.EditValue = "[ZRE] Exported project \"{ProjectName}\"";
            this.zulSubjectTextEdit.Location = new System.Drawing.Point(12, 84);
            this.zulSubjectTextEdit.MaximumSize = new System.Drawing.Size(0, 24);
            this.zulSubjectTextEdit.MinimumSize = new System.Drawing.Size(0, 24);
            this.zulSubjectTextEdit.Name = "zulSubjectTextEdit";
            this.zulSubjectTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.zulSubjectTextEdit.Properties.Appearance.Options.UseFont = true;
            this.zulSubjectTextEdit.Properties.NullValuePrompt = null;
            this.zulSubjectTextEdit.Size = new System.Drawing.Size(476, 24);
            this.zulSubjectTextEdit.TabIndex = 8;
            this.zulSubjectTextEdit.EditValueChanged += new System.EventHandler(this.zulSubjectTextEdit_EditValueChanged);
            // 
            // zulReceiversTextEdit
            // 
            this.zulReceiversTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zulReceiversTextEdit.CueText = null;
            this.zulReceiversTextEdit.Location = new System.Drawing.Point(12, 30);
            this.zulReceiversTextEdit.Name = "zulReceiversTextEdit";
            this.zulReceiversTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.zulReceiversTextEdit.Properties.Appearance.Options.UseFont = true;
            this.zulReceiversTextEdit.Properties.AutoHeight = false;
            this.zulReceiversTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.zulReceiversTextEdit.Properties.DropDownRows = 20;
            this.zulReceiversTextEdit.Properties.NullValuePrompt = null;
            this.zulReceiversTextEdit.Size = new System.Drawing.Size(476, 20);
            this.zulReceiversTextEdit.TabIndex = 3;
            this.zulReceiversTextEdit.SelectedIndexChanged += new System.EventHandler(this.zulReceiversTextEdit_SelectedIndexChanged);
            this.zulReceiversTextEdit.EditValueChanged += new System.EventHandler(this.zulReceiversTextEdit_EditValueChanged);
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Send the project to the following email receivers:";
            // 
            // successWizardPage
            // 
            this.successWizardPage.Controls.Add(this.downloadProjectUrlLinkEdit);
            this.successWizardPage.Controls.Add(this.pictureBox2);
            this.successWizardPage.Controls.Add(this.labelControl5);
            this.successWizardPage.Name = "successWizardPage";
            this.successWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.successWizardPage.Size = new System.Drawing.Size(500, 332);
            this.successWizardPage.Text = "The project was sent successfully";
            // 
            // downloadProjectUrlLinkEdit
            // 
            this.downloadProjectUrlLinkEdit.AllowAutoWidth = true;
            this.downloadProjectUrlLinkEdit.CausesValidation = false;
            this.downloadProjectUrlLinkEdit.EditValue = "Download now";
            this.downloadProjectUrlLinkEdit.Location = new System.Drawing.Point(75, 45);
            this.downloadProjectUrlLinkEdit.Name = "downloadProjectUrlLinkEdit";
            this.downloadProjectUrlLinkEdit.Properties.AllowFocused = false;
            this.downloadProjectUrlLinkEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.downloadProjectUrlLinkEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.downloadProjectUrlLinkEdit.Properties.Appearance.Options.UseBackColor = true;
            this.downloadProjectUrlLinkEdit.Properties.Appearance.Options.UseFont = true;
            this.downloadProjectUrlLinkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.downloadProjectUrlLinkEdit.Properties.ReadOnly = true;
            this.downloadProjectUrlLinkEdit.Size = new System.Drawing.Size(102, 22);
            this.downloadProjectUrlLinkEdit.TabIndex = 11;
            this.downloadProjectUrlLinkEdit.TabStop = false;
            this.downloadProjectUrlLinkEdit.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.downloadProjectUrlLinkEdit_OpenLink);
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
            this.labelControl5.Size = new System.Drawing.Size(413, 28);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Your project was successfully sent to the receivers.";
            // 
            // progressWizardPage
            // 
            this.progressWizardPage.Controls.Add(this.progressBarControl);
            this.progressWizardPage.Controls.Add(this.progressLabel);
            this.progressWizardPage.Name = "progressWizardPage";
            this.progressWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.progressWizardPage.Size = new System.Drawing.Size(500, 332);
            this.progressWizardPage.Text = "Project is being packaged and sent";
            // 
            // progressBarControl
            // 
            this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(12, 12);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(476, 18);
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
            this.errorOccurredWizardPage.Controls.Add(this.optionsButton);
            this.errorOccurredWizardPage.Controls.Add(this.errorTextMemoEdit);
            this.errorOccurredWizardPage.Controls.Add(this.barDockControlLeft);
            this.errorOccurredWizardPage.Controls.Add(this.barDockControlRight);
            this.errorOccurredWizardPage.Controls.Add(this.barDockControlBottom);
            this.errorOccurredWizardPage.Controls.Add(this.barDockControlTop);
            this.errorOccurredWizardPage.Name = "errorOccurredWizardPage";
            this.errorOccurredWizardPage.Padding = new System.Windows.Forms.Padding(9);
            this.errorOccurredWizardPage.Size = new System.Drawing.Size(500, 332);
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
            this.optionsButton.Location = new System.Drawing.Point(15, 292);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 28);
            this.optionsButton.TabIndex = 10;
            this.optionsButton.Text = "&Options";
            // 
            // optionsPopupMenu
            // 
            this.optionsPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonErrorDetails)});
            this.optionsPopupMenu.Manager = this.barManager;
            this.optionsPopupMenu.Name = "optionsPopupMenu";
            this.optionsPopupMenu.BeforePopup += new System.ComponentModel.CancelEventHandler(this.optionsPopupMenu_BeforePopup);
            // 
            // buttonErrorDetails
            // 
            this.buttonErrorDetails.Caption = "Details";
            this.buttonErrorDetails.Id = 3;
            this.buttonErrorDetails.Name = "buttonErrorDetails";
            this.buttonErrorDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.detailedErrorsButton_ItemClick);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this.errorOccurredWizardPage;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.detailedErrorsButton,
            this.underylingExceptionButton,
            this.buttonErrorDetails});
            this.barManager.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(9, 9);
            this.barDockControlTop.Size = new System.Drawing.Size(482, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(9, 323);
            this.barDockControlBottom.Size = new System.Drawing.Size(482, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(9, 9);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 314);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(491, 9);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 314);
            // 
            // detailedErrorsButton
            // 
            this.detailedErrorsButton.Caption = "Show &detailed error message...";
            this.detailedErrorsButton.Id = 0;
            this.detailedErrorsButton.ImageIndex = 1;
            this.detailedErrorsButton.Name = "detailedErrorsButton";
            // 
            // underylingExceptionButton
            // 
            this.underylingExceptionButton.Caption = "&Inspect the underyling exception...";
            this.underylingExceptionButton.Id = 1;
            this.underylingExceptionButton.ImageIndex = 0;
            this.underylingExceptionButton.Name = "underylingExceptionButton";
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
            this.errorTextMemoEdit.Size = new System.Drawing.Size(470, 271);
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
            this.panel1.Size = new System.Drawing.Size(544, 462);
            this.panel1.TabIndex = 3;
            // 
            // SendProjectWizardForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(544, 462);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 500);
            this.Name = "SendProjectWizardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendProjectWizardForm_FormClosing);
            this.Load += new System.EventHandler(this.SendProjectWizardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.wizardControl.ResumeLayout(false);
            this.optionsWizardPage.ResumeLayout(false);
            this.optionsWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportLocalSettingsCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportResourceFilesCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportProjectFileCheckEdit.Properties)).EndInit();
            this.receiversWizardPage.ResumeLayout(false);
            this.receiversWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zulBodyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zulSubjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zulReceiversTextEdit.Properties)).EndInit();
            this.successWizardPage.ResumeLayout(false);
            this.successWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadProjectUrlLinkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.progressWizardPage.ResumeLayout(false);
            this.progressWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.errorOccurredWizardPage.ResumeLayout(false);
            this.errorOccurredWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTextMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomWizard.NoHeaderWizardControl wizardControl;
		private DevExpress.XtraWizard.WelcomeWizardPage optionsWizardPage;
		private DevExpress.XtraWizard.WizardPage receiversWizardPage;
		private DevExpress.XtraWizard.CompletionWizardPage successWizardPage;
		private System.ComponentModel.BackgroundWorker progressBackgroundWorker;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl7;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportLocalSettingsCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportResourceFilesCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit exportProjectFileCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit zulReceiversTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private DevExpress.XtraWizard.WizardPage progressWizardPage;
		private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl progressLabel;
		private DevExpress.XtraWizard.WizardPage errorOccurredWizardPage;
		private ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton optionsButton;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit errorTextMemoEdit;
		private System.Windows.Forms.PictureBox pictureBox2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl5;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonZulReset;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl10;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit zulBodyTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit zulSubjectTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit downloadProjectUrlLinkEdit;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarButtonItem detailedErrorsButton;
		private DevExpress.XtraBars.BarButtonItem underylingExceptionButton;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private System.Windows.Forms.PictureBox pictureBox3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private DevExpress.XtraBars.BarButtonItem buttonErrorDetails;
        private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panel1;
    }
}