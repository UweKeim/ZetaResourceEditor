namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.Import
{
    using System.Collections.Generic;

    public class ExcelImportResult
    {
        public int ImportedRowCount { get; internal set; }
        public List<string> ImportMessages { get; } = new List<string>();
    }
}