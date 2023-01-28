namespace ZetaResourceEditor.UI.Helper.Grid;

using DevExpress.Utils.Serializing;
using DevExpress.Utils.Serializing.Helpers;

public class DXFilterSerializer : XmlXtraSerializer
{
    protected override SerializeHelper CreateSerializeHelper(
        object rootObj,
        bool useRootObj)
    {
        return useRootObj ? new(rootObj) : new FilterSerializeHelper();
    }

    protected override void DeserializeObject(
        object obj,
        IXtraPropertyCollection store,
        OptionsLayoutBase options)
    {
        options ??= OptionsLayoutBase.FullLayout;
        if (store == null) return;
        var coll = new XtraPropertyCollection();
        coll.AddRange(store);
        var helper = new DeserializeHelper(obj, false);
        helper.DeserializeObject(obj, coll, options);
    }
}

public class FilterSerializeHelper : SerializeHelper
{
    public FilterSerializeHelper()
    {
    }

    public FilterSerializeHelper(object rootObject) : base(rootObject)
    {
    }


    protected override SerializationContext CreateSerializationContext()
    {
        return FilterSerializationContext.Default;
    }
}

public class FilterSerializationContext :
    SerializationContext
{
    private readonly Dictionary<Type, string> _filters = new();

    public bool Exclusive { get; set; }

    public static FilterSerializationContext Default { get; } = new();

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
        if (!_filters.TryGetValue(key, out var filter)) return;

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
        return !CheckFilter(obj.GetType(), prop.Name) &&
               base.ShouldSerializeProperty(helper, obj, prop, xtraSerializableProperty);
    }

    private bool CheckFilter(Type key, string propertyName)
    {
        return (_filters.ContainsKey(key) && _filters[key].Contains(string.Concat(@";", propertyName, @";"))) ==
               Exclusive;
    }
}