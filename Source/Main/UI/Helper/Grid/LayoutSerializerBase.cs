namespace ZetaResourceEditor.UI.Helper.Grid
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.IO;
	using System.Text;
	using DevExpress.Utils;
	using DevExpress.Utils.Serializing;
	using DevExpress.Utils.Serializing.Helpers;
	using DevExpress.XtraGrid.Views.Grid;
	using Zeta.VoyagerLibrary.Common;
	using Zeta.VoyagerLibrary.Tools.Storage;
	using Zeta.VoyagerLibrary.WinForms.Persistance;

	// http://www.devexpress.com/Support/Center/p/Q249609.aspx
	// http://www.devexpress.com/Support/Center/e/E600.aspx
	// http://www.devexpress.com/Support/Center/KB/p/AK9157.aspx
	// http://www.devexpress.com/Support/Center/p/Q104945.aspx

	internal abstract class LayoutSerializerBase :
		XmlXtraSerializer
	{
		public const string XtraGridAppName = @"View";
		public const string BarManagerAppName = @"BarManager";
		public const string DockManagerAppName = @"DockManager";
		public const string XtraGaugeAppName = @"IGaugeContainer";
		public const string LayoutControlAppName = @"LayoutControl";
		public const string DataLayoutControlAppName = @"DataLayoutControl";
		public const string XtraNavBarAppName = @"NavBarControl";
		public const string XtraPivotGridAppName = @"PivotGrid";
		public const string XtraTreeListAppName = @"TreeList";
		public const string VGridControlAppName = @"VGridControl";
		public const string PropertyGridControlAppName = @"PropertyGridControl";

		protected LayoutSerializerBase(
			GridView gridView,
			IPersistentPairStorage storage,
			string key)
		{
			this.gridView = gridView;
			_storage = storage;
			_key = key;
		}

	    private readonly IPersistentPairStorage _storage;
		private readonly string _key;
		private static FilterSerializationContext _instance;
		private static readonly object TypeLock =new object();

		protected override SerializeHelper CreateSerializeHelper(
			object rootObj,
			bool useRootObj)
		{
			lock (TypeLock)
			{
				_instance = new FilterSerializationContext();

				foreach (var field in Fields)
				{
					_instance.AddProperty(typeof (GridView), field);
				}

				// --

				return useRootObj ? new FilterSerializeHelper(rootObj) : new FilterSerializeHelper();
			}
		}

		protected override void DeserializeObject(
			object obj,
			IXtraPropertyCollection store,
			OptionsLayoutBase options)
		{
			if (options == null)
				options = OptionsLayoutBase.FullLayout;
			if (store == null)
				return;
			var coll = new XtraPropertyCollection();
			coll.AddRange(store);
			var helper = new DeserializeHelper(obj, false);
			helper.DeserializeObject(obj, coll, options);
		}

		public void Save()
        {
            using var ms = new MemoryStream();
            saveSettings(gridView, ms, XtraGridAppName);
            ms.Seek(0, SeekOrigin.Begin);

            string s;
            using (var sr = new StreamReader(ms, Encoding.UTF8))
            {
                s = sr.ReadToEnd();
            }

            PersistanceHelper.SaveValue(_storage, key, s);
        }

		public void Restore()
		{
			var s = ConvertHelper.ToString(PersistanceHelper.RestoreValue(_storage, key));

			if (!string.IsNullOrEmpty(s))
            {
                using var ms =
                    new MemoryStream(Encoding.UTF8.GetBytes(s));
                loadSettings(gridView, ms, XtraGridAppName);
            }
		}

		public virtual void Reset()
		{
			PersistanceHelper.SaveValue(_storage, key, string.Empty);
		}

		protected abstract string[] Fields { get; }
		protected abstract string KeyPrefix { get; }

		private string key => KeyPrefix + @"-" + _key;

	    protected GridView gridView { get; }

	    private void saveSettings(object view, Stream stream, string appName)
		{
			SerializeObject(view, stream, appName);
		}

		private void loadSettings(object view, Stream stream, string appName)
		{
			DeserializeObject(view, stream, appName);
		}

		private class FilterSerializeHelper : 
			SerializeHelper
		{
			public FilterSerializeHelper()
			{
			}

			public FilterSerializeHelper(
				object rootObject)
				: base(rootObject)
			{
			}

			protected override SerializationContext CreateSerializationContext()
			{
				return _instance;
			}
		}

		private class FilterSerializationContext :
			SerializationContext
		{
			private readonly Dictionary<Type, string> _filters = new Dictionary<Type, string>();

// ReSharper disable UnusedAutoPropertyAccessor.Local
			private bool Exclusive { get; set; }
// ReSharper restore UnusedAutoPropertyAccessor.Local

			public void AddProperty(Type key, string propertyName)
			{
				if (!_filters.ContainsKey(key)) _filters.Add(key, @";");
				_filters[key] = string.Concat(_filters[key], propertyName, @";");
			}

			protected override bool ShouldSerializeProperty(
				SerializeHelper helper,
				object obj,
				PropertyDescriptor prop,
				XtraSerializableProperty xtraSerializableProperty)
            {
                return !CheckFilter(obj.GetType(), prop.Name) && base.ShouldSerializeProperty(helper, obj, prop, xtraSerializableProperty);
            }

			private bool CheckFilter(Type key, string propertyName)
			{
				return
					(_filters.ContainsKey(key) &&
					 _filters[key].Contains(string.Concat(@";", propertyName, @";")))
					== Exclusive;
			}
		}
	}
}