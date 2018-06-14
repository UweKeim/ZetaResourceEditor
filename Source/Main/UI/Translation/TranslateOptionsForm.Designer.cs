namespace ZetaResourceEditor.UI.Translation
{
    partial class TranslateOptionsForm
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
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.xtraTabControl1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl();
            this.engineTabPage = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
            this.appIDLinkControl = new ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit();
            this.labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.engineComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.appIDLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.appIDTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.settingsTabPage = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.checkEditContinueOnErrors = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.translationDelayTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.wordsToKeepTabPage = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
            this.buttonAddDefaultWordsToKeep = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.wordsToProtectMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.labelControl5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.wordsToRemoveTabPage = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
            this.myLabelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl6 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.wordsToRemoveMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.appIDMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.engineTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIDLinkControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appIDTextEdit.Properties)).BeginInit();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditContinueOnErrors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationDelayTextEdit.Properties)).BeginInit();
            this.wordsToKeepTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsToProtectMemoEdit.Properties)).BeginInit();
            this.wordsToRemoveTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsToRemoveMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appIDMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Controls.Add(this.buttonOK);
            this.panelControl1.Controls.Add(this.buttonCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(3);
            this.panelControl1.Size = new System.Drawing.Size(461, 419);
            this.panelControl1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(6, 6);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.engineTabPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(449, 375);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.engineTabPage,
            this.settingsTabPage,
            this.wordsToKeepTabPage,
            this.wordsToRemoveTabPage});
            // 
            // engineTabPage
            // 
            this.engineTabPage.Controls.Add(this.appIDMemoEdit);
            this.engineTabPage.Controls.Add(this.appIDLinkControl);
            this.engineTabPage.Controls.Add(this.labelControl2);
            this.engineTabPage.Controls.Add(this.engineComboBox);
            this.engineTabPage.Controls.Add(this.appIDLabel);
            this.engineTabPage.Controls.Add(this.appIDTextEdit);
            this.engineTabPage.Name = "engineTabPage";
            this.engineTabPage.Padding = new System.Windows.Forms.Padding(9);
            this.engineTabPage.Size = new System.Drawing.Size(443, 343);
            this.engineTabPage.Text = "Service";
            // 
            // appIDLinkControl
            // 
            this.appIDLinkControl.AllowAutoWidth = true;
            this.appIDLinkControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appIDLinkControl.CausesValidation = false;
            this.appIDLinkControl.EditValue = "How to get an API key?";
            this.appIDLinkControl.Location = new System.Drawing.Point(12, 62);
            this.appIDLinkControl.Name = "appIDLinkControl";
            this.appIDLinkControl.Properties.AllowFocused = false;
            this.appIDLinkControl.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.appIDLinkControl.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.appIDLinkControl.Properties.Appearance.Options.UseBackColor = true;
            this.appIDLinkControl.Properties.Appearance.Options.UseFont = true;
            this.appIDLinkControl.Properties.Appearance.Options.UseTextOptions = true;
            this.appIDLinkControl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.appIDLinkControl.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.appIDLinkControl.Properties.ReadOnly = true;
            this.appIDLinkControl.Size = new System.Drawing.Size(419, 22);
            this.appIDLinkControl.TabIndex = 2;
            this.appIDLinkControl.TabStop = false;
            this.appIDLinkControl.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.appIDLinkControl_OpenLink);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(151, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Translation service to use:";
            // 
            // engineComboBox
            // 
            this.engineComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.engineComboBox.CueText = null;
            this.engineComboBox.Location = new System.Drawing.Point(12, 32);
            this.engineComboBox.Name = "engineComboBox";
            this.engineComboBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.engineComboBox.Properties.Appearance.Options.UseFont = true;
            this.engineComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.engineComboBox.Properties.NullValuePrompt = null;
            this.engineComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.engineComboBox.Size = new System.Drawing.Size(419, 24);
            this.engineComboBox.TabIndex = 1;
            this.engineComboBox.SelectedIndexChanged += new System.EventHandler(this.engineComboBox_SelectedIndexChanged);
            // 
            // appIDLabel
            // 
            this.appIDLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.appIDLabel.Appearance.Options.UseFont = true;
            this.appIDLabel.Location = new System.Drawing.Point(12, 104);
            this.appIDLabel.Name = "appIDLabel";
            this.appIDLabel.Size = new System.Drawing.Size(107, 17);
            this.appIDLabel.TabIndex = 3;
            this.appIDLabel.Text = "{0} for this service:";
            // 
            // appIDTextEdit
            // 
            this.appIDTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appIDTextEdit.Bold = false;
            this.appIDTextEdit.CueText = null;
            this.appIDTextEdit.Location = new System.Drawing.Point(12, 124);
            this.appIDTextEdit.MaximumSize = new System.Drawing.Size(0, 24);
            this.appIDTextEdit.MinimumSize = new System.Drawing.Size(0, 24);
            this.appIDTextEdit.Name = "appIDTextEdit";
            this.appIDTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.appIDTextEdit.Properties.Appearance.Options.UseFont = true;
            this.appIDTextEdit.Properties.Mask.EditMask = null;
            this.appIDTextEdit.Properties.MaxLength = 400;
            this.appIDTextEdit.Properties.NullValuePrompt = null;
            this.appIDTextEdit.Size = new System.Drawing.Size(419, 24);
            this.appIDTextEdit.TabIndex = 4;
            this.appIDTextEdit.EditValueChanged += new System.EventHandler(this.translationDelayTextEdit_EditValueChanged);
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.labelControl1);
            this.settingsTabPage.Controls.Add(this.checkEditContinueOnErrors);
            this.settingsTabPage.Controls.Add(this.translationDelayTextEdit);
            this.settingsTabPage.Controls.Add(this.label2);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(9);
            this.settingsTabPage.Size = new System.Drawing.Size(443, 343);
            this.settingsTabPage.Text = "Settings";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(277, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ms";
            // 
            // checkEditContinueOnErrors
            // 
            this.checkEditContinueOnErrors.Location = new System.Drawing.Point(12, 12);
            this.checkEditContinueOnErrors.Name = "checkEditContinueOnErrors";
            this.checkEditContinueOnErrors.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.checkEditContinueOnErrors.Properties.Appearance.Options.UseFont = true;
            this.checkEditContinueOnErrors.Properties.AutoWidth = true;
            this.checkEditContinueOnErrors.Properties.Caption = "Continue on errors";
            this.checkEditContinueOnErrors.Size = new System.Drawing.Size(132, 21);
            this.checkEditContinueOnErrors.TabIndex = 0;
            // 
            // translationDelayTextEdit
            // 
            this.translationDelayTextEdit.Bold = false;
            this.translationDelayTextEdit.CueText = null;
            this.translationDelayTextEdit.Location = new System.Drawing.Point(204, 39);
            this.translationDelayTextEdit.MaximumSize = new System.Drawing.Size(0, 24);
            this.translationDelayTextEdit.MinimumSize = new System.Drawing.Size(0, 24);
            this.translationDelayTextEdit.Name = "translationDelayTextEdit";
            this.translationDelayTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.translationDelayTextEdit.Properties.Appearance.Options.UseFont = true;
            this.translationDelayTextEdit.Properties.Mask.EditMask = null;
            this.translationDelayTextEdit.Properties.MaxLength = 5;
            this.translationDelayTextEdit.Properties.NullValuePrompt = null;
            this.translationDelayTextEdit.Size = new System.Drawing.Size(67, 24);
            this.translationDelayTextEdit.TabIndex = 2;
            this.translationDelayTextEdit.EditValueChanged += new System.EventHandler(this.translationDelayTextEdit_EditValueChanged);
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delay between two translations:";
            // 
            // wordsToKeepTabPage
            // 
            this.wordsToKeepTabPage.Controls.Add(this.buttonAddDefaultWordsToKeep);
            this.wordsToKeepTabPage.Controls.Add(this.labelControl4);
            this.wordsToKeepTabPage.Controls.Add(this.wordsToProtectMemoEdit);
            this.wordsToKeepTabPage.Controls.Add(this.labelControl5);
            this.wordsToKeepTabPage.Name = "wordsToKeepTabPage";
            this.wordsToKeepTabPage.Padding = new System.Windows.Forms.Padding(9);
            this.wordsToKeepTabPage.Size = new System.Drawing.Size(443, 343);
            this.wordsToKeepTabPage.Text = "Words to keep";
            // 
            // buttonAddDefaultWordsToKeep
            // 
            this.buttonAddDefaultWordsToKeep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDefaultWordsToKeep.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonAddDefaultWordsToKeep.Appearance.Options.UseFont = true;
            this.buttonAddDefaultWordsToKeep.Location = new System.Drawing.Point(336, 262);
            this.buttonAddDefaultWordsToKeep.Name = "buttonAddDefaultWordsToKeep";
            this.buttonAddDefaultWordsToKeep.Size = new System.Drawing.Size(95, 28);
            this.buttonAddDefaultWordsToKeep.TabIndex = 3;
            this.buttonAddDefaultWordsToKeep.Text = "Add defaults";
            this.buttonAddDefaultWordsToKeep.WantDrawFocusRectangle = true;
            this.buttonAddDefaultWordsToKeep.Click += new System.EventHandler(this.buttonAddDefaultWordsToKeep_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(12, 296);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(419, 35);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "(One word/sentence per line. [WC] prefix for wildcards, [RX] prefix for Regular E" +
    "xpressions)";
            // 
            // wordsToProtectMemoEdit
            // 
            this.wordsToProtectMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordsToProtectMemoEdit.CueText = null;
            this.wordsToProtectMemoEdit.Location = new System.Drawing.Point(12, 32);
            this.wordsToProtectMemoEdit.Name = "wordsToProtectMemoEdit";
            this.wordsToProtectMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wordsToProtectMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.wordsToProtectMemoEdit.Properties.NullValuePrompt = null;
            this.wordsToProtectMemoEdit.Size = new System.Drawing.Size(419, 224);
            this.wordsToProtectMemoEdit.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(211, 17);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Never translate the following words:";
            // 
            // wordsToRemoveTabPage
            // 
            this.wordsToRemoveTabPage.Controls.Add(this.myLabelControl1);
            this.wordsToRemoveTabPage.Controls.Add(this.labelControl6);
            this.wordsToRemoveTabPage.Controls.Add(this.wordsToRemoveMemoEdit);
            this.wordsToRemoveTabPage.Name = "wordsToRemoveTabPage";
            this.wordsToRemoveTabPage.Padding = new System.Windows.Forms.Padding(9);
            this.wordsToRemoveTabPage.Size = new System.Drawing.Size(443, 343);
            this.wordsToRemoveTabPage.Text = "Words to remove";
            // 
            // myLabelControl1
            // 
            this.myLabelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myLabelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.myLabelControl1.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.myLabelControl1.Appearance.Options.UseFont = true;
            this.myLabelControl1.Appearance.Options.UseForeColor = true;
            this.myLabelControl1.Appearance.Options.UseTextOptions = true;
            this.myLabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.myLabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.myLabelControl1.Location = new System.Drawing.Point(12, 296);
            this.myLabelControl1.Name = "myLabelControl1";
            this.myLabelControl1.Size = new System.Drawing.Size(419, 35);
            this.myLabelControl1.TabIndex = 4;
            this.myLabelControl1.Text = "(One word/sentence per line. [WC] prefix for wildcards, [RX] prefix for Regular E" +
    "xpressions)";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(277, 17);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Remove the following words before translating:";
            // 
            // wordsToRemoveMemoEdit
            // 
            this.wordsToRemoveMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordsToRemoveMemoEdit.CueText = null;
            this.wordsToRemoveMemoEdit.Location = new System.Drawing.Point(12, 32);
            this.wordsToRemoveMemoEdit.Name = "wordsToRemoveMemoEdit";
            this.wordsToRemoveMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wordsToRemoveMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.wordsToRemoveMemoEdit.Properties.NullValuePrompt = null;
            this.wordsToRemoveMemoEdit.Size = new System.Drawing.Size(419, 258);
            this.wordsToRemoveMemoEdit.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(299, 385);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 28);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.WantDrawFocusRectangle = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(380, 385);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.WantDrawFocusRectangle = true;
            // 
            // appIDMemoEdit
            // 
            this.appIDMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appIDMemoEdit.CueText = null;
            this.appIDMemoEdit.Location = new System.Drawing.Point(12, 154);
            this.appIDMemoEdit.Name = "appIDMemoEdit";
            this.appIDMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.appIDMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.appIDMemoEdit.Properties.NullValuePrompt = null;
            this.appIDMemoEdit.Size = new System.Drawing.Size(419, 177);
            this.appIDMemoEdit.TabIndex = 5;
            // 
            // TranslateOptionsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(461, 419);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(398, 373);
            this.Name = "TranslateOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Translation settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoTranslateOptionsForm_FormClosing);
            this.Load += new System.EventHandler(this.AutoTranslateOptionsForm_Load);
            this.Shown += new System.EventHandler(this.TranslateOptionsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.engineTabPage.ResumeLayout(false);
            this.engineTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIDLinkControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appIDTextEdit.Properties)).EndInit();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditContinueOnErrors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationDelayTextEdit.Properties)).EndInit();
            this.wordsToKeepTabPage.ResumeLayout(false);
            this.wordsToKeepTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsToProtectMemoEdit.Properties)).EndInit();
            this.wordsToRemoveTabPage.ResumeLayout(false);
            this.wordsToRemoveTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsToRemoveMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appIDMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
        private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit translationDelayTextEdit;
        private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit checkEditContinueOnErrors;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
        private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit engineComboBox;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
        private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl xtraTabControl1;
        private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage settingsTabPage;
        private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage wordsToKeepTabPage;
        private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit wordsToProtectMemoEdit;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
        private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage wordsToRemoveTabPage;
        private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit wordsToRemoveMemoEdit;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl5;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl6;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonAddDefaultWordsToKeep;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl appIDLabel;
        private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit appIDTextEdit;
        private ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit appIDLinkControl;
        private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage engineTabPage;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl myLabelControl1;
        private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit appIDMemoEdit;
    }
}