namespace ZetaResourceEditor.UI.Main.RightContent
{
	partial class ConfigureLanguageColumnsForm
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
			selectAllLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			invertLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectNoLanguagesToExportButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			languagesToDisplayCheckListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
			displayAllLanguagesCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			displayCertainLanguagesCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)languagesToDisplayCheckListBox).BeginInit();
			((ISupportInitialize)displayAllLanguagesCheckEdit.Properties).BeginInit();
			((ISupportInitialize)displayCertainLanguagesCheckEdit.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			SuspendLayout();
			// 
			// selectAllLanguagesToExportButton
			// 
			selectAllLanguagesToExportButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectAllLanguagesToExportButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(selectAllLanguagesToExportButton, 0);
			selectAllLanguagesToExportButton.Dock = DockStyle.Fill;
			selectAllLanguagesToExportButton.Location = new Point(0, 202);
			selectAllLanguagesToExportButton.Margin = new Padding(0, 0, 9, 0);
			selectAllLanguagesToExportButton.Name = "selectAllLanguagesToExportButton";
			tablePanel2.SetRow(selectAllLanguagesToExportButton, 1);
			selectAllLanguagesToExportButton.Size = new Size(75, 28);
			selectAllLanguagesToExportButton.TabIndex = 1;
			selectAllLanguagesToExportButton.Text = "All";
			selectAllLanguagesToExportButton.Click += selectAllLanguagesToExportButton_Click;
			// 
			// invertLanguagesToExportButton
			// 
			invertLanguagesToExportButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			invertLanguagesToExportButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(invertLanguagesToExportButton, 2);
			invertLanguagesToExportButton.Dock = DockStyle.Fill;
			invertLanguagesToExportButton.Location = new Point(168, 202);
			invertLanguagesToExportButton.Margin = new Padding(0, 0, 9, 0);
			invertLanguagesToExportButton.Name = "invertLanguagesToExportButton";
			tablePanel2.SetRow(invertLanguagesToExportButton, 1);
			invertLanguagesToExportButton.Size = new Size(75, 28);
			invertLanguagesToExportButton.TabIndex = 3;
			invertLanguagesToExportButton.Text = "Flip";
			invertLanguagesToExportButton.Click += invertLanguagesToExportButton_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 2);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(368, 309);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 3);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 4;
			buttonCancel.Text = "Cancel";
			// 
			// selectNoLanguagesToExportButton
			// 
			selectNoLanguagesToExportButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectNoLanguagesToExportButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(selectNoLanguagesToExportButton, 1);
			selectNoLanguagesToExportButton.Dock = DockStyle.Fill;
			selectNoLanguagesToExportButton.Location = new Point(84, 202);
			selectNoLanguagesToExportButton.Margin = new Padding(0, 0, 9, 0);
			selectNoLanguagesToExportButton.Name = "selectNoLanguagesToExportButton";
			tablePanel2.SetRow(selectNoLanguagesToExportButton, 1);
			selectNoLanguagesToExportButton.Size = new Size(75, 28);
			selectNoLanguagesToExportButton.TabIndex = 2;
			selectNoLanguagesToExportButton.Text = "None";
			selectNoLanguagesToExportButton.Click += selectNoLanguagesToExportButton_Click;
			// 
			// buttonOK
			// 
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonOK, 1);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Dock = DockStyle.Fill;
			buttonOK.Location = new Point(284, 309);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel1.SetRow(buttonOK, 3);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 3;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
			// 
			// languagesToDisplayCheckListBox
			// 
			languagesToDisplayCheckListBox.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			languagesToDisplayCheckListBox.Appearance.Options.UseFont = true;
			languagesToDisplayCheckListBox.CheckOnClick = true;
			tablePanel2.SetColumn(languagesToDisplayCheckListBox, 0);
			tablePanel2.SetColumnSpan(languagesToDisplayCheckListBox, 4);
			languagesToDisplayCheckListBox.Dock = DockStyle.Fill;
			languagesToDisplayCheckListBox.Location = new Point(0, 0);
			languagesToDisplayCheckListBox.Margin = new Padding(0, 0, 0, 9);
			languagesToDisplayCheckListBox.Name = "languagesToDisplayCheckListBox";
			tablePanel2.SetRow(languagesToDisplayCheckListBox, 0);
			languagesToDisplayCheckListBox.Size = new Size(414, 193);
			languagesToDisplayCheckListBox.TabIndex = 0;
			languagesToDisplayCheckListBox.ItemCheck += languagesToDisplayCheckListBox_ItemCheck;
			languagesToDisplayCheckListBox.SelectedIndexChanged += languagesToDisplayCheckListBox_SelectedIndexChanged;
			// 
			// displayAllLanguagesCheckEdit
			// 
			tablePanel1.SetColumn(displayAllLanguagesCheckEdit, 0);
			tablePanel1.SetColumnSpan(displayAllLanguagesCheckEdit, 3);
			displayAllLanguagesCheckEdit.Dock = DockStyle.Fill;
			displayAllLanguagesCheckEdit.EditValue = true;
			displayAllLanguagesCheckEdit.Location = new Point(11, 10);
			displayAllLanguagesCheckEdit.Margin = new Padding(0, 0, 0, 6);
			displayAllLanguagesCheckEdit.Name = "displayAllLanguagesCheckEdit";
			displayAllLanguagesCheckEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			displayAllLanguagesCheckEdit.Properties.Appearance.Options.UseFont = true;
			displayAllLanguagesCheckEdit.Properties.AutoWidth = true;
			displayAllLanguagesCheckEdit.Properties.Caption = "Display all languages";
			displayAllLanguagesCheckEdit.Properties.CheckStyle = CheckStyles.Radio;
			displayAllLanguagesCheckEdit.Properties.RadioGroupIndex = 0;
			tablePanel1.SetRow(displayAllLanguagesCheckEdit, 0);
			displayAllLanguagesCheckEdit.Size = new Size(432, 21);
			displayAllLanguagesCheckEdit.TabIndex = 0;
			displayAllLanguagesCheckEdit.CheckedChanged += displayAllLanguagesCheckEdit_CheckedChanged;
			// 
			// displayCertainLanguagesCheckEdit
			// 
			tablePanel1.SetColumn(displayCertainLanguagesCheckEdit, 0);
			tablePanel1.SetColumnSpan(displayCertainLanguagesCheckEdit, 3);
			displayCertainLanguagesCheckEdit.Dock = DockStyle.Fill;
			displayCertainLanguagesCheckEdit.Location = new Point(11, 37);
			displayCertainLanguagesCheckEdit.Margin = new Padding(0, 0, 0, 3);
			displayCertainLanguagesCheckEdit.Name = "displayCertainLanguagesCheckEdit";
			displayCertainLanguagesCheckEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			displayCertainLanguagesCheckEdit.Properties.Appearance.Options.UseFont = true;
			displayCertainLanguagesCheckEdit.Properties.AutoWidth = true;
			displayCertainLanguagesCheckEdit.Properties.Caption = "Display only the following languages:";
			displayCertainLanguagesCheckEdit.Properties.CheckStyle = CheckStyles.Radio;
			displayCertainLanguagesCheckEdit.Properties.RadioGroupIndex = 0;
			tablePanel1.SetRow(displayCertainLanguagesCheckEdit, 1);
			displayCertainLanguagesCheckEdit.Size = new Size(432, 21);
			displayCertainLanguagesCheckEdit.TabIndex = 1;
			displayCertainLanguagesCheckEdit.TabStop = false;
			displayCertainLanguagesCheckEdit.CheckedChanged += displayCertainLanguagesCheckEdit_CheckedChanged;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(tablePanel2);
			tablePanel1.Controls.Add(displayAllLanguagesCheckEdit);
			tablePanel1.Controls.Add(displayCertainLanguagesCheckEdit);
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Controls.Add(buttonOK);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(454, 348);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// tablePanel2
			// 
			tablePanel2.AutoSize = true;
			tablePanel1.SetColumn(tablePanel2, 0);
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.SetColumnSpan(tablePanel2, 3);
			tablePanel2.Controls.Add(languagesToDisplayCheckListBox);
			tablePanel2.Controls.Add(invertLanguagesToExportButton);
			tablePanel2.Controls.Add(selectAllLanguagesToExportButton);
			tablePanel2.Controls.Add(selectNoLanguagesToExportButton);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(29, 61);
			tablePanel2.Margin = new Padding(18, 0, 0, 18);
			tablePanel2.Name = "tablePanel2";
			tablePanel1.SetRow(tablePanel2, 2);
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel2.Size = new Size(414, 230);
			tablePanel2.TabIndex = 2;
			// 
			// ConfigureLanguageColumnsForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(454, 348);
			Controls.Add(tablePanel1);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(456, 380);
			Name = "ConfigureLanguageColumnsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Configure language columns";
			FormClosing += configureLanguageColumnsForm_FormClosing;
			Load += configureLanguageColumnsForm_Load;
			((ISupportInitialize)languagesToDisplayCheckListBox).EndInit();
			((ISupportInitialize)displayAllLanguagesCheckEdit.Properties).EndInit();
			((ISupportInitialize)displayCertainLanguagesCheckEdit.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit displayAllLanguagesCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit displayCertainLanguagesCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoLanguagesToExportButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl languagesToDisplayCheckListBox;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
	}
}