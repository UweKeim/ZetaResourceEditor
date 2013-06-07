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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslateOptionsForm));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.engineTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.appIDLinkControl = new DevExpress.XtraEditors.HyperLinkEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.appID2Label = new DevExpress.XtraEditors.LabelControl();
			this.appID2TextEdit = new DevExpress.XtraEditors.TextEdit();
			this.engineComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
			this.appIDLabel = new DevExpress.XtraEditors.LabelControl();
			this.appIDTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.settingsTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.checkEditContinueOnErrors = new DevExpress.XtraEditors.CheckEdit();
			this.translationDelayTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.label2 = new DevExpress.XtraEditors.LabelControl();
			this.wordsToKeepTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.buttonAddDefaultWordsToKeep = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.wordsToProtectMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.wordsToRemoveTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.wordsToRemoveMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
			this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.engineTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.appIDLinkControl.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appID2TextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.engineComboBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appIDTextEdit.Properties)).BeginInit();
			this.settingsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkEditContinueOnErrors.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.translationDelayTextEdit.Properties)).BeginInit();
			this.wordsToKeepTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.wordsToProtectMemoEdit.Properties)).BeginInit();
			this.wordsToRemoveTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.wordsToRemoveMemoEdit.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.xtraTabControl1);
			this.panelControl1.Controls.Add(this.buttonOK);
			this.panelControl1.Controls.Add(this.buttonCancel);
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Name = "panelControl1";
			// 
			// xtraTabControl1
			// 
			resources.ApplyResources(this.xtraTabControl1, "xtraTabControl1");
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.engineTabPage;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.engineTabPage,
            this.settingsTabPage,
            this.wordsToKeepTabPage,
            this.wordsToRemoveTabPage});
			// 
			// engineTabPage
			// 
			this.engineTabPage.Controls.Add(this.appIDLinkControl);
			this.engineTabPage.Controls.Add(this.labelControl2);
			this.engineTabPage.Controls.Add(this.appID2Label);
			this.engineTabPage.Controls.Add(this.appID2TextEdit);
			this.engineTabPage.Controls.Add(this.engineComboBox);
			this.engineTabPage.Controls.Add(this.appIDLabel);
			this.engineTabPage.Controls.Add(this.appIDTextEdit);
			this.engineTabPage.Name = "engineTabPage";
			resources.ApplyResources(this.engineTabPage, "engineTabPage");
			// 
			// appIDLinkControl
			// 
			resources.ApplyResources(this.appIDLinkControl, "appIDLinkControl");
			this.appIDLinkControl.Name = "appIDLinkControl";
			this.appIDLinkControl.Properties.AllowFocused = false;
			this.appIDLinkControl.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("appIDLinkControl.Properties.Appearance.BackColor")));
			this.appIDLinkControl.Properties.Appearance.Options.UseBackColor = true;
			this.appIDLinkControl.Properties.Appearance.Options.UseTextOptions = true;
			this.appIDLinkControl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.appIDLinkControl.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.appIDLinkControl.TabStop = false;
			this.appIDLinkControl.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.appIDLinkControl_OpenLink);
			// 
			// labelControl2
			// 
			resources.ApplyResources(this.labelControl2, "labelControl2");
			this.labelControl2.Name = "labelControl2";
			// 
			// appID2Label
			// 
			resources.ApplyResources(this.appID2Label, "appID2Label");
			this.appID2Label.Name = "appID2Label";
			// 
			// appID2TextEdit
			// 
			resources.ApplyResources(this.appID2TextEdit, "appID2TextEdit");
			this.appID2TextEdit.Name = "appID2TextEdit";
			this.appID2TextEdit.Properties.Mask.EditMask = resources.GetString("appID2TextEdit.Properties.Mask.EditMask");
			this.appID2TextEdit.Properties.MaxLength = 400;
			this.appID2TextEdit.Properties.NullValuePrompt = resources.GetString("appID2TextEdit.Properties.NullValuePrompt");
			this.appID2TextEdit.EditValueChanged += new System.EventHandler(this.translationDelayTextEdit_EditValueChanged);
			// 
			// engineComboBox
			// 
			resources.ApplyResources(this.engineComboBox, "engineComboBox");
			this.engineComboBox.Name = "engineComboBox";
			this.engineComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("engineComboBox.Properties.Buttons"))))});
			this.engineComboBox.Properties.NullValuePrompt = resources.GetString("engineComboBox.Properties.NullValuePrompt");
			this.engineComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.engineComboBox.SelectedIndexChanged += new System.EventHandler(this.engineComboBox_SelectedIndexChanged);
			// 
			// appIDLabel
			// 
			resources.ApplyResources(this.appIDLabel, "appIDLabel");
			this.appIDLabel.Name = "appIDLabel";
			// 
			// appIDTextEdit
			// 
			resources.ApplyResources(this.appIDTextEdit, "appIDTextEdit");
			this.appIDTextEdit.Name = "appIDTextEdit";
			this.appIDTextEdit.Properties.Mask.EditMask = resources.GetString("appIDTextEdit.Properties.Mask.EditMask");
			this.appIDTextEdit.Properties.MaxLength = 400;
			this.appIDTextEdit.Properties.NullValuePrompt = resources.GetString("appIDTextEdit.Properties.NullValuePrompt");
			this.appIDTextEdit.EditValueChanged += new System.EventHandler(this.translationDelayTextEdit_EditValueChanged);
			// 
			// settingsTabPage
			// 
			this.settingsTabPage.Controls.Add(this.labelControl1);
			this.settingsTabPage.Controls.Add(this.checkEditContinueOnErrors);
			this.settingsTabPage.Controls.Add(this.translationDelayTextEdit);
			this.settingsTabPage.Controls.Add(this.label2);
			this.settingsTabPage.Name = "settingsTabPage";
			resources.ApplyResources(this.settingsTabPage, "settingsTabPage");
			// 
			// labelControl1
			// 
			resources.ApplyResources(this.labelControl1, "labelControl1");
			this.labelControl1.Name = "labelControl1";
			// 
			// checkEditContinueOnErrors
			// 
			resources.ApplyResources(this.checkEditContinueOnErrors, "checkEditContinueOnErrors");
			this.checkEditContinueOnErrors.Name = "checkEditContinueOnErrors";
			this.checkEditContinueOnErrors.Properties.AutoWidth = true;
			this.checkEditContinueOnErrors.Properties.Caption = resources.GetString("checkEditContinueOnErrors.Properties.Caption");
			// 
			// translationDelayTextEdit
			// 
			resources.ApplyResources(this.translationDelayTextEdit, "translationDelayTextEdit");
			this.translationDelayTextEdit.Name = "translationDelayTextEdit";
			this.translationDelayTextEdit.Properties.Mask.EditMask = resources.GetString("translationDelayTextEdit.Properties.Mask.EditMask");
			this.translationDelayTextEdit.Properties.MaxLength = 5;
			this.translationDelayTextEdit.Properties.NullValuePrompt = resources.GetString("translationDelayTextEdit.Properties.NullValuePrompt");
			this.translationDelayTextEdit.EditValueChanged += new System.EventHandler(this.translationDelayTextEdit_EditValueChanged);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// wordsToKeepTabPage
			// 
			this.wordsToKeepTabPage.Controls.Add(this.buttonAddDefaultWordsToKeep);
			this.wordsToKeepTabPage.Controls.Add(this.labelControl4);
			this.wordsToKeepTabPage.Controls.Add(this.wordsToProtectMemoEdit);
			this.wordsToKeepTabPage.Controls.Add(this.labelControl5);
			this.wordsToKeepTabPage.Name = "wordsToKeepTabPage";
			resources.ApplyResources(this.wordsToKeepTabPage, "wordsToKeepTabPage");
			// 
			// buttonAddDefaultWordsToKeep
			// 
			resources.ApplyResources(this.buttonAddDefaultWordsToKeep, "buttonAddDefaultWordsToKeep");
			this.buttonAddDefaultWordsToKeep.Name = "buttonAddDefaultWordsToKeep";
			this.buttonAddDefaultWordsToKeep.Click += new System.EventHandler(this.buttonAddDefaultWordsToKeep_Click);
			// 
			// labelControl4
			// 
			resources.ApplyResources(this.labelControl4, "labelControl4");
			this.labelControl4.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl4.Appearance.ForeColor")));
			this.labelControl4.Name = "labelControl4";
			// 
			// wordsToProtectMemoEdit
			// 
			resources.ApplyResources(this.wordsToProtectMemoEdit, "wordsToProtectMemoEdit");
			this.wordsToProtectMemoEdit.Name = "wordsToProtectMemoEdit";
			// 
			// labelControl5
			// 
			resources.ApplyResources(this.labelControl5, "labelControl5");
			this.labelControl5.Name = "labelControl5";
			// 
			// wordsToRemoveTabPage
			// 
			this.wordsToRemoveTabPage.Controls.Add(this.labelControl6);
			this.wordsToRemoveTabPage.Controls.Add(this.wordsToRemoveMemoEdit);
			this.wordsToRemoveTabPage.Controls.Add(this.labelControl3);
			this.wordsToRemoveTabPage.Name = "wordsToRemoveTabPage";
			resources.ApplyResources(this.wordsToRemoveTabPage, "wordsToRemoveTabPage");
			// 
			// labelControl6
			// 
			resources.ApplyResources(this.labelControl6, "labelControl6");
			this.labelControl6.Name = "labelControl6";
			// 
			// wordsToRemoveMemoEdit
			// 
			resources.ApplyResources(this.wordsToRemoveMemoEdit, "wordsToRemoveMemoEdit");
			this.wordsToRemoveMemoEdit.Name = "wordsToRemoveMemoEdit";
			// 
			// labelControl3
			// 
			resources.ApplyResources(this.labelControl3, "labelControl3");
			this.labelControl3.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl3.Appearance.ForeColor")));
			this.labelControl3.Name = "labelControl3";
			// 
			// buttonOK
			// 
			resources.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Name = "buttonCancel";
			// 
			// TranslateOptionsForm
			// 
			this.AcceptButton = this.buttonOK;
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TranslateOptionsForm.Appearance.Font")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.buttonCancel;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panelControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TranslateOptionsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
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
			((System.ComponentModel.ISupportInitialize)(this.appID2TextEdit.Properties)).EndInit();
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
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton buttonOK;
		private DevExpress.XtraEditors.SimpleButton buttonCancel;
		private DevExpress.XtraEditors.TextEdit translationDelayTextEdit;
		private DevExpress.XtraEditors.CheckEdit checkEditContinueOnErrors;
		private DevExpress.XtraEditors.LabelControl label2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.ComboBoxEdit engineComboBox;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage settingsTabPage;
		private DevExpress.XtraTab.XtraTabPage wordsToKeepTabPage;
		private DevExpress.XtraEditors.MemoEdit wordsToProtectMemoEdit;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraTab.XtraTabPage wordsToRemoveTabPage;
		private DevExpress.XtraEditors.MemoEdit wordsToRemoveMemoEdit;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.SimpleButton buttonAddDefaultWordsToKeep;
		private DevExpress.XtraEditors.LabelControl appIDLabel;
		private DevExpress.XtraEditors.TextEdit appIDTextEdit;
		private DevExpress.XtraEditors.HyperLinkEdit appIDLinkControl;
		private DevExpress.XtraEditors.LabelControl appID2Label;
		private DevExpress.XtraEditors.TextEdit appID2TextEdit;
		private DevExpress.XtraTab.XtraTabPage engineTabPage;
	}
}