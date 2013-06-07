namespace ZetaResourceEditor.UI.TagOperations
{
	partial class RenameTagForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameTagForm));
			this.textBox1 = new DevExpress.XtraEditors.TextEdit();
			this.label1 = new DevExpress.XtraEditors.LabelControl();
			this.button1 = new DevExpress.XtraEditors.SimpleButton();
			this.button2 = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.Name = "textBox1";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Name = "button1";
			// 
			// button2
			// 
			resources.ApplyResources(this.button2, "button2");
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Name = "button2";
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.textBox1);
			this.panelControl1.Controls.Add(this.button2);
			this.panelControl1.Controls.Add(this.button1);
			this.panelControl1.Controls.Add(this.label1);
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Name = "panelControl1";
			// 
			// RenameTagForm
			// 
			this.AcceptButton = this.button1;
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("RenameTagForm.Appearance.Font")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.button2;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panelControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RenameTagForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RenameTagForm_FormClosing);
			this.Load += new System.EventHandler(this.TagChange_Load);
			((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit textBox1;
		private DevExpress.XtraEditors.LabelControl label1;
		private DevExpress.XtraEditors.SimpleButton button1;
		private DevExpress.XtraEditors.SimpleButton button2;
		private DevExpress.XtraEditors.PanelControl panelControl1;
	}
}