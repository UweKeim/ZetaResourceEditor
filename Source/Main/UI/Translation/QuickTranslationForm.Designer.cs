namespace ZetaResourceEditor.UI.Translation
{
	partial class QuickTranslationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickTranslationForm));
            this.closeButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.groupControl1 = new ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl();
            this.destinationTextTextBox = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.buttonCopyToClipboard = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.groupControl2 = new ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl();
            this.buttonSwap = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.sourceLanguageComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.destinationLanguageComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
            this.labelControl3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.copyDestinationTextToClipboardCheckBox = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.sourceTextTextBox = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.buttonTranslate = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.buttonSettings = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationTextTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceLanguageComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLanguageComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDestinationTextToClipboardCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTextTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.closeButton.Appearance.Options.UseFont = true;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.Location = new System.Drawing.Point(389, 446);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 28);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.WantDrawFocusRectangle = true;
            this.closeButton.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.destinationTextTextBox);
            this.groupControl1.Controls.Add(this.buttonCopyToClipboard);
            this.groupControl1.HasPadding = true;
            this.groupControl1.Location = new System.Drawing.Point(12, 263);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(452, 170);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Translated text";
            // 
            // destinationTextTextBox
            // 
            this.destinationTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationTextTextBox.CueText = null;
            this.destinationTextTextBox.Location = new System.Drawing.Point(14, 36);
            this.destinationTextTextBox.Name = "destinationTextTextBox";
            this.destinationTextTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.destinationTextTextBox.Properties.Appearance.Options.UseFont = true;
            this.destinationTextTextBox.Properties.NullValuePrompt = null;
            this.destinationTextTextBox.Size = new System.Drawing.Size(424, 86);
            this.destinationTextTextBox.TabIndex = 0;
            this.destinationTextTextBox.TextChanged += new System.EventHandler(this.destinationTextTextBox_TextChanged);
            this.destinationTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.destinationTextTextBox_KeyDown);
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopyToClipboard.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCopyToClipboard.Appearance.Options.UseFont = true;
            this.buttonCopyToClipboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(14, 128);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(127, 28);
            this.buttonCopyToClipboard.TabIndex = 1;
            this.buttonCopyToClipboard.Text = "&Copy to clipboard";
            this.buttonCopyToClipboard.WantDrawFocusRectangle = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.buttonSwap);
            this.groupControl2.Controls.Add(this.sourceLanguageComboBox);
            this.groupControl2.Controls.Add(this.destinationLanguageComboBox);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.copyDestinationTextToClipboardCheckBox);
            this.groupControl2.Controls.Add(this.sourceTextTextBox);
            this.groupControl2.Controls.Add(this.buttonTranslate);
            this.groupControl2.HasPadding = true;
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(452, 245);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Source";
            // 
            // buttonSwap
            // 
            this.buttonSwap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSwap.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonSwap.Appearance.Options.UseFont = true;
            this.buttonSwap.Image = ((System.Drawing.Image)(resources.GetObject("buttonSwap.Image")));
            this.buttonSwap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.buttonSwap.Location = new System.Drawing.Point(412, 48);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(26, 26);
            this.buttonSwap.TabIndex = 4;
            this.buttonSwap.WantDrawFocusRectangle = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // sourceLanguageComboBox
            // 
            this.sourceLanguageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceLanguageComboBox.CueText = null;
            this.sourceLanguageComboBox.Location = new System.Drawing.Point(145, 36);
            this.sourceLanguageComboBox.Name = "sourceLanguageComboBox";
            this.sourceLanguageComboBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sourceLanguageComboBox.Properties.Appearance.Options.UseFont = true;
            this.sourceLanguageComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sourceLanguageComboBox.Properties.DropDownRows = 20;
            this.sourceLanguageComboBox.Properties.NullValuePrompt = null;
            this.sourceLanguageComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.sourceLanguageComboBox.Size = new System.Drawing.Size(262, 24);
            this.sourceLanguageComboBox.TabIndex = 1;
            this.sourceLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.sourceLanguageComboBox_SelectedIndexChanged);
            // 
            // destinationLanguageComboBox
            // 
            this.destinationLanguageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationLanguageComboBox.CueText = null;
            this.destinationLanguageComboBox.Location = new System.Drawing.Point(145, 66);
            this.destinationLanguageComboBox.Name = "destinationLanguageComboBox";
            this.destinationLanguageComboBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.destinationLanguageComboBox.Properties.Appearance.Options.UseFont = true;
            this.destinationLanguageComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.destinationLanguageComboBox.Properties.DropDownRows = 20;
            this.destinationLanguageComboBox.Properties.NullValuePrompt = null;
            this.destinationLanguageComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.destinationLanguageComboBox.Size = new System.Drawing.Size(262, 24);
            this.destinationLanguageComboBox.TabIndex = 3;
            this.destinationLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.destinationLanguageComboBox_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl3.Location = new System.Drawing.Point(13, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Source te&xt:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl2.Location = new System.Drawing.Point(13, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "&Destination language:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Location = new System.Drawing.Point(13, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "&Source language:";
            // 
            // copyDestinationTextToClipboardCheckBox
            // 
            this.copyDestinationTextToClipboardCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyDestinationTextToClipboardCheckBox.Location = new System.Drawing.Point(223, 207);
            this.copyDestinationTextToClipboardCheckBox.Name = "copyDestinationTextToClipboardCheckBox";
            this.copyDestinationTextToClipboardCheckBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.copyDestinationTextToClipboardCheckBox.Properties.Appearance.Options.UseFont = true;
            this.copyDestinationTextToClipboardCheckBox.Properties.AutoWidth = true;
            this.copyDestinationTextToClipboardCheckBox.Properties.Caption = "Copy translated text to &clipboard";
            this.copyDestinationTextToClipboardCheckBox.Properties.CheckedChanged += new System.EventHandler(this.copyDestinationTextToClipboardCheckBox_CheckedChanged);
            this.copyDestinationTextToClipboardCheckBox.Size = new System.Drawing.Size(215, 21);
            this.copyDestinationTextToClipboardCheckBox.TabIndex = 7;
            // 
            // sourceTextTextBox
            // 
            this.sourceTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTextTextBox.CueText = null;
            this.sourceTextTextBox.Location = new System.Drawing.Point(14, 119);
            this.sourceTextTextBox.Name = "sourceTextTextBox";
            this.sourceTextTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sourceTextTextBox.Properties.Appearance.Options.UseFont = true;
            this.sourceTextTextBox.Properties.NullValuePrompt = null;
            this.sourceTextTextBox.Size = new System.Drawing.Size(424, 78);
            this.sourceTextTextBox.TabIndex = 5;
            this.sourceTextTextBox.TextChanged += new System.EventHandler(this.sourceTextTextBox_TextChanged);
            this.sourceTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sourceTextTextBox_KeyDown);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTranslate.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonTranslate.Appearance.Options.UseFont = true;
            this.buttonTranslate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonTranslate.Location = new System.Drawing.Point(13, 203);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(75, 28);
            this.buttonTranslate.TabIndex = 6;
            this.buttonTranslate.Text = "&Translate";
            this.buttonTranslate.WantDrawFocusRectangle = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.buttonSettings);
            this.panelControl1.Controls.Add(this.closeButton);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
            this.panelControl1.Size = new System.Drawing.Size(476, 486);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(93, 452);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(18, 17);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "<>";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonSettings.Appearance.Options.UseFont = true;
            this.buttonSettings.Location = new System.Drawing.Point(12, 446);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 28);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.WantDrawFocusRectangle = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // QuickTranslationForm
            // 
            this.AcceptButton = this.buttonTranslate;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(476, 486);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 520);
            this.Name = "QuickTranslationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick translate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuickTranslationForm_FormClosing);
            this.Load += new System.EventHandler(this.QuickTranslationForm_Load);
            this.Shown += new System.EventHandler(this.QuickTranslationForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinationTextTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceLanguageComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLanguageComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDestinationTextToClipboardCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTextTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton closeButton;
		private ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl groupControl1;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit destinationTextTextBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCopyToClipboard;
		private ExtendedControlsLibrary.Skinning.CustomGroup.MyGroupControl groupControl2;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit copyDestinationTextToClipboardCheckBox;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit sourceTextTextBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonTranslate;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit destinationLanguageComboBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit sourceLanguageComboBox;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonSettings;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonSwap;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
	}
}