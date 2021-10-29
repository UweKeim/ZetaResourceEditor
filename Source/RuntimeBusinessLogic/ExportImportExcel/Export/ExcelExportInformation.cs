namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.Export;

using FileGroups;
using Projects;

public class ExcelExportInformation
{
    public Project Project { get; set; }
    public FileGroup[] FileGroups { get; set; }

    public string ReferenceLanguageCode { get; set; }
    public string[] DestinationLanguageCodes { get; set; }

    public string DestinationFilePath { get; set; }

    public bool EliminateDuplicateRows { get; set; }
    public bool OnlyExportRowsWithNoTranslation { get; set; }
    public bool ExportCompletelyEmptyRows { get; set; }
    public bool OnlyExportRowsWithChangedTexts { get; set; }

    public enum ExportFileGroupMode
    {
        AllGroupsIntoOneWorksheet,
        EachGroupIntoSeparateWorksheet,
        OneExcelFilePerGroup
    }

    public ExportFileGroupMode ExportAllGroupsMode { get; set; }

    public bool ExportFileGroupColumn { get; set; }

    public bool ExportNameColumn { get; set; }

    public bool ExportCommentColumn { get; set; }

    public bool ExportEachLanguageIntoSeparateExcelFile { get; set; }

    public bool UseCrypticExcelExportSheetNames { get; set; }

    public bool ExportReferenceLanguageColumn { get; set; }
}