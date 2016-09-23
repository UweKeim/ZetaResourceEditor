namespace Test
{
    using ExtendedControlsLibrary.Skinning.CustomPropertyGrid;

    partial class Form1
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
            this.noHeaderWizardControl1 = new ExtendedControlsLibrary.Skinning.CustomWizard.NoHeaderWizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.wizardPage3 = new DevExpress.XtraWizard.WizardPage();
            this.wizardPage4 = new DevExpress.XtraWizard.WizardPage();
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.noHeaderWizardControl1)).BeginInit();
            this.noHeaderWizardControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noHeaderWizardControl1
            // 
            this.noHeaderWizardControl1.AllowTransitionAnimation = false;
            this.noHeaderWizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.noHeaderWizardControl1.Controls.Add(this.wizardPage1);
            this.noHeaderWizardControl1.Controls.Add(this.completionWizardPage1);
            this.noHeaderWizardControl1.Controls.Add(this.wizardPage2);
            this.noHeaderWizardControl1.Controls.Add(this.wizardPage3);
            this.noHeaderWizardControl1.Controls.Add(this.wizardPage4);
            this.noHeaderWizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noHeaderWizardControl1.Location = new System.Drawing.Point(0, 0);
            this.noHeaderWizardControl1.Name = "noHeaderWizardControl1";
            this.noHeaderWizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2,
            this.wizardPage3,
            this.wizardPage4,
            this.completionWizardPage1});
            this.noHeaderWizardControl1.Size = new System.Drawing.Size(457, 568);
            this.noHeaderWizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.noHeaderWizardControl1.CustomizeCommandButtons += new DevExpress.XtraWizard.WizardCustomizeCommandButtonsEventHandler(this.noHeaderWizardControl1_CustomizeCommandButtons);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(413, 444);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(413, 444);
            this.wizardPage1.Text = "Page 1";
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(413, 444);
            // 
            // wizardPage2
            // 
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(413, 444);
            this.wizardPage2.Text = "Page 2";
            // 
            // wizardPage3
            // 
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(413, 444);
            this.wizardPage3.Text = "Page 3";
            // 
            // wizardPage4
            // 
            this.wizardPage4.Name = "wizardPage4";
            this.wizardPage4.Size = new System.Drawing.Size(413, 444);
            this.wizardPage4.Text = "Page 4";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.noHeaderWizardControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(457, 568);
            this.panelControl1.TabIndex = 6;
            // 
            // Form1
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 568);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noHeaderWizardControl1)).EndInit();
            this.noHeaderWizardControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControlsLibrary.Skinning.CustomWizard.NoHeaderWizardControl noHeaderWizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private DevExpress.XtraWizard.WizardPage wizardPage3;
        private DevExpress.XtraWizard.WizardPage wizardPage4;
        private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;

    }
}

