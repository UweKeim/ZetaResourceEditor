namespace ZetaResourceEditor.UI.Main.RightContent
{
	partial class ConfigureLanguageColumnsForm
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
            this.panel1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.selectAllLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.invertLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectNoLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.languagesToDisplayCheckListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
            this.displayAllLanguagesCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.displayCertainLanguagesCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languagesToDisplayCheckListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAllLanguagesCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayCertainLanguagesCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Appearance.Options.UseBackColor = true;
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel1.Controls.Add(this.selectAllLanguagesToExportButton);
            this.panel1.Controls.Add(this.invertLanguagesToExportButton);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.selectNoLanguagesToExportButton);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.languagesToDisplayCheckListBox);
            this.panel1.Controls.Add(this.displayAllLanguagesCheckEdit);
            this.panel1.Controls.Add(this.displayCertainLanguagesCheckEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9);
            this.panel1.Size = new System.Drawing.Size(454, 348);
            this.panel1.TabIndex = 0;
            // 
            // selectAllLanguagesToExportButton
            // 
            this.selectAllLanguagesToExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllLanguagesToExportButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectAllLanguagesToExportButton.Appearance.Options.UseFont = true;
            this.selectAllLanguagesToExportButton.Location = new System.Drawing.Point(31, 254);
            this.selectAllLanguagesToExportButton.Name = "selectAllLanguagesToExportButton";
            this.selectAllLanguagesToExportButton.Size = new System.Drawing.Size(75, 28);
            this.selectAllLanguagesToExportButton.TabIndex = 3;
            this.selectAllLanguagesToExportButton.Text = "All";
            this.selectAllLanguagesToExportButton.WantDrawFocusRectangle = true;
            this.selectAllLanguagesToExportButton.Click += new System.EventHandler(this.selectAllLanguagesToExportButton_Click);
            // 
            // invertLanguagesToExportButton
            // 
            this.invertLanguagesToExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invertLanguagesToExportButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invertLanguagesToExportButton.Appearance.Options.UseFont = true;
            this.invertLanguagesToExportButton.Location = new System.Drawing.Point(193, 254);
            this.invertLanguagesToExportButton.Name = "invertLanguagesToExportButton";
            this.invertLanguagesToExportButton.Size = new System.Drawing.Size(75, 28);
            this.invertLanguagesToExportButton.TabIndex = 5;
            this.invertLanguagesToExportButton.Text = "Flip";
            this.invertLanguagesToExportButton.WantDrawFocusRectangle = true;
            this.invertLanguagesToExportButton.Click += new System.EventHandler(this.invertLanguagesToExportButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(367, 308);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.WantDrawFocusRectangle = true;
            // 
            // selectNoLanguagesToExportButton
            // 
            this.selectNoLanguagesToExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectNoLanguagesToExportButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectNoLanguagesToExportButton.Appearance.Options.UseFont = true;
            this.selectNoLanguagesToExportButton.Location = new System.Drawing.Point(112, 254);
            this.selectNoLanguagesToExportButton.Name = "selectNoLanguagesToExportButton";
            this.selectNoLanguagesToExportButton.Size = new System.Drawing.Size(75, 28);
            this.selectNoLanguagesToExportButton.TabIndex = 4;
            this.selectNoLanguagesToExportButton.Text = "None";
            this.selectNoLanguagesToExportButton.WantDrawFocusRectangle = true;
            this.selectNoLanguagesToExportButton.Click += new System.EventHandler(this.selectNoLanguagesToExportButton_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(286, 308);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 28);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.WantDrawFocusRectangle = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // languagesToDisplayCheckListBox
            // 
            this.languagesToDisplayCheckListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesToDisplayCheckListBox.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.languagesToDisplayCheckListBox.Appearance.Options.UseFont = true;
            this.languagesToDisplayCheckListBox.CheckOnClick = true;
            this.languagesToDisplayCheckListBox.Location = new System.Drawing.Point(31, 66);
            this.languagesToDisplayCheckListBox.Name = "languagesToDisplayCheckListBox";
            this.languagesToDisplayCheckListBox.Size = new System.Drawing.Size(411, 182);
            this.languagesToDisplayCheckListBox.TabIndex = 2;
            this.languagesToDisplayCheckListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.languagesToDisplayCheckListBox_ItemCheck);
            this.languagesToDisplayCheckListBox.SelectedIndexChanged += new System.EventHandler(this.languagesToDisplayCheckListBox_SelectedIndexChanged);
            // 
            // displayAllLanguagesCheckEdit
            // 
            this.displayAllLanguagesCheckEdit.EditValue = true;
            this.displayAllLanguagesCheckEdit.Location = new System.Drawing.Point(10, 10);
            this.displayAllLanguagesCheckEdit.Name = "displayAllLanguagesCheckEdit";
            this.displayAllLanguagesCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.displayAllLanguagesCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.displayAllLanguagesCheckEdit.Properties.AutoWidth = true;
            this.displayAllLanguagesCheckEdit.Properties.Caption = "Display all languages";
            this.displayAllLanguagesCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.displayAllLanguagesCheckEdit.Properties.RadioGroupIndex = 0;
            this.displayAllLanguagesCheckEdit.Size = new System.Drawing.Size(145, 21);
            this.displayAllLanguagesCheckEdit.TabIndex = 0;
            this.displayAllLanguagesCheckEdit.CheckedChanged += new System.EventHandler(this.displayAllLanguagesCheckEdit_CheckedChanged);
            // 
            // displayCertainLanguagesCheckEdit
            // 
            this.displayCertainLanguagesCheckEdit.Location = new System.Drawing.Point(12, 39);
            this.displayCertainLanguagesCheckEdit.Name = "displayCertainLanguagesCheckEdit";
            this.displayCertainLanguagesCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.displayCertainLanguagesCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.displayCertainLanguagesCheckEdit.Properties.AutoWidth = true;
            this.displayCertainLanguagesCheckEdit.Properties.Caption = "Display only the following languages:";
            this.displayCertainLanguagesCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.displayCertainLanguagesCheckEdit.Properties.RadioGroupIndex = 0;
            this.displayCertainLanguagesCheckEdit.Size = new System.Drawing.Size(238, 21);
            this.displayCertainLanguagesCheckEdit.TabIndex = 1;
            this.displayCertainLanguagesCheckEdit.TabStop = false;
            this.displayCertainLanguagesCheckEdit.CheckedChanged += new System.EventHandler(this.displayCertainLanguagesCheckEdit_CheckedChanged);
            // 
            // ConfigureLanguageColumnsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(454, 348);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 386);
            this.Name = "ConfigureLanguageColumnsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure language columns";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.configureLanguageColumnsForm_FormClosing);
            this.Load += new System.EventHandler(this.configureLanguageColumnsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languagesToDisplayCheckListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAllLanguagesCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayCertainLanguagesCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panel1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit displayAllLanguagesCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit displayCertainLanguagesCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl languagesToDisplayCheckListBox;
	}
}