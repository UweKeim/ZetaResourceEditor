namespace ZetaResourceEditor.UI.Tools
{
	partial class ReplaceForm
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
            this.whiteSpaceAwareCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.textToReplaceComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.textToFindComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.simpleButton1 = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.simpleButton2 = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whiteSpaceAwareCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textToReplaceComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textToFindComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.whiteSpaceAwareCheckEdit);
            this.panelControl1.Controls.Add(this.textToReplaceComboBox);
            this.panelControl1.Controls.Add(this.textToFindComboBox);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
            this.panelControl1.Size = new System.Drawing.Size(453, 156);
            this.panelControl1.TabIndex = 0;
            // 
            // whiteSpaceAwareCheckEdit
            // 
            this.whiteSpaceAwareCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.whiteSpaceAwareCheckEdit.Location = new System.Drawing.Point(12, 120);
            this.whiteSpaceAwareCheckEdit.Name = "whiteSpaceAwareCheckEdit";
            this.whiteSpaceAwareCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.whiteSpaceAwareCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.whiteSpaceAwareCheckEdit.Properties.AutoWidth = true;
            this.whiteSpaceAwareCheckEdit.Properties.Caption = "White-space aware";
            this.whiteSpaceAwareCheckEdit.Size = new System.Drawing.Size(133, 21);
            this.whiteSpaceAwareCheckEdit.TabIndex = 6;
            // 
            // textToReplaceComboBox
            // 
            this.textToReplaceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textToReplaceComboBox.CueText = null;
            this.textToReplaceComboBox.Location = new System.Drawing.Point(12, 76);
            this.textToReplaceComboBox.Name = "textToReplaceComboBox";
            this.textToReplaceComboBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textToReplaceComboBox.Properties.Appearance.Options.UseFont = true;
            this.textToReplaceComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textToReplaceComboBox.Properties.NullValuePrompt = null;
            this.textToReplaceComboBox.Size = new System.Drawing.Size(429, 24);
            this.textToReplaceComboBox.TabIndex = 3;
            this.textToReplaceComboBox.EditValueChanged += new System.EventHandler(this.textToReplaceComboBox_TextUpdate);
            // 
            // textToFindComboBox
            // 
            this.textToFindComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textToFindComboBox.CueText = null;
            this.textToFindComboBox.Location = new System.Drawing.Point(12, 29);
            this.textToFindComboBox.Name = "textToFindComboBox";
            this.textToFindComboBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textToFindComboBox.Properties.Appearance.Options.UseFont = true;
            this.textToFindComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textToFindComboBox.Properties.NullValuePrompt = null;
            this.textToFindComboBox.Size = new System.Drawing.Size(429, 24);
            this.textToFindComboBox.TabIndex = 1;
            this.textToFindComboBox.EditValueChanged += new System.EventHandler(this.textToFindComboBox_TextUpdate);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Location = new System.Drawing.Point(265, 116);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 28);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Replace all";
            this.simpleButton1.WantDrawFocusRectangle = true;
            this.simpleButton1.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Location = new System.Drawing.Point(12, 59);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Text to &replace with:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(356, 116);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(85, 28);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.WantDrawFocusRectangle = true;
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Text to find:";
            // 
            // ReplaceForm
            // 
            this.AcceptButton = this.simpleButton1;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.simpleButton2;
            this.ClientSize = new System.Drawing.Size(453, 156);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 195);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(469, 195);
            this.Name = "ReplaceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
            this.Load += new System.EventHandler(this.ReplaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whiteSpaceAwareCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textToReplaceComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textToFindComboBox.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit textToFindComboBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton simpleButton1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton simpleButton2;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit textToReplaceComboBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit whiteSpaceAwareCheckEdit;
	}
}