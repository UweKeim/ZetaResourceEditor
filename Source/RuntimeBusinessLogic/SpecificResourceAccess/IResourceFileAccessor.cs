namespace ZetaResourceEditor.RuntimeBusinessLogic.SpecificResourceAccess;

#region Using directives.
// ----------------------------------------------------------------------
using System;
using ZetaLongPaths;

// ----------------------------------------------------------------------
#endregion

/////////////////////////////////////////////////////////////////////////

/// <summary>
/// Interface to read from resource files and write to resource files.
/// </summary>
internal interface IResourceFileAccessor
{
    #region Interface members.
    // ------------------------------------------------------------------

    /// <summary>
    /// Gets the unique class ID.
    /// </summary>
    /// <value>The unique class ID.</value>
    Guid UniqueClassID
    {
        get;
    }

    /// <summary>
    /// Gets the supported file extensions. return as e.g. ".RESX".
    /// </summary>
    /// <value>The supported file extensions.</value>
    string[] SupportedFileExtensions
    {
        get;
    }

    /// <summary>
    /// Gets the name. This is visible to the user.
    /// </summary>
    /// <value>The name.</value>
    string Name
    {
        get;
    }

    /// <summary>
    /// Gets a value indicating whether this instance is adding of new tags 
    /// supported.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is adding of new tags supported; 
    /// otherwise, <c>false</c>.
    /// </value>
    bool IsAddingOfNewTagsSupported
    {
        get;
    }

    /// <summary>
    /// Loads a list of name/value pairs from the given resource file.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <returns></returns>
    NameValuePair[] LoadFromResourceFile(
        ZlpFileInfo filePath);

    /// <summary>
    /// Stores a list of name/value pairs to the specified resource file.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <param name="rows">The rows.</param>
    void StoreToResourceFile(
        ZlpFileInfo filePath,
        NameValuePair[] rows );

    // ------------------------------------------------------------------
    #endregion
}

/////////////////////////////////////////////////////////////////////////