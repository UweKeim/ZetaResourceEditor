namespace ZetaResourceEditor.UI.Main
{
	using System;
	using System.Configuration;
	using System.Threading;
	using Code;
	using Helper.Base;
	using RuntimeBusinessLogic.Licensing;
	using RuntimeUserInterface.Shell;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	public partial class ExitAdvertisementFormNew :
		FormBase
	{
		/// <summary>
		/// Checks and shows the trial version form if necessary.
		/// </summary>
		public static void CheckShow()
		{
			if (!ConvertHelper.ToBoolean(
				ConfigurationManager.AppSettings[@"disableExitAdvertisementFormNew"])
				/*&& !ZetaResourceEditorCommandLineInfo.Current.IsNonblockingGui*/)
			{
				if (HostSettings.Current.License.LicenseType == ZreLicenseType.Freeware)
				{
					var lastExitAdvertisementShownAt =
						ConvertHelper.ToDateTime(
							PersistanceHelper.RestoreValue(@"ExitAdvertisement.LastShown"));

					if (lastExitAdvertisementShownAt <= DateTime.Now.AddDays(-1) ||
						ConvertHelper.ToBoolean(
							ConfigurationManager.AppSettings[@"forceExitAdvertisementFormNew"]))
					{
						PersistanceHelper.SaveValue(@"ExitAdvertisement.LastShown", DateTime.Now);

						using (var form = new ExitAdvertisementFormNew())
						{
							var af = ActiveForm;
							if (af != null)
							{
								af.Visible = false;
							}
							form.ShowDialog(af);
						}
					}
				}
			}
		}

		public ExitAdvertisementFormNew()
		{
			InitializeComponent();
		}

		private void ExitAdvertisementFormNew_Load(object sender, EventArgs e)
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

		private void ExitAdvertisementFormNew_Shown(object sender, EventArgs e)
		{
			buttonClose.Focus();
		}

		private static string Suffix
		{
			get
			{
				if (Thread.CurrentThread.CurrentUICulture.Name.StartsWith(@"de", 
					StringComparison.InvariantCultureIgnoreCase))
				{
					return @"-de";
				}
				else
				{
					return @"-en";
				}
			}
		}

		private void pictureBoxTwitter_Click(object sender, EventArgs e)
		{
			new ShellExecuteInformation
				{
					FileName = @"http://zeta.li/zre-link--publicity-twitter" + Suffix
				}
				.Execute();
		}

		private void pictureBoxFacebook_Click(object sender, EventArgs e)
		{
			new ShellExecuteInformation
				{
					FileName = @"http://zeta.li/zre-link--publicity-facebook" + Suffix
				}
				.Execute();
		}

		private void pictureBoxEmail_Click(object sender, EventArgs e)
		{
			new ShellExecuteInformation
				{
					FileName = @"http://zeta.li/zre-link--publicity-email" + Suffix
				}
				.Execute();
		}

		private void pictureBoxBlog_Click(object sender, EventArgs e)
		{
			new ShellExecuteInformation
				{
					FileName = @"http://zeta.li/zre-link--publicity-blog" + Suffix
				}
				.Execute();
		}
	}
}