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
            this.components = new System.ComponentModel.Container();
            this.cancelGuardTimer = new System.Windows.Forms.Timer(this.components);
            this.CmdCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.backgroundWorker = new ZetaResourceEditor.UI.Helper.Progress.BackgroundWorkerLongProgress();
            this.ProgressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.ProgressTextControl = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
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
            this.CmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CmdCancel.Appearance.Options.UseFont = true;
            this.CmdCancel.Location = new System.Drawing.Point(237, 66);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 28);
            this.CmdCancel.TabIndex = 0;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.WantDrawFocusRectangle = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            //
            // backgroundWorker
            //
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            //
            // ProgressBarControl
            //
            this.ProgressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarControl.EditValue = 0;
            this.ProgressBarControl.Location = new System.Drawing.Point(12, 71);
            this.ProgressBarControl.Name = "ProgressBarControl";
            this.ProgressBarControl.Size = new System.Drawing.Size(219, 18);
            this.ProgressBarControl.TabIndex = 2;
            //
            // ProgressTextControl
            //
            this.ProgressTextControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressTextControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProgressTextControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ProgressTextControl.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ProgressTextControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ProgressTextControl.Location = new System.Drawing.Point(12, 12);
            this.ProgressTextControl.Name = "ProgressTextControl";
            this.ProgressTextControl.Size = new System.Drawing.Size(300, 48);
            this.ProgressTextControl.TabIndex = 0;
            this.ProgressTextControl.Text = "The operation is being processed. Please wait...";
            //
            // panelControl1
            //
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.ProgressTextControl);
            this.panelControl1.Controls.Add(this.CmdCancel);
            this.panelControl1.Controls.Add(this.ProgressBarControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(9);
            this.panelControl1.Size = new System.Drawing.Size(324, 106);
            this.panelControl1.TabIndex = 3;
            //
            // BackgroundWorkerLongProgressForm
            //
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(324, 106);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackgroundWorkerLongProgressForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please wait – Zeta Resource Editor";
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
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton CmdCancel;
        private BackgroundWorkerLongProgress backgroundWorker;
        private DevExpress.XtraEditors.MarqueeProgressBarControl ProgressBarControl;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl ProgressTextControl;
        private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
    }
}