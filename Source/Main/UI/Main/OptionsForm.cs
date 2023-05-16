namespace ZetaResourceEditor.UI.Main;

using Helper.Base;
using RuntimeBusinessLogic.WebServices;
using System.Net;
using ExtendedControlsLibrary;

public partial class OptionsForm :
	FormBase
{
	public OptionsForm()
	{
		InitializeComponent();

		if (!DesignModeHelper.IsDesignMode)
		{
			xtraTabControl1.SelectedTabPageIndex = 0;
		}
	}

	protected override void FillItemToControls()
	{
		base.FillItemToControls();

		panel1.BackColor = GridColors.CommentForeColor;
		panel2.BackColor = GridColors.CompleteRowEmptyForeColor;
		panel3.BackColor = GridColors.TagNameForeColor;
		panel4.BackColor = GridColors.NullCellBackColor;
		panel5.BackColor = GridColors.EmptyCellBackColor;
		panel6.BackColor = GridColors.PlaceHolderMismatchForeColor;
		panel7.BackColor = GridColors.TranslationErrorForeColor;
		panel8.BackColor = GridColors.TranslationSuccessForeColor;
	}

	private void OptionsForm_Load(object sender, EventArgs e)
	{
		if (!DesignModeHelper.IsDesignMode)
		{
			CenterToParent();

			InitiallyFillLists();
			FillItemToControls();

			UpdateUI();
		}
	}

	private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		FillControlsToItem();
	}

	private void proxyButton_Click(object sender, EventArgs e)
	{
		using var form = new WebProxySettingsForm
		{
			WebProxy = WebServiceManager.Current.WebServiceProxy as WebProxy,
			WebProxyUsage = WebServiceManager.Current.WebProxyUsage
		};

		if (form.ShowDialog(this) == DialogResult.OK)
		{
			WebServiceManager.Current.WebServiceProxy = form.WebProxy;
			WebServiceManager.Current.WebProxyUsage = form.WebProxyUsage;
		}
	}
}