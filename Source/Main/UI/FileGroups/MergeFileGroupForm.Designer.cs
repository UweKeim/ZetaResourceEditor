namespace ZetaResourceEditor.UI.FileGroups
{
	partial class MergeFileGroupForm
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
			components = new Container();
			filesToMergeControl = new FileGroupSelectionControl();
			invertFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectNoFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			selectAllFileGroupsButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			filesToMergeLabel = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			fileGroupToMergeIntoTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)filesToMergeControl).BeginInit();
			((ISupportInitialize)fileGroupToMergeIntoTextBox.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// filesToMergeControl
			// 
			filesToMergeControl.AllowDrop = true;
			tablePanel1.SetColumn(filesToMergeControl, 0);
			tablePanel1.SetColumnSpan(filesToMergeControl, 6);
			filesToMergeControl.Dock = DockStyle.Fill;
			filesToMergeControl.EmptyText = "No items";
			filesToMergeControl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			filesToMergeControl.Location = new Point(11, 83);
			filesToMergeControl.Margin = new Padding(0);
			filesToMergeControl.Name = "filesToMergeControl";
			tablePanel1.SetRow(filesToMergeControl, 3);
			filesToMergeControl.Size = new Size(562, 471);
			filesToMergeControl.TabIndex = 1;
			filesToMergeControl.NodeChecked += filesToMergeControl_NodeChecked;
			// 
			// invertFileGroupsButton
			// 
			invertFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			invertFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(invertFileGroupsButton, 2);
			invertFileGroupsButton.Dock = DockStyle.Fill;
			invertFileGroupsButton.Location = new Point(179, 572);
			invertFileGroupsButton.Margin = new Padding(0);
			invertFileGroupsButton.Name = "invertFileGroupsButton";
			tablePanel1.SetRow(invertFileGroupsButton, 5);
			invertFileGroupsButton.Size = new Size(75, 28);
			invertFileGroupsButton.TabIndex = 4;
			invertFileGroupsButton.Text = "&Flip";
			invertFileGroupsButton.Click += invertFileGroupsButton_Click;
			// 
			// selectNoFileGroupsButton
			// 
			selectNoFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectNoFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(selectNoFileGroupsButton, 1);
			selectNoFileGroupsButton.Dock = DockStyle.Fill;
			selectNoFileGroupsButton.Location = new Point(95, 572);
			selectNoFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			selectNoFileGroupsButton.Name = "selectNoFileGroupsButton";
			tablePanel1.SetRow(selectNoFileGroupsButton, 5);
			selectNoFileGroupsButton.Size = new Size(75, 28);
			selectNoFileGroupsButton.TabIndex = 3;
			selectNoFileGroupsButton.Text = "&None";
			selectNoFileGroupsButton.Click += selectNoFileGroupsButton_Click;
			// 
			// selectAllFileGroupsButton
			// 
			selectAllFileGroupsButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			selectAllFileGroupsButton.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(selectAllFileGroupsButton, 0);
			selectAllFileGroupsButton.Dock = DockStyle.Fill;
			selectAllFileGroupsButton.Location = new Point(11, 572);
			selectAllFileGroupsButton.Margin = new Padding(0, 0, 9, 0);
			selectAllFileGroupsButton.Name = "selectAllFileGroupsButton";
			tablePanel1.SetRow(selectAllFileGroupsButton, 5);
			selectAllFileGroupsButton.Size = new Size(75, 28);
			selectAllFileGroupsButton.TabIndex = 2;
			selectAllFileGroupsButton.Text = "&All";
			selectAllFileGroupsButton.Click += selectAllFileGroupsButton_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 5);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(498, 572);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 5);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 6;
			buttonCancel.Text = "Cancel";
			// 
			// buttonOK
			// 
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonOK, 4);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Dock = DockStyle.Fill;
			buttonOK.Location = new Point(414, 572);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel1.SetRow(buttonOK, 5);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 5;
			buttonOK.Text = "Merge";
			buttonOK.Click += buttonOK_Click;
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label1, 0);
			tablePanel1.SetColumnSpan(label1, 6);
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(11, 10);
			label1.Margin = new Padding(0, 0, 0, 3);
			label1.Name = "label1";
			tablePanel1.SetRow(label1, 0);
			label1.Size = new Size(562, 17);
			label1.TabIndex = 7;
			label1.Text = "File group to merge into:";
			// 
			// filesToMergeLabel
			// 
			filesToMergeLabel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			filesToMergeLabel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(filesToMergeLabel, 0);
			tablePanel1.SetColumnSpan(filesToMergeLabel, 6);
			filesToMergeLabel.Dock = DockStyle.Top;
			filesToMergeLabel.Location = new Point(11, 63);
			filesToMergeLabel.Margin = new Padding(0, 0, 0, 3);
			filesToMergeLabel.Name = "filesToMergeLabel";
			tablePanel1.SetRow(filesToMergeLabel, 2);
			filesToMergeLabel.Size = new Size(562, 17);
			filesToMergeLabel.TabIndex = 0;
			filesToMergeLabel.Text = "&Files to merge:";
			// 
			// fileGroupToMergeIntoTextBox
			// 
			tablePanel1.SetColumn(fileGroupToMergeIntoTextBox, 0);
			tablePanel1.SetColumnSpan(fileGroupToMergeIntoTextBox, 6);
			fileGroupToMergeIntoTextBox.CueText = null;
			fileGroupToMergeIntoTextBox.Dock = DockStyle.Fill;
			fileGroupToMergeIntoTextBox.Location = new Point(11, 30);
			fileGroupToMergeIntoTextBox.Margin = new Padding(0, 0, 0, 9);
			fileGroupToMergeIntoTextBox.MaximumSize = new Size(0, 24);
			fileGroupToMergeIntoTextBox.MinimumSize = new Size(0, 24);
			fileGroupToMergeIntoTextBox.Name = "fileGroupToMergeIntoTextBox";
			fileGroupToMergeIntoTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			fileGroupToMergeIntoTextBox.Properties.Appearance.Options.UseFont = true;
			fileGroupToMergeIntoTextBox.Properties.Mask.EditMask = null;
			fileGroupToMergeIntoTextBox.Properties.NullValuePrompt = null;
			fileGroupToMergeIntoTextBox.Properties.ReadOnly = true;
			fileGroupToMergeIntoTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(fileGroupToMergeIntoTextBox, 1);
			fileGroupToMergeIntoTextBox.Size = new Size(562, 24);
			fileGroupToMergeIntoTextBox.TabIndex = 8;
			fileGroupToMergeIntoTextBox.TabStop = false;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(selectAllFileGroupsButton);
			tablePanel1.Controls.Add(filesToMergeControl);
			tablePanel1.Controls.Add(selectNoFileGroupsButton);
			tablePanel1.Controls.Add(fileGroupToMergeIntoTextBox);
			tablePanel1.Controls.Add(filesToMergeLabel);
			tablePanel1.Controls.Add(label1);
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Controls.Add(invertFileGroupsButton);
			tablePanel1.Controls.Add(buttonOK);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 18F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(584, 611);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// MergeFileGroupForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(584, 611);
			Controls.Add(tablePanel1);
			Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(586, 643);
			Name = "MergeFileGroupForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Merge files";
			FormClosing += MergeFileGroupForm_FormClosing;
			Load += MergeFileGroupForm_Load;
			((ISupportInitialize)filesToMergeControl).EndInit();
			((ISupportInitialize)fileGroupToMergeIntoTextBox.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton invertFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectNoFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton selectAllFileGroupsButton;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl filesToMergeLabel;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit fileGroupToMergeIntoTextBox;
		private FileGroupSelectionControl filesToMergeControl;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
	}
}