﻿namespace ZetaResourceEditor.UI.Main;

using Helper.Base;
using RuntimeBusinessLogic.WebServices;
using System.Net;

public partial class WebProxySettingsForm : FormBase
{
	public WebProxySettingsForm()
	{
		InitializeComponent();
	}

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
			useIEProxyRadioButton.Checked ||
			useNoProxyRadioButton.Checked
			||
			useCustomProxyRadioButton.Checked &&
			ProxyAddressTextBox.Text.Trim().Length > 0;
	}

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

					if (value.Credentials is NetworkCredential credentials)
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