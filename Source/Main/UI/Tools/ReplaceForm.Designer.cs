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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceForm));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.whiteSpaceAwareCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.textToReplaceComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
			this.textToFindComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.label1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.whiteSpaceAwareCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textToReplaceComboBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textToFindComboBox.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.whiteSpaceAwareCheckEdit);
			this.panelControl1.Controls.Add(this.textToReplaceComboBox);
			this.panelControl1.Controls.Add(this.textToFindComboBox);
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.simpleButton2);
			this.panelControl1.Controls.Add(this.label1);
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Name = "panelControl1";
			// 
			// whiteSpaceAwareCheckEdit
			// 
			resources.ApplyResources(this.whiteSpaceAwareCheckEdit, "whiteSpaceAwareCheckEdit");
			this.whiteSpaceAwareCheckEdit.Name = "whiteSpaceAwareCheckEdit";
			this.whiteSpaceAwareCheckEdit.Properties.AutoWidth = true;
			this.whiteSpaceAwareCheckEdit.Properties.Caption = resources.GetString("whiteSpaceAwareCheckEdit.Properties.Caption");
			// 
			// textToReplaceComboBox
			// 
			resources.ApplyResources(this.textToReplaceComboBox, "textToReplaceComboBox");
			this.textToReplaceComboBox.Name = "textToReplaceComboBox";
			this.textToReplaceComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("textToReplaceComboBox.Properties.Buttons"))))});
			this.textToReplaceComboBox.EditValueChanged += new System.EventHandler(this.textToReplaceComboBox_TextUpdate);
			// 
			// textToFindComboBox
			// 
			resources.ApplyResources(this.textToFindComboBox, "textToFindComboBox");
			this.textToFindComboBox.Name = "textToFindComboBox";
			this.textToFindComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("textToFindComboBox.Properties.Buttons"))))});
			this.textToFindComboBox.EditValueChanged += new System.EventHandler(this.textToFindComboBox_TextUpdate);
			// 
			// simpleButton1
			// 
			resources.ApplyResources(this.simpleButton1, "simpleButton1");
			this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// labelControl1
			// 
			resources.ApplyResources(this.labelControl1, "labelControl1");
			this.labelControl1.Name = "labelControl1";
			// 
			// simpleButton2
			// 
			resources.ApplyResources(this.simpleButton2, "simpleButton2");
			this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.simpleButton2.Name = "simpleButton2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// ReplaceForm
			// 
			this.AcceptButton = this.simpleButton1;
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ReplaceForm.Appearance.Font")));
			this.Appearance.Options.UseFont = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.simpleButton2;
			this.Controls.Add(this.panelControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReplaceForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
			this.Load += new System.EventHandler(this.ReplaceForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.whiteSpaceAwareCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textToReplaceComboBox.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textToFindComboBox.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.ComboBoxEdit textToFindComboBox;
		private DevExpress.XtraEditors.LabelControl label1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.ComboBoxEdit textToReplaceComboBox;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.CheckEdit whiteSpaceAwareCheckEdit;
	}
}