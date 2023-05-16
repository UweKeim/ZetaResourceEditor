namespace ZetaResourceEditor.UI.FileGroups
{
	using DevExpress.XtraEditors;

	partial class FileGroupSettingsForm
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
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(FileGroupSettingsForm));
			ignoreDuringExportAndImportCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			parentTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			labelControl2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			button1 = new ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton();
			optionsPopupMenu = new PopupMenu(components);
			openButton = new BarButtonItem();
			barManager = new BarManager(components);
			barDockControlTop = new BarDockControl();
			barDockControlBottom = new BarDockControl();
			barDockControlLeft = new BarDockControl();
			barDockControlRight = new BarDockControl();
			checkSumTextEdit = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			locationTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			nameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)ignoreDuringExportAndImportCheckEdit.Properties).BeginInit();
			((ISupportInitialize)parentTextEdit.Properties).BeginInit();
			((ISupportInitialize)optionsPopupMenu).BeginInit();
			((ISupportInitialize)barManager).BeginInit();
			((ISupportInitialize)checkSumTextEdit.Properties).BeginInit();
			((ISupportInitialize)locationTextBox.Properties).BeginInit();
			((ISupportInitialize)nameTextBox.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			SuspendLayout();
			// 
			// ignoreDuringExportAndImportCheckEdit
			// 
			tablePanel1.SetColumn(ignoreDuringExportAndImportCheckEdit, 1);
			tablePanel1.SetColumnSpan(ignoreDuringExportAndImportCheckEdit, 3);
			ignoreDuringExportAndImportCheckEdit.Location = new Point(99, 142);
			ignoreDuringExportAndImportCheckEdit.Margin = new Padding(0);
			ignoreDuringExportAndImportCheckEdit.Name = "ignoreDuringExportAndImportCheckEdit";
			ignoreDuringExportAndImportCheckEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			ignoreDuringExportAndImportCheckEdit.Properties.Appearance.Options.UseFont = true;
			ignoreDuringExportAndImportCheckEdit.Properties.AutoWidth = true;
			ignoreDuringExportAndImportCheckEdit.Properties.Caption = "Ignore during export and import";
			tablePanel1.SetRow(ignoreDuringExportAndImportCheckEdit, 4);
			ignoreDuringExportAndImportCheckEdit.Size = new Size(214, 21);
			ignoreDuringExportAndImportCheckEdit.TabIndex = 8;
			// 
			// parentTextEdit
			// 
			parentTextEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(parentTextEdit, 1);
			tablePanel1.SetColumnSpan(parentTextEdit, 3);
			parentTextEdit.CueText = null;
			parentTextEdit.Location = new Point(99, 10);
			parentTextEdit.Margin = new Padding(0, 0, 0, 6);
			parentTextEdit.MaximumSize = new Size(0, 24);
			parentTextEdit.MinimumSize = new Size(0, 24);
			parentTextEdit.Name = "parentTextEdit";
			parentTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			parentTextEdit.Properties.Appearance.Options.UseFont = true;
			parentTextEdit.Properties.NullValuePrompt = null;
			parentTextEdit.Properties.ReadOnly = true;
			parentTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(parentTextEdit, 0);
			parentTextEdit.Size = new Size(356, 24);
			parentTextEdit.TabIndex = 1;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl2.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl2, 0);
			labelControl2.Dock = DockStyle.Top;
			labelControl2.Location = new Point(11, 13);
			labelControl2.Margin = new Padding(0, 3, 6, 0);
			labelControl2.Name = "labelControl2";
			tablePanel1.SetRow(labelControl2, 0);
			labelControl2.Size = new Size(82, 17);
			labelControl2.TabIndex = 0;
			labelControl2.Text = "Project folder:";
			// 
			// button1
			// 
			button1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(button1, 1);
			button1.Dock = DockStyle.Top;
			button1.DropDownArrowStyle = DropDownArrowStyle.Hide;
			button1.DropDownControl = optionsPopupMenu;
			button1.ImageOptions.Image = (Image)resources.GetObject("button1.ImageOptions.Image");
			button1.ImageOptions.Location = ImageLocation.MiddleCenter;
			button1.Location = new Point(332, 0);
			button1.Margin = new Padding(0);
			button1.Name = "button1";
			tablePanel2.SetRow(button1, 0);
			button1.Size = new Size(24, 24);
			button1.TabIndex = 1;
			// 
			// optionsPopupMenu
			// 
			optionsPopupMenu.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(openButton) });
			optionsPopupMenu.Manager = barManager;
			optionsPopupMenu.Name = "optionsPopupMenu";
			// 
			// openButton
			// 
			openButton.Caption = "&Open folder";
			openButton.Id = 0;
			openButton.ImageOptions.ImageIndex = 0;
			openButton.Name = "openButton";
			openButton.ItemClick += openButton_ItemClick;
			// 
			// barManager
			// 
			barManager.DockControls.Add(barDockControlTop);
			barManager.DockControls.Add(barDockControlBottom);
			barManager.DockControls.Add(barDockControlLeft);
			barManager.DockControls.Add(barDockControlRight);
			barManager.Form = this;
			barManager.Items.AddRange(new BarItem[] { openButton });
			barManager.MaxItemId = 3;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager;
			barDockControlTop.Size = new Size(466, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 220);
			barDockControlBottom.Manager = barManager;
			barDockControlBottom.Size = new Size(466, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 0);
			barDockControlLeft.Manager = barManager;
			barDockControlLeft.Size = new Size(0, 220);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(466, 0);
			barDockControlRight.Manager = barManager;
			barDockControlRight.Size = new Size(0, 220);
			// 
			// checkSumTextEdit
			// 
			tablePanel1.SetColumn(checkSumTextEdit, 1);
			tablePanel1.SetColumnSpan(checkSumTextEdit, 3);
			checkSumTextEdit.CueText = null;
			checkSumTextEdit.Dock = DockStyle.Fill;
			checkSumTextEdit.Location = new Point(99, 106);
			checkSumTextEdit.Margin = new Padding(0, 0, 0, 12);
			checkSumTextEdit.MaximumSize = new Size(0, 24);
			checkSumTextEdit.MinimumSize = new Size(0, 24);
			checkSumTextEdit.Name = "checkSumTextEdit";
			checkSumTextEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			checkSumTextEdit.Properties.Appearance.Options.UseFont = true;
			checkSumTextEdit.Properties.NullValuePrompt = null;
			checkSumTextEdit.Properties.ReadOnly = true;
			checkSumTextEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(checkSumTextEdit, 3);
			checkSumTextEdit.Size = new Size(356, 24);
			checkSumTextEdit.TabIndex = 7;
			// 
			// locationTextBox
			// 
			tablePanel2.SetColumn(locationTextBox, 0);
			locationTextBox.CueText = null;
			locationTextBox.Dock = DockStyle.Fill;
			locationTextBox.Location = new Point(0, 0);
			locationTextBox.Margin = new Padding(0, 0, 3, 6);
			locationTextBox.MaximumSize = new Size(0, 24);
			locationTextBox.MinimumSize = new Size(0, 24);
			locationTextBox.Name = "locationTextBox";
			locationTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			locationTextBox.Properties.Appearance.Options.UseFont = true;
			locationTextBox.Properties.NullValuePrompt = null;
			locationTextBox.Properties.ReadOnly = true;
			locationTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel2.SetRow(locationTextBox, 0);
			locationTextBox.Size = new Size(329, 24);
			locationTextBox.TabIndex = 0;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl1, 0);
			labelControl1.Dock = DockStyle.Top;
			labelControl1.Location = new Point(11, 109);
			labelControl1.Margin = new Padding(0, 3, 6, 0);
			labelControl1.Name = "labelControl1";
			tablePanel1.SetRow(labelControl1, 3);
			labelControl1.Size = new Size(82, 17);
			labelControl1.TabIndex = 6;
			labelControl1.Text = "Check sum:";
			// 
			// nameTextBox
			// 
			tablePanel1.SetColumn(nameTextBox, 1);
			tablePanel1.SetColumnSpan(nameTextBox, 3);
			nameTextBox.CueText = null;
			nameTextBox.Dock = DockStyle.Fill;
			nameTextBox.Location = new Point(99, 40);
			nameTextBox.Margin = new Padding(0, 0, 0, 12);
			nameTextBox.MaximumSize = new Size(0, 24);
			nameTextBox.MinimumSize = new Size(0, 24);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			nameTextBox.Properties.Appearance.Options.UseFont = true;
			nameTextBox.Properties.NullValuePrompt = null;
			nameTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(nameTextBox, 1);
			nameTextBox.Size = new Size(356, 24);
			nameTextBox.TabIndex = 3;
			nameTextBox.TextChanged += nameTextBox_TextChanged;
			// 
			// label2
			// 
			label2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label2, 0);
			label2.Dock = DockStyle.Top;
			label2.Location = new Point(11, 79);
			label2.Margin = new Padding(0, 3, 6, 0);
			label2.Name = "label2";
			tablePanel1.SetRow(label2, 2);
			label2.Size = new Size(82, 17);
			label2.TabIndex = 4;
			label2.Text = "&Location:";
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label1, 0);
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(11, 43);
			label1.Margin = new Padding(0, 3, 6, 0);
			label1.Name = "label1";
			tablePanel1.SetRow(label1, 1);
			label1.Size = new Size(82, 17);
			label1.TabIndex = 2;
			label1.Text = "&Name:";
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 3);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(380, 181);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 6);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 10;
			buttonCancel.Text = "Cancel";
			// 
			// buttonOK
			// 
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonOK, 2);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Dock = DockStyle.Fill;
			buttonOK.Location = new Point(296, 181);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel1.SetRow(buttonOK, 6);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 9;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(tablePanel2);
			tablePanel1.Controls.Add(labelControl2);
			tablePanel1.Controls.Add(label1);
			tablePanel1.Controls.Add(label2);
			tablePanel1.Controls.Add(labelControl1);
			tablePanel1.Controls.Add(checkSumTextEdit);
			tablePanel1.Controls.Add(parentTextEdit);
			tablePanel1.Controls.Add(nameTextBox);
			tablePanel1.Controls.Add(ignoreDuringExportAndImportCheckEdit);
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Controls.Add(buttonOK);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(466, 220);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// tablePanel2
			// 
			tablePanel2.AutoSize = true;
			tablePanel1.SetColumn(tablePanel2, 1);
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F) });
			tablePanel1.SetColumnSpan(tablePanel2, 3);
			tablePanel2.Controls.Add(button1);
			tablePanel2.Controls.Add(locationTextBox);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(99, 76);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel1.SetRow(tablePanel2, 2);
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel2.Size = new Size(356, 30);
			tablePanel2.TabIndex = 5;
			// 
			// FileGroupSettingsForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(466, 220);
			Controls.Add(tablePanel1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MaximumSize = new Size(1024, 252);
			MinimizeBox = false;
			MinimumSize = new Size(468, 252);
			Name = "FileGroupSettingsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Edit file group settings";
			FormClosing += FileGroupSettingsForm_FormClosing;
			Load += FileGroupSettingsForm_Load;
			((ISupportInitialize)ignoreDuringExportAndImportCheckEdit.Properties).EndInit();
			((ISupportInitialize)parentTextEdit.Properties).EndInit();
			((ISupportInitialize)optionsPopupMenu).EndInit();
			((ISupportInitialize)barManager).EndInit();
			((ISupportInitialize)checkSumTextEdit.Properties).EndInit();
			((ISupportInitialize)locationTextBox.Properties).EndInit();
			((ISupportInitialize)nameTextBox.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit locationTextBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit nameTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton button1;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private DevExpress.XtraBars.BarButtonItem openButton;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit checkSumTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit parentTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl2;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit ignoreDuringExportAndImportCheckEdit;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
	}
}