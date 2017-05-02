namespace ZetaResourceEditor.UI.FileGroups
{
    partial class MergeFileGroupForm
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
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.filesToMergeControl = new ZetaResourceEditor.UI.FileGroups.FileGroupSelectionControl();
            this.invertFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectNoFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.selectAllFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.filesToMergeLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.fileGroupToMergeIntoTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesToMergeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupToMergeIntoTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.filesToMergeControl);
            this.panelControl1.Controls.Add(this.invertFileGroupsButton);
            this.panelControl1.Controls.Add(this.selectNoFileGroupsButton);
            this.panelControl1.Controls.Add(this.selectAllFileGroupsButton);
            this.panelControl1.Controls.Add(this.buttonCancel);
            this.panelControl1.Controls.Add(this.buttonOK);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.filesToMergeLabel);
            this.panelControl1.Controls.Add(this.fileGroupToMergeIntoTextBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
            this.panelControl1.Size = new System.Drawing.Size(584, 611);
            this.panelControl1.TabIndex = 0;
            // 
            // filesToMergeControl
            // 
            this.filesToMergeControl.AllowDrop = true;
            this.filesToMergeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesToMergeControl.EmptyText = "No items";
            this.filesToMergeControl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.filesToMergeControl.Location = new System.Drawing.Point(12, 91);
            this.filesToMergeControl.Name = "filesToMergeControl";
            this.filesToMergeControl.Size = new System.Drawing.Size(560, 466);
            this.filesToMergeControl.TabIndex = 4;
            this.filesToMergeControl.NodeChecked += new System.EventHandler(this.filesToMergeControl_NodeChecked);
            // 
            // invertFileGroupsButton
            // 
            this.invertFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invertFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invertFileGroupsButton.Appearance.Options.UseFont = true;
            this.invertFileGroupsButton.Location = new System.Drawing.Point(174, 571);
            this.invertFileGroupsButton.Name = "invertFileGroupsButton";
            this.invertFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.invertFileGroupsButton.TabIndex = 9;
            this.invertFileGroupsButton.Text = "&Flip";
            this.invertFileGroupsButton.WantDrawFocusRectangle = true;
            this.invertFileGroupsButton.Click += new System.EventHandler(this.invertFileGroupsButton_Click);
            // 
            // selectNoFileGroupsButton
            // 
            this.selectNoFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectNoFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectNoFileGroupsButton.Appearance.Options.UseFont = true;
            this.selectNoFileGroupsButton.Location = new System.Drawing.Point(93, 571);
            this.selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
            this.selectNoFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.selectNoFileGroupsButton.TabIndex = 8;
            this.selectNoFileGroupsButton.Text = "&None";
            this.selectNoFileGroupsButton.WantDrawFocusRectangle = true;
            this.selectNoFileGroupsButton.Click += new System.EventHandler(this.selectNoFileGroupsButton_Click);
            // 
            // selectAllFileGroupsButton
            // 
            this.selectAllFileGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllFileGroupsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectAllFileGroupsButton.Appearance.Options.UseFont = true;
            this.selectAllFileGroupsButton.Location = new System.Drawing.Point(12, 571);
            this.selectAllFileGroupsButton.Name = "selectAllFileGroupsButton";
            this.selectAllFileGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.selectAllFileGroupsButton.TabIndex = 7;
            this.selectAllFileGroupsButton.Text = "&All";
            this.selectAllFileGroupsButton.WantDrawFocusRectangle = true;
            this.selectAllFileGroupsButton.Click += new System.EventHandler(this.selectAllFileGroupsButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(497, 571);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.WantDrawFocusRectangle = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(416, 571);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 28);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Merge";
            this.buttonOK.WantDrawFocusRectangle = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File group to merge into:";
            // 
            // filesToMergeLabel
            // 
            this.filesToMergeLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.filesToMergeLabel.Appearance.Options.UseFont = true;
            this.filesToMergeLabel.Location = new System.Drawing.Point(12, 71);
            this.filesToMergeLabel.Name = "filesToMergeLabel";
            this.filesToMergeLabel.Size = new System.Drawing.Size(86, 17);
            this.filesToMergeLabel.TabIndex = 3;
            this.filesToMergeLabel.Text = "&Files to merge:";
            // 
            // fileGroupToMergeIntoTextBox
            // 
            this.fileGroupToMergeIntoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGroupToMergeIntoTextBox.Bold = false;
            this.fileGroupToMergeIntoTextBox.CueText = null;
            this.fileGroupToMergeIntoTextBox.Location = new System.Drawing.Point(12, 32);
            this.fileGroupToMergeIntoTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.fileGroupToMergeIntoTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.fileGroupToMergeIntoTextBox.Name = "fileGroupToMergeIntoTextBox";
            this.fileGroupToMergeIntoTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileGroupToMergeIntoTextBox.Properties.Appearance.Options.UseFont = true;
            this.fileGroupToMergeIntoTextBox.Properties.Mask.EditMask = null;
            this.fileGroupToMergeIntoTextBox.Properties.NullValuePrompt = null;
            this.fileGroupToMergeIntoTextBox.Properties.ReadOnly = true;
            this.fileGroupToMergeIntoTextBox.Size = new System.Drawing.Size(558, 24);
            this.fileGroupToMergeIntoTextBox.TabIndex = 2;
            // 
            // MergeFileGroupForm
            // 
            this.AcceptButton = this.buttonOK;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 650);
            this.Name = "MergeFileGroupForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Merge files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MergeFileGroupForm_FormClosing);
            this.Load += new System.EventHandler(this.MergeFileGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesToMergeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupToMergeIntoTextBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertFileGroupsButton;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoFileGroupsButton;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllFileGroupsButton;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl filesToMergeLabel;
        private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit fileGroupToMergeIntoTextBox;
        private FileGroupSelectionControl filesToMergeControl;
    }
}