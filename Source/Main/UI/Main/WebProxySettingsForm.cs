namespace ZetaResourceEditor.UI.Main
{
	using System;
	using System.Net;
	using Helper.Base;
	using RuntimeBusinessLogic.WebServices;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	public partial class WebProxySettingsForm : FormBase
	{
		public WebProxySettingsForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Updates the UI.
		/// </summary>
		public override void UpdateUI()
		{
			base.UpdateUI();

			label5.Enabled =
				label3.Enabled =
					label2.Enabled =
						label1.Enabled =
							ProxyAddressTextBox.Enabled =
								ProxyUserNameTextBox.Enabled =
									ProxyPasswordTextBox.Enabled =
										ProxyDomainNameTextBox.Enabled =
											useCustomProxyRadioButton.Checked;

			CmdOK.Enabled =
				(
					useIEProxyRadioButton.Checked ||
						useNoProxyRadioButton.Checked
					)
						||
						(
							useCustomProxyRadioButton.Checked &&
								ProxyAddressTextBox.Text.Trim().Length > 0
							);
		}

		/// <summary>
		/// Get/set the configured proxy.
		/// </summary>
		public WebProxy WebProxy
		{
			get
			{
				if (useCustomProxyRadioButton.Checked)
				{
					var webProxy =
						new WebProxy(
						ProxyAddressTextBox.Text.Trim());

					if (ProxyUserNameTextBox.Text.Trim().Length > 0)
					{
						webProxy.Credentials = new NetworkCredential(
							ProxyUserNameTextBox.Text.Trim(),
							ProxyPasswordTextBox.Text.Trim(),
							ProxyDomainNameTextBox.Text.Trim());
					}
					else
					{
						webProxy.Credentials = null;
					}

					return webProxy;
				}
				else
				{
					return null;
				}
			}
			set
			{
				if (value == null)
				{
					useNoProxyRadioButton.Checked = true;
				}
				else
				{
					if (value == WebRequest.GetSystemWebProxy())
					{
						useIEProxyRadioButton.Checked = true;
					}
					else
					{
						useCustomProxyRadioButton.Checked = true;

						ProxyAddressTextBox.Text = value.Address.ToString();

						var credentials =
							value.Credentials as NetworkCredential;

						if (credentials != null)
						{
							ProxyUserNameTextBox.Text = credentials.UserName;
							ProxyPasswordTextBox.Text = credentials.Password;
							ProxyDomainNameTextBox.Text = credentials.Domain;
						}
					}

					UpdateUI();
				}
			}
		}

		/// <summary>
		/// Gets or sets the web proxy usage.
		/// </summary>
		/// <value>The web proxy usage.</value>
		public WebProxyUsage WebProxyUsage
		{
			get
			{
				if (useIEProxyRadioButton.Checked)
				{
					return WebProxyUsage.DefaultProxy;
				}
				else if (useNoProxyRadioButton.Checked)
				{
					return WebProxyUsage.NoProxy;
				}
				else
				{
					return WebProxyUsage.CustomProxy;
				}
			}
			set
			{
				useIEProxyRadioButton.Checked = value == WebProxyUsage.DefaultProxy;
				useNoProxyRadioButton.Checked = value == WebProxyUsage.NoProxy;
				useCustomProxyRadioButton.Checked = value == WebProxyUsage.CustomProxy;

				UpdateUI();
			}
		}

		private void WebProxySettingsForm_Load(object sender, EventArgs e)
		{
			WinFormsPersistanceHelper.RestoreState(this);
			CenterToParent();

			UpdateUI();
		}

		private void useIEProxyRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void useNoProxyRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void useCustomProxyRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void ProxyAddressTextBox_EditValueChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}
	}
}