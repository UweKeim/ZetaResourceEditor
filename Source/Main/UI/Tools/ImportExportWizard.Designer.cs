namespace ZetaResourceEditor.UI.Tools
{
    partial class ImportExportWizard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ImportExportWizard ) );
			this.wizard = new DevComponents.DotNetBar.Wizard();
			this.wizardPage1 = new DevComponents.DotNetBar.WizardPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.listBoxActions = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.wizardPage2 = new DevComponents.DotNetBar.WizardPage();
			this.buttonCheckNone = new System.Windows.Forms.Button();
			this.buttonCheckAll = new System.Windows.Forms.Button();
			this.listViewFileGroups = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.imageList = new System.Windows.Forms.ImageList( this.components );
			this.label2 = new System.Windows.Forms.Label();
			this.wizardPage3 = new DevComponents.DotNetBar.WizardPage();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonBrowseFile = new System.Windows.Forms.Button();
			this.textBoxSourceDestination = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.wizard.SuspendLayout();
			this.wizardPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.wizardPage2.SuspendLayout();
			this.wizardPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// wizard
			// 
			this.wizard.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources( this.wizard, "wizard" );
			this.wizard.FinishButtonTabIndex = 3;
			// 
			// 
			// 
			this.wizard.FooterStyle.BackColor = System.Drawing.SystemColors.Control;
			this.wizard.FooterStyle.BackColorGradientAngle = 90;
			this.wizard.FooterStyle.BorderBottomWidth = 1;
			this.wizard.FooterStyle.BorderColor = System.Drawing.SystemColors.Control;
			this.wizard.FooterStyle.BorderLeftWidth = 1;
			this.wizard.FooterStyle.BorderRightWidth = 1;
			this.wizard.FooterStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
			this.wizard.FooterStyle.BorderTopColor = System.Drawing.SystemColors.Control;
			this.wizard.FooterStyle.BorderTopWidth = 1;
			this.wizard.FooterStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.wizard.FooterStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.wizard.HeaderImageSize = new System.Drawing.Size( 48, 48 );
			// 
			// 
			// 
			this.wizard.HeaderStyle.BackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))) );
			this.wizard.HeaderStyle.BackColorGradientAngle = 90;
			this.wizard.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
			this.wizard.HeaderStyle.BorderBottomWidth = 1;
			this.wizard.HeaderStyle.BorderColor = System.Drawing.SystemColors.Control;
			this.wizard.HeaderStyle.BorderLeftWidth = 1;
			this.wizard.HeaderStyle.BorderRightWidth = 1;
			this.wizard.HeaderStyle.BorderTopWidth = 1;
			this.wizard.HeaderStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.wizard.HeaderStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.wizard.HelpButtonVisible = false;
			this.wizard.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.wizard.Name = "wizard";
			this.wizard.WizardPages.AddRange( new DevComponents.DotNetBar.WizardPage[] {
            this.wizardPage1,
            this.wizardPage2,
            this.wizardPage3} );
			this.wizard.CancelButtonClick += new System.ComponentModel.CancelEventHandler( this.wizard_CancelButtonClick );
			this.wizard.FinishButtonClick += new System.ComponentModel.CancelEventHandler( this.wizard_FinishButtonClick );
			// 
			// wizardPage1
			// 
			resources.ApplyResources( this.wizardPage1, "wizardPage1" );
			this.wizardPage1.AntiAlias = false;
			this.wizardPage1.Controls.Add( this.groupBox1 );
			this.wizardPage1.Controls.Add( this.listBoxActions );
			this.wizardPage1.Controls.Add( this.label1 );
			this.wizardPage1.Name = "wizardPage1";
			this.wizardPage1.PageHeaderImage = ((System.Drawing.Image)(resources.GetObject( "wizardPage1.PageHeaderImage" )));
			// 
			// groupBox1
			// 
			resources.ApplyResources( this.groupBox1, "groupBox1" );
			this.groupBox1.Controls.Add( this.labelDescription );
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// labelDescription
			// 
			resources.ApplyResources( this.labelDescription, "labelDescription" );
			this.labelDescription.Name = "labelDescription";
			// 
			// listBoxActions
			// 
			resources.ApplyResources( this.listBoxActions, "listBoxActions" );
			this.listBoxActions.FormattingEnabled = true;
			this.listBoxActions.Items.AddRange( new object[] {
            resources.GetString("listBoxActions.Items")} );
			this.listBoxActions.Name = "listBoxActions";
			this.listBoxActions.SelectedIndexChanged += new System.EventHandler( this.listBoxActions_SelectedIndexChanged );
			// 
			// label1
			// 
			resources.ApplyResources( this.label1, "label1" );
			this.label1.Name = "label1";
			// 
			// wizardPage2
			// 
			resources.ApplyResources( this.wizardPage2, "wizardPage2" );
			this.wizardPage2.AntiAlias = false;
			this.wizardPage2.Controls.Add( this.buttonCheckNone );
			this.wizardPage2.Controls.Add( this.buttonCheckAll );
			this.wizardPage2.Controls.Add( this.listViewFileGroups );
			this.wizardPage2.Controls.Add( this.label2 );
			this.wizardPage2.Name = "wizardPage2";
			this.wizardPage2.PageHeaderImage = ((System.Drawing.Image)(resources.GetObject( "wizardPage2.PageHeaderImage" )));
			// 
			// buttonCheckNone
			// 
			resources.ApplyResources( this.buttonCheckNone, "buttonCheckNone" );
			this.buttonCheckNone.Name = "buttonCheckNone";
			this.buttonCheckNone.UseVisualStyleBackColor = true;
			this.buttonCheckNone.Click += new System.EventHandler( this.buttonCheckNone_Click );
			// 
			// buttonCheckAll
			// 
			resources.ApplyResources( this.buttonCheckAll, "buttonCheckAll" );
			this.buttonCheckAll.Name = "buttonCheckAll";
			this.buttonCheckAll.UseVisualStyleBackColor = true;
			this.buttonCheckAll.Click += new System.EventHandler( this.buttonCheckAll_Click );
			// 
			// listViewFileGroups
			// 
			resources.ApplyResources( this.listViewFileGroups, "listViewFileGroups" );
			this.listViewFileGroups.CheckBoxes = true;
			this.listViewFileGroups.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1} );
			this.listViewFileGroups.FullRowSelect = true;
			this.listViewFileGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewFileGroups.HideSelection = false;
			this.listViewFileGroups.MultiSelect = false;
			this.listViewFileGroups.Name = "listViewFileGroups";
			this.listViewFileGroups.SmallImageList = this.imageList;
			this.listViewFileGroups.UseCompatibleStateImageBehavior = false;
			this.listViewFileGroups.View = System.Windows.Forms.View.SmallIcon;
			this.listViewFileGroups.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler( this.treeViewFileGroups_ItemChecked );
			this.listViewFileGroups.SizeChanged += new System.EventHandler( this.listViewFileGroups_SizeChanged );
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "imageList.ImageStream" )));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName( 0, "group" );
			this.imageList.Images.SetKeyName( 1, "project" );
			this.imageList.Images.SetKeyName( 2, "file" );
			// 
			// label2
			// 
			resources.ApplyResources( this.label2, "label2" );
			this.label2.Name = "label2";
			// 
			// wizardPage3
			// 
			resources.ApplyResources( this.wizardPage3, "wizardPage3" );
			this.wizardPage3.AntiAlias = false;
			this.wizardPage3.Controls.Add( this.label4 );
			this.wizardPage3.Controls.Add( this.buttonBrowseFile );
			this.wizardPage3.Controls.Add( this.textBoxSourceDestination );
			this.wizardPage3.Controls.Add( this.label3 );
			this.wizardPage3.HelpButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
			this.wizardPage3.HelpButtonVisible = DevComponents.DotNetBar.eWizardButtonState.False;
			this.wizardPage3.Name = "wizardPage3";
			this.wizardPage3.PageHeaderImage = ((System.Drawing.Image)(resources.GetObject( "wizardPage3.PageHeaderImage" )));
			// 
			// label4
			// 
			resources.ApplyResources( this.label4, "label4" );
			this.label4.Name = "label4";
			// 
			// buttonBrowseFile
			// 
			resources.ApplyResources( this.buttonBrowseFile, "buttonBrowseFile" );
			this.buttonBrowseFile.Name = "buttonBrowseFile";
			this.buttonBrowseFile.UseVisualStyleBackColor = true;
			this.buttonBrowseFile.Click += new System.EventHandler( this.buttonBrowseFile_Click );
			// 
			// textBoxSourceDestination
			// 
			resources.ApplyResources( this.textBoxSourceDestination, "textBoxSourceDestination" );
			this.textBoxSourceDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxSourceDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.textBoxSourceDestination.Name = "textBoxSourceDestination";
			this.textBoxSourceDestination.TextChanged += new System.EventHandler( this.textBoxSourceDestination_TextChanged );
			// 
			// label3
			// 
			resources.ApplyResources( this.label3, "label3" );
			this.label3.Name = "label3";
			// 
			// ImportExportWizard
			// 
			this.Appearance.Font = new System.Drawing.Font( "Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel );
			this.Appearance.Options.UseFont = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			resources.ApplyResources( this, "$this" );
			this.Controls.Add( this.wizard );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ImportExportWizard";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler( this.importExportWizard_Load );
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.importExportWizard_FormClosing );
			this.wizard.ResumeLayout( false );
			this.wizardPage1.ResumeLayout( false );
			this.wizardPage1.PerformLayout();
			this.groupBox1.ResumeLayout( false );
			this.wizardPage2.ResumeLayout( false );
			this.wizardPage2.PerformLayout();
			this.wizardPage3.ResumeLayout( false );
			this.wizardPage3.PerformLayout();
			this.ResumeLayout( false );

        }

        #endregion

        private DevComponents.DotNetBar.Wizard wizard;
        private DevComponents.DotNetBar.WizardPage wizardPage1;
        private DevComponents.DotNetBar.WizardPage wizardPage2;
        private DevComponents.DotNetBar.WizardPage wizardPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.ListView listViewFileGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.TextBox textBoxSourceDestination;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonCheckNone;
		private System.Windows.Forms.Button buttonCheckAll;
    }
}