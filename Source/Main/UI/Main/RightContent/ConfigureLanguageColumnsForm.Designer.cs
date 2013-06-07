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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureLanguageColumnsForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lineUserControl1 = new ZetaResourceEditor.UI.Helper.LineUserControl();
			this.selectAllLanguagesToExportButton = new DevExpress.XtraEditors.SimpleButton();
			this.invertLanguagesToExportButton = new DevExpress.XtraEditors.SimpleButton();
			this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
			this.selectNoLanguagesToExportButton = new DevExpress.XtraEditors.SimpleButton();
			this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
			this.languagesToDisplayCheckListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.displayAllLanguagesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.displayCertainLanguagesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.languagesToDisplayCheckListBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.displayAllLanguagesCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.displayCertainLanguagesCheckEdit.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.lineUserControl1);
			this.panel1.Controls.Add(this.selectAllLanguagesToExportButton);
			this.panel1.Controls.Add(this.invertLanguagesToExportButton);
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.selectNoLanguagesToExportButton);
			this.panel1.Controls.Add(this.buttonOK);
			this.panel1.Controls.Add(this.languagesToDisplayCheckListBox);
			this.panel1.Controls.Add(this.displayAllLanguagesCheckEdit);
			this.panel1.Controls.Add(this.displayCertainLanguagesCheckEdit);
			this.panel1.Name = "panel1";
			// 
			// lineUserControl1
			// 
			resources.ApplyResources(this.lineUserControl1, "lineUserControl1");
			this.lineUserControl1.Name = "lineUserControl1";
			this.lineUserControl1.TabStop = false;
			// 
			// selectAllLanguagesToExportButton
			// 
			resources.ApplyResources(this.selectAllLanguagesToExportButton, "selectAllLanguagesToExportButton");
			this.selectAllLanguagesToExportButton.Name = "selectAllLanguagesToExportButton";
			this.selectAllLanguagesToExportButton.Click += new System.EventHandler(this.selectAllLanguagesToExportButton_Click);
			// 
			// invertLanguagesToExportButton
			// 
			resources.ApplyResources(this.invertLanguagesToExportButton, "invertLanguagesToExportButton");
			this.invertLanguagesToExportButton.Name = "invertLanguagesToExportButton";
			this.invertLanguagesToExportButton.Click += new System.EventHandler(this.invertLanguagesToExportButton_Click);
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Name = "buttonCancel";
			// 
			// selectNoLanguagesToExportButton
			// 
			resources.ApplyResources(this.selectNoLanguagesToExportButton, "selectNoLanguagesToExportButton");
			this.selectNoLanguagesToExportButton.Name = "selectNoLanguagesToExportButton";
			this.selectNoLanguagesToExportButton.Click += new System.EventHandler(this.selectNoLanguagesToExportButton_Click);
			// 
			// buttonOK
			// 
			resources.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// languagesToDisplayCheckListBox
			// 
			resources.ApplyResources(this.languagesToDisplayCheckListBox, "languagesToDisplayCheckListBox");
			this.languagesToDisplayCheckListBox.CheckOnClick = true;
			this.languagesToDisplayCheckListBox.Name = "languagesToDisplayCheckListBox";
			this.languagesToDisplayCheckListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.languagesToDisplayCheckListBox_ItemCheck);
			this.languagesToDisplayCheckListBox.SelectedIndexChanged += new System.EventHandler(this.languagesToDisplayCheckListBox_SelectedIndexChanged);
			// 
			// displayAllLanguagesCheckEdit
			// 
			resources.ApplyResources(this.displayAllLanguagesCheckEdit, "displayAllLanguagesCheckEdit");
			this.displayAllLanguagesCheckEdit.Name = "displayAllLanguagesCheckEdit";
			this.displayAllLanguagesCheckEdit.Properties.AccessibleDescription = resources.GetString("displayAllLanguagesCheckEdit.Properties.AccessibleDescription");
			this.displayAllLanguagesCheckEdit.Properties.AccessibleName = resources.GetString("displayAllLanguagesCheckEdit.Properties.AccessibleName");
			this.displayAllLanguagesCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("displayAllLanguagesCheckEdit.Properties.AutoHeight")));
			this.displayAllLanguagesCheckEdit.Properties.AutoWidth = true;
			this.displayAllLanguagesCheckEdit.Properties.Caption = resources.GetString("displayAllLanguagesCheckEdit.Properties.Caption");
			this.displayAllLanguagesCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.displayAllLanguagesCheckEdit.Properties.DisplayValueChecked = resources.GetString("displayAllLanguagesCheckEdit.Properties.DisplayValueChecked");
			this.displayAllLanguagesCheckEdit.Properties.DisplayValueGrayed = resources.GetString("displayAllLanguagesCheckEdit.Properties.DisplayValueGrayed");
			this.displayAllLanguagesCheckEdit.Properties.DisplayValueUnchecked = resources.GetString("displayAllLanguagesCheckEdit.Properties.DisplayValueUnchecked");
			this.displayAllLanguagesCheckEdit.Properties.RadioGroupIndex = 0;
			this.displayAllLanguagesCheckEdit.CheckedChanged += new System.EventHandler(this.displayAllLanguagesCheckEdit_CheckedChanged);
			// 
			// displayCertainLanguagesCheckEdit
			// 
			resources.ApplyResources(this.displayCertainLanguagesCheckEdit, "displayCertainLanguagesCheckEdit");
			this.displayCertainLanguagesCheckEdit.Name = "displayCertainLanguagesCheckEdit";
			this.displayCertainLanguagesCheckEdit.Properties.AccessibleDescription = resources.GetString("displayCertainLanguagesCheckEdit.Properties.AccessibleDescription");
			this.displayCertainLanguagesCheckEdit.Properties.AccessibleName = resources.GetString("displayCertainLanguagesCheckEdit.Properties.AccessibleName");
			this.displayCertainLanguagesCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("displayCertainLanguagesCheckEdit.Properties.AutoHeight")));
			this.displayCertainLanguagesCheckEdit.Properties.AutoWidth = true;
			this.displayCertainLanguagesCheckEdit.Properties.Caption = resources.GetString("displayCertainLanguagesCheckEdit.Properties.Caption");
			this.displayCertainLanguagesCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.displayCertainLanguagesCheckEdit.Properties.DisplayValueChecked = resources.GetString("displayCertainLanguagesCheckEdit.Properties.DisplayValueChecked");
			this.displayCertainLanguagesCheckEdit.Properties.DisplayValueGrayed = resources.GetString("displayCertainLanguagesCheckEdit.Properties.DisplayValueGrayed");
			this.displayCertainLanguagesCheckEdit.Properties.DisplayValueUnchecked = resources.GetString("displayCertainLanguagesCheckEdit.Properties.DisplayValueUnchecked");
			this.displayCertainLanguagesCheckEdit.Properties.RadioGroupIndex = 0;
			this.displayCertainLanguagesCheckEdit.TabStop = false;
			this.displayCertainLanguagesCheckEdit.CheckedChanged += new System.EventHandler(this.displayCertainLanguagesCheckEdit_CheckedChanged);
			// 
			// ConfigureLanguageColumnsForm
			// 
			this.AcceptButton = this.buttonOK;
			resources.ApplyResources(this, "$this");
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ConfigureLanguageColumnsForm.Appearance.Font")));
			this.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("ConfigureLanguageColumnsForm.Appearance.GradientMode")));
			this.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("ConfigureLanguageColumnsForm.Appearance.Image")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.buttonCancel;
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfigureLanguageColumnsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.configureLanguageColumnsForm_FormClosing);
			this.Load += new System.EventHandler(this.configureLanguageColumnsForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.languagesToDisplayCheckListBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.displayAllLanguagesCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.displayCertainLanguagesCheckEdit.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.SimpleButton buttonCancel;
		private DevExpress.XtraEditors.SimpleButton buttonOK;
		private DevExpress.XtraEditors.CheckEdit displayAllLanguagesCheckEdit;
		private DevExpress.XtraEditors.CheckEdit displayCertainLanguagesCheckEdit;
		private DevExpress.XtraEditors.SimpleButton selectAllLanguagesToExportButton;
		private DevExpress.XtraEditors.SimpleButton invertLanguagesToExportButton;
		private DevExpress.XtraEditors.SimpleButton selectNoLanguagesToExportButton;
		private DevExpress.XtraEditors.CheckedListBoxControl languagesToDisplayCheckListBox;
		private Helper.LineUserControl lineUserControl1;
	}
}