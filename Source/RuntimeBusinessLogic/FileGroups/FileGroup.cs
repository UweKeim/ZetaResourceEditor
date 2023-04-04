namespace ZetaResourceEditor.RuntimeBusinessLogic.FileGroups;

using BL;
using DL;
using DynamicSettings;
using FileInformations;
using Helpers;
using Language;
using ProjectFolders;
using Projects;
using Properties;
using Runtime.FileAccess;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Translation;
using Zeta.VoyagerLibrary.Core.Common;
using Zeta.VoyagerLibrary.Core.Common.Collections;
using ZetaAsync;

/// <summary>
/// Groups multiple single files.
/// </summary>
[DebuggerDisplay(@"Name = {Name}, files = {_fileInfos.Count}")]
public class FileGroup :
    ITranslationStateInformation,
    IComparable,
    IComparable<FileGroup>,
    IUniqueID,
    IOrderPosition,
    IGridEditableData
{
    public FileGroup(Project? project)
    {
        Project = project;
    }

    private string? _name;
    private Guid _projectFolderUniqueID;
    private int _orderPosition;
    private bool _ignoreDuringExportAndImport;

    public FileInformation[] GetFileInfos()
    {
        lock (_fileInfos)
        {
            return _fileInfos.ToArray();
        }
    }

    FileInformation[]? IGridEditableData.GetFileInformationsSorted()
    {
        lock (_fileInfos)
        {
            _fileInfos.Sort();
            return _fileInfos.ToArray();
        }
    }

    public IInheritedSettings? ParentSettings
    {
        get
        {
            var projectFolder = ProjectFolder;
            var project = Project;

            if (projectFolder == null)
            {
                // When opening without a project,
                // use a dummy project.
                return project ?? Project.Empty;
            }
            else
            {
                return projectFolder;
            }
        }
    }

    public bool IgnoreDuringExportAndImport
    {
        get => _ignoreDuringExportAndImport;
        set => _ignoreDuringExportAndImport = value;
    }

    public static FileGroupStateColor TranslateStateToColorKey(
        FileGroupStates state)
    {
        switch (state)
        {
            case FileGroupStates.Empty:
                return FileGroupStateColor.Grey;
            case FileGroupStates.CompletelyTranslated:
                return FileGroupStateColor.Green;
            default:
                if ((state & FileGroupStates.FormatParameterMismatches) != 0)
                {
                    return FileGroupStateColor.Red;
                }
                else if ((state & FileGroupStates.TranslationsMissing) != 0)
                {
                    return FileGroupStateColor.Yellow;
                }
                else if ((state & FileGroupStates.AutomaticTranslationsExist) != 0)
                {
                    return FileGroupStateColor.Blue;
                }
                else
                {
                    return FileGroupStateColor.Green;
                }
        }
    }

    public static FileGroupStateColor CombineColorKeys(
        FileGroupStateColor c1,
        FileGroupStateColor c2)
    {
        if (c1 == FileGroupStateColor.None) return c2;

        switch (c2)
        {
            case FileGroupStateColor.None:
                return c1;

            case FileGroupStateColor.Grey:
                return c1;

            case FileGroupStateColor.Green:
                switch (c1)
                {
                    case FileGroupStateColor.Grey:
                    case FileGroupStateColor.Yellow:
                        return FileGroupStateColor.Yellow;
                    case FileGroupStateColor.Green:
                        return FileGroupStateColor.Green;
                    case FileGroupStateColor.Blue:
                        return FileGroupStateColor.Blue;
                    case FileGroupStateColor.Red:
                        return FileGroupStateColor.Red;

                    default:
                        throw new ArgumentException();
                }

            case FileGroupStateColor.Yellow:
                switch (c1)
                {
                    case FileGroupStateColor.Grey:
                    case FileGroupStateColor.Green:
                    case FileGroupStateColor.Yellow:
                    case FileGroupStateColor.Blue:
                        return FileGroupStateColor.Yellow;
                    case FileGroupStateColor.Red:
                        return FileGroupStateColor.Red;

                    default:
                        throw new ArgumentException();
                }

            case FileGroupStateColor.Red:
                return FileGroupStateColor.Red;

            case FileGroupStateColor.Blue:
                switch (c1)
                {
                    case FileGroupStateColor.Green:
                    case FileGroupStateColor.Blue:
                        return FileGroupStateColor.Blue;
                    case FileGroupStateColor.Grey:
                    case FileGroupStateColor.Yellow:
                        return FileGroupStateColor.Yellow;
                    case FileGroupStateColor.Red:
                        return FileGroupStateColor.Red;

                    default:
                        throw new ArgumentException();
                }
            default:
                throw new ArgumentException();
        }
    }

    public ProjectFolder? ProjectFolder
    {
        get => Project?.GetProjectFolderByUniqueID(_projectFolderUniqueID);
        set => _projectFolderUniqueID = value?.UniqueID ?? Guid.Empty;
    }

    /*
            public static FileGroup CheckCreate(
                Project project,
                string joinedFilePaths)
            {
                return string.IsNullOrEmpty(joinedFilePaths) ? new FileGroup(project) : CheckCreate(project, SplitFilePaths(joinedFilePaths));
            }
    */

    public static FileGroup CheckCreate(
        Project? project,
        string[]? filePaths)
    {
        return CheckCreate(project, filePaths.Select(filePath => new FileInfo(filePath)).ToArray());
    }

    public static FileGroup CheckCreate(
        Project? project,
        FileInfo[] filePaths)
    {
        var result = new FileGroup(project);

        if (filePaths.Length > 0)
        {
            foreach (var filePath in filePaths)
            {
                result.Add(
                    new(result)
                    {
                        File = filePath
                    });
            }
        }

        var same = project?.GetFileGroupByCheckSum(result.GetChecksum(project));

        return same ?? result;
    }

    private FileGroupStates TranslationState => _inMemoryState ?? calculateEditingState();

    public FileGroupStateColor TranslationStateColor => TranslateStateToColorKey(TranslationState);

    private FileGroupStates calculateEditingState()
    {
        var data = new DataProcessing(this);
        var table = data.GetDataTableFromResxFiles(Project);

        return DoCalculateEditingState(Project, table, CommentVisibilityScope.InMemory);
    }

    public static FileGroupStates DoCalculateEditingState(
        Project? project,
        DataTable table,
        CommentVisibilityScope commentVisibilityScope)
    {
        if (table == null)
        {
            return FileGroupStates.Empty;
        }
        else
        {
            var result = FileGroupStates.CompletelyTranslated;

            foreach (DataRow row in table.Rows)
            {
                if (IsCompleteRowEmpty(row))
                {
                    result |= FileGroupStates.EmptyRows;
                }

                if (areTranslationsMissing(project, row, commentVisibilityScope))
                {
                    result |= FileGroupStates.TranslationsMissing;
                }

                if (hasPlaceholderMismatch(project, row, commentVisibilityScope))
                {
                    result |= FileGroupStates.FormatParameterMismatches;
                }

                if (doesAutomaticTranslationsExist(project, row, commentVisibilityScope))
                {
                    result |= FileGroupStates.AutomaticTranslationsExist;
                }
            }

            return result;
        }
    }

    // AJ CHANGE
    private static bool doesAutomaticTranslationsExist(
        Project? project,
        DataRow row,
        CommentVisibilityScope commentVisibilityScope)
    {
        // Column 0=FileGroup checksum, column 1=Tag name.
        for (var i = 2;
             i < row.Table.Columns.Count -
             (DataProcessing.CommentsAreVisible(project, row, commentVisibilityScope) ? 1 : 0);
             ++i)
        {
            var s = ConvertHelper.ToString(row[i], string.Empty);
            if (s.StartsWith(DefaultTranslatedPrefix)) return true;
        }

        return false;
    }

    private static bool areTranslationsMissing(
        Project? project,
        DataRow row,
        CommentVisibilityScope commentVisibilityScope)
    {
        var hasEmpty = false;
        var hasNonEmpty = false;

        // AJ CHANGE
        // Don't check the comments column
        // Column 0=FileGroup checksum, column 1=Tag name.
        for (var i = 2;
             i < row.Table.Columns.Count -
             (DataProcessing.CommentsAreVisible(project, row, commentVisibilityScope) ? 1 : 0);
             ++i)
        {
            var s = ConvertHelper.ToString(row[i], string.Empty);

            if (string.IsNullOrEmpty(s))
            {
                hasEmpty = true;
            }
            else
            {
                hasNonEmpty = true;
            }
        }

        return hasEmpty && hasNonEmpty;
    }

    private static int findColumnIndex(
        DataTable table,
        string? columnName,
        int fallbackIndex)
    {
        if (string.IsNullOrEmpty(columnName))
        {
            return fallbackIndex;
        }
        else
        {
            foreach (DataColumn column in table.Columns)
            {
                if (column.ColumnName.EqualsNoCase(columnName))
                {
                    return column.Ordinal;
                }
            }

            return fallbackIndex;
        }
    }

    private static bool hasPlaceholderMismatch(
        Project? project,
        DataRow row,
        CommentVisibilityScope commentVisibilityScope)
    {
        // 2011-11-17, Uwe Keim.
        var neutralCode = project == null ? @"en-US" : project.NeutralLanguageCode;
        var neutralColumnIndex = findColumnIndex(row.Table, neutralCode, 2);

        var columnCount = row.Table.Columns.Count;

        var s0 =
            columnCount > 0
                // Column 0=FileGroup checksum, column 1=Tag name.
                ? ConvertHelper.ToString(row[neutralColumnIndex], string.Empty)
                : string.Empty;
        var firstPlaceholderCount = ExtractPlaceholders(s0);

        // AJ CHANGE, skip the comments column
        // Column 0=FileGroup checksum, column 1=Tag name.
        for (var i = 2;
             i < columnCount -
             (DataProcessing.CommentsAreVisible(project, row, commentVisibilityScope) ? 1 : 0);
             ++i)
        {
            if (i != neutralColumnIndex)
            {
                var s = ConvertHelper.ToString(row[i], string.Empty);

                // 2011-11-16, Uwe Keim: Only check if non-empty, non-default-language.
                if (!string.IsNullOrEmpty(s))
                {
                    var other = ExtractPlaceholders(s);

                    if (other != firstPlaceholderCount)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    public static bool IsCompleteRowEmpty(
        DataRow row)
    {
        // Column 0=FileGroup checksum, column 1=Tag name.
        for (var i = 2; i < row.Table.Columns.Count; ++i)
        {
            if (ConvertHelper.ToString(row[i], string.Empty).Trim().Length > 0)
            {
                return false;
            }
        }

        return true;
    }

    // http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx?msg=3367544#xx3367544xx
    public static bool IsInternalRow(DataRow row)
    {
        var name = row[@"Name"] as string;

        return string.IsNullOrEmpty(name) ||
               name.StartsWith(@">>") ||
               !name.Equals(@"$this.Text") && name.StartsWith(@"$this.");
    }

    public static string ExtractPlaceholders(
        string text)
    {
        if (string.IsNullOrEmpty(text) || text.IndexOf('{') < 0 ||
            text.IndexOf('}') < 0)
        {
            return string.Empty;
        }
        else
        {
            const string pattern = @"\{(\d+(:\w+)?)\}";

            var matches = Regex.Matches(
                text,
                pattern,
                RegexOptions.IgnoreCase);

            if (matches.Count <= 0)
            {
                return string.Empty;
            }
            else
            {
                var indexes = new HashSet<int>();

                foreach (Match match in matches)
                {
                    var i = match.Groups[1].Value;
                    indexes.Add(ConvertHelper.ToInt32(i));
                }

                var l = indexes.ToList();
                l.Sort();

                var result = new StringBuilder();

                foreach (var i in l)
                {
                    result.Append('-');
                    result.Append(i);
                }

                // Do not return the count but the hash to allow
                // for comparing the exact placeholders equality.
                return result.ToString();
            }
        }
    }

    public bool Contains(
        FileInformation item)
    {
        lock (_fileInfos)
        {
            return _fileInfos.Any(fileInfo => item.File.FullName.EqualsNoCase(fileInfo.File.FullName));
        }
    }

    public void Add(
        FileInformation item)
    {
        lock (_fileInfos)
        {
            if (!Contains(item))
            {
                _fileInfos.Add(item);
            }
        }
    }

    internal void StoreToXml(
        Project? project,
        XmlElement parentNode)
    {
        lock (_fileInfos)
        {
            foreach (var fileInfo in _fileInfos)
            {
                if (parentNode.OwnerDocument != null)
                {
                    var fileNode =
                        parentNode.OwnerDocument.CreateElement(@"file");
                    parentNode.AppendChild(fileNode);

                    fileInfo.StoreToXml(project, fileNode);
                }
            }
        }

        if (parentNode.OwnerDocument != null)
        {
            var a = parentNode.OwnerDocument.CreateAttribute(@"name");
            a.Value = _name;
            parentNode.Attributes.Append(a);

            a = parentNode.OwnerDocument.CreateAttribute(@"projectFolderUniqueID");
            a.Value = _projectFolderUniqueID.ToString();
            parentNode.Attributes.Append(a);

            a = parentNode.OwnerDocument.CreateAttribute(@"orderPosition");
            a.Value = OrderPosition.ToString(CultureInfo.InvariantCulture);
            parentNode.Attributes.Append(a);

            a = parentNode.OwnerDocument.CreateAttribute(@"ignoreDuringExportAndImport");
            a.Value = _ignoreDuringExportAndImport.ToString(CultureInfo.InvariantCulture);
            parentNode.Attributes.Append(a);

            var remarksNode =
                parentNode.OwnerDocument.CreateElement(@"remarks");
            parentNode.AppendChild(remarksNode);
            remarksNode.InnerText = Remarks;

            if (parentNode.OwnerDocument != null)
            {
                a = parentNode.OwnerDocument.CreateAttribute(@"uniqueID");
                a.Value = _uniqueID.ToString();
                parentNode.Attributes.Append(a);
            }
        }
    }

    internal void LoadFromXml(
        Project? project,
        XmlNode parentNode)
    {
        lock (_fileInfos)
        {
            _fileInfos.Clear();

            var fileNodes = parentNode.SelectNodes(@"file");

            if (fileNodes != null)
            {
                foreach (XmlNode fileNode in fileNodes)
                {
                    var ffi = new FileInformation(this);

                    if (ffi.LoadFromXml(project, fileNode))
                    {
                        Add(ffi);
                    }
                }
            }

            // --

            if (parentNode.Attributes != null)
            {
                XmlHelper.ReadAttribute(
                    out _uniqueID,
                    parentNode.Attributes[@"uniqueID"]);
            }

            if (_uniqueID == Guid.Empty)
            {
                _uniqueID = Guid.NewGuid();
            }

            // --

            if (parentNode.Attributes != null)
            {
                XmlHelper.ReadAttribute(
                    out _projectFolderUniqueID,
                    parentNode.Attributes[@"projectFolderUniqueID"]);

                XmlHelper.ReadAttribute(
                    out _name,
                    parentNode.Attributes[@"name"]);

                XmlHelper.ReadAttribute(
                    out _orderPosition,
                    parentNode.Attributes[@"orderPosition"]);

                XmlHelper.ReadAttribute(
                    out _ignoreDuringExportAndImport,
                    parentNode.Attributes[@"ignoreDuringExportAndImport"]);
            }

            var remarksNode = parentNode.SelectSingleNode(@"remarks");
            Remarks = remarksNode?.InnerText;

            // --

            _fileInfos.Sort();
        }
    }

    public string? GetNameIntelligent(
        Project? project)
    {
        lock (_fileInfos)
        {
            if (string.IsNullOrEmpty(_name) && _fileInfos.Count > 0)
            {
                // Try guessing several names.

                var filePath = _fileInfos[0].File;
                var folderPath = filePath.Directory;

                //CHANGED: use base name instead
                var baseName = LanguageCodeDetection.GetBaseName(project, filePath.Name);
                filePath = new(ZspPathHelper.Combine(folderPath?.FullName, baseName) ?? string.Empty);

                if ((@"Properties".EqualsNoCase(folderPath?.Name) ||
                     @"App_GlobalResources".EqualsNoCase(folderPath?.Name)) &&
                    filePath.Name.StartsWithNoCase(@"Resources."))
                {
                    var parentFolderPath = folderPath?.Parent;
                    if (parentFolderPath == null)
                    {
                        return project is not { DisplayFileGroupWithoutFolder: true }
                            ? _name
                            : ZspPathHelper.GetFileNameFromFilePath(_name);
                    }
                    else
                    {
                        //CHANGED: append fileName, otherwise name is not complete.
                        var pathToMakeRelative = ZspPathHelper.Combine(parentFolderPath.FullName, filePath.Name);
                        return
                            project is not { DisplayFileGroupWithoutFolder: true }
                                ? shortenFilePath(
                                    ZspPathHelper.GetRelativePath(
                                        project == null
                                            ? string.Empty
                                            : project.ProjectConfigurationFilePath.DirectoryName,
                                        pathToMakeRelative))
                                : filePath.Name;
                    }
                }
                else if (@"App_LocalResources".EqualsNoCase(folderPath?.Name))
                {
                    var name =
                        ZspPathHelper.GetRelativePath(
                            project == null
                                ? string.Empty
                                : project.ProjectConfigurationFilePath.DirectoryName,
                            filePath.FullName);

                    var ext = ZspPathHelper.GetExtension(name);
                    var result = name?.Substring(0, name.Length - ext?.Length ?? 0);

                    return
                        project is not { DisplayFileGroupWithoutFolder: true }
                            ? shortenFilePath(result)
                            : filePath.Name;
                }
                else
                {
                    return
                        project is not { DisplayFileGroupWithoutFolder: true }
                            ? shortenFilePath(
                                ZspPathHelper.GetRelativePath(
                                    project == null
                                        ? string.Empty
                                        : project.ProjectConfigurationFilePath.DirectoryName,
                                    filePath.FullName))
                            : filePath.Name;
                }
            }
            else
            {
                return project is not { DisplayFileGroupWithoutFolder: true }
                    ? _name
                    : ZspPathHelper.GetFileNameFromFilePath(_name);
            }
        }
    }

    public string? Name
    {
        get
        {
            lock (_fileInfos)
            {
                if (string.IsNullOrEmpty(_name) && _fileInfos.Count > 0)
                {
                    // Try guessing several names.

                    var filePath = _fileInfos[0].File;
                    var folderPath = filePath.Directory;

                    if (@"Properties".EqualsNoCase(folderPath?.Name) ||
                        @"App_GlobalResources".EqualsNoCase(folderPath?.Name))
                    {
                        var parentFolderPath = folderPath?.Parent;
                        if (parentFolderPath == null)
                        {
                            return _name;
                        }
                        else
                        {
                            return
                                ZspPathHelper.Combine(
                                    parentFolderPath.Name,
                                    folderPath.Name);
                        }
                    }
                    else if (@"App_LocalResources".EqualsNoCase(folderPath?.Name))
                    {
                        return
                            ZspPathHelper.Combine(
                                @"App_LocalResources",
                                ZspPathHelper.GetFileNameWithoutExtension(filePath.Name));
                    }
                    else
                    {
                        return filePath.Name;
                    }
                }
                else
                {
                    return _name;
                }
            }
        }
        set => _name = value;
    }

    public string? GetFullNameIntelligent(
        Project? project)
    {
        lock (_fileInfos)
        {
            return _fileInfos.Count <= 0 ? GetNameIntelligent(project) : _fileInfos[0].File.DirectoryName;
        }
    }

    public DirectoryInfo? FolderPath
    {
        get
        {
            lock (_fileInfos)
            {
                return _fileInfos.Count <= 0 ? null : _fileInfos[0].File.Directory;
            }
        }
    }

    public long GetChecksum(
        Project? project)
    {
        lock (_fileInfos)
        {
            return BuildChecksum(project, _fileInfos);
        }
    }

    public string? JoinedFilePaths => JoinFilePaths(FilePaths);

    public static string? JoinFilePaths(
        params string[]? paths)
    {
        return paths is not { Length: > 0 } ? string.Empty : string.Join(@";", paths);
    }

    public static string[]? SplitFilePaths(string paths)
    {
        return string.IsNullOrEmpty(paths) ? new string[] { } : paths.Split(';');
    }

    public string[]? FilePaths
    {
        get
        {
            lock (_fileInfos)
            {
                var xs = sortFiles(_fileInfos.ToArray());
                return xs.Select(x => x.File.FullName).ToArray();
            }
        }
    }

    public string?[]? GetLanguageCodes(
        Project? project)
    {
        var result = new HashSet<string>();

        foreach (var filePath in FilePaths)
        {
            var lc =
                new LanguageCodeDetection(project).DetectLanguageCodeFromFileName(
                    ParentSettings,
                    filePath);

            if (!string.IsNullOrEmpty(lc))
            {
                result.Add(lc.ToLowerInvariant());
            }
        }

        return result.ToArray();
    }

    public MyTuple<string, string>[]? GetLanguageCodesExtended(
        Project? project)
    {
        var result = new HashSet<MyTuple<string, string>>();

        foreach (var filePath in FilePaths)
        {
            var lc =
                new LanguageCodeDetection(project).DetectLanguageCodeFromFileName(
                    ParentSettings,
                    filePath);

            if (!string.IsNullOrEmpty(lc))
            {
                result.Add(
                    new(
                        lc.ToLowerInvariant(),
                        filePath));
            }
        }

        return result.ToArray();
    }

    public FileInformation GetFileByLanguageCode(
        Project? project,
        CultureInfo culture)
    {
        return GetFileByLanguageCode(project, culture.Name);
    }

    public FileInformation GetFileByLanguageCode(
        Project? project,
        string languageCode)
    {
        lock (_fileInfos)
        {
            foreach (var ffi in _fileInfos)
            {
                var lc = new LanguageCodeDetection(project).DetectLanguageCodeFromFileName(
                    ParentSettings,
                    ffi.File.FullName);

                if (languageCode.EqualsNoCase(lc))
                {
                    return ffi;
                }
            }

            // Not found.
            return null;
        }
    }

    public static string? DefaultTranslatedPrefix => @"####";

    public static string DefaultTranslationErrorPrefix => @"****";

    /// <summary>
    /// Gets the base name.
    /// </summary>
    /// <remarks>
    /// E.g. for:
    ///  - Main.master.resx
    ///  - Main.master.de.resx
    ///  - Main.master.en-us.resx
    /// it would be "Main.master"
    ///
    /// E.g. for:
    ///  - Properties.resx
    ///  - Properties.de.resx
    /// it would be "Properties".
    /// </remarks>
    /// <value>The base name.</value>
    public string BaseName => new LanguageCodeDetection(Project).GetBaseName(this);

    public string BaseExtension => new LanguageCodeDetection(Project).GetBaseExtension(this);

    public string BaseOptionalDefaultType => new LanguageCodeDetection(Project).GetBaseOptionalDefaultType(this);

    private string? Remarks { get; set; }

    public Guid ProjectFolderUniqueID => _projectFolderUniqueID;

    public void StoreOrderPosition(
        object threadPoolManager,
        object postExecuteCallback,
        AsynchronousMode asynchronousMode,
        object userState)
    {
        Project.MarkAsModified();
    }

    public int OrderPosition
    {
        get => _orderPosition;
        set => _orderPosition = value;
    }

    private FileGroupStates? _inMemoryState;
    private Guid _uniqueID;
    private readonly List<FileInformation> _fileInfos = new();

    public FileGroupStates InMemoryState
    {
        get => _inMemoryState.GetValueOrDefault(FileGroupStates.Empty);
        set => _inMemoryState = value;
    }

    private static IEnumerable<FileInformation> sortFiles(
        ICollection<FileInformation> filePaths)
    {
        if (filePaths == null || filePaths.Count < 2)
        {
            return filePaths;
        }
        else
        {
            var sortableP = new List<FileInformation>(filePaths);

            sortableP.Sort();

            return sortableP.ToArray();
        }
    }

    private static long BuildChecksum(
        Project? project,
        IEnumerable<FileInformation> filePaths)
    {
        long result = 0;

        if (filePaths != null)
        {
            // Clone.
            var fp = new List<FileInformation>(filePaths);

            foreach (var filePath in fp)
            {
                // Changed 2009-07-11, Uwe Keim:
                // Use relative path if available.
                var realPath =
                    project == null
                        ? filePath.File.FullName
                        : project.MakeRelativeFilePath(filePath.File.FullName);

                result += Math.Abs(realPath.ToLowerInvariant().GetHashCode());
            }
        }

        return result;
    }

    private static string? shortenFilePath(
        string? filePath)
    {
        return ShortenFilePath(filePath, 150);
    }

    public static string? ShortenFilePath(
        string? filePath,
        int maxLength)
    {
        if (string.IsNullOrEmpty(filePath) || filePath.Length <= maxLength)
        {
            return filePath;
        }
        else
        {
            return ZrePathHelper.ShortenPathName(filePath, maxLength);
        }
    }

    public int CompareTo(FileGroup other)
    {
        var a = _orderPosition.CompareTo(other._orderPosition);

        return a == 0 ? string.CompareOrdinal(Name, other.Name) : a;
    }

    public int CompareTo(object obj)
    {
        return CompareTo((FileGroup)obj);
    }

    public override bool Equals(object obj)
    {
        if (obj is FileGroup to)
        {
            var compareTo = to;

            return compareTo.GetChecksum(null) == GetChecksum(null);
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode()
    {
        return GetChecksum(null).GetHashCode();
    }

    public Guid UniqueID
    {
        get
        {
            if (_uniqueID == Guid.Empty) _uniqueID = Guid.NewGuid();
            return _uniqueID;
        }
    }

    public GridSourceType SourceType => GridSourceType.FileGroup;

    FileGroup? IGridEditableData.FileGroup => this;

    public Project? Project { get; set; }

    public int FileInfoCount
    {
        get
        {
            lock (_fileInfos)
            {
                return _fileInfos.Count;
            }
        }
    }

    public FileInformation CreateAndAddNewFile(
        string baseFolderPath,
        string? newFileName)
    {
        if (newFileName.StartsWithNoCase(BaseName) && newFileName.EndsWithNoCase(BaseExtension))
        {
            var newFilePath = ZspPathHelper.Combine(baseFolderPath, newFileName);

            // Add to myself.
            var ffi =
                new FileInformation(this)
                {
                    File = new(newFilePath ?? string.Empty)
                };
            Add(ffi);
            return ffi;
        }
        else
        {
            throw new(
                string.Format(
                    Resources.SR_FileGroup_CreateAndAddNewFile_New_file_name_does_not_match,
                    BaseName,
                    BaseExtension));
        }
    }

    public bool CreateAndAddNewFile(
        string sourceFilePath,
        string? newFileName,
        string? sourceLanguageCode,
        string? newLanguageCode,
        bool copyTextsFromSource,
        bool automaticallyTranslateTexts,
        string prefix,
        bool includeFileInCsProj,
        bool includeFileAsDependantUpon)
    {
        if (newFileName.StartsWithNoCase(BaseName) && newFileName.EndsWithNoCase(BaseExtension))
        {
            var newFilePath =
                ZspPathHelper.Combine(
                    ZspPathHelper.GetDirectoryPathNameFromFilePath(sourceFilePath),
                    newFileName);

            bool didCopy;

            if (File.Exists(newFilePath))
            {
                // Simply ignore and add.

                didCopy = false;

                // File may already exist but was not yet added
                // to the file group.

                /*
                throw new Exception(
                    string.Format(
                        "New file '{0}' already exists.",
                        newFileName));
                 */

            }
            else
            {
                // Copy only if not exists.

                File.Copy(sourceFilePath, newFilePath ?? string.Empty, false);
                didCopy = true;
            }

            // Add to myself.
            var ffi =
                new FileInformation(this)
                {
                    File = new(newFilePath ?? string.Empty)
                };
            Add(ffi);

            // --
            // Further process.

            if (includeFileInCsProj)
            {
                try
                {
                    addFileToCsProj(new(sourceFilePath), new FileInfo(newFilePath ?? string.Empty),
                        includeFileAsDependantUpon);
                }
                catch
                {
                    //Including new resource file to csproj should not break process of creating new files.
                    //To consider showing this information in any form
                }
            }

            if (!copyTextsFromSource /*&& !automaticallyTranslateTexts*/)
            {
                if (didCopy)
                {
                    clearAllTexts(ffi);
                }
            }

            if (automaticallyTranslateTexts)
            {
                if (didCopy)
                {
                    translateTexts(
                        Project,
                        ffi,
                        sourceLanguageCode,
                        newLanguageCode,
                        prefix);
                }
            }

            return didCopy;
        }
        else
        {
            throw new(
                string.Format(
                    Resources.SR_FileGroup_CreateAndAddNewFile_New_file_name_does_not_match,
                    BaseName,
                    BaseExtension));
        }
    }

    //private FileInformation getFfiForFilePath( string filePath )
    //{
    //    var fileName = Path.GetFileName( filePath );

    //    foreach ( var ffi in this )
    //    {
    //        if ( string.Compare( ffi.File.Name, fileName, true ) == 0 )
    //        {
    //            return ffi;
    //        }
    //    }

    //    return null;
    //}

    private static void addFileToCsProj(FileInfo sourceFile, FileSystemInfo newFile, bool addDependantUpon)
    {
        var newFilePath = newFile.FullName;
        var csProjWithFileResult = CsProjHelper.GetProjectContainingFile(sourceFile);
        if (csProjWithFileResult?.Project?.Items == null)
        {
            //If we are unable to find correlated csProj, we do nothing
            return;
        }

        var project = csProjWithFileResult.Project;

        if (project.Items.FirstOrDefault(i => i.EvaluatedInclude == newFilePath) == null)
        {
            var metaData = new List<KeyValuePair<string, string>>();
            if (addDependantUpon && !string.IsNullOrEmpty(csProjWithFileResult.DependantUponRootFileName))
            {
                metaData.Add(new(CsProjHelper.DependentUponLiteral,
                    csProjWithFileResult.DependantUponRootFileName));
            }

            var relativeFilePath = newFilePath.Replace(project.DirectoryPath + "\\", string.Empty);
            project.AddItem(CsProjHelper.EmbeddedResourceLiteral, relativeFilePath, metaData);
        }

        project.Save();
    }

    private void clearAllTexts(FileInformation ffi)
    {
        var tmpFileGroup = new FileGroup(Project);
        tmpFileGroup.AddFileInfo(ffi);

        var data = new DataProcessing(tmpFileGroup);
        var table = data.GetDataTableFromResxFiles(Project);

        foreach (DataRow row in table.Rows)
        {
            // Clear.
            // Column 0=FileGroup checksum, column 1=Tag name.
            row[2] = DBNull.Value;
        }

        // Write back.
        data.SaveDataTableToResxFiles(Project, table, false, false);
    }

    private void AddFileInfo(FileInformation ffi)
    {
        lock (_fileInfos)
        {
            _fileInfos.Add(ffi);
        }
    }

    private void translateTexts(
        Project? project,
        FileInformation destinationFfi,
        string? sourceLanguageCode,
        string? destinationLanguageCode,
        string prefix)
    {
        project ??= Project.Empty;
        var continueOnErrors = project.TranslationContinueOnErrors;

        var delayMilliseconds = project.TranslationDelayMilliseconds;

        var translationCount = 0;
        var translationSuccessCount = 0;
        var translationErrorCount = 0;

        // --

        var tmpFileGroup = new FileGroup(Project);
        tmpFileGroup.AddFileInfo(destinationFfi);

        var data = new DataProcessing(tmpFileGroup);
        var table = data.GetDataTableFromResxFiles(Project);

        // --

        TranslationHelper.GetTranslationAppID(project, out var appID);

        var ti = TranslationHelper.GetTranslationEngine(project);

        // 2017-03-11, Uwe Keim: Only translate if supported.
        if (ti.IsSourceLanguageSupported(appID, sourceLanguageCode) &&
            ti.IsDestinationLanguageSupported(appID, destinationLanguageCode))
        {
            var slc =
                ti.MapCultureToSourceLanguageCode(
                    appID,
                    CultureHelper.CreateCultureErrorTolerant(sourceLanguageCode));
            var dlc =
                ti.MapCultureToDestinationLanguageCode(
                    appID,
                    CultureHelper.CreateCultureErrorTolerant(destinationLanguageCode));

            // --

            foreach (DataRow row in table.Rows)
            {
                var sourceText = ConvertHelper.ToString(row[2]);

                if (!string.IsNullOrEmpty(sourceText))
                {
                    if (delayMilliseconds > 0)
                    {
                        Thread.Sleep(delayMilliseconds);
                    }

                    try
                    {
                        var destinationText =
                            prefix +
                            ti.Translate(
                                appID,
                                sourceText,
                                slc,
                                dlc,
                                project.TranslationWordsToProtect,
                                project.TranslationWordsToRemove);

                        row[2] = destinationText;

                        translationSuccessCount++;
                    }
                    catch (Exception x)
                    {
                        translationErrorCount++;

                        if (continueOnErrors)
                        {
                            var prefixError = DefaultTranslationErrorPrefix.Trim() + @" ";

                            var destinationText = prefixError + x.Message;

                            if (row[2] != DBNull.Value)
                            {
                                row[2] = destinationText;
                            }
                        }
                        else
                        {
                            throw;
                        }
                    }

                    translationCount++;
                }
            }

            // Write back.
            data.SaveDataTableToResxFiles(project, table, false, false);
        }

        LogCentral.Current.Info(
            $@"Finished translating: {nameof(translationCount)} = '{translationCount}', {nameof(translationSuccessCount)} = '{translationSuccessCount}', {nameof(translationErrorCount)} = '{translationErrorCount}'.");
    }

    public bool IsDeepChildOf(ProjectFolder folder)
    {
        var pf = ProjectFolder;
        while (pf != null)
        {
            if (pf.UniqueID == folder.UniqueID)
            {
                return true;
            }

            pf = pf.Parent;
        }

        return false;
    }

    public bool HasLanguageCode(CultureInfo cultureInfo)
    {
        var lcd = new LanguageCodeDetection(Project);

        return FilePaths
            .Select(filePath => lcd.DetectCultureFromFileName(ParentSettings, filePath))
            .Any(ci => ci.Name.EqualsNoCase(cultureInfo.Name));
    }

    public bool DeleteFile(FileInformation fileInformation)
    {
        RemoveFileInfo(fileInformation);
        fileInformation.File.SafeDelete();

        return !fileInformation.File.SafeExists();
    }

    public void RemoveFileInfo(FileInformation fileInformation)
    {
        lock (_fileInfos)
        {
            _fileInfos.Remove(fileInformation);
        }
    }

    public CsProjectWithFileResult? GetConnectedCsProject()
    {
        CsProjectWithFileResult? csProjResult = null;
        if (FilePaths is { Length: >= 2 })
        {
            var notDefaultLanguageVersion = FilePaths
                .Select(t => new
                {
                    Replaced = CsProjHelper.RegexFindMainResourceFile.Replace(t,
                        CsProjHelper.RegexFindMainResourceFileReplacePattern),
                    Original = t
                }).FirstOrDefault(t => t.Original != t.Replaced)?.Original;
            csProjResult =
                CsProjHelper.GetProjectContainingFile(new(notDefaultLanguageVersion ?? string.Empty));
        }

        return csProjResult;
    }
}