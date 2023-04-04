namespace ZetaResourceEditor.UI.TagOperations
{
	partial class AddTagForm
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
			textBox1 = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			button1 = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			button2 = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)textBox1.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Bold = false;
			tablePanel1.SetColumn(textBox1, 0);
			tablePanel1.SetColumnSpan(textBox1, 4);
			textBox1.CueText = null;
			textBox1.Location = new Point(16, 35);
			textBox1.Margin = new Padding(0);
			textBox1.MaximumSize = new Size(0, 24);
			textBox1.MinimumSize = new Size(0, 24);
			textBox1.Name = "textBox1";
			textBox1.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			textBox1.Properties.Appearance.Options.UseFont = true;
			textBox1.Properties.Mask.EditMask = null;
			textBox1.Properties.NullValuePrompt = null;
			textBox1.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(textBox1, 1);
			textBox1.Size = new Size(453, 24);
			textBox1.TabIndex = 1;
			textBox1.TextChanged += textBox1_TextChanged;
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
			label1.Size = new Size(126, 17);
			label1.TabIndex = 0;
			label1.Text = "&Name of the new tag:";
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button1.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			button1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(button1, 1);
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(310, 80);
			button1.Margin = new Padding(0);
			button1.Name = "button1";
			tablePanel1.SetRow(button1, 3);
			button1.Size = new Size(75, 28);
			button1.TabIndex = 2;
			button1.Text = "OK";
			button1.WantDrawFocusRectangle = true;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button2.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			button2.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(button2, 3);
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(394, 80);
			button2.Margin = new Padding(0);
			button2.Name = "button2";
			tablePanel1.SetRow(button2, 3);
			button2.Size = new Size(75, 28);
			button2.TabIndex = 3;
			button2.Text = "Cancel";
			button2.WantDrawFocusRectangle = true;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(button1);
			tablePanel1.Controls.Add(textBox1);
			tablePanel1.Controls.Add(button2);
			tablePanel1.Controls.Add(label1);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 18F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(485, 126);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// AddTagForm
			// 
			AcceptButton = button1;
			Appearance.Options.UseFont = true;
			AutoScaleMode = AutoScaleMode.None;
			CancelButton = button2;
			ClientSize = new Size(485, 126);
			Controls.Add(tablePanel1);
			Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AddTagForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Add new tag";
			FormClosing += AddTagForm_FormClosing;
			Load += AddTagForm_Load;
			((ISupportInitialize)textBox1.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit textBox1;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton button1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton button2;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
	}
}