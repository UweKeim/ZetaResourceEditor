namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	partial class ExtendedWebBrowserUserControl
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
			this.panel1 = new System.Windows.Forms.Panel();
			webBrowser = new ZetaResourceEditor.UI.Helper.ExtendedWebBrowser.ExtendedWebBrowserControl();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add( webBrowser );
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point( 0, 0 );
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding( 1 );
			this.panel1.Size = new System.Drawing.Size( 150, 150 );
			this.panel1.TabIndex = 0;
			// 
			// extendedWebBrowserControl1
			// 
			webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			webBrowser.DocumentTextBody = "<HTML></HTML>\0";
			webBrowser.EventSink = null;
			webBrowser.Location = new System.Drawing.Point( 1, 1 );
			webBrowser.MinimumSize = new System.Drawing.Size( 20, 20 );
			webBrowser.Name = "WebBrowser";
			webBrowser.ScriptErrorsSuppressed = true;
			webBrowser.Size = new System.Drawing.Size( 148, 148 );
			webBrowser.TabIndex = 0;
			// 
			// ExtendedWebBrowserUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Controls.Add( this.panel1 );
			this.Name = "ExtendedWebBrowserUserControl";
			this.panel1.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private ExtendedWebBrowserControl webBrowser;
	}
}
