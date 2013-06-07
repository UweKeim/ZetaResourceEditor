// ReSharper disable CheckNamespace
// ReSharper disable EmptyNamespace
namespace ZetaResourceEditor.UI.Helper
// ReSharper restore EmptyNamespace
// ReSharper restore CheckNamespace
{
    /*
    using System;
    using System.IO;
    using System.Text;
    using DevExpress.Utils;
    using DevExpress.XtraGrid.Views.Grid;
    using Zeta.EnterpriseLibrary.Common;
    using Zeta.EnterpriseLibrary.Windows.Common;

    /// <summary>
    /// See http://www.devexpress.com/Support/Center/kb/p/A1433.aspx.
    /// </summary>
    [Serializable]
    public class XtraGridState
    {
        [NonSerialized]
        private readonly GridView _gridView;

        public XtraGridState(
            GridView gridView)
        {
            _gridView = gridView;
        }

        public void PersistsState(string key)
        {
            using (var ms = new MemoryStream())
            {
                _gridView.SaveLayoutToStream(ms, OptionsLayoutBase.FullLayout);
                ms.Seek(0, SeekOrigin.Begin);

                string s;
                using (var sr = new StreamReader(ms, Encoding.UTF8))
                {
                    s = sr.ReadToEnd();
                }

                PersistanceHelper.SaveValue(key, s);
            }
        }

        public void RestoreState(string key)
        {
            var s = ConvertHelper.ToString(PersistanceHelper.RestoreValue(key));

            if (!string.IsNullOrEmpty(s))
            {
                using (var ms =
                    new MemoryStream(Encoding.UTF8.GetBytes(s)))
                {
                    _gridView.RestoreLayoutFromStream(ms, OptionsLayoutBase.FullLayout);
                }
            }
        }

        public void ResetState(string key)
        {
            PersistanceHelper.SaveValue(key, string.Empty);
        }
    }
       */
}