namespace ZetaResourceEditor.Runtime.Localization;

[AttributeUsage(
    AttributeTargets.All,
    Inherited = false,
    AllowMultiple = true )]
public sealed class LocalizableCategoryAttribute :
    CategoryAttribute
{
    public LocalizableCategoryAttribute(
        string category,
        Type resourcesType )
        :
        base( category )
    {
        _resourcesType = resourcesType;
    }

    protected override string GetLocalizedString(
        string value )
    {
        var resMan =
            _resourcesType.InvokeMember(
                @"ResourceManager",
                BindingFlags.GetProperty | BindingFlags.Static |
                BindingFlags.Public | BindingFlags.NonPublic,
                null,
                null,
                new object[] {} ) as ResourceManager;

        var culture =
            _resourcesType.InvokeMember(
                @"Culture",
                BindingFlags.GetProperty | BindingFlags.Static |
                BindingFlags.Public | BindingFlags.NonPublic,
                null,
                null,
                new object[] {} ) as CultureInfo;

        return resMan == null ? value : resMan.GetString( value, culture );
    }

    private readonly Type _resourcesType;
}
