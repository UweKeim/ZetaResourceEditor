namespace ZetaResourceEditor.UI.FileGroups
{
	partial class AddNewFileGroupForm
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
			extensionComboBoxEdit = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			invertFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectNoFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectProjectLanguagesButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			baseFolderSelectButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectAllFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			destinationLanguagesListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			baseFolderTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			baseFileNameTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			parentElementTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)extensionComboBoxEdit.Properties).BeginInit();
			((ISupportInitialize)destinationLanguagesListBox).BeginInit();
			((ISupportInitialize)baseFolderTextEdit.Properties).BeginInit();
			((ISupportInitialize)baseFileNameTextEdit.Properties).BeginInit();
			((ISupportInitialize)parentElementTextBox.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			SuspendLayout();
			// 
			// extensionComboBoxEdit
			// 
			tablePanel1.SetColumn(extensionComboBoxEdit, 1);
			tablePanel1.SetColumnSpan(extensionComboBoxEdit, 3);
			extensionComboBoxEdit.CueText = null;
			extensionComboBoxEdit.Dock = DockStyle.Fill;
			extensionComboBoxEdit.Location = new Point(110, 109);
			extensionComboBoxEdit.Margin = new Padding(0, 0, 0, 9);
			extensionComboBoxEdit.Name = "extensionComboBoxEdit";
			extensionComboBoxEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			extensionComboBoxEdit.Properties.Appearance.Options.UseFont = true;
			extensionComboBoxEdit.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
			extensionComboBoxEdit.Properties.Items.AddRange(new object[] { ".resx", ".resw" });
			extensionComboBoxEdit.Properties.NullValuePrompt = null;
			extensionComboBoxEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			extensionComboBoxEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
			tablePanel1.SetRow(extensionComboBoxEdit, 3);
			extensionComboBoxEdit.Size = new Size(418, 24);
			extensionComboBoxEdit.TabIndex = 7;
			// 
			// invertFileGroupsButton
			// 
			invertFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			invertFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(invertFileGroupsButton, 2);
			invertFileGroupsButton.Dock = DockStyle.Fill;
			invertFileGroupsButton.Location = new Point(168, 228);
			invertFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			invertFileGroupsButton.Name = "invertFileGroupsButton";
			tablePanel2.SetRow(invertFileGroupsButton, 1);
			invertFileGroupsButton.Size = new Size(75, 28);
			invertFileGroupsButton.TabIndex = 3;
			invertFileGroupsButton.Text = "Flip";
			invertFileGroupsButton.Click += invertFileGroupsButton_Click;
			// 
			// selectNoFileGroupsButton
			// 
			selectNoFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectNoFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(selectNoFileGroupsButton, 1);
			selectNoFileGroupsButton.Dock = DockStyle.Fill;
			selectNoFileGroupsButton.Location = new Point(84, 228);
			selectNoFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
			tablePanel2.SetRow(selectNoFileGroupsButton, 1);
			selectNoFileGroupsButton.Size = new Size(75, 28);
			selectNoFileGroupsButton.TabIndex = 2;
			selectNoFileGroupsButton.Text = "None";
			selectNoFileGroupsButton.Click += selectNoFileGroupsButton_Click;
			// 
			// selectProjectLanguagesButton
			// 
			selectProjectLanguagesButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectProjectLanguagesButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(selectProjectLanguagesButton, 3);
			selectProjectLanguagesButton.Dock = DockStyle.Fill;
			selectProjectLanguagesButton.Location = new Point(252, 228);
			selectProjectLanguagesButton.Margin = new Padding(0);
			selectProjectLanguagesButton.Name = "selectProjectLanguagesButton";
			tablePanel2.SetRow(selectProjectLanguagesButton, 1);
			selectProjectLanguagesButton.Size = new Size(75, 28);
			selectProjectLanguagesButton.TabIndex = 4;
			selectProjectLanguagesButton.Text = "Project";
			selectProjectLanguagesButton.Click += selectProjectLanguagesButton_Click;
			// 
			// baseFolderSelectButton
			// 
			baseFolderSelectButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			baseFolderSelectButton.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(baseFolderSelectButton, 1);
			baseFolderSelectButton.Dock = DockStyle.Top;
			baseFolderSelectButton.Location = new Point(394, 0);
			baseFolderSelectButton.Margin = new Padding(0);
			baseFolderSelectButton.Name = "baseFolderSelectButton";
			tablePanel3.SetRow(baseFolderSelectButton, 0);
			baseFolderSelectButton.Size = new Size(24, 24);
			baseFolderSelectButton.TabIndex = 1;
			baseFolderSelectButton.Text = "...";
			baseFolderSelectButton.Click += baseFolderSelectButton_Click;
			// 
			// selectAllFileGroupsButton
			// 
			selectAllFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectAllFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(selectAllFileGroupsButton, 0);
			selectAllFileGroupsButton.Dock = DockStyle.Fill;
			selectAllFileGroupsButton.Location = new Point(0, 228);
			selectAllFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			selectAllFileGroupsButton.Name = "selectAllFileGroupsButton";
			tablePanel2.SetRow(selectAllFileGroupsButton, 1);
			selectAllFileGroupsButton.Size = new Size(75, 28);
			selectAllFileGroupsButton.TabIndex = 1;
			selectAllFileGroupsButton.Text = "All";
			selectAllFileGroupsButton.Click += selectAllFileGroupsButton_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 3);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(453, 420);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 6);
			buttonCancel.Size = new Size(75, 26);
			buttonCancel.TabIndex = 11;
			buttonCancel.Text = "Cancel";
			// 
			// destinationLanguagesListBox
			// 
			destinationLanguagesListBox.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			destinationLanguagesListBox.Appearance.Options.UseFont = true;
			destinationLanguagesListBox.CheckOnClick = true;
			tablePanel2.SetColumn(destinationLanguagesListBox, 0);
			tablePanel2.SetColumnSpan(destinationLanguagesListBox, 5);
			destinationLanguagesListBox.Dock = DockStyle.Fill;
			destinationLanguagesListBox.Location = new Point(0, 0);
			destinationLanguagesListBox.Margin = new Padding(0, 0, 0, 9);
			destinationLanguagesListBox.Name = "destinationLanguagesListBox";
			tablePanel2.SetRow(destinationLanguagesListBox, 0);
			destinationLanguagesListBox.Size = new Size(414, 219);
			destinationLanguagesListBox.TabIndex = 0;
			destinationLanguagesListBox.ItemCheck += destinationLanguagesListBox_ItemCheck;
			destinationLanguagesListBox.SelectedIndexChanged += destinationLanguagesListBox_SelectedIndexChanged;
			// 
			// buttonOK
			// 
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonOK, 2);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Dock = DockStyle.Fill;
			buttonOK.Location = new Point(369, 420);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel1.SetRow(buttonOK, 6);
			buttonOK.Size = new Size(75, 26);
			buttonOK.TabIndex = 10;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label1, 0);
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(11, 13);
			label1.Margin = new Padding(0, 3, 6, 0);
			label1.Name = "label1";
			tablePanel1.SetRow(label1, 0);
			label1.Size = new Size(93, 17);
			label1.TabIndex = 0;
			label1.Text = "Parent element:";
			// 
			// labelControl4
			// 
			labelControl4.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl4.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl4, 0);
			labelControl4.Dock = DockStyle.Top;
			labelControl4.Location = new Point(11, 112);
			labelControl4.Margin = new Padding(0, 3, 6, 0);
			labelControl4.Name = "labelControl4";
			tablePanel1.SetRow(labelControl4, 3);
			labelControl4.Size = new Size(93, 17);
			labelControl4.TabIndex = 6;
			labelControl4.Text = "Extension:";
			// 
			// labelControl3
			// 
			labelControl3.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl3.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl3, 0);
			labelControl3.Dock = DockStyle.Top;
			labelControl3.Location = new Point(11, 79);
			labelControl3.Margin = new Padding(0, 3, 6, 0);
			labelControl3.Name = "labelControl3";
			tablePanel1.SetRow(labelControl3, 2);
			labelControl3.Size = new Size(93, 17);
			labelControl3.TabIndex = 4;
			labelControl3.Text = "Base file name:";
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl2.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl2, 0);
			labelControl2.Dock = DockStyle.Top;
			labelControl2.Location = new Point(11, 46);
			labelControl2.Margin = new Padding(0, 3, 6, 0);
			labelControl2.Name = "labelControl2";
			tablePanel1.SetRow(labelControl2, 1);
			labelControl2.Size = new Size(93, 17);
			labelControl2.TabIndex = 2;
			labelControl2.Text = "Base folder:";
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl1, 0);
			labelControl1.Dock = DockStyle.Top;
			labelControl1.Location = new Point(11, 145);
			labelControl1.Margin = new Padding(0, 3, 6, 0);
			labelControl1.Name = "labelControl1";
			tablePanel1.SetRow(labelControl1, 4);
			labelControl1.Size = new Size(93, 17);
			labelControl1.TabIndex = 8;
			labelControl1.Text = "&New languages:";
			// 
			// baseFolderTextEdit
			// 
			tablePanel3.SetColumn(baseFolderTextEdit, 0);
			baseFolderTextEdit.CueText = null;
			baseFolderTextEdit.Dock = DockStyle.Fill;
			baseFolderTextEdit.Location = new Point(0, 0);
			baseFolderTextEdit.Margin = new Padding(0, 0, 6, 9);
			baseFolderTextEdit.MaximumSize = new Size(0, 24);
			baseFolderTextEdit.MinimumSize = new Size(0, 24);
			baseFolderTextEdit.Name = "baseFolderTextEdit";
			baseFolderTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			baseFolderTextEdit.Properties.Appearance.Options.UseFont = true;
			baseFolderTextEdit.Properties.MaskSettings.Set("mask", null);
			baseFolderTextEdit.Properties.NullValuePrompt = null;
			baseFolderTextEdit.Properties.ReadOnly = true;
			baseFolderTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel3.SetRow(baseFolderTextEdit, 0);
			baseFolderTextEdit.Size = new Size(388, 24);
			baseFolderTextEdit.TabIndex = 0;
			baseFolderTextEdit.EditValueChanged += baseFileNameTextEdit_EditValueChanged;
			// 
			// baseFileNameTextEdit
			// 
			tablePanel1.SetColumn(baseFileNameTextEdit, 1);
			tablePanel1.SetColumnSpan(baseFileNameTextEdit, 3);
			baseFileNameTextEdit.CueText = null;
			baseFileNameTextEdit.Dock = DockStyle.Fill;
			baseFileNameTextEdit.Location = new Point(110, 76);
			baseFileNameTextEdit.Margin = new Padding(0, 0, 0, 9);
			baseFileNameTextEdit.MaximumSize = new Size(0, 24);
			baseFileNameTextEdit.MinimumSize = new Size(0, 24);
			baseFileNameTextEdit.Name = "baseFileNameTextEdit";
			baseFileNameTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			baseFileNameTextEdit.Properties.Appearance.Options.UseFont = true;
			baseFileNameTextEdit.Properties.Mask.EditMask = null;
			baseFileNameTextEdit.Properties.NullValuePrompt = null;
			baseFileNameTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(baseFileNameTextEdit, 2);
			baseFileNameTextEdit.Size = new Size(418, 24);
			baseFileNameTextEdit.TabIndex = 5;
			baseFileNameTextEdit.EditValueChanged += baseFileNameTextEdit_EditValueChanged;
			// 
			// parentElementTextBox
			// 
			tablePanel1.SetColumn(parentElementTextBox, 1);
			tablePanel1.SetColumnSpan(parentElementTextBox, 3);
			parentElementTextBox.CueText = null;
			parentElementTextBox.Dock = DockStyle.Fill;
			parentElementTextBox.Location = new Point(110, 10);
			parentElementTextBox.Margin = new Padding(0, 0, 0, 9);
			parentElementTextBox.MaximumSize = new Size(0, 24);
			parentElementTextBox.MinimumSize = new Size(0, 24);
			parentElementTextBox.Name = "parentElementTextBox";
			parentElementTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			parentElementTextBox.Properties.Appearance.Options.UseFont = true;
			parentElementTextBox.Properties.Mask.EditMask = null;
			parentElementTextBox.Properties.NullValuePrompt = null;
			parentElementTextBox.Properties.ReadOnly = true;
			parentElementTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(parentElementTextBox, 0);
			parentElementTextBox.Size = new Size(418, 24);
			parentElementTextBox.TabIndex = 1;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(labelControl1);
			tablePanel1.Controls.Add(tablePanel3);
			tablePanel1.Controls.Add(tablePanel2);
			tablePanel1.Controls.Add(label1);
			tablePanel1.Controls.Add(labelControl2);
			tablePanel1.Controls.Add(labelControl3);
			tablePanel1.Controls.Add(labelControl4);
			tablePanel1.Controls.Add(extensionComboBoxEdit);
			tablePanel1.Controls.Add(buttonOK);
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Controls.Add(parentElementTextBox);
			tablePanel1.Controls.Add(baseFileNameTextEdit);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 18F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
			tablePanel1.Size = new Size(539, 457);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// tablePanel3
			// 
			tablePanel3.AutoSize = true;
			tablePanel1.SetColumn(tablePanel3, 1);
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F) });
			tablePanel1.SetColumnSpan(tablePanel3, 3);
			tablePanel3.Controls.Add(baseFolderTextEdit);
			tablePanel3.Controls.Add(baseFolderSelectButton);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(110, 43);
			tablePanel3.Margin = new Padding(0);
			tablePanel3.Name = "tablePanel3";
			tablePanel1.SetRow(tablePanel3, 1);
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel3.Size = new Size(418, 33);
			tablePanel3.TabIndex = 3;
			// 
			// tablePanel2
			// 
			tablePanel1.SetColumn(tablePanel2, 1);
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.SetColumnSpan(tablePanel2, 3);
			tablePanel2.Controls.Add(destinationLanguagesListBox);
			tablePanel2.Controls.Add(selectAllFileGroupsButton);
			tablePanel2.Controls.Add(selectNoFileGroupsButton);
			tablePanel2.Controls.Add(invertFileGroupsButton);
			tablePanel2.Controls.Add(selectProjectLanguagesButton);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(112, 144);
			tablePanel2.Name = "tablePanel2";
			tablePanel1.SetRow(tablePanel2, 4);
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel2.Size = new Size(414, 256);
			tablePanel2.TabIndex = 9;
			// 
			// AddNewFileGroupForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(539, 457);
			Controls.Add(tablePanel1);
			Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(541, 489);
			Name = "AddNewFileGroupForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Create new files";
			FormClosing += CreateNewFileForm_FormClosing;
			Load += CreateNewFileForm_Load;
			((ISupportInitialize)extensionComboBoxEdit.Properties).EndInit();
			((ISupportInitialize)destinationLanguagesListBox).EndInit();
			((ISupportInitialize)baseFolderTextEdit.Properties).EndInit();
			((ISupportInitialize)baseFileNameTextEdit.Properties).EndInit();
			((ISupportInitialize)parentElementTextBox.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			tablePanel3.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit parentElementTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl destinationLanguagesListBox;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectProjectLanguagesButton;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit baseFileNameTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton baseFolderSelectButton;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl3;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit baseFolderTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit extensionComboBoxEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
	}
}