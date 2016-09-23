namespace ZetaResourceEditor.UI.Main
{
    partial class WebProxySettingsForm
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
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.panelControl2 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.ProxyPasswordTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.label5 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.ProxyDomainNameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.label3 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.ProxyUserNameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.ProxyAddressTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
            this.label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.useCustomProxyRadioButton = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.useNoProxyRadioButton = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.useIEProxyRadioButton = new ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit();
            this.CmdCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.CmdOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyPasswordTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyDomainNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyUserNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyAddressTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useCustomProxyRadioButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useNoProxyRadioButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useIEProxyRadioButton.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.useCustomProxyRadioButton);
            this.panelControl1.Controls.Add(this.useNoProxyRadioButton);
            this.panelControl1.Controls.Add(this.useIEProxyRadioButton);
            this.panelControl1.Controls.Add(this.CmdCancel);
            this.panelControl1.Controls.Add(this.CmdOK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.panelControl1.Size = new System.Drawing.Size(502, 311);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.ProxyPasswordTextBox);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.ProxyDomainNameTextBox);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.ProxyUserNameTextBox);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.ProxyAddressTextBox);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Location = new System.Drawing.Point(34, 100);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.panelControl2.Size = new System.Drawing.Size(455, 153);
            this.panelControl2.TabIndex = 3;
            // 
            // ProxyPasswordTextBox
            // 
            this.ProxyPasswordTextBox.Bold = false;
            this.ProxyPasswordTextBox.CueText = null;
            this.ProxyPasswordTextBox.Location = new System.Drawing.Point(148, 114);
            this.ProxyPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProxyPasswordTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.ProxyPasswordTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.ProxyPasswordTextBox.Name = "ProxyPasswordTextBox";
            this.ProxyPasswordTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProxyPasswordTextBox.Properties.Appearance.Options.UseFont = true;
            this.ProxyPasswordTextBox.Properties.Mask.EditMask = null;
            this.ProxyPasswordTextBox.Properties.NullValuePrompt = null;
            this.ProxyPasswordTextBox.Properties.PasswordChar = '●';
            this.ProxyPasswordTextBox.Size = new System.Drawing.Size(213, 24);
            this.ProxyPasswordTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Proxy server &address:";
            // 
            // ProxyDomainNameTextBox
            // 
            this.ProxyDomainNameTextBox.Bold = false;
            this.ProxyDomainNameTextBox.CueText = null;
            this.ProxyDomainNameTextBox.Location = new System.Drawing.Point(148, 82);
            this.ProxyDomainNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProxyDomainNameTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.ProxyDomainNameTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.ProxyDomainNameTextBox.Name = "ProxyDomainNameTextBox";
            this.ProxyDomainNameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProxyDomainNameTextBox.Properties.Appearance.Options.UseFont = true;
            this.ProxyDomainNameTextBox.Properties.Mask.EditMask = null;
            this.ProxyDomainNameTextBox.Properties.NullValuePrompt = null;
            this.ProxyDomainNameTextBox.Size = new System.Drawing.Size(213, 24);
            this.ProxyDomainNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User &name:";
            // 
            // ProxyUserNameTextBox
            // 
            this.ProxyUserNameTextBox.Bold = false;
            this.ProxyUserNameTextBox.CueText = null;
            this.ProxyUserNameTextBox.Location = new System.Drawing.Point(148, 50);
            this.ProxyUserNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProxyUserNameTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.ProxyUserNameTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.ProxyUserNameTextBox.Name = "ProxyUserNameTextBox";
            this.ProxyUserNameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProxyUserNameTextBox.Properties.Appearance.Options.UseFont = true;
            this.ProxyUserNameTextBox.Properties.Mask.EditMask = null;
            this.ProxyUserNameTextBox.Properties.NullValuePrompt = null;
            this.ProxyUserNameTextBox.Size = new System.Drawing.Size(213, 24);
            this.ProxyUserNameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "&Domain name:";
            // 
            // ProxyAddressTextBox
            // 
            this.ProxyAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyAddressTextBox.Bold = false;
            this.ProxyAddressTextBox.CueText = null;
            this.ProxyAddressTextBox.Location = new System.Drawing.Point(148, 18);
            this.ProxyAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProxyAddressTextBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.ProxyAddressTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.ProxyAddressTextBox.Name = "ProxyAddressTextBox";
            this.ProxyAddressTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProxyAddressTextBox.Properties.Appearance.Options.UseFont = true;
            this.ProxyAddressTextBox.Properties.Mask.EditMask = null;
            this.ProxyAddressTextBox.Properties.NullValuePrompt = null;
            this.ProxyAddressTextBox.Size = new System.Drawing.Size(291, 24);
            this.ProxyAddressTextBox.TabIndex = 1;
            this.ProxyAddressTextBox.EditValueChanged += new System.EventHandler(this.ProxyAddressTextBox_EditValueChanged);
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Password:";
            // 
            // useCustomProxyRadioButton
            // 
            this.useCustomProxyRadioButton.Location = new System.Drawing.Point(14, 74);
            this.useCustomProxyRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.useCustomProxyRadioButton.Name = "useCustomProxyRadioButton";
            this.useCustomProxyRadioButton.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.useCustomProxyRadioButton.Properties.Appearance.Options.UseFont = true;
            this.useCustomProxyRadioButton.Properties.AutoWidth = true;
            this.useCustomProxyRadioButton.Properties.Caption = "Use the following &custom HTTP proxy server:";
            this.useCustomProxyRadioButton.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.useCustomProxyRadioButton.Properties.RadioGroupIndex = 1;
            this.useCustomProxyRadioButton.Size = new System.Drawing.Size(283, 21);
            this.useCustomProxyRadioButton.TabIndex = 2;
            this.useCustomProxyRadioButton.TabStop = false;
            this.useCustomProxyRadioButton.CheckedChanged += new System.EventHandler(this.useCustomProxyRadioButton_CheckedChanged);
            // 
            // useNoProxyRadioButton
            // 
            this.useNoProxyRadioButton.Location = new System.Drawing.Point(14, 45);
            this.useNoProxyRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.useNoProxyRadioButton.Name = "useNoProxyRadioButton";
            this.useNoProxyRadioButton.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.useNoProxyRadioButton.Properties.Appearance.Options.UseFont = true;
            this.useNoProxyRadioButton.Properties.AutoWidth = true;
            this.useNoProxyRadioButton.Properties.Caption = "Use &no HTTP proxy server";
            this.useNoProxyRadioButton.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.useNoProxyRadioButton.Properties.RadioGroupIndex = 1;
            this.useNoProxyRadioButton.Size = new System.Drawing.Size(174, 21);
            this.useNoProxyRadioButton.TabIndex = 1;
            this.useNoProxyRadioButton.TabStop = false;
            this.useNoProxyRadioButton.CheckedChanged += new System.EventHandler(this.useNoProxyRadioButton_CheckedChanged);
            // 
            // useIEProxyRadioButton
            // 
            this.useIEProxyRadioButton.Location = new System.Drawing.Point(14, 16);
            this.useIEProxyRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.useIEProxyRadioButton.Name = "useIEProxyRadioButton";
            this.useIEProxyRadioButton.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.useIEProxyRadioButton.Properties.Appearance.Options.UseFont = true;
            this.useIEProxyRadioButton.Properties.AutoWidth = true;
            this.useIEProxyRadioButton.Properties.Caption = "Use the same HTTP proxy as configured in &Internet Explorer";
            this.useIEProxyRadioButton.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.useIEProxyRadioButton.Properties.RadioGroupIndex = 1;
            this.useIEProxyRadioButton.Size = new System.Drawing.Size(371, 21);
            this.useIEProxyRadioButton.TabIndex = 0;
            this.useIEProxyRadioButton.TabStop = false;
            this.useIEProxyRadioButton.CheckedChanged += new System.EventHandler(this.useIEProxyRadioButton_CheckedChanged);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CmdCancel.Appearance.Options.UseFont = true;
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Location = new System.Drawing.Point(415, 270);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 28);
            this.CmdCancel.TabIndex = 5;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.WantDrawFocusRectangle = true;
            // 
            // CmdOK
            // 
            this.CmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CmdOK.Appearance.Options.UseFont = true;
            this.CmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmdOK.Location = new System.Drawing.Point(334, 270);
            this.CmdOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(75, 28);
            this.CmdOK.TabIndex = 4;
            this.CmdOK.Text = "OK";
            this.CmdOK.WantDrawFocusRectangle = true;
            // 
            // WebProxySettingsForm
            // 
            this.AcceptButton = this.CmdOK;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.CmdCancel;
            this.ClientSize = new System.Drawing.Size(502, 311);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebProxySettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure proxy server";
            this.Load += new System.EventHandler(this.WebProxySettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyPasswordTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyDomainNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyUserNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyAddressTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useCustomProxyRadioButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useNoProxyRadioButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useIEProxyRadioButton.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton CmdOK;
        private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton CmdCancel;
        private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useIEProxyRadioButton;
        private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useCustomProxyRadioButton;
		private ExtendedControlsLibrary.Skinning.CustomCheckEdit.MyCheckEdit useNoProxyRadioButton;
        private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit ProxyPasswordTextBox;
        private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit ProxyDomainNameTextBox;
        private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit ProxyUserNameTextBox;
        private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit ProxyAddressTextBox;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label3;
        private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label5;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl2;
    }
}