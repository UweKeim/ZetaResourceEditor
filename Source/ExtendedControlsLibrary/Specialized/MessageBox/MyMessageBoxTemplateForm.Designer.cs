namespace ZetaResourceEditor.ExtendedControlsLibrary.Specialized.MessageBox
{
    partial class MyMessageBoxTemplateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessageBoxTemplateForm));
            this.formBottomPanel1 = new global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.button1 = new global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.button2 = new global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.button3 = new global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.panelControl1 = new global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.textControl = new global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.updateVisualCountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.closeCountDownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formBottomPanel1)).BeginInit();
            this.formBottomPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formBottomPanel1
            // 
            this.formBottomPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.formBottomPanel1.Controls.Add(this.button1);
            this.formBottomPanel1.Controls.Add(this.button2);
            this.formBottomPanel1.Controls.Add(this.button3);
            resources.ApplyResources(this.formBottomPanel1, "formBottomPanel1");
            this.formBottomPanel1.Name = "formBottomPanel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("button1.Appearance.Font")));
            this.button1.Appearance.Options.UseFont = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Name = "button1";
            this.button1.WantDrawFocusRectangle = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("button2.Appearance.Font")));
            this.button2.Appearance.Options.UseFont = true;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Name = "button2";
            this.button2.WantDrawFocusRectangle = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("button3.Appearance.Font")));
            this.button3.Appearance.Options.UseFont = true;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Name = "button3";
            this.button3.WantDrawFocusRectangle = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.iconPictureBox);
            this.panelControl1.Controls.Add(this.textControl);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // iconPictureBox
            // 
            resources.ApplyResources(this.iconPictureBox, "iconPictureBox");
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.TabStop = false;
            // 
            // textControl
            // 
            resources.ApplyResources(this.textControl, "textControl");
            this.textControl.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("textControl.Appearance.Font")));
            this.textControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.textControl.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.textControl.Name = "textControl";
            // 
            // updateVisualCountDownTimer
            // 
            this.updateVisualCountDownTimer.Interval = 200;
            this.updateVisualCountDownTimer.Tick += new System.EventHandler(this.updateVisualCountDownTimer_Tick);
            // 
            // closeCountDownTimer
            // 
            this.closeCountDownTimer.Tick += new System.EventHandler(this.closeCountDownTimer_Tick);
            // 
            // MyMessageBoxTemplateForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.formBottomPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyMessageBoxTemplateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyMessageBoxTemplateForm_FormClosing);
            this.Load += new System.EventHandler(this.MyMessageBoxTemplateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formBottomPanel1)).EndInit();
            this.formBottomPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl formBottomPanel1;
        private global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton button1;
        private global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton button2;
        private global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton button3;
        private global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private global::ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl textControl;
        private System.Windows.Forms.Timer updateVisualCountDownTimer;
        private System.Windows.Forms.Timer closeCountDownTimer;
    }
}