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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextBoxForm));
			this.wordWrapCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.textMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
			this.buttonCopyTextToClipboard = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.wordWrapCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textMemoEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// wordWrapCheckEdit
			// 
			resources.ApplyResources(this.wordWrapCheckEdit, "wordWrapCheckEdit");
			this.wordWrapCheckEdit.Name = "wordWrapCheckEdit";
			this.wordWrapCheckEdit.Properties.AccessibleDescription = resources.GetString("wordWrapCheckEdit.Properties.AccessibleDescription");
			this.wordWrapCheckEdit.Properties.AccessibleName = resources.GetString("wordWrapCheckEdit.Properties.AccessibleName");
			this.wordWrapCheckEdit.Properties.AutoHeight = ((bool)(resources.GetObject("wordWrapCheckEdit.Properties.AutoHeight")));
			this.wordWrapCheckEdit.Properties.AutoWidth = true;
			this.wordWrapCheckEdit.Properties.Caption = resources.GetString("wordWrapCheckEdit.Properties.Caption");
			this.wordWrapCheckEdit.Properties.DisplayValueChecked = resources.GetString("wordWrapCheckEdit.Properties.DisplayValueChecked");
			this.wordWrapCheckEdit.Properties.DisplayValueGrayed = resources.GetString("wordWrapCheckEdit.Properties.DisplayValueGrayed");
			this.wordWrapCheckEdit.Properties.DisplayValueUnchecked = resources.GetString("wordWrapCheckEdit.Properties.DisplayValueUnchecked");
			this.wordWrapCheckEdit.CheckedChanged += new System.EventHandler(this.wordWrapCheckEdit_CheckedChanged);
			// 
			// textMemoEdit
			// 
			resources.ApplyResources(this.textMemoEdit, "textMemoEdit");
			this.textMemoEdit.Name = "textMemoEdit";
			this.textMemoEdit.Properties.AccessibleDescription = resources.GetString("textMemoEdit.Properties.AccessibleDescription");
			this.textMemoEdit.Properties.AccessibleName = resources.GetString("textMemoEdit.Properties.AccessibleName");
			this.textMemoEdit.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("textMemoEdit.Properties.Appearance.BackColor")));
			this.textMemoEdit.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("textMemoEdit.Properties.Appearance.Font")));
			this.textMemoEdit.Properties.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("textMemoEdit.Properties.Appearance.GradientMode")));
			this.textMemoEdit.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("textMemoEdit.Properties.Appearance.Image")));
			this.textMemoEdit.Properties.Appearance.Options.UseBackColor = true;
			this.textMemoEdit.Properties.Appearance.Options.UseFont = true;
			this.textMemoEdit.Properties.NullValuePrompt = resources.GetString("textMemoEdit.Properties.NullValuePrompt");
			this.textMemoEdit.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("textMemoEdit.Properties.NullValuePromptShowForEmptyValue")));
			this.textMemoEdit.Properties.ReadOnly = true;
			this.textMemoEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMemoEdit_KeyDown);
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Name = "buttonCancel";
			// 
			// buttonCopyTextToClipboard
			// 
			resources.ApplyResources(this.buttonCopyTextToClipboard, "buttonCopyTextToClipboard");
			this.buttonCopyTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyTextToClipboard.Image")));
			this.buttonCopyTextToClipboard.Name = "buttonCopyTextToClipboard";
			this.buttonCopyTextToClipboard.Click += new System.EventHandler(this.buttonCopyTextToClipboard_Click);
			// 
			// panelControl1
			// 
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
			this.panelControl1.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("panelControl1.Appearance.GradientMode")));
			this.panelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("panelControl1.Appearance.Image")));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.wordWrapCheckEdit);
			this.panelControl1.Controls.Add(this.textMemoEdit);
			this.panelControl1.Controls.Add(this.buttonCopyTextToClipboard);
			this.panelControl1.Controls.Add(this.buttonCancel);
			this.panelControl1.Name = "panelControl1";
			// 
			// TextBoxForm
			// 
			resources.ApplyResources(this, "$this");
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TextBoxForm.Appearance.Font")));
			this.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("TextBoxForm.Appearance.GradientMode")));
			this.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("TextBoxForm.Appearance.Image")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.panelControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TextBoxForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.textBoxForm_FormClosing);
			this.Load += new System.EventHandler(this.textBoxForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.wordWrapCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textMemoEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.MemoEdit textMemoEdit;
		private DevExpress.XtraEditors.SimpleButton buttonCancel;
		private DevExpress.XtraEditors.SimpleButton buttonCopyTextToClipboard;
		private DevExpress.XtraEditors.CheckEdit wordWrapCheckEdit;
		private DevExpress.XtraEditors.PanelControl panelControl1;
	}
}