namespace ZetaResourceEditor.UI.Helper.Progress
{
	partial class BackgroundWorkerLongProgressForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			components = new Container();
			cancelGuardTimer = new System.Windows.Forms.Timer(components);
			CmdCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			backgroundWorker = new BackgroundWorkerLongProgress();
			ProgressBarControl = new MarqueeProgressBarControl();
			ProgressTextControl = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)ProgressBarControl.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// cancelGuardTimer
			// 
			cancelGuardTimer.Interval = 5000;
			cancelGuardTimer.Tick += cancelGuardTimer_Tick;
			// 
			// CmdCancel
			// 
			CmdCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			CmdCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(CmdCancel, 1);
			CmdCancel.Dock = DockStyle.Fill;
			CmdCancel.Location = new Point(238, 67);
			CmdCancel.Margin = new Padding(0);
			CmdCancel.Name = "CmdCancel";
			tablePanel1.SetRow(CmdCancel, 1);
			CmdCancel.Size = new Size(75, 28);
			CmdCancel.TabIndex = 0;
			CmdCancel.Text = "Cancel";
			CmdCancel.Click += CmdCancel_Click;
			// 
			// backgroundWorker
			// 
			backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
			// 
			// ProgressBarControl
			// 
			ProgressBarControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(ProgressBarControl, 0);
			ProgressBarControl.EditValue = 0;
			ProgressBarControl.Location = new Point(11, 72);
			ProgressBarControl.Margin = new Padding(0, 0, 9, 0);
			ProgressBarControl.Name = "ProgressBarControl";
			tablePanel1.SetRow(ProgressBarControl, 1);
			ProgressBarControl.Size = new Size(218, 18);
			ProgressBarControl.TabIndex = 2;
			// 
			// ProgressTextControl
			// 
			ProgressTextControl.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			ProgressTextControl.Appearance.Options.UseFont = true;
			ProgressTextControl.Appearance.Options.UseTextOptions = true;
			ProgressTextControl.Appearance.TextOptions.VAlignment = VertAlignment.Top;
			ProgressTextControl.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
			ProgressTextControl.AutoSizeMode = LabelAutoSizeMode.None;
			tablePanel1.SetColumn(ProgressTextControl, 0);
			tablePanel1.SetColumnSpan(ProgressTextControl, 2);
			ProgressTextControl.Dock = DockStyle.Fill;
			ProgressTextControl.Location = new Point(11, 10);
			ProgressTextControl.Margin = new Padding(0, 0, 0, 18);
			ProgressTextControl.Name = "ProgressTextControl";
			tablePanel1.SetRow(ProgressTextControl, 0);
			ProgressTextControl.Size = new Size(302, 39);
			ProgressTextControl.TabIndex = 1;
			ProgressTextControl.Text = "The operation is being processed. Please wait...";
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(ProgressBarControl);
			tablePanel1.Controls.Add(CmdCancel);
			tablePanel1.Controls.Add(ProgressTextControl);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(324, 106);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// BackgroundWorkerLongProgressForm
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(324, 106);
			Controls.Add(tablePanel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "BackgroundWorkerLongProgressForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Please wait – Zeta Resource Editor";
			FormClosing += ProgressForm_FormClosing;
			Load += BackgroundWorkerLongProgressForm_Load;
			Shown += BackgroundWorkerLongProgressForm_Shown;
			((ISupportInitialize)ProgressBarControl.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Timer cancelGuardTimer;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton CmdCancel;
		private BackgroundWorkerLongProgress backgroundWorker;
		private MarqueeProgressBarControl ProgressBarControl;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl ProgressTextControl;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
	}
}