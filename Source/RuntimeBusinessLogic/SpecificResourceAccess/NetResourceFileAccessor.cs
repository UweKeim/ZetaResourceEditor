namespace ZetaResourceEditor.RuntimeBusinessLogic.SpecificResourceAccess;

#region Using directives.
// ----------------------------------------------------------------------
using System.IO;
using Properties;

// ----------------------------------------------------------------------
#endregion
	
/////////////////////////////////////////////////////////////////////////

/// <summary>
/// For .NET resource files in XML format.
/// </summary>
internal class NetResourceFileAccessor :
    IResourceFileAccessor
{
    #region IResourceFileAccessor members.
    // ------------------------------------------------------------------

    /// <summary>
    /// Gets the unique class ID.
    /// </summary>
    /// <value>The unique class ID.</value>
    public Guid UniqueClassID => new( @"91680cc0-4eca-4999-bb57-d3a757bd022c" );

    /// <summary>
    /// Gets the supported file extensions. return as e.g. ".RESX".
    /// </summary>
    /// <value>The supported file extensions.</value>
    public string[] SupportedFileExtensions => new[]
    {
        @".resx",
        @".resw"
    };

    /// <summary>
    /// Gets the name. This is visible to the user.
    /// </summary>
    /// <value>The name.</value>
    public string Name => Resources.SR_NetResourceFileAccessor_Name_NETResourceFiles;

    /// <summary>
    /// Gets a value indicating whether this instance is adding of new tags 
    /// supported.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is adding of new tags supported; 
    /// otherwise, <c>false</c>.
    /// </value>
    public bool IsAddingOfNewTagsSupported => true;

    /// <summary>
    /// Loads a list of name/value pairs from the given resource file.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <returns></returns>
    public NameValuePair[] LoadFromResourceFile(
        FileInfo filePath)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Stores a list of name/value pairs to the specified resource file.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <param name="rows">The rows.</param>
    public void StoreToResourceFile(
        FileInfo filePath,
        NameValuePair[] rows )
    {
        throw new NotImplementedException();
    }

    // ------------------------------------------------------------------
    #endregion
}

/////////////////////////////////////////////////////////////////////////