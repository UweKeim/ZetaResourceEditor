namespace ZetaResourceEditor.UI.Translation
{
	partial class AutoTranslateForm
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
            this.updateUITimer = new System.Windows.Forms.Timer(this.components);
            this.buttonDefault = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.prefixTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.prefixCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.buttonAll = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonInvert = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonNone = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.languagesToTranslateCheckListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
            this.referenceLanguageGroupBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.fileGroupTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.label3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.buttonTranslate = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.useExistingTranslationsCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.buttonSettings = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.useOnlyExistingTranslationsCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.prefixTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefixCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesToTranslateCheckListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceLanguageGroupBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useExistingTranslationsCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useOnlyExistingTranslationsCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // updateUITimer
            // 
            this.updateUITimer.Tick += new System.EventHandler(this.updateUITimer_Tick);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefault.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonDefault.Appearance.Options.UseFont = true;
            this.buttonDefault.Location = new System.Drawing.Point(299, 446);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(60, 26);
            this.buttonDefault.TabIndex = 11;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.WantDrawFocusRectangle = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prefixTextBox.Bold = false;
            this.prefixTextBox.CueText = null;
            this.prefixTextBox.Location = new System.Drawing.Point(193, 447);
            this.prefixTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.prefixTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.prefixTextBox.Properties.Appearance.Options.UseFont = true;
            this.prefixTextBox.Properties.Mask.EditMask = null;
            this.prefixTextBox.Properties.NullValuePrompt = null;
            this.prefixTextBox.Size = new System.Drawing.Size(100, 24);
            this.prefixTextBox.TabIndex = 10;
            this.prefixTextBox.TextChanged += new System.EventHandler(this.prefixTextBox_TextChanged);
            // 
            // prefixCheckBox
            // 
            this.prefixCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prefixCheckBox.Location = new System.Drawing.Point(10, 449);
            this.prefixCheckBox.Name = "prefixCheckBox";
            this.prefixCheckBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.prefixCheckBox.Properties.Appearance.Options.UseFont = true;
            this.prefixCheckBox.Properties.AutoWidth = true;
            this.prefixCheckBox.Properties.Caption = "Prefix translated texts with:";
            this.prefixCheckBox.Size = new System.Drawing.Size(177, 21);
            this.prefixCheckBox.TabIndex = 9;
            this.prefixCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonAll
            // 
            this.buttonAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAll.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonAll.Appearance.Options.UseFont = true;
            this.buttonAll.Location = new System.Drawing.Point(10, 405);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(75, 28);
            this.buttonAll.TabIndex = 6;
            this.buttonAll.Text = "All";
            this.buttonAll.WantDrawFocusRectangle = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonInvert
            // 
            this.buttonInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInvert.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonInvert.Appearance.Options.UseFont = true;
            this.buttonInvert.Location = new System.Drawing.Point(172, 405);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(75, 28);
            this.buttonInvert.TabIndex = 8;
            this.buttonInvert.Text = "Flip";
            this.buttonInvert.WantDrawFocusRectangle = true;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            // 
            // buttonNone
            // 
            this.buttonNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNone.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonNone.Appearance.Options.UseFont = true;
            this.buttonNone.Location = new System.Drawing.Point(91, 405);
            this.buttonNone.Name = "buttonNone";
            this.buttonNone.Size = new System.Drawing.Size(75, 28);
            this.buttonNone.TabIndex = 7;
            this.buttonNone.Text = "None";
            this.buttonNone.WantDrawFocusRectangle = true;
            this.buttonNone.Click += new System.EventHandler(this.buttonNone_Click);
            // 
            // languagesToTranslateCheckListBox
            // 
            this.languagesToTranslateCheckListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesToTranslateCheckListBox.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.languagesToTranslateCheckListBox.Appearance.Options.UseFont = true;
            this.languagesToTranslateCheckListBox.CheckOnClick = true;
            this.languagesToTranslateCheckListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.languagesToTranslateCheckListBox.Location = new System.Drawing.Point(12, 100);
            this.languagesToTranslateCheckListBox.Name = "languagesToTranslateCheckListBox";
            this.languagesToTranslateCheckListBox.Size = new System.Drawing.Size(460, 299);
            this.languagesToTranslateCheckListBox.TabIndex = 5;
            this.languagesToTranslateCheckListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.languagesToTranslateCheckListBox_ItemCheck);
            this.languagesToTranslateCheckListBox.SelectedIndexChanged += new System.EventHandler(this.languagesToTranslateCheckListBox_SelectedIndexChanged);
            // 
            // referenceLanguageGroupBox
            // 
            this.referenceLanguageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.referenceLanguageGroupBox.CueText = null;
            this.referenceLanguageGroupBox.Location = new System.Drawing.Point(137, 42);
            this.referenceLanguageGroupBox.Name = "referenceLanguageGroupBox";
            this.referenceLanguageGroupBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.referenceLanguageGroupBox.Properties.Appearance.Options.UseFont = true;
            this.referenceLanguageGroupBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.referenceLanguageGroupBox.Properties.DropDownRows = 20;
            this.referenceLanguageGroupBox.Properties.NullValuePrompt = null;
            this.referenceLanguageGroupBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.referenceLanguageGroupBox.Properties.SelectedIndexChanged += new System.EventHandler(this.referenceLanguageGroupBox_SelectedIndexChanged);
            this.referenceLanguageGroupBox.Size = new System.Drawing.Size(335, 24);
            this.referenceLanguageGroupBox.TabIndex = 3;
            // 
            // fileGroupTextBox
            // 
            this.fileGroupTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGroupTextBox.Bold = false;
            this.fileGroupTextBox.CueText = null;
            this.fileGroupTextBox.Location = new System.Drawing.Point(137, 12);
            this.fileGroupTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.fileGroupTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.fileGroupTextBox.Name = "fileGroupTextBox";
            this.fileGroupTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileGroupTextBox.Properties.Appearance.Options.UseFont = true;
            this.fileGroupTextBox.Properties.Mask.EditMask = null;
            this.fileGroupTextBox.Properties.NullValuePrompt = null;
            this.fileGroupTextBox.Properties.ReadOnly = true;
            this.fileGroupTextBox.Size = new System.Drawing.Size(335, 24);
            this.fileGroupTextBox.TabIndex = 1;
            this.fileGroupTextBox.TextChanged += new System.EventHandler(this.fileGroupTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "L&anguages to translate:";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Reference language:";
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File group:";
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTranslate.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonTranslate.Appearance.Options.UseFont = true;
            this.buttonTranslate.Location = new System.Drawing.Point(275, 541);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(116, 28);
            this.buttonTranslate.TabIndex = 14;
            this.buttonTranslate.Text = "Translate now";
            this.buttonTranslate.WantDrawFocusRectangle = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(397, 541);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.WantDrawFocusRectangle = true;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.useOnlyExistingTranslationsCheckEdit);
            this.panelControl1.Controls.Add(this.useExistingTranslationsCheckBox);
            this.panelControl1.Controls.Add(this.buttonDefault);
            this.panelControl1.Controls.Add(this.prefixTextBox);
            this.panelControl1.Controls.Add(this.buttonCancel);
            this.panelControl1.Controls.Add(this.prefixCheckBox);
            this.panelControl1.Controls.Add(this.buttonAll);
            this.panelControl1.Controls.Add(this.buttonTranslate);
            this.panelControl1.Controls.Add(this.buttonInvert);
            this.panelControl1.Controls.Add(this.buttonSettings);
            this.panelControl1.Controls.Add(this.buttonNone);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.languagesToTranslateCheckListBox);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.referenceLanguageGroupBox);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.fileGroupTextBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
            this.panelControl1.Size = new System.Drawing.Size(484, 581);
            this.panelControl1.TabIndex = 0;
            // 
            // useExistingTranslationsCheckBox
            // 
            this.useExistingTranslationsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.useExistingTranslationsCheckBox.Location = new System.Drawing.Point(10, 476);
            this.useExistingTranslationsCheckBox.Name = "useExistingTranslationsCheckBox";
            this.useExistingTranslationsCheckBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.useExistingTranslationsCheckBox.Properties.Appearance.Options.UseFont = true;
            this.useExistingTranslationsCheckBox.Properties.AutoWidth = true;
            this.useExistingTranslationsCheckBox.Properties.Caption = "Use existing translations, if available";
            this.useExistingTranslationsCheckBox.Size = new System.Drawing.Size(232, 21);
            this.useExistingTranslationsCheckBox.TabIndex = 12;
            this.useExistingTranslationsCheckBox.CheckedChanged += new System.EventHandler(this.useExistingTranslationsCheckBox_CheckedChanged);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonSettings.Appearance.Options.UseFont = true;
            this.buttonSettings.Location = new System.Drawing.Point(12, 541);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 28);
            this.buttonSettings.TabIndex = 16;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.WantDrawFocusRectangle = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(93, 547);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 17);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "<>";
            // 
            // useOnlyExistingTranslationsCheckEdit
            // 
            this.useOnlyExistingTranslationsCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.useOnlyExistingTranslationsCheckEdit.Location = new System.Drawing.Point(10, 503);
            this.useOnlyExistingTranslationsCheckEdit.Name = "useOnlyExistingTranslationsCheckEdit";
            this.useOnlyExistingTranslationsCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.useOnlyExistingTranslationsCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.useOnlyExistingTranslationsCheckEdit.Properties.AutoWidth = true;
            this.useOnlyExistingTranslationsCheckEdit.Properties.Caption = "Use only existing translations, if available, never call translation service";
            this.useOnlyExistingTranslationsCheckEdit.Size = new System.Drawing.Size(431, 21);
            this.useOnlyExistingTranslationsCheckEdit.TabIndex = 13;
            this.useOnlyExistingTranslationsCheckEdit.CheckedChanged += new System.EventHandler(this.useOnlyExistingTranslationsCheckEdit_CheckedChanged);
            // 
            // AutoTranslateForm
            // 
            this.AcceptButton = this.buttonTranslate;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(484, 581);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 401);
            this.Name = "AutoTranslateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Automatically translate missing languages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.autoTranslateForm_FormClosing);
            this.Load += new System.EventHandler(this.autoTranslateForm_Load);
            this.Shown += new System.EventHandler(this.autoTranslateForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.prefixTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefixCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesToTranslateCheckListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceLanguageGroupBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useExistingTranslationsCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useOnlyExistingTranslationsCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer updateUITimer;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonTranslate;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit prefixTextBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit prefixCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonAll;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonInvert;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonNone;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl languagesToTranslateCheckListBox;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit referenceLanguageGroupBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit fileGroupTextBox;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonDefault;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonSettings;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
        private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useExistingTranslationsCheckBox;
        private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useOnlyExistingTranslationsCheckEdit;
    }
}