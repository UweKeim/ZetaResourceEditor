namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.Import;

public class ExcelImportResult
{
    public int ImportedRowCount { get; internal set; }
    public List<string> ImportMessages { get; } = new();
}