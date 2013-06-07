namespace ZetaResourceEditor.RuntimeBusinessLogic.SpecificResourceAccess
{
	#region Using directives.
	// ----------------------------------------------------------------------
	using System;
	using Properties;
	using ZetaLongPaths;

	// ----------------------------------------------------------------------
	#endregion
	
	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// For Qt resource files in XML format.
	/// </summary>
	internal class QTResourceFileAccessor :
		IResourceFileAccessor
	{
		#region IResourceFileAccessor members.
		// ------------------------------------------------------------------

		/// <summary>
		/// Gets the unique class ID.
		/// </summary>
		/// <value>The unique class ID.</value>
		public Guid UniqueClassID
		{
			get
			{
				return new Guid( @"f5831289-8a27-45a0-a869-d74268e12ed6" );
			}
		}

		/// <summary>
		/// Gets the supported file extensions. return as e.g. ".RESX".
		/// </summary>
		/// <value>The supported file extensions.</value>
		public string[] SupportedFileExtensions
		{
			get
			{
				return new[]
					{
						@".ts"
					};
			}
		}

		/// <summary>
		/// Gets the name. This is visible to the user.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get
			{
				return Resources.SR_QTResourceFileAccessor_Name_QTResourceFiles;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this instance is adding of new tags 
		/// supported.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance is adding of new tags supported; 
		/// otherwise, <c>false</c>.
		/// </value>
		public bool IsAddingOfNewTagsSupported
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		/// Loads a list of name/value pairs from the given resource file.
		/// </summary>
		/// <param name="filePath">The file path.</param>
		/// <returns></returns>
		public NameValuePair[] LoadFromResourceFile(
			ZlpFileInfo filePath)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Stores a list of name/value pairs to the specified resource file.
		/// </summary>
		/// <param name="filePath">The file path.</param>
		/// <param name="rows">The rows.</param>
		public void StoreToResourceFile(
			ZlpFileInfo filePath, 
			NameValuePair[] rows )
		{
			throw new NotImplementedException();
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}