namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.CoreExcel2;

using ExcelDataReader;
using System.IO;

internal static class CoreExcelImporter
{
    public static DataSet ImportExcelFromFile(
        string filePath)
    {
        using var stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
        using var reader = ExcelReaderFactory.CreateReader(stream);
        var result = reader.AsDataSet(new()
        {
            UseColumnDataType = false,
            ConfigureDataTable = delegate { return new() { UseHeaderRow = true }; }
        });
        return result;
    }
}