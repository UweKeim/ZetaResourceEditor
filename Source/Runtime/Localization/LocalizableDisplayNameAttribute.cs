namespace ZetaResourceEditor.Runtime.Localization;

[AttributeUsage(
    AttributeTargets.All,
    Inherited = false,
    AllowMultiple = true )]
public sealed class LocalizableDisplayNameAttribute :
    DisplayNameAttribute
{
    public LocalizableDisplayNameAttribute(
        string displayName,
        Type resourcesType )
        :
        base( displayName )
    {
        _resourcesType = resourcesType;
    }

    public override string DisplayName
    {
        get
        {
            if ( !_isLocalized )
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

                _isLocalized = true;
                if ( resMan != null )
                {
                    DisplayNameValue = resMan.GetString(
                        DisplayNameValue,
                        culture );
                }
            }

            return DisplayNameValue;
        }
    }

    private readonly Type _resourcesType;
    private bool _isLocalized;
}
