namespace ZetaResourceEditor.UI.Projects
{
	partial class SendProjectWizardForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendProjectWizardForm));
			this.wizardControl = new DevExpress.XtraWizard.WizardControl();
			this.optionsWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.exportLocalSettingsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportResourceFilesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.exportProjectFileCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.receiversWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.buttonZulReset = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.zulBodyTextEdit = new DevExpress.XtraEditors.MemoEdit();
			this.zulSubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
			this.zulReceiversTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
			this.label2 = new DevExpress.XtraEditors.LabelControl();
			this.successWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
			this.downloadProjectUrlLinkEdit = new DevExpress.XtraEditors.HyperLinkEdit();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.progressWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
			this.progressLabel = new DevExpress.XtraEditors.LabelControl();
			this.errorOccurredWizardPage = new DevExpress.XtraWizard.WizardPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.optionsButton = new DevExpress.XtraEditors.DropDownButton();
			this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.buttonErrorDetails = new DevExpress.XtraBars.BarButtonItem();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.detailedErrorsButton = new DevExpress.XtraBars.BarButtonItem();
			this.underylingExceptionButton = new DevExpress.XtraBars.BarButtonItem();
			this.errorTextMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.progressBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
			this.wizardControl.SuspendLayout();
			this.optionsWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exportLocalSettingsCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exportResourceFilesCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exportProjectFileCheckEdit.Properties)).BeginInit();
			this.receiversWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.zulBodyTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zulSubjectTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zulReceiversTextEdit.Properties)).BeginInit();
			this.successWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.downloadProjectUrlLinkEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.progressWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
			this.errorOccurredWizardPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorTextMemoEdit.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// wizardControl
			// 
			resources.ApplyResources(this.wizardControl, "wizardControl");
			this.wizardControl.Controls.Add(this.optionsWizardPage);
			this.wizardControl.Controls.Add(this.receiversWizardPage);
			this.wizardControl.Controls.Add(this.successWizardPage);
			this.wizardControl.Controls.Add(this.progressWizardPage);
			this.wizardControl.Controls.Add(this.errorOccurredWizardPage);
			this.wizardControl.Name = "wizardControl";
			this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.optionsWizardPage,
            this.receiversWizardPage,
            this.progressWizardPage,
            this.errorOccurredWizardPage,
            this.successWizardPage});
			this.wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
			this.wizardControl.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl_SelectedPageChanged);
			this.wizardControl.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_CancelClick);
			this.wizardControl.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_FinishClick);
			this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
			this.wizardControl.PrevClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_PrevClick);
			this.wizardControl.CustomizeCommandButtons += new DevExpress.XtraWizard.WizardCustomizeCommandButtonsEventHandler(this.wizardControl_CustomizeCommandButtons);
			// 
			// optionsWizardPage
			// 
			resources.ApplyResources(this.optionsWizardPage, "optionsWizardPage");
			this.optionsWizardPage.Controls.Add(this.pictureBox3);
			this.optionsWizardPage.Controls.Add(this.exportLocalSettingsCheckEdit);
			this.optionsWizardPage.Controls.Add(this.exportResourceFilesCheckEdit);
			this.optionsWizardPage.Controls.Add(this.exportProjectFileCheckEdit);
			this.optionsWizardPage.Controls.Add(this.labelControl1);
			this.optionsWizardPage.Controls.Add(this.labelControl7);
			this.optionsWizardPage.Name = "optionsWizardPage";
			// 
			// pictureBox3
			// 
			resources.ApplyResources(this.pictureBox3, "pictureBox3");
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.TabStop = false;
			// 
			// exportLocalSettingsCheckEdit
			// 
			resources.ApplyResources(this.exportLocalSettingsCheckEdit, "exportLocalSettingsCheckEdit");
			this.exportLocalSettingsCheckEdit.Name = "exportLocalSettingsCheckEdit";
			this.exportLocalSettingsCheckEdit.Properties.AccessibleDescription = resources.GetString("exportLocalSettingsCheckEdit.Properties.AccessibleDescription");
			this.exportLocalSettingsCheckEdit.Properties.AccessibleName = resources.GetString("exportLocalSettingsCheckEdit.Properties.AccessibleName");
			this.exportLocalSettingsCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportLocalSettingsCheckEdit.Properties.AutoHeight")));
			this.exportLocalSettingsCheckEdit.Properties.AutoWidth = true;
			this.exportLocalSettingsCheckEdit.Properties.Caption = resources.GetString("exportLocalSettingsCheckEdit.Properties.Caption");
			this.exportLocalSettingsCheckEdit.Properties.DisplayValueChecked = resources.GetString("exportLocalSettingsCheckEdit.Properties.DisplayValueChecked");
			this.exportLocalSettingsCheckEdit.Properties.DisplayValueGrayed = resources.GetString("exportLocalSettingsCheckEdit.Properties.DisplayValueGrayed");
			this.exportLocalSettingsCheckEdit.Properties.DisplayValueUnchecked = resources.GetString("exportLocalSettingsCheckEdit.Properties.DisplayValueUnchecked");
			this.exportLocalSettingsCheckEdit.CheckedChanged += new System.EventHandler(this.exportLocalSettingsCheckEdit_CheckedChanged);
			// 
			// exportResourceFilesCheckEdit
			// 
			resources.ApplyResources(this.exportResourceFilesCheckEdit, "exportResourceFilesCheckEdit");
			this.exportResourceFilesCheckEdit.Name = "exportResourceFilesCheckEdit";
			this.exportResourceFilesCheckEdit.Properties.AccessibleDescription = resources.GetString("exportResourceFilesCheckEdit.Properties.AccessibleDescription");
			this.exportResourceFilesCheckEdit.Properties.AccessibleName = resources.GetString("exportResourceFilesCheckEdit.Properties.AccessibleName");
			this.exportResourceFilesCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportResourceFilesCheckEdit.Properties.AutoHeight")));
			this.exportResourceFilesCheckEdit.Properties.AutoWidth = true;
			this.exportResourceFilesCheckEdit.Properties.Caption = resources.GetString("exportResourceFilesCheckEdit.Properties.Caption");
			this.exportResourceFilesCheckEdit.Properties.DisplayValueChecked = resources.GetString("exportResourceFilesCheckEdit.Properties.DisplayValueChecked");
			this.exportResourceFilesCheckEdit.Properties.DisplayValueGrayed = resources.GetString("exportResourceFilesCheckEdit.Properties.DisplayValueGrayed");
			this.exportResourceFilesCheckEdit.Properties.DisplayValueUnchecked = resources.GetString("exportResourceFilesCheckEdit.Properties.DisplayValueUnchecked");
			this.exportResourceFilesCheckEdit.CheckedChanged += new System.EventHandler(this.exportResourceFilesCheckEdit_CheckedChanged);
			// 
			// exportProjectFileCheckEdit
			// 
			resources.ApplyResources(this.exportProjectFileCheckEdit, "exportProjectFileCheckEdit");
			this.exportProjectFileCheckEdit.Name = "exportProjectFileCheckEdit";
			this.exportProjectFileCheckEdit.Properties.AccessibleDescription = resources.GetString("exportProjectFileCheckEdit.Properties.AccessibleDescription");
			this.exportProjectFileCheckEdit.Properties.AccessibleName = resources.GetString("exportProjectFileCheckEdit.Properties.AccessibleName");
			this.exportProjectFileCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("exportProjectFileCheckEdit.Properties.AutoHeight")));
			this.exportProjectFileCheckEdit.Properties.AutoWidth = true;
			this.exportProjectFileCheckEdit.Properties.Caption = resources.GetString("exportProjectFileCheckEdit.Properties.Caption");
			this.exportProjectFileCheckEdit.Properties.DisplayValueChecked = resources.GetString("exportProjectFileCheckEdit.Properties.DisplayValueChecked");
			this.exportProjectFileCheckEdit.Properties.DisplayValueGrayed = resources.GetString("exportProjectFileCheckEdit.Properties.DisplayValueGrayed");
			this.exportProjectFileCheckEdit.Properties.DisplayValueUnchecked = resources.GetString("exportProjectFileCheckEdit.Properties.DisplayValueUnchecked");
			this.exportProjectFileCheckEdit.CheckedChanged += new System.EventHandler(this.exportProjectFileCheckEdit_CheckedChanged);
			// 
			// labelControl1
			// 
			resources.ApplyResources(this.labelControl1, "labelControl1");
			this.labelControl1.Appearance.DisabledImage = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.DisabledImage")));
			this.labelControl1.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("labelControl1.Appearance.GradientMode")));
			this.labelControl1.Appearance.HoverImage = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.HoverImage")));
			this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
			this.labelControl1.Appearance.PressedImage = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.PressedImage")));
			this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl1.Name = "labelControl1";
			// 
			// labelControl7
			// 
			resources.ApplyResources(this.labelControl7, "labelControl7");
			this.labelControl7.Appearance.DisabledImage = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.DisabledImage")));
			this.labelControl7.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("labelControl7.Appearance.GradientMode")));
			this.labelControl7.Appearance.HoverImage = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.HoverImage")));
			this.labelControl7.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.Image")));
			this.labelControl7.Appearance.PressedImage = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.PressedImage")));
			this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl7.Name = "labelControl7";
			// 
			// receiversWizardPage
			// 
			resources.ApplyResources(this.receiversWizardPage, "receiversWizardPage");
			this.receiversWizardPage.Controls.Add(this.buttonZulReset);
			this.receiversWizardPage.Controls.Add(this.labelControl10);
			this.receiversWizardPage.Controls.Add(this.zulBodyTextEdit);
			this.receiversWizardPage.Controls.Add(this.zulSubjectTextEdit);
			this.receiversWizardPage.Controls.Add(this.hyperLinkEdit1);
			this.receiversWizardPage.Controls.Add(this.zulReceiversTextEdit);
			this.receiversWizardPage.Controls.Add(this.label2);
			this.receiversWizardPage.Name = "receiversWizardPage";
			// 
			// buttonZulReset
			// 
			resources.ApplyResources(this.buttonZulReset, "buttonZulReset");
			this.buttonZulReset.Name = "buttonZulReset";
			this.buttonZulReset.Click += new System.EventHandler(this.buttonZulReset_Click);
			// 
			// labelControl10
			// 
			resources.ApplyResources(this.labelControl10, "labelControl10");
			this.labelControl10.Name = "labelControl10";
			// 
			// zulBodyTextEdit
			// 
			resources.ApplyResources(this.zulBodyTextEdit, "zulBodyTextEdit");
			this.zulBodyTextEdit.Name = "zulBodyTextEdit";
			this.zulBodyTextEdit.Properties.AccessibleDescription = resources.GetString("zulBodyTextEdit.Properties.AccessibleDescription");
			this.zulBodyTextEdit.Properties.AccessibleName = resources.GetString("zulBodyTextEdit.Properties.AccessibleName");
			this.zulBodyTextEdit.Properties.NullValuePrompt = resources.GetString("zulBodyTextEdit.Properties.NullValuePrompt");
			this.zulBodyTextEdit.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("zulBodyTextEdit.Properties.NullValuePromptShowForEmptyValue")));
			this.zulBodyTextEdit.EditValueChanged += new System.EventHandler(this.zulBodyTextEdit_EditValueChanged);
			// 
			// zulSubjectTextEdit
			// 
			resources.ApplyResources(this.zulSubjectTextEdit, "zulSubjectTextEdit");
			this.zulSubjectTextEdit.Name = "zulSubjectTextEdit";
			this.zulSubjectTextEdit.Properties.AccessibleDescription = resources.GetString("zulSubjectTextEdit.Properties.AccessibleDescription");
			this.zulSubjectTextEdit.Properties.AccessibleName = resources.GetString("zulSubjectTextEdit.Properties.AccessibleName");
			this.zulSubjectTextEdit.Properties.AutoHeight = ((bool)(resources.GetObject("zulSubjectTextEdit.Properties.AutoHeight")));
			this.zulSubjectTextEdit.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("zulSubjectTextEdit.Properties.Mask.AutoComplete")));
			this.zulSubjectTextEdit.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("zulSubjectTextEdit.Properties.Mask.BeepOnError")));
			this.zulSubjectTextEdit.Properties.Mask.EditMask = resources.GetString("zulSubjectTextEdit.Properties.Mask.EditMask");
			this.zulSubjectTextEdit.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("zulSubjectTextEdit.Properties.Mask.IgnoreMaskBlank")));
			this.zulSubjectTextEdit.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("zulSubjectTextEdit.Properties.Mask.MaskType")));
			this.zulSubjectTextEdit.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("zulSubjectTextEdit.Properties.Mask.PlaceHolder")));
			this.zulSubjectTextEdit.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("zulSubjectTextEdit.Properties.Mask.SaveLiteral")));
			this.zulSubjectTextEdit.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("zulSubjectTextEdit.Properties.Mask.ShowPlaceHolders")));
			this.zulSubjectTextEdit.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("zulSubjectTextEdit.Properties.Mask.UseMaskAsDisplayFormat")));
			this.zulSubjectTextEdit.Properties.NullValuePrompt = resources.GetString("zulSubjectTextEdit.Properties.NullValuePrompt");
			this.zulSubjectTextEdit.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("zulSubjectTextEdit.Properties.NullValuePromptShowForEmptyValue")));
			this.zulSubjectTextEdit.EditValueChanged += new System.EventHandler(this.zulSubjectTextEdit_EditValueChanged);
			// 
			// hyperLinkEdit1
			// 
			resources.ApplyResources(this.hyperLinkEdit1, "hyperLinkEdit1");
			this.hyperLinkEdit1.Name = "hyperLinkEdit1";
			this.hyperLinkEdit1.Properties.AccessibleDescription = resources.GetString("hyperLinkEdit1.Properties.AccessibleDescription");
			this.hyperLinkEdit1.Properties.AccessibleName = resources.GetString("hyperLinkEdit1.Properties.AccessibleName");
			this.hyperLinkEdit1.Properties.AllowFocused = false;
			this.hyperLinkEdit1.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("hyperLinkEdit1.Properties.Appearance.BackColor")));
			this.hyperLinkEdit1.Properties.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("hyperLinkEdit1.Properties.Appearance.GradientMode")));
			this.hyperLinkEdit1.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("hyperLinkEdit1.Properties.Appearance.Image")));
			this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.hyperLinkEdit1.Properties.AutoHeight = ((bool)(resources.GetObject("hyperLinkEdit1.Properties.AutoHeight")));
			this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.hyperLinkEdit1.Properties.Caption = resources.GetString("hyperLinkEdit1.Properties.Caption");
			this.hyperLinkEdit1.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("hyperLinkEdit1.Properties.Mask.AutoComplete")));
			this.hyperLinkEdit1.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("hyperLinkEdit1.Properties.Mask.BeepOnError")));
			this.hyperLinkEdit1.Properties.Mask.EditMask = resources.GetString("hyperLinkEdit1.Properties.Mask.EditMask");
			this.hyperLinkEdit1.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("hyperLinkEdit1.Properties.Mask.IgnoreMaskBlank")));
			this.hyperLinkEdit1.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("hyperLinkEdit1.Properties.Mask.MaskType")));
			this.hyperLinkEdit1.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("hyperLinkEdit1.Properties.Mask.PlaceHolder")));
			this.hyperLinkEdit1.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("hyperLinkEdit1.Properties.Mask.SaveLiteral")));
			this.hyperLinkEdit1.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("hyperLinkEdit1.Properties.Mask.ShowPlaceHolders")));
			this.hyperLinkEdit1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("hyperLinkEdit1.Properties.Mask.UseMaskAsDisplayFormat")));
			this.hyperLinkEdit1.Properties.NullValuePrompt = resources.GetString("hyperLinkEdit1.Properties.NullValuePrompt");
			this.hyperLinkEdit1.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("hyperLinkEdit1.Properties.NullValuePromptShowForEmptyValue")));
			this.hyperLinkEdit1.TabStop = false;
			this.hyperLinkEdit1.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hyperLinkEdit1_OpenLink);
			// 
			// zulReceiversTextEdit
			// 
			resources.ApplyResources(this.zulReceiversTextEdit, "zulReceiversTextEdit");
			this.zulReceiversTextEdit.Name = "zulReceiversTextEdit";
			this.zulReceiversTextEdit.Properties.AccessibleDescription = resources.GetString("zulReceiversTextEdit.Properties.AccessibleDescription");
			this.zulReceiversTextEdit.Properties.AccessibleName = resources.GetString("zulReceiversTextEdit.Properties.AccessibleName");
			this.zulReceiversTextEdit.Properties.AutoHeight = ((bool)(resources.GetObject("zulReceiversTextEdit.Properties.AutoHeight")));
			this.zulReceiversTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("zulReceiversTextEdit.Properties.Buttons"))))});
			this.zulReceiversTextEdit.Properties.DropDownRows = 20;
			this.zulReceiversTextEdit.Properties.NullValuePrompt = resources.GetString("zulReceiversTextEdit.Properties.NullValuePrompt");
			this.zulReceiversTextEdit.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("zulReceiversTextEdit.Properties.NullValuePromptShowForEmptyValue")));
			this.zulReceiversTextEdit.SelectedIndexChanged += new System.EventHandler(this.zulReceiversTextEdit_SelectedIndexChanged);
			this.zulReceiversTextEdit.EditValueChanged += new System.EventHandler(this.zulReceiversTextEdit_EditValueChanged);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// successWizardPage
			// 
			resources.ApplyResources(this.successWizardPage, "successWizardPage");
			this.successWizardPage.Controls.Add(this.downloadProjectUrlLinkEdit);
			this.successWizardPage.Controls.Add(this.pictureBox2);
			this.successWizardPage.Controls.Add(this.labelControl5);
			this.successWizardPage.Name = "successWizardPage";
			// 
			// downloadProjectUrlLinkEdit
			// 
			resources.ApplyResources(this.downloadProjectUrlLinkEdit, "downloadProjectUrlLinkEdit");
			this.downloadProjectUrlLinkEdit.Name = "downloadProjectUrlLinkEdit";
			this.downloadProjectUrlLinkEdit.Properties.AccessibleDescription = resources.GetString("downloadProjectUrlLinkEdit.Properties.AccessibleDescription");
			this.downloadProjectUrlLinkEdit.Properties.AccessibleName = resources.GetString("downloadProjectUrlLinkEdit.Properties.AccessibleName");
			this.downloadProjectUrlLinkEdit.Properties.AllowFocused = false;
			this.downloadProjectUrlLinkEdit.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Appearance.BackColor")));
			this.downloadProjectUrlLinkEdit.Properties.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Appearance.GradientMode")));
			this.downloadProjectUrlLinkEdit.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Appearance.Image")));
			this.downloadProjectUrlLinkEdit.Properties.Appearance.Options.UseBackColor = true;
			this.downloadProjectUrlLinkEdit.Properties.AutoHeight = ((bool)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.AutoHeight")));
			this.downloadProjectUrlLinkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.downloadProjectUrlLinkEdit.Properties.Caption = resources.GetString("downloadProjectUrlLinkEdit.Properties.Caption");
			this.downloadProjectUrlLinkEdit.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Mask.AutoComplete")));
			this.downloadProjectUrlLinkEdit.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Mask.BeepOnError")));
			this.downloadProjectUrlLinkEdit.Properties.Mask.EditMask = resources.GetString("downloadProjectUrlLinkEdit.Properties.Mask.EditMask");
			this.downloadProjectUrlLinkEdit.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Mask.IgnoreMaskBlank")));
			this.downloadProjectUrlLinkEdit.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Mask.MaskType")));
			this.downloadProjectUrlLinkEdit.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Mask.PlaceHolder")));
			this.downloadProjectUrlLinkEdit.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Mask.SaveLiteral")));
			this.downloadProjectUrlLinkEdit.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Mask.ShowPlaceHolders")));
			this.downloadProjectUrlLinkEdit.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.Mask.UseMaskAsDisplayFormat")));
			this.downloadProjectUrlLinkEdit.Properties.NullValuePrompt = resources.GetString("downloadProjectUrlLinkEdit.Properties.NullValuePrompt");
			this.downloadProjectUrlLinkEdit.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("downloadProjectUrlLinkEdit.Properties.NullValuePromptShowForEmptyValue")));
			this.downloadProjectUrlLinkEdit.TabStop = false;
			this.downloadProjectUrlLinkEdit.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.downloadProjectUrlLinkEdit_OpenLink);
			// 
			// pictureBox2
			// 
			resources.ApplyResources(this.pictureBox2, "pictureBox2");
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.TabStop = false;
			// 
			// labelControl5
			// 
			resources.ApplyResources(this.labelControl5, "labelControl5");
			this.labelControl5.Appearance.DisabledImage = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.DisabledImage")));
			this.labelControl5.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("labelControl5.Appearance.GradientMode")));
			this.labelControl5.Appearance.HoverImage = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.HoverImage")));
			this.labelControl5.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.Image")));
			this.labelControl5.Appearance.PressedImage = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.PressedImage")));
			this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl5.Name = "labelControl5";
			// 
			// progressWizardPage
			// 
			resources.ApplyResources(this.progressWizardPage, "progressWizardPage");
			this.progressWizardPage.Controls.Add(this.progressBarControl);
			this.progressWizardPage.Controls.Add(this.progressLabel);
			this.progressWizardPage.Name = "progressWizardPage";
			// 
			// progressBarControl
			// 
			resources.ApplyResources(this.progressBarControl, "progressBarControl");
			this.progressBarControl.Name = "progressBarControl";
			this.progressBarControl.Properties.AccessibleDescription = resources.GetString("progressBarControl.Properties.AccessibleDescription");
			this.progressBarControl.Properties.AccessibleName = resources.GetString("progressBarControl.Properties.AccessibleName");
			this.progressBarControl.Properties.AutoHeight = ((bool)(resources.GetObject("progressBarControl.Properties.AutoHeight")));
			// 
			// progressLabel
			// 
			resources.ApplyResources(this.progressLabel, "progressLabel");
			this.progressLabel.Name = "progressLabel";
			// 
			// errorOccurredWizardPage
			// 
			resources.ApplyResources(this.errorOccurredWizardPage, "errorOccurredWizardPage");
			this.errorOccurredWizardPage.Controls.Add(this.pictureBox1);
			this.errorOccurredWizardPage.Controls.Add(this.optionsButton);
			this.errorOccurredWizardPage.Controls.Add(this.errorTextMemoEdit);
			this.errorOccurredWizardPage.Controls.Add(this.barDockControlLeft);
			this.errorOccurredWizardPage.Controls.Add(this.barDockControlRight);
			this.errorOccurredWizardPage.Controls.Add(this.barDockControlBottom);
			this.errorOccurredWizardPage.Controls.Add(this.barDockControlTop);
			this.errorOccurredWizardPage.Name = "errorOccurredWizardPage";
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// optionsButton
			// 
			resources.ApplyResources(this.optionsButton, "optionsButton");
			this.optionsButton.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("optionsButton.Appearance.Font")));
			this.optionsButton.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("optionsButton.Appearance.GradientMode")));
			this.optionsButton.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("optionsButton.Appearance.Image")));
			this.optionsButton.Appearance.Options.UseFont = true;
			this.optionsButton.DropDownControl = this.optionsPopupMenu;
			this.optionsButton.Image = ((System.Drawing.Image)(resources.GetObject("optionsButton.Image")));
			this.optionsButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
			this.optionsButton.Name = "optionsButton";
			this.optionsButton.ShowArrowButton = false;
			// 
			// optionsPopupMenu
			// 
			this.optionsPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonErrorDetails)});
			this.optionsPopupMenu.Manager = this.barManager;
			this.optionsPopupMenu.Name = "optionsPopupMenu";
			this.optionsPopupMenu.BeforePopup += new System.ComponentModel.CancelEventHandler(this.optionsPopupMenu_BeforePopup);
			// 
			// buttonErrorDetails
			// 
			resources.ApplyResources(this.buttonErrorDetails, "buttonErrorDetails");
			this.buttonErrorDetails.Id = 3;
			this.buttonErrorDetails.Name = "buttonErrorDetails";
			this.buttonErrorDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.detailedErrorsButton_ItemClick);
			// 
			// barManager
			// 
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this.errorOccurredWizardPage;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.detailedErrorsButton,
            this.underylingExceptionButton,
            this.buttonErrorDetails});
			this.barManager.MaxItemId = 4;
			// 
			// barDockControlTop
			// 
			resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
			this.barDockControlTop.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("barDockControlTop.Appearance.GradientMode")));
			this.barDockControlTop.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("barDockControlTop.Appearance.Image")));
			this.barDockControlTop.CausesValidation = false;
			// 
			// barDockControlBottom
			// 
			resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
			this.barDockControlBottom.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("barDockControlBottom.Appearance.GradientMode")));
			this.barDockControlBottom.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("barDockControlBottom.Appearance.Image")));
			this.barDockControlBottom.CausesValidation = false;
			// 
			// barDockControlLeft
			// 
			resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
			this.barDockControlLeft.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("barDockControlLeft.Appearance.GradientMode")));
			this.barDockControlLeft.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("barDockControlLeft.Appearance.Image")));
			this.barDockControlLeft.CausesValidation = false;
			// 
			// barDockControlRight
			// 
			resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
			this.barDockControlRight.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("barDockControlRight.Appearance.GradientMode")));
			this.barDockControlRight.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("barDockControlRight.Appearance.Image")));
			this.barDockControlRight.CausesValidation = false;
			// 
			// detailedErrorsButton
			// 
			resources.ApplyResources(this.detailedErrorsButton, "detailedErrorsButton");
			this.detailedErrorsButton.Id = 0;
			this.detailedErrorsButton.ImageIndex = 1;
			this.detailedErrorsButton.Name = "detailedErrorsButton";
			// 
			// underylingExceptionButton
			// 
			resources.ApplyResources(this.underylingExceptionButton, "underylingExceptionButton");
			this.underylingExceptionButton.Id = 1;
			this.underylingExceptionButton.ImageIndex = 0;
			this.underylingExceptionButton.Name = "underylingExceptionButton";
			// 
			// errorTextMemoEdit
			// 
			resources.ApplyResources(this.errorTextMemoEdit, "errorTextMemoEdit");
			this.errorTextMemoEdit.Name = "errorTextMemoEdit";
			this.errorTextMemoEdit.Properties.AccessibleDescription = resources.GetString("errorTextMemoEdit.Properties.AccessibleDescription");
			this.errorTextMemoEdit.Properties.AccessibleName = resources.GetString("errorTextMemoEdit.Properties.AccessibleName");
			this.errorTextMemoEdit.Properties.NullValuePrompt = resources.GetString("errorTextMemoEdit.Properties.NullValuePrompt");
			this.errorTextMemoEdit.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("errorTextMemoEdit.Properties.NullValuePromptShowForEmptyValue")));
			// 
			// progressBackgroundWorker
			// 
			this.progressBackgroundWorker.WorkerReportsProgress = true;
			this.progressBackgroundWorker.WorkerSupportsCancellation = true;
			this.progressBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.progressBackgroundWorker_DoWork);
			this.progressBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.progressBackgroundWorker_ProgressChanged);
			this.progressBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.progressBackgroundWorker_RunWorkerCompleted);
			// 
			// SendProjectWizardForm
			// 
			resources.ApplyResources(this, "$this");
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("SendProjectWizardForm.Appearance.Font")));
			this.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SendProjectWizardForm.Appearance.GradientMode")));
			this.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("SendProjectWizardForm.Appearance.Image")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.wizardControl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SendProjectWizardForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendProjectWizardForm_FormClosing);
			this.Load += new System.EventHandler(this.SendProjectWizardForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
			this.wizardControl.ResumeLayout(false);
			this.optionsWizardPage.ResumeLayout(false);
			this.optionsWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exportLocalSettingsCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exportResourceFilesCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exportProjectFileCheckEdit.Properties)).EndInit();
			this.receiversWizardPage.ResumeLayout(false);
			this.receiversWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.zulBodyTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zulSubjectTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zulReceiversTextEdit.Properties)).EndInit();
			this.successWizardPage.ResumeLayout(false);
			this.successWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.downloadProjectUrlLinkEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.progressWizardPage.ResumeLayout(false);
			this.progressWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
			this.errorOccurredWizardPage.ResumeLayout(false);
			this.errorOccurredWizardPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorTextMemoEdit.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraWizard.WizardControl wizardControl;
		private DevExpress.XtraWizard.WelcomeWizardPage optionsWizardPage;
		private DevExpress.XtraWizard.WizardPage receiversWizardPage;
		private DevExpress.XtraWizard.CompletionWizardPage successWizardPage;
		private System.ComponentModel.BackgroundWorker progressBackgroundWorker;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.CheckEdit exportLocalSettingsCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportResourceFilesCheckEdit;
		private DevExpress.XtraEditors.CheckEdit exportProjectFileCheckEdit;
		private DevExpress.XtraEditors.ComboBoxEdit zulReceiversTextEdit;
		private DevExpress.XtraEditors.LabelControl label2;
		private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
		private DevExpress.XtraWizard.WizardPage progressWizardPage;
		private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
		private DevExpress.XtraEditors.LabelControl progressLabel;
		private DevExpress.XtraWizard.WizardPage errorOccurredWizardPage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private DevExpress.XtraEditors.DropDownButton optionsButton;
		private DevExpress.XtraEditors.MemoEdit errorTextMemoEdit;
		private System.Windows.Forms.PictureBox pictureBox2;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.SimpleButton buttonZulReset;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.MemoEdit zulBodyTextEdit;
		private DevExpress.XtraEditors.TextEdit zulSubjectTextEdit;
		private DevExpress.XtraEditors.HyperLinkEdit downloadProjectUrlLinkEdit;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarButtonItem detailedErrorsButton;
		private DevExpress.XtraBars.BarButtonItem underylingExceptionButton;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private System.Windows.Forms.PictureBox pictureBox3;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraBars.BarButtonItem buttonErrorDetails;
	}
}