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
            this.textMemoEdit = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
            this.buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textMemoEdit
            // 
            resources.ApplyResources(this.textMemoEdit, "textMemoEdit");
            this.textMemoEdit.Name = "textMemoEdit";
            this.textMemoEdit.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("textMemoEdit.Properties.Appearance.BackColor")));
            this.textMemoEdit.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("textMemoEdit.Properties.Appearance.Font")));
            this.textMemoEdit.Properties.Appearance.Options.UseBackColor = true;
            this.textMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.textMemoEdit.Properties.NullValuePrompt = resources.GetString("textMemoEdit.Properties.NullValuePrompt");
            this.textMemoEdit.Properties.ReadOnly = true;
            this.textMemoEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMemoEdit_KeyDown);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("buttonCancel.Appearance.Font")));
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.WantDrawFocusRectangle = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.textMemoEdit);
            this.panelControl1.Controls.Add(this.buttonCancel);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // TextBoxForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextBoxForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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