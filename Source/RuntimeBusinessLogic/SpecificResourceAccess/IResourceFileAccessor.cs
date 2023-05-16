namespace ZetaResourceEditor.RuntimeBusinessLogic.SpecificResourceAccess;
/// <summary>
/// Interface to read from resource files and write to resource files.
/// </summary>
internal interface IResourceFileAccessor
{
	string[] SupportedFileExtensions { get; }
	string Name { get; }
}