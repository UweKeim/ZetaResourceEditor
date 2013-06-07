namespace ZetaResourceEditor.UI.Helper.Progress
{
	partial class BackgroundWorkerLongProgressForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundWorkerLongProgressForm));
			this.cancelGuardTimer = new System.Windows.Forms.Timer(this.components);
			this.CmdCancel = new DevExpress.XtraEditors.SimpleButton();
			this.backgroundWorker = new ZetaResourceEditor.UI.Helper.Progress.BackgroundWorkerLongProgress();
			this.ProgressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
			this.ProgressTextControl = new DevExpress.XtraEditors.LabelControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.ProgressBarControl.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cancelGuardTimer
			// 
			this.cancelGuardTimer.Interval = 5000;
			this.cancelGuardTimer.Tick += new System.EventHandler(this.cancelGuardTimer_Tick);
			// 
			// CmdCancel
			// 
			resources.ApplyResources(this.CmdCancel, "CmdCancel");
			this.CmdCancel.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("CmdCancel.Appearance.Font")));
			this.CmdCancel.Appearance.Options.UseFont = true;
			this.CmdCancel.Name = "CmdCancel";
			this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
			// 
			// ProgressBarControl
			// 
			resources.ApplyResources(this.ProgressBarControl, "ProgressBarControl");
			this.ProgressBarControl.Name = "ProgressBarControl";
			// 
			// ProgressTextControl
			// 
			resources.ApplyResources(this.ProgressTextControl, "ProgressTextControl");
			this.ProgressTextControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.ProgressTextControl.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.ProgressTextControl.Name = "ProgressTextControl";
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.ProgressTextControl);
			this.panelControl1.Controls.Add(this.CmdCancel);
			this.panelControl1.Controls.Add(this.ProgressBarControl);
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Name = "panelControl1";
			// 
			// BackgroundWorkerLongProgressForm
			// 
			this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BackgroundWorkerLongProgressForm.Appearance.Font")));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BackgroundWorkerLongProgressForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressForm_FormClosing);
			this.Load += new System.EventHandler(this.BackgroundWorkerLongProgressForm_Load);
			this.Shown += new System.EventHandler(this.BackgroundWorkerLongProgressForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.ProgressBarControl.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer cancelGuardTimer;
		private DevExpress.XtraEditors.SimpleButton CmdCancel;
		private BackgroundWorkerLongProgress backgroundWorker;
		private DevExpress.XtraEditors.MarqueeProgressBarControl ProgressBarControl;
		private DevExpress.XtraEditors.LabelControl ProgressTextControl;
		private DevExpress.XtraEditors.PanelControl panelControl1;
	}
}