namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.Import;

using FileGroups;
using Projects;

public class ExcelImportInformation
{
    public Project? Project { get; set; }
    public FileGroup[] FileGroups { get; set; }

    public string?[] LanguageCodes { get; set; }
    public string SourceFilePath { get; set; }

    public bool HasFileGroups => FileGroups is { Length: > 0 };
}