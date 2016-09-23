namespace ZetaResourceEditor.UI.Tools
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Reflection;
	using DevExpress.XtraEditors.Controls;
	using Helper.Base;
	using Properties;
	using RuntimeUserInterface.Shell;
	using ZetaLongPaths;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	public partial class AboutForm :
		FormBase
	{
		#region Public methods.
		// ------------------------------------------------------------------

		public AboutForm()
		{
			InitializeComponent();
		}

		// ------------------------------------------------------------------
		#endregion

		#region Event handler.
		// ------------------------------------------------------------------

		private void AboutForm_Load(
			object sender,
			EventArgs e)
		{
			CenterToParent();

			label4.Text = label4.Text.
				Replace(@"{VersionNo}",
				Assembly.GetExecutingAssembly().GetName().Version.ToString()).
				Replace(@"{BuildDate}",
				ZlpIOHelper.GetFileLastWriteTime(Assembly.GetExecutingAssembly().Location).ToString(@"g"));
		}

		private void linkLabel1_Properties_Click(object sender, EventArgs e)
		{
			var sei =
				new ShellExecuteInformation
				{
					FileName =
					Resources.SR_AboutForm_linkLabel1LinkClicked_Httpwwwzetasoftwaredelinkszrehome
				};
			sei.Execute();
		}

		private void linkLabel1_OpenLink(object sender, OpenLinkEventArgs e)
		{
		    e.Handled = true;
			linkLabel1_Properties_Click(null, null);
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}