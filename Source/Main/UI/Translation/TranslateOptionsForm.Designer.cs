namespace ZetaResourceEditor.UI.Translation
{
	partial class TranslateOptionsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			xtraTabControl1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl();
			engineTabPage = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			myHyperLinkEdit1 = new ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit();
			appIDMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			appIDTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			appIDLinkControl = new ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit();
			engineComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			appIDLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			settingsTabPage = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			checkEditContinueOnErrors = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			translationDelayTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			wordsToKeepTabPage = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
			tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
			labelControl5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			buttonAddDefaultWordsToKeep = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			wordsToProtectMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			wordsToRemoveTabPage = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
			tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
			labelControl6 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			myLabelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			wordsToRemoveMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)xtraTabControl1).BeginInit();
			xtraTabControl1.SuspendLayout();
			engineTabPage.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			((ISupportInitialize)myHyperLinkEdit1.Properties).BeginInit();
			((ISupportInitialize)appIDMemoEdit.Properties).BeginInit();
			((ISupportInitialize)appIDTextEdit.Properties).BeginInit();
			((ISupportInitialize)appIDLinkControl.Properties).BeginInit();
			((ISupportInitialize)engineComboBox.Properties).BeginInit();
			settingsTabPage.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((ISupportInitialize)checkEditContinueOnErrors.Properties).BeginInit();
			((ISupportInitialize)translationDelayTextEdit.Properties).BeginInit();
			wordsToKeepTabPage.SuspendLayout();
			((ISupportInitialize)tablePanel5).BeginInit();
			tablePanel5.SuspendLayout();
			((ISupportInitialize)wordsToProtectMemoEdit.Properties).BeginInit();
			wordsToRemoveTabPage.SuspendLayout();
			((ISupportInitialize)tablePanel4).BeginInit();
			tablePanel4.SuspendLayout();
			((ISupportInitialize)wordsToRemoveMemoEdit.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// xtraTabControl1
			// 
			xtraTabControl1.AppearancePage.Header.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
			tablePanel1.SetColumn(xtraTabControl1, 0);
			tablePanel1.SetColumnSpan(xtraTabControl1, 3);
			xtraTabControl1.Dock = DockStyle.Fill;
			xtraTabControl1.Location = new Point(11, 10);
			xtraTabControl1.Margin = new Padding(0, 0, 0, 9);
			xtraTabControl1.Name = "xtraTabControl1";
			tablePanel1.SetRow(xtraTabControl1, 0);
			xtraTabControl1.SelectedTabPage = engineTabPage;
			xtraTabControl1.Size = new Size(374, 283);
			xtraTabControl1.TabIndex = 0;
			xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { engineTabPage, settingsTabPage, wordsToKeepTabPage, wordsToRemoveTabPage });
			// 
			// engineTabPage
			// 
			engineTabPage.Controls.Add(tablePanel2);
			engineTabPage.Name = "engineTabPage";
			engineTabPage.Padding = new Padding(9);
			engineTabPage.Size = new Size(372, 254);
			engineTabPage.Text = "Service";
			// 
			// tablePanel2
			// 
			tablePanel2.AutoSize = true;
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel2.Controls.Add(myHyperLinkEdit1);
			tablePanel2.Controls.Add(appIDMemoEdit);
			tablePanel2.Controls.Add(appIDTextEdit);
			tablePanel2.Controls.Add(labelControl2);
			tablePanel2.Controls.Add(appIDLinkControl);
			tablePanel2.Controls.Add(engineComboBox);
			tablePanel2.Controls.Add(appIDLabel);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(9, 9);
			tablePanel2.Name = "tablePanel2";
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel2.Size = new Size(354, 236);
			tablePanel2.TabIndex = 2;
			// 
			// myHyperLinkEdit1
			// 
			myHyperLinkEdit1.AllowAutoWidth = true;
			myHyperLinkEdit1.CausesValidation = false;
			tablePanel2.SetColumn(myHyperLinkEdit1, 0);
			myHyperLinkEdit1.Dock = DockStyle.Fill;
			myHyperLinkEdit1.EditValue = "JSON validator";
			myHyperLinkEdit1.Location = new Point(0, 214);
			myHyperLinkEdit1.Margin = new Padding(0);
			myHyperLinkEdit1.Name = "myHyperLinkEdit1";
			myHyperLinkEdit1.Properties.AllowFocused = false;
			myHyperLinkEdit1.Properties.Appearance.BackColor = Color.Transparent;
			myHyperLinkEdit1.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			myHyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
			myHyperLinkEdit1.Properties.Appearance.Options.UseFont = true;
			myHyperLinkEdit1.Properties.Appearance.Options.UseTextOptions = true;
			myHyperLinkEdit1.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
			myHyperLinkEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
			myHyperLinkEdit1.Properties.ReadOnly = true;
			tablePanel2.SetRow(myHyperLinkEdit1, 6);
			myHyperLinkEdit1.Size = new Size(354, 22);
			myHyperLinkEdit1.TabIndex = 6;
			myHyperLinkEdit1.TabStop = false;
			myHyperLinkEdit1.OpenLink += myHyperLinkEdit1_OpenLink;
			// 
			// appIDMemoEdit
			// 
			tablePanel2.SetColumn(appIDMemoEdit, 0);
			appIDMemoEdit.CueText = null;
			appIDMemoEdit.Dock = DockStyle.Fill;
			appIDMemoEdit.Location = new Point(0, 134);
			appIDMemoEdit.Margin = new Padding(0, 0, 0, 6);
			appIDMemoEdit.Name = "appIDMemoEdit";
			appIDMemoEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			appIDMemoEdit.Properties.Appearance.Options.UseFont = true;
			appIDMemoEdit.Properties.NullValuePrompt = null;
			appIDMemoEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(appIDMemoEdit, 5);
			appIDMemoEdit.Size = new Size(354, 74);
			appIDMemoEdit.TabIndex = 5;
			// 
			// appIDTextEdit
			// 
			tablePanel2.SetColumn(appIDTextEdit, 0);
			appIDTextEdit.CueText = null;
			appIDTextEdit.Dock = DockStyle.Fill;
			appIDTextEdit.Location = new Point(0, 104);
			appIDTextEdit.Margin = new Padding(0, 0, 0, 6);
			appIDTextEdit.MaximumSize = new Size(0, 24);
			appIDTextEdit.MinimumSize = new Size(0, 24);
			appIDTextEdit.Name = "appIDTextEdit";
			appIDTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			appIDTextEdit.Properties.Appearance.Options.UseFont = true;
			appIDTextEdit.Properties.Mask.EditMask = null;
			appIDTextEdit.Properties.MaxLength = 400;
			appIDTextEdit.Properties.NullValuePrompt = null;
			appIDTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(appIDTextEdit, 4);
			appIDTextEdit.Size = new Size(354, 24);
			appIDTextEdit.TabIndex = 4;
			appIDTextEdit.EditValueChanged += translationDelayTextEdit_EditValueChanged;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl2.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(labelControl2, 0);
			labelControl2.Dock = DockStyle.Fill;
			labelControl2.Location = new Point(0, 0);
			labelControl2.Margin = new Padding(0, 0, 0, 3);
			labelControl2.Name = "labelControl2";
			tablePanel2.SetRow(labelControl2, 0);
			labelControl2.Size = new Size(354, 17);
			labelControl2.TabIndex = 0;
			labelControl2.Text = "Translation service to use:";
			// 
			// appIDLinkControl
			// 
			appIDLinkControl.AllowAutoWidth = true;
			appIDLinkControl.CausesValidation = false;
			tablePanel2.SetColumn(appIDLinkControl, 0);
			appIDLinkControl.Dock = DockStyle.Fill;
			appIDLinkControl.EditValue = "How to get an API key?";
			appIDLinkControl.Location = new Point(0, 53);
			appIDLinkControl.Margin = new Padding(0, 0, 0, 9);
			appIDLinkControl.Name = "appIDLinkControl";
			appIDLinkControl.Properties.AllowFocused = false;
			appIDLinkControl.Properties.Appearance.BackColor = Color.Transparent;
			appIDLinkControl.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			appIDLinkControl.Properties.Appearance.Options.UseBackColor = true;
			appIDLinkControl.Properties.Appearance.Options.UseFont = true;
			appIDLinkControl.Properties.Appearance.Options.UseTextOptions = true;
			appIDLinkControl.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
			appIDLinkControl.Properties.BorderStyle = BorderStyles.NoBorder;
			appIDLinkControl.Properties.ReadOnly = true;
			tablePanel2.SetRow(appIDLinkControl, 2);
			appIDLinkControl.Size = new Size(354, 22);
			appIDLinkControl.TabIndex = 2;
			appIDLinkControl.TabStop = false;
			appIDLinkControl.OpenLink += appIDLinkControl_OpenLink;
			// 
			// engineComboBox
			// 
			tablePanel2.SetColumn(engineComboBox, 0);
			engineComboBox.CueText = null;
			engineComboBox.Dock = DockStyle.Fill;
			engineComboBox.Location = new Point(0, 20);
			engineComboBox.Margin = new Padding(0, 0, 0, 9);
			engineComboBox.MinimumSize = new Size(0, 24);
			engineComboBox.Name = "engineComboBox";
			engineComboBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			engineComboBox.Properties.Appearance.Options.UseFont = true;
			engineComboBox.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
			engineComboBox.Properties.NullValuePrompt = null;
			engineComboBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			engineComboBox.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			tablePanel2.SetRow(engineComboBox, 1);
			engineComboBox.Size = new Size(354, 24);
			engineComboBox.TabIndex = 1;
			engineComboBox.SelectedIndexChanged += engineComboBox_SelectedIndexChanged;
			// 
			// appIDLabel
			// 
			appIDLabel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			appIDLabel.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(appIDLabel, 0);
			appIDLabel.Dock = DockStyle.Fill;
			appIDLabel.Location = new Point(0, 84);
			appIDLabel.Margin = new Padding(0, 0, 0, 3);
			appIDLabel.Name = "appIDLabel";
			tablePanel2.SetRow(appIDLabel, 3);
			appIDLabel.Size = new Size(354, 17);
			appIDLabel.TabIndex = 3;
			appIDLabel.Text = "{0} for this service:";
			// 
			// settingsTabPage
			// 
			settingsTabPage.Controls.Add(tablePanel3);
			settingsTabPage.Name = "settingsTabPage";
			settingsTabPage.Padding = new Padding(9);
			settingsTabPage.Size = new Size(372, 254);
			settingsTabPage.Text = "Settings";
			// 
			// tablePanel3
			// 
			tablePanel3.AutoSize = true;
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel3.Controls.Add(checkEditContinueOnErrors);
			tablePanel3.Controls.Add(labelControl1);
			tablePanel3.Controls.Add(label2);
			tablePanel3.Controls.Add(translationDelayTextEdit);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(9, 9);
			tablePanel3.Margin = new Padding(0);
			tablePanel3.Name = "tablePanel3";
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel3.Size = new Size(354, 236);
			tablePanel3.TabIndex = 2;
			// 
			// checkEditContinueOnErrors
			// 
			checkEditContinueOnErrors.AutoSizeInLayoutControl = true;
			tablePanel3.SetColumn(checkEditContinueOnErrors, 0);
			tablePanel3.SetColumnSpan(checkEditContinueOnErrors, 4);
			checkEditContinueOnErrors.Dock = DockStyle.Fill;
			checkEditContinueOnErrors.Location = new Point(0, 0);
			checkEditContinueOnErrors.Margin = new Padding(0, 0, 0, 6);
			checkEditContinueOnErrors.Name = "checkEditContinueOnErrors";
			checkEditContinueOnErrors.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			checkEditContinueOnErrors.Properties.Appearance.Options.UseFont = true;
			checkEditContinueOnErrors.Properties.AutoWidth = true;
			checkEditContinueOnErrors.Properties.Caption = "Continue on errors";
			tablePanel3.SetRow(checkEditContinueOnErrors, 0);
			checkEditContinueOnErrors.Size = new Size(354, 21);
			checkEditContinueOnErrors.TabIndex = 0;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(labelControl1, 2);
			labelControl1.Location = new Point(290, 30);
			labelControl1.Margin = new Padding(0);
			labelControl1.Name = "labelControl1";
			tablePanel3.SetRow(labelControl1, 1);
			labelControl1.Size = new Size(17, 17);
			labelControl1.TabIndex = 3;
			labelControl1.Text = "ms";
			// 
			// label2
			// 
			label2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(label2, 0);
			label2.Location = new Point(0, 30);
			label2.Margin = new Padding(0, 0, 6, 0);
			label2.Name = "label2";
			tablePanel3.SetRow(label2, 1);
			label2.Size = new Size(184, 17);
			label2.TabIndex = 1;
			label2.Text = "Delay between two translations:";
			// 
			// translationDelayTextEdit
			// 
			tablePanel3.SetColumn(translationDelayTextEdit, 1);
			translationDelayTextEdit.CueText = null;
			translationDelayTextEdit.Location = new Point(190, 27);
			translationDelayTextEdit.Margin = new Padding(0, 0, 6, 0);
			translationDelayTextEdit.MaximumSize = new Size(0, 24);
			translationDelayTextEdit.MinimumSize = new Size(0, 24);
			translationDelayTextEdit.Name = "translationDelayTextEdit";
			translationDelayTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			translationDelayTextEdit.Properties.Appearance.Options.UseFont = true;
			translationDelayTextEdit.Properties.Mask.EditMask = null;
			translationDelayTextEdit.Properties.MaxLength = 5;
			translationDelayTextEdit.Properties.NullValuePrompt = null;
			translationDelayTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel3.SetRow(translationDelayTextEdit, 1);
			translationDelayTextEdit.Size = new Size(94, 24);
			translationDelayTextEdit.TabIndex = 2;
			translationDelayTextEdit.EditValueChanged += translationDelayTextEdit_EditValueChanged;
			// 
			// wordsToKeepTabPage
			// 
			wordsToKeepTabPage.Controls.Add(tablePanel5);
			wordsToKeepTabPage.Name = "wordsToKeepTabPage";
			wordsToKeepTabPage.Padding = new Padding(9);
			wordsToKeepTabPage.Size = new Size(372, 254);
			wordsToKeepTabPage.Text = "Words to keep";
			// 
			// tablePanel5
			// 
			tablePanel5.AutoSize = true;
			tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 109F) });
			tablePanel5.Controls.Add(labelControl5);
			tablePanel5.Controls.Add(labelControl4);
			tablePanel5.Controls.Add(buttonAddDefaultWordsToKeep);
			tablePanel5.Controls.Add(wordsToProtectMemoEdit);
			tablePanel5.Dock = DockStyle.Fill;
			tablePanel5.Location = new Point(9, 9);
			tablePanel5.Margin = new Padding(0);
			tablePanel5.Name = "tablePanel5";
			tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel5.Size = new Size(354, 236);
			tablePanel5.TabIndex = 2;
			// 
			// labelControl5
			// 
			labelControl5.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl5.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(labelControl5, 0);
			tablePanel5.SetColumnSpan(labelControl5, 2);
			labelControl5.Dock = DockStyle.Fill;
			labelControl5.Location = new Point(0, 0);
			labelControl5.Margin = new Padding(0, 0, 0, 3);
			labelControl5.Name = "labelControl5";
			tablePanel5.SetRow(labelControl5, 0);
			labelControl5.Size = new Size(354, 17);
			labelControl5.TabIndex = 0;
			labelControl5.Text = "Never translate the following words:";
			// 
			// labelControl4
			// 
			labelControl4.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl4.Appearance.Options.UseFont = true;
			labelControl4.Appearance.Options.UseTextOptions = true;
			labelControl4.Appearance.TextOptions.VAlignment = VertAlignment.Top;
			labelControl4.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
			labelControl4.AutoSizeMode = LabelAutoSizeMode.None;
			tablePanel5.SetColumn(labelControl4, 0);
			tablePanel5.SetColumnSpan(labelControl4, 2);
			labelControl4.Dock = DockStyle.Fill;
			labelControl4.Enabled = false;
			labelControl4.Location = new Point(0, 201);
			labelControl4.Margin = new Padding(0, 9, 0, 0);
			labelControl4.Name = "labelControl4";
			tablePanel5.SetRow(labelControl4, 3);
			labelControl4.Size = new Size(354, 35);
			labelControl4.TabIndex = 3;
			labelControl4.Text = "(One word/sentence per line. [WC] prefix for wildcards, [RX] prefix for Regular Expressions)";
			// 
			// buttonAddDefaultWordsToKeep
			// 
			buttonAddDefaultWordsToKeep.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonAddDefaultWordsToKeep.Appearance.Options.UseFont = true;
			tablePanel5.SetColumn(buttonAddDefaultWordsToKeep, 1);
			buttonAddDefaultWordsToKeep.Dock = DockStyle.Fill;
			buttonAddDefaultWordsToKeep.Location = new Point(245, 164);
			buttonAddDefaultWordsToKeep.Margin = new Padding(0);
			buttonAddDefaultWordsToKeep.Name = "buttonAddDefaultWordsToKeep";
			tablePanel5.SetRow(buttonAddDefaultWordsToKeep, 2);
			buttonAddDefaultWordsToKeep.Size = new Size(109, 28);
			buttonAddDefaultWordsToKeep.TabIndex = 2;
			buttonAddDefaultWordsToKeep.Text = "Add defaults";
			buttonAddDefaultWordsToKeep.Click += buttonAddDefaultWordsToKeep_Click;
			// 
			// wordsToProtectMemoEdit
			// 
			tablePanel5.SetColumn(wordsToProtectMemoEdit, 0);
			tablePanel5.SetColumnSpan(wordsToProtectMemoEdit, 2);
			wordsToProtectMemoEdit.CueText = null;
			wordsToProtectMemoEdit.Dock = DockStyle.Fill;
			wordsToProtectMemoEdit.Location = new Point(0, 20);
			wordsToProtectMemoEdit.Margin = new Padding(0, 0, 0, 6);
			wordsToProtectMemoEdit.Name = "wordsToProtectMemoEdit";
			wordsToProtectMemoEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			wordsToProtectMemoEdit.Properties.Appearance.Options.UseFont = true;
			wordsToProtectMemoEdit.Properties.NullValuePrompt = null;
			wordsToProtectMemoEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel5.SetRow(wordsToProtectMemoEdit, 1);
			wordsToProtectMemoEdit.Size = new Size(354, 138);
			wordsToProtectMemoEdit.TabIndex = 1;
			// 
			// wordsToRemoveTabPage
			// 
			wordsToRemoveTabPage.Controls.Add(tablePanel4);
			wordsToRemoveTabPage.Name = "wordsToRemoveTabPage";
			wordsToRemoveTabPage.Padding = new Padding(9);
			wordsToRemoveTabPage.Size = new Size(372, 254);
			wordsToRemoveTabPage.Text = "Words to remove";
			// 
			// tablePanel4
			// 
			tablePanel4.AutoSize = true;
			tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel4.Controls.Add(labelControl6);
			tablePanel4.Controls.Add(myLabelControl1);
			tablePanel4.Controls.Add(wordsToRemoveMemoEdit);
			tablePanel4.Dock = DockStyle.Fill;
			tablePanel4.Location = new Point(9, 9);
			tablePanel4.Margin = new Padding(0);
			tablePanel4.Name = "tablePanel4";
			tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel4.Size = new Size(354, 236);
			tablePanel4.TabIndex = 2;
			// 
			// labelControl6
			// 
			labelControl6.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl6.Appearance.Options.UseFont = true;
			tablePanel4.SetColumn(labelControl6, 0);
			labelControl6.Location = new Point(0, 0);
			labelControl6.Margin = new Padding(0, 0, 0, 3);
			labelControl6.Name = "labelControl6";
			tablePanel4.SetRow(labelControl6, 0);
			labelControl6.Size = new Size(277, 17);
			labelControl6.TabIndex = 0;
			labelControl6.Text = "Remove the following words before translating:";
			// 
			// myLabelControl1
			// 
			myLabelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			myLabelControl1.Appearance.Options.UseFont = true;
			myLabelControl1.Appearance.Options.UseTextOptions = true;
			myLabelControl1.Appearance.TextOptions.VAlignment = VertAlignment.Top;
			myLabelControl1.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
			myLabelControl1.AutoSizeMode = LabelAutoSizeMode.None;
			tablePanel4.SetColumn(myLabelControl1, 0);
			myLabelControl1.Dock = DockStyle.Fill;
			myLabelControl1.Enabled = false;
			myLabelControl1.Location = new Point(0, 201);
			myLabelControl1.Margin = new Padding(0);
			myLabelControl1.Name = "myLabelControl1";
			tablePanel4.SetRow(myLabelControl1, 2);
			myLabelControl1.Size = new Size(354, 35);
			myLabelControl1.TabIndex = 2;
			myLabelControl1.Text = "(One word/sentence per line. [WC] prefix for wildcards, [RX] prefix for Regular Expressions)";
			// 
			// wordsToRemoveMemoEdit
			// 
			tablePanel4.SetColumn(wordsToRemoveMemoEdit, 0);
			wordsToRemoveMemoEdit.CueText = null;
			wordsToRemoveMemoEdit.Dock = DockStyle.Fill;
			wordsToRemoveMemoEdit.Location = new Point(0, 20);
			wordsToRemoveMemoEdit.Margin = new Padding(0, 0, 0, 9);
			wordsToRemoveMemoEdit.Name = "wordsToRemoveMemoEdit";
			wordsToRemoveMemoEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			wordsToRemoveMemoEdit.Properties.Appearance.Options.UseFont = true;
			wordsToRemoveMemoEdit.Properties.NullValuePrompt = null;
			wordsToRemoveMemoEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel4.SetRow(wordsToRemoveMemoEdit, 1);
			wordsToRemoveMemoEdit.Size = new Size(354, 172);
			wordsToRemoveMemoEdit.TabIndex = 1;
			// 
			// buttonOK
			// 
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonOK, 1);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Dock = DockStyle.Fill;
			buttonOK.Location = new Point(226, 302);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel1.SetRow(buttonOK, 1);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 1;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 2);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(310, 302);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 1);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 2;
			buttonCancel.Text = "Cancel";
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(xtraTabControl1);
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Controls.Add(buttonOK);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(396, 341);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// TranslateOptionsForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(396, 341);
			Controls.Add(tablePanel1);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(398, 373);
			Name = "TranslateOptionsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Translation settings";
			FormClosing += AutoTranslateOptionsForm_FormClosing;
			Load += AutoTranslateOptionsForm_Load;
			Shown += TranslateOptionsForm_Shown;
			((ISupportInitialize)xtraTabControl1).EndInit();
			xtraTabControl1.ResumeLayout(false);
			engineTabPage.ResumeLayout(false);
			engineTabPage.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			((ISupportInitialize)myHyperLinkEdit1.Properties).EndInit();
			((ISupportInitialize)appIDMemoEdit.Properties).EndInit();
			((ISupportInitialize)appIDTextEdit.Properties).EndInit();
			((ISupportInitialize)appIDLinkControl.Properties).EndInit();
			((ISupportInitialize)engineComboBox.Properties).EndInit();
			settingsTabPage.ResumeLayout(false);
			settingsTabPage.PerformLayout();
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			tablePanel3.PerformLayout();
			((ISupportInitialize)checkEditContinueOnErrors.Properties).EndInit();
			((ISupportInitialize)translationDelayTextEdit.Properties).EndInit();
			wordsToKeepTabPage.ResumeLayout(false);
			wordsToKeepTabPage.PerformLayout();
			((ISupportInitialize)tablePanel5).EndInit();
			tablePanel5.ResumeLayout(false);
			tablePanel5.PerformLayout();
			((ISupportInitialize)wordsToProtectMemoEdit.Properties).EndInit();
			wordsToRemoveTabPage.ResumeLayout(false);
			wordsToRemoveTabPage.PerformLayout();
			((ISupportInitialize)tablePanel4).EndInit();
			tablePanel4.ResumeLayout(false);
			tablePanel4.PerformLayout();
			((ISupportInitialize)wordsToRemoveMemoEdit.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit translationDelayTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit checkEditContinueOnErrors;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit engineComboBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl xtraTabControl1;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage settingsTabPage;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage wordsToKeepTabPage;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit wordsToProtectMemoEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage wordsToRemoveTabPage;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit wordsToRemoveMemoEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl5;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl6;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonAddDefaultWordsToKeep;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl appIDLabel;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit appIDTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit appIDLinkControl;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage engineTabPage;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl myLabelControl1;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit appIDMemoEdit;
		private ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit.MyHyperLinkEdit myHyperLinkEdit1;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
		private DevExpress.Utils.Layout.TablePanel tablePanel4;
		private DevExpress.Utils.Layout.TablePanel tablePanel5;
	}
}