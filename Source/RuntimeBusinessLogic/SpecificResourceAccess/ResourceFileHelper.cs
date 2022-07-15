namespace ZetaResourceEditor.RuntimeBusinessLogic.SpecificResourceAccess;

#region Using directives.
// ----------------------------------------------------------------------
using System.IO;
using System.Reflection;

// ----------------------------------------------------------------------
#endregion

/////////////////////////////////////////////////////////////////////////

/// <summary>
/// Helper routines for dealing with resource files.
/// </summary>
internal class ResourceFileHelper
{
    #region Public properties.
    // ------------------------------------------------------------------

    /// <summary>
    /// Gets all available resource file accessors.
    /// </summary>
    /// <value>All available resource file accessors.</value>
    public static IResourceFileAccessor[] AllAvailableResourceFileAccessors
    {
        get
        {
            if (_cacheForAllAvailableResourceFileAccessors == null)
            {
                _cacheForAllAvailableResourceFileAccessors =
                    new List<IResourceFileAccessor>();

                doGetAllTypes(
                    _cacheForAllAvailableResourceFileAccessors,
                    Assembly.GetEntryAssembly());
            }

            return _cacheForAllAvailableResourceFileAccessors.ToArray();
        }
    }

    // ------------------------------------------------------------------
    #endregion

    #region Public methods.
    // ------------------------------------------------------------------

    /// <summary>
    /// Gets the <c>accessor</c> for file.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <returns>Returns NULL if none found.</returns>
    public static IResourceFileAccessor GetAccessorForFile(
        FileInfo filePath)
    {
        var all = AllAvailableResourceFileAccessors;

        if (all is not { Length: > 0 })
        {
            return null;
        }
        else
        {
            var normalizedExtension =
                normalizeExtension(filePath.Extension);

            foreach (var accessor in all)
            {
                var supportedExtensions =
                    accessor.SupportedFileExtensions;

                if (supportedExtensions is { Length: > 0 })
                {
                    foreach (var supportedExtension in supportedExtensions)
                    {
                        if (normalizeExtension(supportedExtension) ==
                            normalizedExtension)
                        {
                            return accessor;
                        }
                    }
                }
            }

            // Not found.
            return null;
        }
    }

    // ------------------------------------------------------------------
    #endregion

    #region Private variables.
    // ----------------------------------------------------------------------

    private static List<IResourceFileAccessor>
        _cacheForAllAvailableResourceFileAccessors;

    // ----------------------------------------------------------------------
    #endregion

    #region Private helper.
    // ------------------------------------------------------------------

    /// <summary>
    /// Normalizes the extension.
    /// </summary>
    /// <param name="extension">The extension.</param>
    /// <returns></returns>
    private static string normalizeExtension(
        string extension)
    {
        return string.IsNullOrEmpty(extension) ? string.Empty : extension.Trim(' ', '.').ToLowerInvariant();
    }

    /// <summary>
    /// Helper.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="a">A.</param>
    private static void doGetAllTypes<T>(
        ICollection<T> list,
        Assembly a)
    {
        if (a != null)
        {
            LogCentral.Current.LogInfo(
                $@"doGetAllTypes(): Searching assembly '{a.GetName().Name}'...");

            try
            {
                var types = a.GetTypes();

                foreach (var t in types)
                {
                    var interfaceTypes = t.GetInterfaces();

                    foreach (var interfaceType in interfaceTypes)
                    {
                        if (interfaceType == typeof(T) && !t.IsAbstract)
                        {
                            // Create instance.
                            var b = (T)Activator.CreateInstance(t);

                            // Don't insert duplicates.
                            var found = false;
                            foreach (var c in list)
                            {
                                if (c.GetType() == b.GetType())
                                {
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                LogCentral.Current.LogInfo(
                                    $@"Found plug-in type '{t}'.");

                                list.Add(b);
                            }

                            break;
                        }
                    }
                }
            }
            catch (ReflectionTypeLoadException tle)
            {
                LogCentral.Current.LogInfo(
                    $@"Ignoring type load exception for assembly '{a.GetName().Name}'. " +
                    @"This usually occurs inside a web application for " +
                    @"plug-ins that are only intended for the main Windows application.",
                    tle);
            }
        }
    }

    // ------------------------------------------------------------------
    #endregion
}

/////////////////////////////////////////////////////////////////////////