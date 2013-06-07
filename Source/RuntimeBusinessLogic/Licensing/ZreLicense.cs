namespace ZetaResourceEditor.RuntimeBusinessLogic.Licensing
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Security.Cryptography;
	using System.Text;
	using System.Xml;
	using Properties;
	using Runtime.Localization;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Tools;

	public class ZreLicense
	{
		private readonly Dictionary<string, string> _settings =
			new Dictionary<string, string>();

		private string _rawString;
		private bool _isLicenseValid = true;

		[LocalizableCategory(@"SR_ZreLicenseType_LicenseType_Category", typeof(Resources))]
		[LocalizableDisplayName(@"SR_ZreLicenseType_LicenseType_DisplayName", typeof(Resources))]
		[LocalizableDescription(@"SR_ZreLicenseType_LicenseType_Description", typeof(Resources))]
		public ZreLicenseType LicenseType
		{
			get
			{
				return (ZreLicenseType)ConvertHelper.ToInt32(
					GetValue(@"LicenseType",
						((int)ZreLicenseType.Freeware).ToString()));
			}
			set
			{
				SetValue(@"LicenseType", ((int)value).ToString());
			}
		}

		[Browsable(false)]
		public string RawString
		{
			get
			{
				return _rawString;
			}
			set
			{
				_rawString = value;
				notifyNeedSave();
			}
		}

		[Browsable(false)]
		public string LicenseTypeName
		{
			get
			{
				return StringHelper.GetEnumDescription(LicenseType);
			}
		}

		[Browsable(false)]
		public bool IsLicenseValid
		{
			get { return _isLicenseValid; }
		}

		private void notifyNeedSave()
		{
			var h = NeedStore;
			if (h != null)
			{
				h(this);
			}
		}

		public void LoadFromString(string raw)
		{
			_rawString = raw;
			_isLicenseValid = true;

			_settings.Clear();

			if (!string.IsNullOrEmpty(raw))
			{
				string xml;
				try
				{
					xml = StringHelper.DecryptString(raw);
				}
				catch (FormatException)
				{
					_isLicenseValid = false;
					return;
				}
				catch (CryptographicException)
				{
					_isLicenseValid = false;
					return;
				}

				var doc = XmlHelper.CreateDocument();
				doc.LoadXml(xml);

				load(doc);
				_isLicenseValid = true;
			}
		}

		private void load(XmlNode doc)
		{
			var pairs = doc.SelectNodes(@"/root/pair");

			if (pairs != null)
			{
				foreach (XmlNode xmlNode in pairs)
				{
					if (xmlNode != null)
					{
						if (xmlNode.Attributes != null)
						{
							var name = xmlNode.Attributes[@"name"].InnerText;
							var value = xmlNode.InnerText;

							doSetValue(name, value);
						}
					}
				}
			}
		}

		public void SetValue(string name, string value)
		{
			doSetValue(name, value);

			notifyNeedSave();
		}

		private void doSetValue(string name, string value)
		{
			if (_settings.ContainsKey(name))
			{
				_settings[name] = value;
			}
			else
			{
				_settings.Add(name, value);
			}
		}

		public string GetValue(string name)
		{
			return GetValue(name, null);
		}

		public string GetValue(string name, string fallBack)
		{
			if (_settings.ContainsKey(name))
			{
				return _settings[name];
			}
			else
			{
				return fallBack;
			}
		}

		public string SaveToString()
		{
			var doc = XmlHelper.CreateDocument(Encoding.UTF8);

			var root = doc.CreateElement(@"root");
			doc.AppendChild(root);

			foreach (var name in _settings.Keys)
			{
				var value = _settings[name];

				if (!string.IsNullOrEmpty(value))
				{
					var pair = doc.CreateElement(@"pair");
					root.AppendChild(pair);

					var a = doc.CreateAttribute(@"name");
					a.InnerText = name;
					pair.Attributes.Append(a);

					pair.InnerText = value;
				}
			}

			return StringHelper.EncryptString(doc.OuterXml);
		}

		public event Action<ZreLicense> NeedStore;
	}
}