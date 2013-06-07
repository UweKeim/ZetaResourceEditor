namespace ZetaResourceEditor.UI.Main
{
	using System;
	using System.Configuration;
	using System.Windows.Forms;
	using Code;
	using DevExpress.XtraEditors.Controls;
	using Helper.Base;
	using RuntimeBusinessLogic.Licensing;
	using RuntimeUserInterface.Shell;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	public partial class ExitAdvertisementForm :
		FormBase
	{
		/// <summary>
		/// Checks and shows the trial version form if necessary.
		/// </summary>
		public static void CheckShow()
		{
			if (!ConvertHelper.ToBoolean(
				ConfigurationManager.AppSettings[@"disableExitAdvertisementForm"])
				/*&& !ZetaResourceEditorCommandLineInfo.Current.IsNonblockingGui*/)
			{
				if (HostSettings.Current.License.LicenseType == ZreLicenseType.Freeware)
				{
					var lastExitAdvertisementShownAt =
						ConvertHelper.ToDateTime(
							PersistanceHelper.RestoreValue(@"ExitAdvertisement.LastShown"));

					if (lastExitAdvertisementShownAt <= DateTime.Now.AddDays(-1) ||
					    ConvertHelper.ToBoolean(
							ConfigurationManager.AppSettings[@"forceExitAdvertisementForm"]))
					{
						PersistanceHelper.SaveValue(@"ExitAdvertisement.LastShown", DateTime.Now);

						using (var form = new ExitAdvertisementForm())
						{
							var af = ActiveForm;
							if(af!=null)
							{
								af.Visible = false;
							}
							form.ShowDialog(af);
						}
					}
				}
			}
		}

		public ExitAdvertisementForm()
		{
			InitializeComponent();
		}

		private void ExitAdvertisementForm_Load(object sender, EventArgs e)
		{
			if (ParentForm == null)
			{
				CenterToScreen();
			}
			else
			{
				CenterToParent();
			}

			UpdateUI();
		}

		private void ExitAdvertisementForm_Shown(object sender, EventArgs e)
		{
			buttonClose.Focus();
		}

		private void hyperLinkEdit1_OpenLink(object sender, OpenLinkEventArgs e)
		{
			openLink();
		}

		private void openLink()
		{
			new ShellExecuteInformation
				{
					FileName = @"http://zeta.li/zre-link--zeta-test-2"
				}
				.Execute();

			Close();
		}

		private void pictureEdit1_MouseClick(object sender, MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left)
			{
				openLink();
			}
		}
	}
}