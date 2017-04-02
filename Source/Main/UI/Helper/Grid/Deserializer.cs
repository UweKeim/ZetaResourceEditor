namespace ZetaResourceEditor.UI.Helper.Grid
{
	using System;
	using System.ComponentModel;
	using System.Collections.Generic;
	using DevExpress.Utils.Serializing;
	using DevExpress.Utils.Serializing.Helpers;
	using DevExpress.Utils;

	public class DXFilterSerializer : XmlXtraSerializer
	{
		protected override SerializeHelper CreateSerializeHelper(
			object rootObj,
			bool useRootObj)
		{
			if (useRootObj)
			{
				return new FilterSerializeHelper(rootObj);
			}
			else
			{
				return new FilterSerializeHelper();
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
	}

	public class FilterSerializeHelper : SerializeHelper
	{
		public FilterSerializeHelper()
		{ }
		public FilterSerializeHelper(object rootObject) : base(rootObject) { }


		protected override SerializationContext CreateSerializationContext()
		{
			return FilterSerializationContext.Default;
		}
	}

	public class FilterSerializationContext :
		SerializationContext
	{
		private readonly Dictionary<Type, string> _filters = new Dictionary<Type, string>();

	    public bool Exclusive { get; set; }

		public static FilterSerializationContext Default { get; } = new FilterSerializationContext();

	    public void AddProperty(Type key, string propertyName)
		{
			if (!_filters.ContainsKey(key)) _filters.Add(key, @";");
			_filters[key] = string.Concat(_filters[key], propertyName, @";");
		}

		public void AddProperties(Type key, IEnumerable<string> propertyNames)
		{
			foreach (var propertyName in propertyNames) AddProperty(key, propertyName);
		}

		public void RemoveProperty(Type key, string propertyName)
		{
			string filter;
			if (!_filters.TryGetValue(key, out filter)) return;

			_filters[key] = filter.Replace(string.Concat(propertyName, @";"), string.Empty);
		}

		public void RemoveProperties(Type key, IEnumerable<string> propertyNames)
		{
			foreach (var propertyName in propertyNames)
			{
				RemoveProperty(key, propertyName);
			}
		}

		protected override bool ShouldSerializeProperty(
			SerializeHelper helper,
			object obj,
			PropertyDescriptor prop,
			XtraSerializableProperty xtraSerializableProperty)
		{
			if (CheckFilter(obj.GetType(), prop.Name)) return false;
			return base.ShouldSerializeProperty(helper, obj, prop, xtraSerializableProperty);
		}

		private bool CheckFilter(Type key, string propertyName)
		{
			return (_filters.ContainsKey(key) && _filters[key].Contains(string.Concat(@";", propertyName, @";"))) ==
				   Exclusive;
		}
	}
}


