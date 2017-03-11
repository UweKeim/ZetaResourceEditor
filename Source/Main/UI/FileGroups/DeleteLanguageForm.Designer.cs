namespace ZetaResourceEditor.UI.FileGroups
{
	partial class DeleteLanguageForm
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
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.informationLightUserControl1 = new ZetaResourceEditor.UI.Helper.InformationLightUserControl();
            this.invertFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectNoFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectAllFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.destinationLanguagesListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
            this.buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.parentElementTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLanguagesListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentElementTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.informationLightUserControl1);
            this.panelControl1.Controls.Add(this.invertFileGroupsButton);
            this.panelControl1.Controls.Add(this.selectNoFileGroupsButton);
            this.panelControl1.Controls.Add(this.selectAllFileGroupsButton);
            this.panelControl1.Controls.Add(this.buttonCancel);
            this.panelControl1.Controls.Add(this.destinationLanguagesListBox);
            this.panelControl1.Controls.Add(this.buttonOK);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.parentElementTextBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
            this.panelControl1.Size = new System.Drawing.Size(539, 457);
            this.panelControl1.TabIndex = 0;
            // 
            // informationLightUserControl1
            // 
            this.informationLightUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationLightUserControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.informationLightUserControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.informationLightUserControl1.DescriptionText = "Deletes language files for the checked languages.";
            this.informationLightUserControl1.Location = new System.Drawing.Point(12, 12);
            this.informationLightUserControl1.MinimumSize = new System.Drawing.Size(167, 24);
            this.informationLightUserControl1.Name = "informationLightUserControl1";
            this.informationLightUserControl1.Padding = new System.Windows.Forms.Padding(1);
            this.informationLightUserControl1.Size = new System.Drawing.Size(515, 25);
            this.informationLightUserControl1.TabIndex = 0;
            // 
            // invertFileGroupsButton
            // 
            this.invertFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invertFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invertFileGroupsButton.Appearance.Options.UseFont = true;
            this.invertFileGroupsButton.Location = new System.Drawing.Point(304, 369);
            this.invertFileGroupsButton.Name = "invertFileGroupsButton";
            this.invertFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.invertFileGroupsButton.TabIndex = 7;
            this.invertFileGroupsButton.Text = "Flip";
            this.invertFileGroupsButton.WantDrawFocusRectangle = true;
            this.invertFileGroupsButton.Click += new System.EventHandler(this.invertFileGroupsButton_Click);
            // 
            // selectNoFileGroupsButton
            // 
            this.selectNoFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectNoFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectNoFileGroupsButton.Appearance.Options.UseFont = true;
            this.selectNoFileGroupsButton.Location = new System.Drawing.Point(223, 369);
            this.selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
            this.selectNoFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.selectNoFileGroupsButton.TabIndex = 6;
            this.selectNoFileGroupsButton.Text = "None";
            this.selectNoFileGroupsButton.WantDrawFocusRectangle = true;
            this.selectNoFileGroupsButton.Click += new System.EventHandler(this.selectNoFileGroupsButton_Click);
            // 
            // selectAllFileGroupsButton
            // 
            this.selectAllFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectAllFileGroupsButton.Appearance.Options.UseFont = true;
            this.selectAllFileGroupsButton.Location = new System.Drawing.Point(142, 369);
            this.selectAllFileGroupsButton.Name = "selectAllFileGroupsButton";
            this.selectAllFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.selectAllFileGroupsButton.TabIndex = 5;
            this.selectAllFileGroupsButton.Text = "All";
            this.selectAllFileGroupsButton.WantDrawFocusRectangle = true;
            this.selectAllFileGroupsButton.Click += new System.EventHandler(this.selectAllFileGroupsButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(452, 417);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.WantDrawFocusRectangle = true;
            // 
            // destinationLanguagesListBox
            // 
            this.destinationLanguagesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationLanguagesListBox.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.destinationLanguagesListBox.Appearance.Options.UseFont = true;
            this.destinationLanguagesListBox.CheckOnClick = true;
            this.destinationLanguagesListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.destinationLanguagesListBox.Location = new System.Drawing.Point(142, 92);
            this.destinationLanguagesListBox.Name = "destinationLanguagesListBox";
            this.destinationLanguagesListBox.Size = new System.Drawing.Size(385, 271);
            this.destinationLanguagesListBox.TabIndex = 4;
            this.destinationLanguagesListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.destinationLanguagesListBox_ItemCheck);
            this.destinationLanguagesListBox.SelectedIndexChanged += new System.EventHandler(this.destinationLanguagesListBox_SelectedIndexChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(371, 417);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 28);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.WantDrawFocusRectangle = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parent element:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "&Languages to delete:";
            // 
            // parentElementTextBox
            // 
            this.parentElementTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parentElementTextBox.Bold = false;
            this.parentElementTextBox.CueText = null;
            this.parentElementTextBox.Location = new System.Drawing.Point(142, 53);
            this.parentElementTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.parentElementTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.parentElementTextBox.Name = "parentElementTextBox";
            this.parentElementTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.parentElementTextBox.Properties.Appearance.Options.UseFont = true;
            this.parentElementTextBox.Properties.Mask.EditMask = null;
            this.parentElementTextBox.Properties.NullValuePrompt = null;
            this.parentElementTextBox.Properties.ReadOnly = true;
            this.parentElementTextBox.Size = new System.Drawing.Size(385, 24);
            this.parentElementTextBox.TabIndex = 2;
            // 
            // DeleteLanguageForm
            // 
            this.AcceptButton = this.buttonOK;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(539, 457);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(555, 495);
            this.Name = "DeleteLanguageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete multiple files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewFileForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateNewFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLanguagesListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentElementTextBox.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit parentElementTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl destinationLanguagesListBox;
        private Helper.InformationLightUserControl informationLightUserControl1;
    }
}