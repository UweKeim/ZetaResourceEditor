namespace ZetaResourceEditor.UI.Main
{
	partial class OptionsForm
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
            this.proxyButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.xtraTabControl1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl();
            this.xtraTabPage1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
            this.xtraTabPage3 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelControl4 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelControl5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl6 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl7 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl8 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl10 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.labelControl9 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // proxyButton
            // 
            this.proxyButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.proxyButton.Appearance.Options.UseFont = true;
            this.proxyButton.Location = new System.Drawing.Point(12, 12);
            this.proxyButton.Name = "proxyButton";
            this.proxyButton.Size = new System.Drawing.Size(193, 28);
            this.proxyButton.TabIndex = 1;
            this.proxyButton.Text = "Configure HTTP proxy server";
            this.proxyButton.WantDrawFocusRectangle = true;
            this.proxyButton.Click += new System.EventHandler(this.proxyButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(407, 417);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.WantDrawFocusRectangle = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(326, 417);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 28);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.WantDrawFocusRectangle = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Controls.Add(this.buttonCancel);
            this.panelControl1.Controls.Add(this.buttonOK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(3);
            this.panelControl1.Size = new System.Drawing.Size(488, 451);
            this.panelControl1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(6, 6);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(476, 407);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.proxyButton);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Padding = new System.Windows.Forms.Padding(9);
            this.xtraTabPage1.Size = new System.Drawing.Size(474, 374);
            this.xtraTabPage1.Text = "Options";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.panel8);
            this.xtraTabPage3.Controls.Add(this.panel6);
            this.xtraTabPage3.Controls.Add(this.panel3);
            this.xtraTabPage3.Controls.Add(this.labelControl3);
            this.xtraTabPage3.Controls.Add(this.panel7);
            this.xtraTabPage3.Controls.Add(this.labelControl4);
            this.xtraTabPage3.Controls.Add(this.panel5);
            this.xtraTabPage3.Controls.Add(this.labelControl5);
            this.xtraTabPage3.Controls.Add(this.panel2);
            this.xtraTabPage3.Controls.Add(this.labelControl6);
            this.xtraTabPage3.Controls.Add(this.panel4);
            this.xtraTabPage3.Controls.Add(this.labelControl7);
            this.xtraTabPage3.Controls.Add(this.panel1);
            this.xtraTabPage3.Controls.Add(this.labelControl8);
            this.xtraTabPage3.Controls.Add(this.labelControl10);
            this.xtraTabPage3.Controls.Add(this.labelControl9);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Padding = new System.Windows.Forms.Padding(9);
            this.xtraTabPage3.Size = new System.Drawing.Size(474, 374);
            this.xtraTabPage3.Text = "Data grid view color information";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(12, 173);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(16, 16);
            this.panel8.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(12, 127);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 16);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(12, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 16);
            this.panel3.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(188, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Foreground color for comments";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(12, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(16, 16);
            this.panel7.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(34, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(257, 17);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Foreground color for completely empty row";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(12, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 16);
            this.panel5.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(34, 57);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(153, 17);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Foreground color for tags";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 16);
            this.panel2.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(34, 80);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(188, 17);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Background color for NULL cells";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 16);
            this.panel4.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(34, 103);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(193, 17);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Background color for empty cells";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 16);
            this.panel1.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(34, 126);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(296, 17);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Foreground color for {0}..{n} placeholder mismatch";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(34, 172);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(304, 17);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Foreground color for translation success (plus bold)";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(34, 149);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(296, 17);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Foreground color for translation errors (plus bold)";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(488, 451);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(490, 489);
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl xtraTabControl1;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage xtraTabPage1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton proxyButton;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage xtraTabPage3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl3;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl8;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl7;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl6;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl5;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl4;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl10;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl9;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
	}
}