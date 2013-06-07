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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoTranslateForm));
			this.updateUITimer = new System.Windows.Forms.Timer(this.components);
			this.buttonDefault = new DevExpress.XtraEditors.SimpleButton();
			this.prefixTextBox = new DevExpress.XtraEditors.TextEdit();
			this.prefixCheckBox = new DevExpress.XtraEditors.CheckEdit();
			this.buttonAll = new DevExpress.XtraEditors.SimpleButton();
			this.buttonInvert = new DevExpress.XtraEditors.SimpleButton();
			this.buttonNone = new DevExpress.XtraEditors.SimpleButton();
			this.languagesToTranslateCheckListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.referenceLanguageGroupBox = new DevExpress.XtraEditors.ComboBoxEdit();
			this.fileGroupTextBox = new DevExpress.XtraEditors.TextEdit();
			this.label3 = new DevExpress.XtraEditors.LabelControl();
			this.label2 = new DevExpress.XtraEditors.LabelControl();
			this.label1 = new DevExpress.XtraEditors.LabelControl();
			this.buttonTranslate = new DevExpress.XtraEditors.SimpleButton();
			this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.lineUserControl1 = new ZetaResourceEditor.UI.Helper.LineUserControl();
			this.buttonSettings = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.prefixTextBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prefixCheckBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.languagesToTranslateCheckListBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.referenceLanguageGroupBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileGroupTextBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// updateUITimer
			// 
			this.updateUITimer.Tick += new System.EventHandler(this.updateUITimer_Tick);
			// 
			// buttonDefault
			// 
			resources.ApplyResources(this.buttonDefault, "buttonDefault");
			this.buttonDefault.Name = "buttonDefault";
			this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
			// 
			// prefixTextBox
			// 
			resources.ApplyResources(this.prefixTextBox, "prefixTextBox");
			this.prefixTextBox.Name = "prefixTextBox";
			this.prefixTextBox.Properties.AccessibleDescription = resources.GetString("prefixTextBox.Properties.AccessibleDescription");
			this.prefixTextBox.Properties.AccessibleName = resources.GetString("prefixTextBox.Properties.AccessibleName");
			this.prefixTextBox.Properties.AutoHeight = ((bool)(resources.GetObject("prefixTextBox.Properties.AutoHeight")));
			this.prefixTextBox.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("prefixTextBox.Properties.Mask.AutoComplete")));
			this.prefixTextBox.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("prefixTextBox.Properties.Mask.BeepOnError")));
			this.prefixTextBox.Properties.Mask.EditMask = resources.GetString("prefixTextBox.Properties.Mask.EditMask");
			this.prefixTextBox.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("prefixTextBox.Properties.Mask.IgnoreMaskBlank")));
			this.prefixTextBox.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("prefixTextBox.Properties.Mask.MaskType")));
			this.prefixTextBox.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("prefixTextBox.Properties.Mask.PlaceHolder")));
			this.prefixTextBox.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("prefixTextBox.Properties.Mask.SaveLiteral")));
			this.prefixTextBox.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("prefixTextBox.Properties.Mask.ShowPlaceHolders")));
			this.prefixTextBox.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("prefixTextBox.Properties.Mask.UseMaskAsDisplayFormat")));
			this.prefixTextBox.Properties.NullValuePrompt = resources.GetString("prefixTextBox.Properties.NullValuePrompt");
			this.prefixTextBox.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("prefixTextBox.Properties.NullValuePromptShowForEmptyValue")));
			this.prefixTextBox.TextChanged += new System.EventHandler(this.prefixTextBox_TextChanged);
			// 
			// prefixCheckBox
			// 
			resources.ApplyResources(this.prefixCheckBox, "prefixCheckBox");
			this.prefixCheckBox.Name = "prefixCheckBox";
			this.prefixCheckBox.Properties.AccessibleDescription = resources.GetString("prefixCheckBox.Properties.AccessibleDescription");
			this.prefixCheckBox.Properties.AccessibleName = resources.GetString("prefixCheckBox.Properties.AccessibleName");
			this.prefixCheckBox.Properties.AutoHeight = ((bool)(resources.GetObject("prefixCheckBox.Properties.AutoHeight")));
			this.prefixCheckBox.Properties.AutoWidth = true;
			this.prefixCheckBox.Properties.Caption = resources.GetString("prefixCheckBox.Properties.Caption");
			this.prefixCheckBox.Properties.DisplayValueChecked = resources.GetString("prefixCheckBox.Properties.DisplayValueChecked");
			this.prefixCheckBox.Properties.DisplayValueGrayed = resources.GetString("prefixCheckBox.Properties.DisplayValueGrayed");
			this.prefixCheckBox.Properties.DisplayValueUnchecked = resources.GetString("prefixCheckBox.Properties.DisplayValueUnchecked");
			this.prefixCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// buttonAll
			// 
			resources.ApplyResources(this.buttonAll, "buttonAll");
			this.buttonAll.Name = "buttonAll";
			this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
			// 
			// buttonInvert
			// 
			resources.ApplyResources(this.buttonInvert, "buttonInvert");
			this.buttonInvert.Name = "buttonInvert";
			this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
			// 
			// buttonNone
			// 
			resources.ApplyResources(this.buttonNone, "buttonNone");
			this.buttonNone.Name = "buttonNone";
			this.buttonNone.Click += new System.EventHandler(this.buttonNone_Click);
			// 
			// languagesToTranslateCheckListBox
			// 
			resources.ApplyResources(this.languagesToTranslateCheckListBox, "languagesToTranslateCheckListBox");
			this.languagesToTranslateCheckListBox.CheckOnClick = true;
			this.languagesToTranslateCheckListBox.Name = "languagesToTranslateCheckListBox";
			this.languagesToTranslateCheckListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.languagesToTranslateCheckListBox_ItemCheck);
			this.languagesToTranslateCheckListBox.SelectedIndexChanged += new System.EventHandler(this.languagesToTranslateCheckListBox_SelectedIndexChanged);
			// 
			// referenceLanguageGroupBox
			// 
			resources.ApplyResources(this.referenceLanguageGroupBox, "referenceLanguageGroupBox");
			this.referenceLanguageGroupBox.Name = "referenceLanguageGroupBox";
			this.referenceLanguageGroupBox.Properties.AccessibleDescription = resources.GetString("referenceLanguageGroupBox.Properties.AccessibleDescription");
			this.referenceLanguageGroupBox.Properties.AccessibleName = resources.GetString("referenceLanguageGroupBox.Properties.AccessibleName");
			this.referenceLanguageGroupBox.Properties.AutoHeight = ((bool)(resources.GetObject("referenceLanguageGroupBox.Properties.AutoHeight")));
			this.referenceLanguageGroupBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("referenceLanguageGroupBox.Properties.Buttons"))))});
			this.referenceLanguageGroupBox.Properties.DropDownRows = 20;
			this.referenceLanguageGroupBox.Properties.NullValuePrompt = resources.GetString("referenceLanguageGroupBox.Properties.NullValuePrompt");
			this.referenceLanguageGroupBox.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("referenceLanguageGroupBox.Properties.NullValuePromptShowForEmptyValue")));
			this.referenceLanguageGroupBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.referenceLanguageGroupBox.Properties.SelectedIndexChanged += new System.EventHandler(this.referenceLanguageGroupBox_SelectedIndexChanged);
			// 
			// fileGroupTextBox
			// 
			resources.ApplyResources(this.fileGroupTextBox, "fileGroupTextBox");
			this.fileGroupTextBox.Name = "fileGroupTextBox";
			this.fileGroupTextBox.Properties.AccessibleDescription = resources.GetString("fileGroupTextBox.Properties.AccessibleDescription");
			this.fileGroupTextBox.Properties.AccessibleName = resources.GetString("fileGroupTextBox.Properties.AccessibleName");
			this.fileGroupTextBox.Properties.AutoHeight = ((bool)(resources.GetObject("fileGroupTextBox.Properties.AutoHeight")));
			this.fileGroupTextBox.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("fileGroupTextBox.Properties.Mask.AutoComplete")));
			this.fileGroupTextBox.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("fileGroupTextBox.Properties.Mask.BeepOnError")));
			this.fileGroupTextBox.Properties.Mask.EditMask = resources.GetString("fileGroupTextBox.Properties.Mask.EditMask");
			this.fileGroupTextBox.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("fileGroupTextBox.Properties.Mask.IgnoreMaskBlank")));
			this.fileGroupTextBox.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fileGroupTextBox.Properties.Mask.MaskType")));
			this.fileGroupTextBox.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("fileGroupTextBox.Properties.Mask.PlaceHolder")));
			this.fileGroupTextBox.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("fileGroupTextBox.Properties.Mask.SaveLiteral")));
			this.fileGroupTextBox.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("fileGroupTextBox.Properties.Mask.ShowPlaceHolders")));
			this.fileGroupTextBox.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fileGroupTextBox.Properties.Mask.UseMaskAsDisplayFormat")));
			this.fileGroupTextBox.Properties.NullValuePrompt = resources.GetString("fileGroupTextBox.Properties.NullValuePrompt");
			this.fileGroupTextBox.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("fileGroupTextBox.Properties.NullValuePromptShowForEmptyValue")));
			this.fileGroupTextBox.Properties.ReadOnly = true;
			this.fileGroupTextBox.TextChanged += new System.EventHandler(this.fileGroupTextBox_TextChanged);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// buttonTranslate
			// 
			resources.ApplyResources(this.buttonTranslate, "buttonTranslate");
			this.buttonTranslate.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("buttonTranslate.Appearance.Font")));
			this.buttonTranslate.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("buttonTranslate.Appearance.GradientMode")));
			this.buttonTranslate.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("buttonTranslate.Appearance.Image")));
			this.buttonTranslate.Appearance.Options.UseFont = true;
			this.buttonTranslate.Name = "buttonTranslate";
			this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Name = "buttonCancel";
			// 
			// panelControl1
			// 
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.buttonDefault);
			this.panelControl1.Controls.Add(this.lineUserControl1);
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
			this.panelControl1.Name = "panelControl1";
			// 
			// lineUserControl1
			// 
			resources.ApplyResources(this.lineUserControl1, "lineUserControl1");
			this.lineUserControl1.Name = "lineUserControl1";
			this.lineUserControl1.TabStop = false;
			// 
			// buttonSettings
			// 
			resources.ApplyResources(this.buttonSettings, "buttonSettings");
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
			// 
			// labelControl1
			// 
			resources.ApplyResources(this.labelControl1, "labelControl1");
			this.labelControl1.Appearance.DisabledImage = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.DisabledImage")));
			this.labelControl1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl1.Appearance.ForeColor")));
			this.labelControl1.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("labelControl1.Appearance.GradientMode")));
			this.labelControl1.Appearance.HoverImage = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.HoverImage")));
			this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
			this.labelControl1.Appearance.PressedImage = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.PressedImage")));
			this.labelControl1.Name = "labelControl1";
			// 
			// AutoTranslateForm
			// 
			this.AcceptButton = this.buttonTranslate;
			resources.ApplyResources(this, "$this");
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("AutoTranslateForm.Appearance.Font")));
			this.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AutoTranslateForm.Appearance.GradientMode")));
			this.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("AutoTranslateForm.Appearance.Image")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.buttonCancel;
			this.Controls.Add(this.panelControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AutoTranslateForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer updateUITimer;
		private DevExpress.XtraEditors.SimpleButton buttonTranslate;
		private DevExpress.XtraEditors.SimpleButton buttonCancel;
		private DevExpress.XtraEditors.LabelControl label3;
		private DevExpress.XtraEditors.LabelControl label2;
		private DevExpress.XtraEditors.LabelControl label1;
		private DevExpress.XtraEditors.TextEdit prefixTextBox;
		private DevExpress.XtraEditors.CheckEdit prefixCheckBox;
		private DevExpress.XtraEditors.SimpleButton buttonAll;
		private DevExpress.XtraEditors.SimpleButton buttonInvert;
		private DevExpress.XtraEditors.SimpleButton buttonNone;
		private DevExpress.XtraEditors.CheckedListBoxControl languagesToTranslateCheckListBox;
		private DevExpress.XtraEditors.ComboBoxEdit referenceLanguageGroupBox;
		private DevExpress.XtraEditors.TextEdit fileGroupTextBox;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton buttonDefault;
		private DevExpress.XtraEditors.SimpleButton buttonSettings;
		private Helper.LineUserControl lineUserControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}