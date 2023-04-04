namespace ZetaResourceEditor.UI.Tools
{
	partial class ReplaceForm
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
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			simpleButton2 = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			simpleButton1 = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			whiteSpaceAwareCheckEdit = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			textToReplaceComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			textToFindComboBox = new ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)whiteSpaceAwareCheckEdit.Properties).BeginInit();
			((ISupportInitialize)textToReplaceComboBox.Properties).BeginInit();
			((ISupportInitialize)textToFindComboBox.Properties).BeginInit();
			SuspendLayout();
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 90F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 90F) });
			tablePanel1.Controls.Add(simpleButton2);
			tablePanel1.Controls.Add(simpleButton1);
			tablePanel1.Controls.Add(whiteSpaceAwareCheckEdit);
			tablePanel1.Controls.Add(textToReplaceComboBox);
			tablePanel1.Controls.Add(labelControl1);
			tablePanel1.Controls.Add(textToFindComboBox);
			tablePanel1.Controls.Add(label1);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 18F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(566, 178);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// simpleButton2
			// 
			simpleButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			simpleButton2.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			simpleButton2.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(simpleButton2, 3);
			simpleButton2.DialogResult = DialogResult.Cancel;
			simpleButton2.Location = new Point(460, 133);
			simpleButton2.Margin = new Padding(0);
			simpleButton2.Name = "simpleButton2";
			tablePanel1.SetRow(simpleButton2, 6);
			simpleButton2.Size = new Size(90, 28);
			simpleButton2.TabIndex = 6;
			simpleButton2.Text = "Cancel";
			simpleButton2.WantDrawFocusRectangle = true;
			// 
			// simpleButton1
			// 
			simpleButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			simpleButton1.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			simpleButton1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(simpleButton1, 1);
			simpleButton1.DialogResult = DialogResult.OK;
			simpleButton1.Location = new Point(361, 133);
			simpleButton1.Margin = new Padding(0);
			simpleButton1.Name = "simpleButton1";
			tablePanel1.SetRow(simpleButton1, 6);
			simpleButton1.Size = new Size(90, 28);
			simpleButton1.TabIndex = 5;
			simpleButton1.Text = "Replace all";
			simpleButton1.WantDrawFocusRectangle = true;
			simpleButton1.Click += buttonOK_Click;
			// 
			// whiteSpaceAwareCheckEdit
			// 
			whiteSpaceAwareCheckEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tablePanel1.SetColumn(whiteSpaceAwareCheckEdit, 0);
			whiteSpaceAwareCheckEdit.Location = new Point(16, 133);
			whiteSpaceAwareCheckEdit.Margin = new Padding(0);
			whiteSpaceAwareCheckEdit.Name = "whiteSpaceAwareCheckEdit";
			whiteSpaceAwareCheckEdit.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			whiteSpaceAwareCheckEdit.Properties.Appearance.Options.UseFont = true;
			whiteSpaceAwareCheckEdit.Properties.AutoWidth = true;
			whiteSpaceAwareCheckEdit.Properties.Caption = "White-space aware";
			tablePanel1.SetRow(whiteSpaceAwareCheckEdit, 6);
			whiteSpaceAwareCheckEdit.Size = new Size(142, 27);
			whiteSpaceAwareCheckEdit.TabIndex = 4;
			// 
			// textToReplaceComboBox
			// 
			textToReplaceComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(textToReplaceComboBox, 0);
			tablePanel1.SetColumnSpan(textToReplaceComboBox, 4);
			textToReplaceComboBox.CueText = null;
			textToReplaceComboBox.Location = new Point(16, 89);
			textToReplaceComboBox.Margin = new Padding(0);
			textToReplaceComboBox.Name = "textToReplaceComboBox";
			textToReplaceComboBox.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			textToReplaceComboBox.Properties.Appearance.Options.UseFont = true;
			textToReplaceComboBox.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
			textToReplaceComboBox.Properties.NullValuePrompt = null;
			textToReplaceComboBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(textToReplaceComboBox, 4);
			textToReplaceComboBox.Size = new Size(534, 25);
			textToReplaceComboBox.TabIndex = 3;
			textToReplaceComboBox.EditValueChanged += textToReplaceComboBox_TextUpdate;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			labelControl1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(labelControl1, 0);
			labelControl1.Location = new Point(16, 69);
			labelControl1.Margin = new Padding(0, 0, 0, 3);
			labelControl1.Name = "labelControl1";
			tablePanel1.SetRow(labelControl1, 3);
			labelControl1.Size = new Size(117, 17);
			labelControl1.TabIndex = 2;
			labelControl1.Text = "Text to &replace with:";
			// 
			// textToFindComboBox
			// 
			textToFindComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(textToFindComboBox, 0);
			tablePanel1.SetColumnSpan(textToFindComboBox, 4);
			textToFindComboBox.CueText = null;
			textToFindComboBox.Location = new Point(16, 35);
			textToFindComboBox.Margin = new Padding(0);
			textToFindComboBox.Name = "textToFindComboBox";
			textToFindComboBox.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			textToFindComboBox.Properties.Appearance.Options.UseFont = true;
			textToFindComboBox.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
			textToFindComboBox.Properties.NullValuePrompt = null;
			textToFindComboBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(textToFindComboBox, 1);
			textToFindComboBox.Size = new Size(534, 25);
			textToFindComboBox.TabIndex = 1;
			textToFindComboBox.EditValueChanged += textToFindComboBox_TextUpdate;
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label1, 0);
			label1.Location = new Point(16, 15);
			label1.Margin = new Padding(0, 0, 0, 3);
			label1.Name = "label1";
			tablePanel1.SetRow(label1, 0);
			tablePanel1.SetRowSpan(label1, 0);
			label1.Size = new Size(69, 17);
			label1.TabIndex = 0;
			label1.Text = "&Text to find:";
			// 
			// ReplaceForm
			// 
			AcceptButton = simpleButton1;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = simpleButton2;
			ClientSize = new Size(566, 178);
			Controls.Add(tablePanel1);
			Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ReplaceForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Replace text";
			Load += ReplaceForm_Load;
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			((ISupportInitialize)whiteSpaceAwareCheckEdit.Properties).EndInit();
			((ISupportInitialize)textToReplaceComboBox.Properties).EndInit();
			((ISupportInitialize)textToFindComboBox.Properties).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit textToFindComboBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit textToReplaceComboBox;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit whiteSpaceAwareCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton simpleButton1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton simpleButton2;
	}
}