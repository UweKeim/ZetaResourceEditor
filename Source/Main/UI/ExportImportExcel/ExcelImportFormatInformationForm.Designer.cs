namespace ZetaResourceEditor.UI.ExportImportExcel
{
	partial class ExcelImportFormatInformationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelImportFormatInformationForm));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
			this.panelControl1.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("panelControl1.Appearance.GradientMode")));
			this.panelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("panelControl1.Appearance.Image")));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.labelControl7);
			this.panelControl1.Controls.Add(this.buttonCancel);
			this.panelControl1.Name = "panelControl1";
			// 
			// labelControl7
			// 
			resources.ApplyResources(this.labelControl7, "labelControl7");
			this.labelControl7.Appearance.DisabledImage = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.DisabledImage")));
			this.labelControl7.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("labelControl7.Appearance.GradientMode")));
			this.labelControl7.Appearance.HoverImage = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.HoverImage")));
			this.labelControl7.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.Image")));
			this.labelControl7.Appearance.PressedImage = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.PressedImage")));
			this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl7.Name = "labelControl7";
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Name = "buttonCancel";
			// 
			// ExcelImportFormatInformationForm
			// 
			this.AcceptButton = this.buttonCancel;
			resources.ApplyResources(this, "$this");
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ExcelImportFormatInformationForm.Appearance.Font")));
			this.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("ExcelImportFormatInformationForm.Appearance.GradientMode")));
			this.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("ExcelImportFormatInformationForm.Appearance.Image")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.buttonCancel;
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExcelImportFormatInformationForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportFormatInformationForm_FormClosing);
			this.Load += new System.EventHandler(this.ImportFormatInformationForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton buttonCancel;
		private DevExpress.XtraEditors.LabelControl labelControl7;
	}
}