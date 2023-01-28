namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
	partial class TextBoxForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textMemoEdit = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			this.buttonCancel = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			this.panelControl1 = new ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
			((System.ComponentModel.ISupportInitialize)(this.textMemoEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textMemoEdit
			// 
			this.textMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textMemoEdit.CueText = null;
			this.textMemoEdit.Location = new System.Drawing.Point(12, 12);
			this.textMemoEdit.Name = "textMemoEdit";
			this.textMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.textMemoEdit.Properties.Appearance.Options.UseBackColor = true;
			this.textMemoEdit.Properties.Appearance.Options.UseFont = true;
			this.textMemoEdit.Properties.NullValuePrompt = null;
			this.textMemoEdit.Properties.ReadOnly = true;
			this.textMemoEdit.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
			this.textMemoEdit.Size = new System.Drawing.Size(460, 453);
			this.textMemoEdit.TabIndex = 0;
			this.textMemoEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMemoEdit_KeyDown);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.buttonCancel.Appearance.Options.UseFont = true;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(397, 476);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 28);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.Text = "Close";
			this.buttonCancel.WantDrawFocusRectangle = true;
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.textMemoEdit);
			this.panelControl1.Controls.Add(this.buttonCancel);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
			this.panelControl1.Size = new System.Drawing.Size(484, 516);
			this.panelControl1.TabIndex = 3;
			// 
			// TextBoxForm
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(484, 516);
			this.Controls.Add(this.panelControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.IconOptions.ShowIcon = false;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(486, 552);
			this.Name = "TextBoxForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Text";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.textBoxForm_FormClosing);
			this.Load += new System.EventHandler(this.textBoxForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.textMemoEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit textMemoEdit;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
	}
}