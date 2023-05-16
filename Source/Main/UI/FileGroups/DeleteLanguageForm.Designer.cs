namespace ZetaResourceEditor.UI.FileGroups
{
	partial class DeleteLanguageForm
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
			informationLightUserControl1 = new Helper.InformationLightUserControl();
			invertFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectNoFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectAllFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			destinationLanguagesListBox = new ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			parentElementTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)destinationLanguagesListBox).BeginInit();
			((ISupportInitialize)parentElementTextBox.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			SuspendLayout();
			// 
			// informationLightUserControl1
			// 
			informationLightUserControl1.BackColor = SystemColors.AppWorkspace;
			tablePanel1.SetColumn(informationLightUserControl1, 0);
			tablePanel1.SetColumnSpan(informationLightUserControl1, 4);
			informationLightUserControl1.DescriptionText = "Deletes language files for the checked languages.";
			informationLightUserControl1.Dock = DockStyle.Fill;
			informationLightUserControl1.Location = new Point(11, 10);
			informationLightUserControl1.Margin = new Padding(0, 0, 0, 18);
			informationLightUserControl1.MinimumSize = new Size(167, 28);
			informationLightUserControl1.Name = "informationLightUserControl1";
			informationLightUserControl1.Padding = new Padding(1);
			tablePanel1.SetRow(informationLightUserControl1, 0);
			informationLightUserControl1.Size = new Size(517, 28);
			informationLightUserControl1.TabIndex = 0;
			// 
			// invertFileGroupsButton
			// 
			invertFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			invertFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(invertFileGroupsButton, 2);
			invertFileGroupsButton.Dock = DockStyle.Fill;
			invertFileGroupsButton.Location = new Point(168, 286);
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
			selectNoFileGroupsButton.Location = new Point(84, 286);
			selectNoFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
			tablePanel2.SetRow(selectNoFileGroupsButton, 1);
			selectNoFileGroupsButton.Size = new Size(75, 28);
			selectNoFileGroupsButton.TabIndex = 2;
			selectNoFileGroupsButton.Text = "None";
			selectNoFileGroupsButton.Click += selectNoFileGroupsButton_Click;
			// 
			// selectAllFileGroupsButton
			// 
			selectAllFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectAllFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(selectAllFileGroupsButton, 0);
			selectAllFileGroupsButton.Dock = DockStyle.Fill;
			selectAllFileGroupsButton.Location = new Point(0, 286);
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
			buttonCancel.Location = new Point(453, 418);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 4);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 6;
			buttonCancel.Text = "Cancel";
			// 
			// destinationLanguagesListBox
			// 
			destinationLanguagesListBox.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			destinationLanguagesListBox.Appearance.Options.UseFont = true;
			destinationLanguagesListBox.CheckOnClick = true;
			tablePanel2.SetColumn(destinationLanguagesListBox, 0);
			tablePanel2.SetColumnSpan(destinationLanguagesListBox, 4);
			destinationLanguagesListBox.Dock = DockStyle.Fill;
			destinationLanguagesListBox.Location = new Point(0, 0);
			destinationLanguagesListBox.Margin = new Padding(0, 0, 0, 6);
			destinationLanguagesListBox.Name = "destinationLanguagesListBox";
			tablePanel2.SetRow(destinationLanguagesListBox, 0);
			destinationLanguagesListBox.Size = new Size(389, 280);
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
			buttonOK.Location = new Point(369, 418);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel1.SetRow(buttonOK, 4);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 5;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label1, 0);
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(11, 59);
			label1.Margin = new Padding(0, 3, 6, 0);
			label1.Name = "label1";
			tablePanel1.SetRow(label1, 1);
			label1.Size = new Size(122, 17);
			label1.TabIndex = 1;
			label1.Text = "Parent element:";
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl1, 0);
			labelControl1.Dock = DockStyle.Top;
			labelControl1.Location = new Point(11, 89);
			labelControl1.Margin = new Padding(0, 3, 6, 0);
			labelControl1.Name = "labelControl1";
			tablePanel1.SetRow(labelControl1, 2);
			labelControl1.Size = new Size(122, 17);
			labelControl1.TabIndex = 3;
			labelControl1.Text = "&Languages to delete:";
			// 
			// parentElementTextBox
			// 
			parentElementTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(parentElementTextBox, 1);
			tablePanel1.SetColumnSpan(parentElementTextBox, 3);
			parentElementTextBox.CueText = null;
			parentElementTextBox.Location = new Point(139, 56);
			parentElementTextBox.Margin = new Padding(0, 0, 0, 6);
			parentElementTextBox.MaximumSize = new Size(0, 24);
			parentElementTextBox.MinimumSize = new Size(0, 24);
			parentElementTextBox.Name = "parentElementTextBox";
			parentElementTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			parentElementTextBox.Properties.Appearance.Options.UseFont = true;
			parentElementTextBox.Properties.Mask.EditMask = null;
			parentElementTextBox.Properties.NullValuePrompt = null;
			parentElementTextBox.Properties.ReadOnly = true;
			parentElementTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(parentElementTextBox, 1);
			parentElementTextBox.Size = new Size(389, 24);
			parentElementTextBox.TabIndex = 2;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(tablePanel2);
			tablePanel1.Controls.Add(informationLightUserControl1);
			tablePanel1.Controls.Add(parentElementTextBox);
			tablePanel1.Controls.Add(labelControl1);
			tablePanel1.Controls.Add(label1);
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Controls.Add(buttonOK);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 18F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(539, 457);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// tablePanel2
			// 
			tablePanel2.AutoSize = true;
			tablePanel1.SetColumn(tablePanel2, 1);
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.SetColumnSpan(tablePanel2, 3);
			tablePanel2.Controls.Add(destinationLanguagesListBox);
			tablePanel2.Controls.Add(selectAllFileGroupsButton);
			tablePanel2.Controls.Add(invertFileGroupsButton);
			tablePanel2.Controls.Add(selectNoFileGroupsButton);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(139, 86);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel1.SetRow(tablePanel2, 2);
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel2.Size = new Size(389, 314);
			tablePanel2.TabIndex = 4;
			// 
			// DeleteLanguageForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(539, 457);
			Controls.Add(tablePanel1);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(541, 489);
			Name = "DeleteLanguageForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Delete multiple files";
			FormClosing += CreateNewFileForm_FormClosing;
			Load += CreateNewFileForm_Load;
			((ISupportInitialize)destinationLanguagesListBox).EndInit();
			((ISupportInitialize)parentElementTextBox.Properties).EndInit();
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
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit parentElementTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomListBox.MyCheckedListBoxControl destinationLanguagesListBox;
		private Helper.InformationLightUserControl informationLightUserControl1;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
	}
}