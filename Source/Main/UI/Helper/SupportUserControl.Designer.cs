namespace ZetaResourceEditor.UI.Helper
{
	partial class SupportUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( SupportUserControl ) );
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip( this.components );
			this.remoteSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.captureScreenshotToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// linkLabel1
			// 
			resources.ApplyResources( this.linkLabel1, "linkLabel1" );
			this.linkLabel1.ContextMenuStrip = this.contextMenuStrip1;
			this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.TabStop = true;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.linkLabel1_LinkClicked );
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.remoteSupportToolStripMenuItem,
            this.toolStripSeparator1,
            this.captureScreenshotToClipboardToolStripMenuItem,
            this.uploadFileToolStripMenuItem} );
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			resources.ApplyResources( this.contextMenuStrip1, "contextMenuStrip1" );
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler( this.contextMenuStrip1_Opening );
			// 
			// remoteSupportToolStripMenuItem
			// 
			resources.ApplyResources( this.remoteSupportToolStripMenuItem, "remoteSupportToolStripMenuItem" );
			this.remoteSupportToolStripMenuItem.Name = "remoteSupportToolStripMenuItem";
			this.remoteSupportToolStripMenuItem.Click += new System.EventHandler( this.remoteSupportToolStripMenuItem_Click );
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources( this.toolStripSeparator1, "toolStripSeparator1" );
			// 
			// captureScreenshotToClipboardToolStripMenuItem
			// 
			resources.ApplyResources( this.captureScreenshotToClipboardToolStripMenuItem, "captureScreenshotToClipboardToolStripMenuItem" );
			this.captureScreenshotToClipboardToolStripMenuItem.Name = "captureScreenshotToClipboardToolStripMenuItem";
			this.captureScreenshotToClipboardToolStripMenuItem.Click += new System.EventHandler( this.captureScreenshotToClipboardToolStripMenuItem_Click );
			// 
			// uploadFileToolStripMenuItem
			// 
			resources.ApplyResources( this.uploadFileToolStripMenuItem, "uploadFileToolStripMenuItem" );
			this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
			this.uploadFileToolStripMenuItem.Click += new System.EventHandler( this.uploadFileToolStripMenuItem_Click );
			// 
			// pictureBox1
			// 
			resources.ApplyResources( this.pictureBox1, "pictureBox1" );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// SupportUserControl
			// 
			resources.ApplyResources( this, "$this" );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add( this.linkLabel1 );
			this.Controls.Add( this.pictureBox1 );
			this.MaximumSize = new System.Drawing.Size( 130, 17 );
			this.MinimumSize = new System.Drawing.Size( 130, 17 );
			this.Name = "SupportUserControl";
			this.contextMenuStrip1.ResumeLayout( false );
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem remoteSupportToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem captureScreenshotToClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;

	}
}
