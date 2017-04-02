namespace ZetaResourceEditor.RuntimeBusinessLogic.DynamicSettings
{
    using System;
    using System.Collections.Generic;
    using Zeta.VoyagerLibrary.Tools.Storage;

    public class DynamicSettings :
        IPersistentPairStorage
    {
        public DynamicSettings(
            string prefix)
        {
            _prefix = prefix;
        }

        public string[] GetAllNames()
        {
            // Not needed now.
            return new string[] {};
        }

        public void MarkAsUnmodified()
        {
            IsModified = false;
        }

        public bool IsModified { get; private set; }

        private readonly string _prefix;

        private string addPrefix(string name)
        {
            if (string.IsNullOrEmpty(_prefix))
            {
                return name;
            }
            else
            {
                return _prefix + @"." + name;
            }
        }

        public Dictionary<string, string> DirectValues { get; } = new Dictionary<string, string>();

        public void PersistValue(string name, object value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            else
            {
                if (DirectValues.ContainsKey(addPrefix(name)))
                {
                    var current = DirectValues[addPrefix(name)];
                    var adding = value?.ToString();

                    if (!isSame(current, adding))
                    {
                        DirectValues[addPrefix(name)] = adding;
                        IsModified = true;
                    }
                }
                else
                {
                    DirectValues.Add(addPrefix(name), value?.ToString());
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

        public object RetrieveValue(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            else
            {
                string result;
                if (DirectValues.TryGetValue(addPrefix(name), out result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
        }

        public object RetrieveValue(string name, object fallBackValue)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            else
            {
                string result;
                if (DirectValues.TryGetValue(addPrefix(name), out result))
                {
                    return result;
                }
                else
                {
                    return fallBackValue;
                }
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
                if (DirectValues.ContainsKey(addPrefix(name)))
                {
                    if (DirectValues.Remove(addPrefix(name)))
                    {
                        IsModified = true;
                    }
                }
            }
        }

        public void Flush()
        {
        }

        public RetrieveValueDelegate ExternalValueRetriever
        {
            get { return null; }
            set { }
        }
    }
}