namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.CoreExcel
{
    using ExcelLibrary;
    using System.Data;

    /// <summary>
    /// 2013-06-09, Uwe Keim:
    /// This class encapsulates the reading of Excel documents. The interface is standard DataSet/DataTable
    /// to keep the implementation hidden and enable it to be changed anytime.
    /// </summary>
    internal static class CoreExcelImporter
    {
        public static DataSet ImportExcelFromFile(
            string filePath)
        {
            var result = DataSetHelper.CreateDataSet(filePath);
            return result;
        }
    }
}