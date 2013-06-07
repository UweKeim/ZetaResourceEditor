namespace ZetaResourceEditor.UI.Main
{
	using System;
	using System.Net;
	using System.Windows.Forms;
	using Code;
	using Helper.Base;
	using Properties;
	using RuntimeBusinessLogic.DL;
	using RuntimeBusinessLogic.Licensing;
	using RuntimeBusinessLogic.WebServices;
	using RuntimeUserInterface.Shell;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	public partial class OptionsForm :
		FormBase
	{
		public OptionsForm()
		{
			InitializeComponent();

			if (!DesignMode)
			{
				// For now, hide license.
				xtraTabControl1.TabPages.Remove(xtraTabPage2);
			}
		}

		public int ActiveTabPageIndex
		{
			get
			{
				return xtraTabControl1.SelectedTabPageIndex;
			}
			set
			{
				xtraTabControl1.SelectedTabPageIndex = value;
			}
		}

		public override void FillControlsToItem()
		{
			base.FillControlsToItem();

			HostSettings.Current.ShowNewsInMainWindow =
				showNewsCheckEdit.Checked;
			HostSettings.Current.License.RawString =
				licenseKeyMemoEdit.Text;
		}

		public override void FillItemToControls()
		{
			base.FillItemToControls();

			showNewsCheckEdit.Checked =
				HostSettings.Current.ShowNewsInMainWindow;

			licenseKeyMemoEdit.Text = HostSettings.Current.License.RawString;
			updateLicenseInfo();

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
			WinFormsPersistanceHelper.RestoreState(this);
			CenterToParent();

			InitiallyFillLists();
			FillItemToControls();

			UpdateUI();
		}

		private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			WinFormsPersistanceHelper.SaveState(this);
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			FillControlsToItem();
		}

		private void licenseKeyMemoEdit_EditValueChanged(object sender, EventArgs e)
		{
			UpdateUI();
			updateLicenseInfo();
		}

		private void updateLicenseInfo()
		{
			var l = new ZreLicense();
			l.LoadFromString(licenseKeyMemoEdit.Text);

			licenseInformationLabel.Text =
				l.IsLicenseValid ? l.LicenseTypeName : Resources.SR_OptionsForm_updateLicenseInfo__Invalid_license_key_;
		}

		private void purchaseLicenseButton_Click(object sender, EventArgs e)
		{
			var sei =
				new ShellExecuteInformation
					{
						FileName =
							Resources.SR_OptionsForm_purchaseLicenseButton_Click
					};
			sei.Execute();
		}

		private void proxyButton_Click(object sender, EventArgs e)
		{
			using (var form = new WebProxySettingsForm())
			{
				form.WebProxy = WebServiceManager.Current.WebServiceProxy as WebProxy;
				form.WebProxyUsage = WebServiceManager.Current.WebProxyUsage;

				if (form.ShowDialog(this) == DialogResult.OK)
				{
					WebServiceManager.Current.WebServiceProxy = form.WebProxy;
					WebServiceManager.Current.WebProxyUsage = form.WebProxyUsage;
				}
			}
		}
	}
}