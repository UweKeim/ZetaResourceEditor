namespace ZetaResourceEditor.UI.Tools;

using Helper.Base;
using Properties;
using RuntimeUserInterface.Shell;

public partial class AboutFormHtml :
	FormBase
{
	public AboutFormHtml()
	{
		InitializeComponent();
	}

	private void AboutFormHtml_Load(object sender, EventArgs e)
	{
		CenterToParent();

		label4.Text = label4.Text.Replace(@"{VersionNo}",
			Assembly.GetExecutingAssembly().GetName().Version.ToString()).Replace(@"{BuildDate}",
			File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToString(@"g"));
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
}