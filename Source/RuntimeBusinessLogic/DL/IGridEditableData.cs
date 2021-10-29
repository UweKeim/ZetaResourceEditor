namespace ZetaResourceEditor.RuntimeBusinessLogic.DL;

using DynamicSettings;
using FileGroups;
using FileInformations;
using Projects;
using ZetaLongPaths;

/// <summary>
/// Something that is editable in a grid.
/// </summary>
public interface IGridEditableData
{
    GridSourceType SourceType { get; }

    /// <summary>
    /// Is NULL if no real file group.
    /// </summary>
    FileGroup FileGroup { get; }

    Project Project { get; set; }
    ZlpDirectoryInfo FolderPath { get; }

    FileInformation[] GetFileInformationsSorted();
    //void SortFileFileFileInfos();

    IInheritedSettings ParentSettings { get; }
    FileGroupStates InMemoryState { get; set; }
    string JoinedFilePaths { get; }
    string[] FilePaths { get; }
    string GetNameIntelligent(Project project);
    string GetFullNameIntelligent(Project project);
    long GetChecksum(Project project);
    string[] GetLanguageCodes(Project project);
}