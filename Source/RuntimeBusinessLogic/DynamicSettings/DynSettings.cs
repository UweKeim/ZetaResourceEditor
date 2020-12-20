namespace ZetaResourceEditor.RuntimeBusinessLogic.DynamicSettings
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using Zeta.VoyagerLibrary.Common;

    internal class DynSettings
    {
        public void MarkAsUnmodified()
        {
            IsModified = false;
        }

        public bool IsModified { get; private set; }

        public void StoreToXml(XmlElement node)
        {
            foreach (var pair in DirectValues)
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
            DirectValues.Clear();

            var settingNodes = node.SelectNodes(@"setting");

            if (settingNodes != null)
            {
                foreach (XmlNode settingNode in settingNodes)
                {
                    if (settingNode.Attributes != null)
                    {
                        XmlHelper.ReadAttribute(out string name, settingNode.Attributes[@"name"]);

                        var value = settingNode.SelectSingleNode(@"value");
                        if (value != null)
                        {
                            DirectValues[name] = value.InnerText;
                        }
                        else
                        {
                            DirectValues[name] = null;
                        }
                    }
                }
            }
        }

        public Dictionary<string, string> DirectValues { get; } = new();

        public void PersistValue(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
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
                        IsModified = true;
                    }
                }
                else
                {
                    DirectValues.Add(name, value ?? string.Empty);
                    IsModified = true;
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
                throw new ArgumentNullException(nameof(name));
            }
            else
            {
                return DirectValues.TryGetValue(name, out var result) ? result : null;
            }
        }

        public void DeleteValue(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            else
            {
                if (DirectValues.ContainsKey(name))
                {
                    if (DirectValues.Remove(name))
                    {
                        IsModified = true;
                    }
                }
            }
        }
    }
}