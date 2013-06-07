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
			this.closeButton = new DevExpress.XtraEditors.SimpleButton();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.destinationTextTextBox = new DevExpress.XtraEditors.MemoEdit();
			this.buttonCopyToClipboard = new DevExpress.XtraEditors.SimpleButton();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.buttonSwap = new DevExpress.XtraEditors.SimpleButton();
			this.sourceLanguageComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
			this.destinationLanguageComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.copyDestinationTextToClipboardCheckBox = new DevExpress.XtraEditors.CheckEdit();
			this.sourceTextTextBox = new DevExpress.XtraEditors.MemoEdit();
			this.buttonTranslate = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.buttonSettings = new DevExpress.XtraEditors.SimpleButton();
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
			resources.ApplyResources(this.closeButton, "closeButton");
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.closeButton.Name = "closeButton";
			this.closeButton.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// groupControl1
			// 
			resources.ApplyResources(this.groupControl1, "groupControl1");
			this.groupControl1.Controls.Add(this.destinationTextTextBox);
			this.groupControl1.Controls.Add(this.buttonCopyToClipboard);
			this.groupControl1.Name = "groupControl1";
			// 
			// destinationTextTextBox
			// 
			resources.ApplyResources(this.destinationTextTextBox, "destinationTextTextBox");
			this.destinationTextTextBox.Name = "destinationTextTextBox";
			this.destinationTextTextBox.Properties.NullValuePrompt = resources.GetString("destinationTextTextBox.Properties.NullValuePrompt");
			this.destinationTextTextBox.TextChanged += new System.EventHandler(this.destinationTextTextBox_TextChanged);
			this.destinationTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.destinationTextTextBox_KeyDown);
			// 
			// buttonCopyToClipboard
			// 
			resources.ApplyResources(this.buttonCopyToClipboard, "buttonCopyToClipboard");
			this.buttonCopyToClipboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
			this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
			// 
			// groupControl2
			// 
			resources.ApplyResources(this.groupControl2, "groupControl2");
			this.groupControl2.Controls.Add(this.buttonSwap);
			this.groupControl2.Controls.Add(this.sourceLanguageComboBox);
			this.groupControl2.Controls.Add(this.destinationLanguageComboBox);
			this.groupControl2.Controls.Add(this.labelControl3);
			this.groupControl2.Controls.Add(this.labelControl2);
			this.groupControl2.Controls.Add(this.labelControl1);
			this.groupControl2.Controls.Add(this.copyDestinationTextToClipboardCheckBox);
			this.groupControl2.Controls.Add(this.sourceTextTextBox);
			this.groupControl2.Controls.Add(this.buttonTranslate);
			this.groupControl2.Name = "groupControl2";
			// 
			// buttonSwap
			// 
			resources.ApplyResources(this.buttonSwap, "buttonSwap");
			this.buttonSwap.Image = ((System.Drawing.Image)(resources.GetObject("buttonSwap.Image")));
			this.buttonSwap.Name = "buttonSwap";
			this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
			// 
			// sourceLanguageComboBox
			// 
			resources.ApplyResources(this.sourceLanguageComboBox, "sourceLanguageComboBox");
			this.sourceLanguageComboBox.Name = "sourceLanguageComboBox";
			this.sourceLanguageComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("sourceLanguageComboBox.Properties.Buttons"))))});
			this.sourceLanguageComboBox.Properties.DropDownRows = 20;
			this.sourceLanguageComboBox.Properties.NullValuePrompt = resources.GetString("sourceLanguageComboBox.Properties.NullValuePrompt");
			this.sourceLanguageComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.sourceLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.sourceLanguageComboBox_SelectedIndexChanged);
			// 
			// destinationLanguageComboBox
			// 
			resources.ApplyResources(this.destinationLanguageComboBox, "destinationLanguageComboBox");
			this.destinationLanguageComboBox.Name = "destinationLanguageComboBox";
			this.destinationLanguageComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("destinationLanguageComboBox.Properties.Buttons"))))});
			this.destinationLanguageComboBox.Properties.DropDownRows = 20;
			this.destinationLanguageComboBox.Properties.NullValuePrompt = resources.GetString("destinationLanguageComboBox.Properties.NullValuePrompt");
			this.destinationLanguageComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.destinationLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.destinationLanguageComboBox_SelectedIndexChanged);
			// 
			// labelControl3
			// 
			resources.ApplyResources(this.labelControl3, "labelControl3");
			this.labelControl3.Name = "labelControl3";
			// 
			// labelControl2
			// 
			resources.ApplyResources(this.labelControl2, "labelControl2");
			this.labelControl2.Name = "labelControl2";
			// 
			// labelControl1
			// 
			resources.ApplyResources(this.labelControl1, "labelControl1");
			this.labelControl1.Name = "labelControl1";
			// 
			// copyDestinationTextToClipboardCheckBox
			// 
			resources.ApplyResources(this.copyDestinationTextToClipboardCheckBox, "copyDestinationTextToClipboardCheckBox");
			this.copyDestinationTextToClipboardCheckBox.Name = "copyDestinationTextToClipboardCheckBox";
			this.copyDestinationTextToClipboardCheckBox.Properties.AutoWidth = true;
			this.copyDestinationTextToClipboardCheckBox.Properties.Caption = resources.GetString("copyDestinationTextToClipboardCheckBox.Properties.Caption");
			this.copyDestinationTextToClipboardCheckBox.Properties.CheckedChanged += new System.EventHandler(this.copyDestinationTextToClipboardCheckBox_CheckedChanged);
			// 
			// sourceTextTextBox
			// 
			resources.ApplyResources(this.sourceTextTextBox, "sourceTextTextBox");
			this.sourceTextTextBox.Name = "sourceTextTextBox";
			this.sourceTextTextBox.Properties.NullValuePrompt = resources.GetString("sourceTextTextBox.Properties.NullValuePrompt");
			this.sourceTextTextBox.TextChanged += new System.EventHandler(this.sourceTextTextBox_TextChanged);
			this.sourceTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sourceTextTextBox_KeyDown);
			// 
			// buttonTranslate
			// 
			resources.ApplyResources(this.buttonTranslate, "buttonTranslate");
			this.buttonTranslate.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("buttonTranslate.Appearance.Font")));
			this.buttonTranslate.Appearance.Options.UseFont = true;
			this.buttonTranslate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonTranslate.Name = "buttonTranslate";
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
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Name = "panelControl1";
			// 
			// labelControl4
			// 
			resources.ApplyResources(this.labelControl4, "labelControl4");
			this.labelControl4.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl4.Appearance.ForeColor")));
			this.labelControl4.Name = "labelControl4";
			// 
			// buttonSettings
			// 
			resources.ApplyResources(this.buttonSettings, "buttonSettings");
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
			// 
			// QuickTranslationForm
			// 
			this.AcceptButton = this.buttonTranslate;
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("QuickTranslationForm.Appearance.Font")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.closeButton;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "QuickTranslationForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
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

		private DevExpress.XtraEditors.SimpleButton closeButton;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.MemoEdit destinationTextTextBox;
		private DevExpress.XtraEditors.SimpleButton buttonCopyToClipboard;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraEditors.CheckEdit copyDestinationTextToClipboardCheckBox;
		private DevExpress.XtraEditors.MemoEdit sourceTextTextBox;
		private DevExpress.XtraEditors.SimpleButton buttonTranslate;
		private DevExpress.XtraEditors.ComboBoxEdit destinationLanguageComboBox;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.ComboBoxEdit sourceLanguageComboBox;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton buttonSettings;
		private DevExpress.XtraEditors.SimpleButton buttonSwap;
		private DevExpress.XtraEditors.LabelControl labelControl4;
	}
}