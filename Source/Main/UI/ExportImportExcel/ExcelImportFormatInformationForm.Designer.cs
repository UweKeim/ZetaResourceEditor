namespace ZetaResourceEditor.UI.ExportImportExcel
{
	partial class ExcelImportFormatInformationForm
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(ExcelImportFormatInformationForm));
			panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			labelControl7 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			((ISupportInitialize)panelControl1).BeginInit();
			panelControl1.SuspendLayout();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelControl1
			// 
			panelControl1.Appearance.BackColor = Color.Transparent;
			panelControl1.Appearance.Options.UseBackColor = true;
			panelControl1.BorderStyle = BorderStyles.NoBorder;
			panelControl1.Controls.Add(tablePanel1);
			panelControl1.Dock = DockStyle.Fill;
			panelControl1.Location = new Point(0, 0);
			panelControl1.Margin = new Padding(0);
			panelControl1.Name = "panelControl1";
			panelControl1.Size = new Size(485, 503);
			panelControl1.TabIndex = 0;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(labelControl7);
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(485, 503);
			tablePanel1.TabIndex = 15;
			tablePanel1.UseSkinIndents = true;
			// 
			// labelControl7
			// 
			labelControl7.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl7.Appearance.Options.UseFont = true;
			labelControl7.Appearance.Options.UseTextOptions = true;
			labelControl7.Appearance.TextOptions.VAlignment = VertAlignment.Top;
			labelControl7.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
			labelControl7.AutoSizeMode = LabelAutoSizeMode.None;
			tablePanel1.SetColumn(labelControl7, 0);
			tablePanel1.SetColumnSpan(labelControl7, 2);
			labelControl7.Dock = DockStyle.Fill;
			labelControl7.Location = new Point(11, 10);
			labelControl7.Margin = new Padding(0, 0, 0, 18);
			labelControl7.Name = "labelControl7";
			tablePanel1.SetRow(labelControl7, 0);
			labelControl7.Size = new Size(463, 436);
			labelControl7.TabIndex = 14;
			labelControl7.Text = resources.GetString("labelControl7.Text");
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 1);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(399, 464);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 1);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 3;
			buttonCancel.Text = "Close";
			// 
			// ExcelImportFormatInformationForm
			// 
			AcceptButton = buttonCancel;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(485, 503);
			Controls.Add(panelControl1);
			Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ExcelImportFormatInformationForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Microsoft Office Excel import format";
			FormClosing += ImportFormatInformationForm_FormClosing;
			Load += ImportFormatInformationForm_Load;
			((ISupportInitialize)panelControl1).EndInit();
			panelControl1.ResumeLayout(false);
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl7;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
	}
}