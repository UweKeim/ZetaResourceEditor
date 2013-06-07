namespace LicenseGenerator.UI
{
	using System;
	using System.Windows.Forms;
	using DevExpress.XtraEditors;
	using DevExpress.XtraVerticalGrid.Events;
	using ZetaResourceEditor.RuntimeBusinessLogic.Licensing;

	public partial class MainForm : XtraForm
	{
		private readonly ZreLicense _license = new ZreLicense();

		public MainForm()
		{
			InitializeComponent();
		}

		private void memoEdit1_EditValueChanged(object sender, EventArgs e)
		{
			updateUI();
		}

		private void updateUI()
		{
			buttonCopyToClipboard.Enabled =
				licenseMemoEdit.Text.Trim().Length > 0;
		}

		private void updateLicenseKey()
		{
			licenseMemoEdit.Text = _license.SaveToString();

			updateUI();
		}

		private void buttonCopyToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(licenseMemoEdit.Text.Trim());
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MainForrm_Load(object sender, EventArgs e)
		{
			propertyGrid.SelectedObject = _license;

			CenterToScreen();

			updateLicenseKey();
			updateUI();
		}

		private void propertyGrid_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			updateLicenseKey();
			updateUI();
		}
	}
}