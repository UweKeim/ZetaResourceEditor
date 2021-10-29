namespace ZetaResourceEditor.Runtime.Localization;

#region Public methods.
// ----------------------------------------------------------------------
using System;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.ComponentModel;

// ----------------------------------------------------------------------
#endregion

/////////////////////////////////////////////////////////////////////////

/// <summary>
/// 
/// </summary>
[AttributeUsage(
    AttributeTargets.All,
    Inherited = false,
    AllowMultiple = true )]
public sealed class LocalizableCategoryAttribute :
    CategoryAttribute
{
    #region Public methods.
    // ------------------------------------------------------------------

    /// <summary>
    /// Initializes a new instance of the <see cref="LocalizableCategoryAttribute"/> class.
    /// </summary>
    /// <param name="category">The category.</param>
    /// <param name="resourcesType">Type of the resources.</param>
    public LocalizableCategoryAttribute(
        string category,
        Type resourcesType )
        :
        base( category )
    {
        _resourcesType = resourcesType;
    }

    // ------------------------------------------------------------------
    #endregion

    #region Private methods.
    // ------------------------------------------------------------------

    /// <summary>
    /// Looks up the localized name of the specified category.
    /// </summary>
    /// <param name="value">The identifer for the category to look up.</param>
    /// <returns>
    /// The localized name of the category, or null if a localized name does not exist.
    /// </returns>
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

    // ------------------------------------------------------------------
    #endregion

    #region Private variables.
    // ------------------------------------------------------------------

    private readonly Type _resourcesType;

    // ------------------------------------------------------------------
    #endregion
}

/////////////////////////////////////////////////////////////////////////