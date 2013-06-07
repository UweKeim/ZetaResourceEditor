namespace ZetaResourceEditor.UI.Helper
{
	using System;
	using System.ComponentModel;
	
	using System.Windows.Forms;
	using Base;
	using Code;
	using RuntimeUserInterface.Shell;
	using Zeta.EnterpriseLibrary.Windows.Common;

	[Designer(@"System.Windows.Forms.Design.ButtonBaseDesigner, System.Design")]
	public partial class SupportUserControl :
		UserControlBase
	{
		public SupportUserControl()
		{
			InitializeComponent();

			if (!DesignMode)
			{
				// Hide myself if not wanted.
				if (!Host.WantDisplaySupportOptionsOnForms)
				{
					foreach (Control c in Controls)
					{
						c.Visible = false;
					}
				}
			}
		}

		public static void ReplaceMenuEntryWithSupportMenu(
			ToolStripMenuItem miToReplace)
		{
			var uc = new SupportUserControl();

			var index = miToReplace.Owner.Items.IndexOf(miToReplace);

			foreach (ToolStripItem menuItem in uc.contextMenuStrip1.Items)
			{
				miToReplace.Owner.Items.Insert(index, menuItem);
				index++;
			}

			miToReplace.Owner.Items.Remove(miToReplace);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel1.ContextMenuStrip.Show(
				linkLabel1,
				0,
				linkLabel1.Height);
		}

		private void remoteSupportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var sei =
				new ShellExecuteInformation
					{
						FileName = @"http://zeta.li/zre-remote-support"
					};
			sei.Execute();
		}

		private void captureScreenshotToClipboardToolStripMenuItem_Click(
			object sender,
			EventArgs e)
		{
			CaptureScreenshotToClipboard(this);
		}

		/// <summary>
		/// Captures the screenshot to clipboard.
		/// </summary>
		/// <param name="owningControl">The owning control.</param>
		public static void CaptureScreenshotToClipboard(
			Control owningControl)
		{
			using (new WaitCursor(owningControl))
			{
				Application.DoEvents();

				var sc = new ScreenCapture();
				sc.CaptureScreenToClipboard();
			}
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			UpdateUI();
		}

		private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var sei = 
				new ShellExecuteInformation
					{
						FileName = @"http://zeta.li/zre-zeta-uploader"
					};
			sei.Execute();
		}
	}
}
