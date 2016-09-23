namespace ZetaResourceEditor.RuntimeBusinessLogic.DynamicSettings
{
	using System;
	using System.Collections.Generic;
	using System.Xml;
	using Zeta.VoyagerLibrary.Common;

	internal class DynSettings
	{
		private readonly Dictionary<string, string> _inMemoryValues =
			new Dictionary<string, string>();

		private bool _isModified;

		public void MarkAsUnmodified()
		{
			_isModified = false;
		}

		public bool IsModified
		{
			get
			{
				return _isModified;
			}
		}

		public void StoreToXml(XmlElement node)
		{
			foreach (var pair in _inMemoryValues)
			{
				if (node.OwnerDocument != null)
				{
					var settingNode =
						node.OwnerDocument.CreateElement(@"setting");
					node.AppendChild(settingNode);

					if (node.OwnerDocument != null)
					{
						var a = node.OwnerDocument.CreateAttribute(@"name");
						a.Value = pair.Key;
						settingNode.Attributes.Append(a);
					}

					if (node.OwnerDocument != null)
					{
						var valueNode =
							node.OwnerDocument.CreateElement(@"value");
						settingNode.AppendChild(valueNode);
						valueNode.InnerText = pair.Value;
					}
				}
			}
		}

		public void LoadFromXml(XmlNode node)
		{
			_inMemoryValues.Clear();

			var settingNodes = node.SelectNodes(@"setting");

			if (settingNodes != null)
			{
				foreach (XmlNode settingNode in settingNodes)
				{
					if (settingNode.Attributes != null)
					{
						string name;
						XmlHelper.ReadAttribute(out name, settingNode.Attributes[@"name"]);

						var value = settingNode.SelectSingleNode(@"value");
						if (value != null)
						{
							_inMemoryValues[name] = value.InnerText;
						}
						else
						{
							_inMemoryValues[name] = null;
						}
					}
				}
			}
		}

		public Dictionary<string, string> DirectValues
		{
			get
			{
				return _inMemoryValues;
			}
		}

		public void PersistValue(string name, string value)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(@"name");
			}
			else
			{
				if (DirectValues.ContainsKey(name))
				{
					var current = DirectValues[name];
					var adding = value;

					if (!isSame(current, adding))
					{
						DirectValues[name] = adding;
						_isModified = true;
					}
				}
				else
				{
					DirectValues.Add(name, value ?? string.Empty);
					_isModified = true;
				}
			}
		}

		private static bool isSame(string a, string b)
		{
			if (a == null && b == null)
			{
				return true;
			}
			else
			{
				return a == b;
			}
		}

		public string RetrieveValue(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(@"name");
			}
			else
			{
				string result;
				return DirectValues.TryGetValue(name, out result) ? result : null;
			}
		}

		public void DeleteValue(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(@"name");
			}
			else
			{
				if (DirectValues.ContainsKey(name))
				{
					if (DirectValues.Remove(name))
					{
						_isModified = true;
					}
				}
			}
		}
	}
}