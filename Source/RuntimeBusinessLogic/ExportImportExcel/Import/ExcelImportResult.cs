namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.Import
{
    using System.Collections.Generic;

    public class ExcelImportResult
    {
        private readonly List<string> _importMessages = new List<string>();

        public int ImportedRowCount { get; internal set; }
        public List<string> ImportMessages { get { return _importMessages; } }
    }
}