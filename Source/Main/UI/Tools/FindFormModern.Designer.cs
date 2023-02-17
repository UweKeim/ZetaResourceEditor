namespace ZetaResourceEditor.UI.Tools
{
	partial class FindFormModern
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
			this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			this.textToFindComboBox = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit();
			this.label1 = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			this.simpleButton2 = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			this.simpleButton1 = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			this.whiteSpaceAwareCheckEdit = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
			this.tablePanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textToFindComboBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.whiteSpaceAwareCheckEdit.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// tablePanel1
			// 
			this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 310.3467F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85.33336F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F)});
			this.tablePanel1.Controls.Add(this.textToFindComboBox);
			this.tablePanel1.Controls.Add(this.label1);
			this.tablePanel1.Controls.Add(this.simpleButton2);
			this.tablePanel1.Controls.Add(this.simpleButton1);
			this.tablePanel1.Controls.Add(this.whiteSpaceAwareCheckEdit);
			this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablePanel1.Location = new System.Drawing.Point(0, 0);
			this.tablePanel1.Name = "tablePanel1";
			this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
			this.tablePanel1.Size = new System.Drawing.Size(504, 115);
			this.tablePanel1.TabIndex = 0;
			this.tablePanel1.UseSkinIndents = true;
			// 
			// textToFindComboBox
			// 
			this.textToFindComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tablePanel1.SetColumn(this.textToFindComboBox, 0);
			this.tablePanel1.SetColumnSpan(this.textToFindComboBox, 3);
			this.textToFindComboBox.CueText = null;
			this.textToFindComboBox.Location = new System.Drawing.Point(16, 35);
			this.textToFindComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.textToFindComboBox.Name = "textToFindComboBox";
			this.textToFindComboBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.textToFindComboBox.Properties.Appearance.Options.UseFont = true;
			this.textToFindComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.textToFindComboBox.Properties.NullValuePrompt = null;
			this.textToFindComboBox.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
			this.tablePanel1.SetRow(this.textToFindComboBox, 1);
			this.textToFindComboBox.Size = new System.Drawing.Size(472, 25);
			this.textToFindComboBox.TabIndex = 1;
			this.textToFindComboBox.EditValueChanged += new System.EventHandler(this.textToFindComboBox_TextUpdate);
			// 
			// label1
			// 
			this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label1.Appearance.Options.UseFont = true;
			this.tablePanel1.SetColumn(this.label1, 0);
			this.tablePanel1.SetColumnSpan(this.label1, 3);
			this.label1.Location = new System.Drawing.Point(16, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.label1.Name = "label1";
			this.tablePanel1.SetRow(this.label1, 0);
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Text to find:";
			// 
			// simpleButton2
			// 
			this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.simpleButton2.Appearance.Options.UseFont = true;
			this.tablePanel1.SetColumn(this.simpleButton2, 2);
			this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.simpleButton2.Location = new System.Drawing.Point(412, 70);
			this.simpleButton2.Margin = new System.Windows.Forms.Padding(0);
			this.simpleButton2.Name = "simpleButton2";
			this.tablePanel1.SetRow(this.simpleButton2, 2);
			this.simpleButton2.Size = new System.Drawing.Size(76, 28);
			this.simpleButton2.TabIndex = 3;
			this.simpleButton2.Text = "Cancel";
			this.simpleButton2.WantDrawFocusRectangle = true;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.tablePanel1.SetColumn(this.simpleButton1, 1);
			this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.simpleButton1.Location = new System.Drawing.Point(326, 70);
			this.simpleButton1.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.simpleButton1.Name = "simpleButton1";
			this.tablePanel1.SetRow(this.simpleButton1, 2);
			this.simpleButton1.Size = new System.Drawing.Size(76, 28);
			this.simpleButton1.TabIndex = 2;
			this.simpleButton1.Text = "OK";
			this.simpleButton1.WantDrawFocusRectangle = true;
			this.simpleButton1.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// whiteSpaceAwareCheckEdit
			// 
			this.whiteSpaceAwareCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tablePanel1.SetColumn(this.whiteSpaceAwareCheckEdit, 0);
			this.whiteSpaceAwareCheckEdit.Location = new System.Drawing.Point(16, 70);
			this.whiteSpaceAwareCheckEdit.Margin = new System.Windows.Forms.Padding(0);
			this.whiteSpaceAwareCheckEdit.Name = "whiteSpaceAwareCheckEdit";
			this.whiteSpaceAwareCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.whiteSpaceAwareCheckEdit.Properties.Appearance.Options.UseFont = true;
			this.whiteSpaceAwareCheckEdit.Properties.AutoWidth = true;
			this.whiteSpaceAwareCheckEdit.Properties.Caption = "White-space aware";
			this.tablePanel1.SetRow(this.whiteSpaceAwareCheckEdit, 2);
			this.whiteSpaceAwareCheckEdit.Size = new System.Drawing.Size(142, 27);
			this.whiteSpaceAwareCheckEdit.TabIndex = 4;
			// 
			// FindFormModern
			// 
			this.AcceptButton = this.simpleButton1;
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.simpleButton2;
			this.ClientSize = new System.Drawing.Size(504, 115);
			this.Controls.Add(this.tablePanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FindFormModern";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Find text";
			this.Load += new System.EventHandler(this.FindForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
			this.tablePanel1.ResumeLayout(false);
			this.tablePanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.textToFindComboBox.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.whiteSpaceAwareCheckEdit.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit whiteSpaceAwareCheckEdit;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton simpleButton1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton simpleButton2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private ExtendedControlsLibrary.Skinning.CustomComboBoxEdit.MyComboBoxEdit textToFindComboBox;
	}
}