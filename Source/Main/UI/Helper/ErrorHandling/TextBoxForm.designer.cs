namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
	partial class TextBoxForm
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
			textMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)textMemoEdit.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// textMemoEdit
			// 
			tablePanel1.SetColumn(textMemoEdit, 0);
			tablePanel1.SetColumnSpan(textMemoEdit, 2);
			textMemoEdit.CueText = null;
			textMemoEdit.Dock = DockStyle.Fill;
			textMemoEdit.Location = new Point(11, 10);
			textMemoEdit.Margin = new Padding(0);
			textMemoEdit.Name = "textMemoEdit";
			textMemoEdit.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textMemoEdit.Properties.Appearance.Options.UseBackColor = true;
			textMemoEdit.Properties.Appearance.Options.UseFont = true;
			textMemoEdit.Properties.NullValuePrompt = null;
			textMemoEdit.Properties.ReadOnly = true;
			textMemoEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(textMemoEdit, 0);
			textMemoEdit.Size = new Size(562, 516);
			textMemoEdit.TabIndex = 1;
			textMemoEdit.KeyDown += textMemoEdit_KeyDown;
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 1);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(498, 535);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 2);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 0;
			buttonCancel.Text = "Close";
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 75F) });
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Controls.Add(textMemoEdit);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
			tablePanel1.Size = new Size(584, 574);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// TextBoxForm
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 574);
			Controls.Add(tablePanel1);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(486, 552);
			Name = "TextBoxForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Text";
			FormClosing += textBoxForm_FormClosing;
			Load += textBoxForm_Load;
			((ISupportInitialize)textMemoEdit.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit textMemoEdit;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
	}
}