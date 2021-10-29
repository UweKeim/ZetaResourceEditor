namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.CoreExcel2;

using OfficeOpenXml;
using System.Collections.Generic;
using System.Data;
using ZetaLongPaths;

internal static class CoreExcelExporter
{
    /// <summary>
    /// We do misuse the "Namespace" column's value to indicate from outside that the column
    /// should be made read-only.
    /// </summary>
    public const string ReadOnlyFlag = @"r/o";

    public static void ExportToExcelFile(
        DataSet dataSet,
        string filePath)
    {
        var p = new ExcelPackage(new ZlpFileInfo(filePath).ToBuiltIn());

        var wb = p.Workbook;
        var loopCount = 0;
        while (wb.Worksheets.Count > 0 && loopCount++ < 100)
        {
            try
            {
                wb.Worksheets.Delete(0);
            }
            catch (KeyNotFoundException)
            {
                // Ignore.
            }

            try
            {
                wb.Worksheets.Delete(1);
            }
            catch (KeyNotFoundException)
            {
                // Ignore.
            }
        }

        foreach (DataTable table in dataSet.Tables)
        {
            var ws = wb.Worksheets.Add(table.TableName);
            processSheet(table, ws);
        }

        ZlpSafeFileOperations.SafeDeleteFile(filePath);
        p.Save();
    }

    private static void processSheet(DataTable table, ExcelWorksheet ws)
    {
        var all = ws.Cells[@"A1"].LoadFromDataTable(table, true);

        all.AutoFitColumns();

        /*
        // Make the header.

        foreach (DataColumn dataColumn in table.Columns)
        {
            var headerCell = ws.Cells[0, dataColumn.Ordinal];
            makeHeaderCell(headerCell);

            headerCell.Value = string.IsNullOrEmpty(dataColumn.Caption)
                ? dataColumn.ColumnName
                : dataColumn.Caption;
        }

        // --
        // Make the body.

        var rowIndex = 1;
        foreach (DataRow sourceRow in table.Rows)
        {
            foreach (DataColumn sourceColumn in table.Columns)
            {
                var sourceValue = sourceRow[sourceColumn];
                if (sourceValue == DBNull.Value) sourceValue = null;

                var destinationCell = ws.Cells[rowIndex, sourceColumn.Ordinal];
                destinationCell.Value = sourceValue;

                if (!string.IsNullOrEmpty(sourceColumn.Namespace) && sourceColumn.Namespace == ReadOnlyFlag)
                {
                    makeCellReadOnly(destinationCell);
                }
            }

            rowIndex++;
        }*/
    }

    private static void makeCellReadOnly(ExcelRange cell)
    {
        //cell.Style.IsLocked = true;
    }

    private static void makeHeaderCell(ExcelRange cell)
    {
        //var colorHeader = ExcelHelper.SafeExcelColors.Green;
        ////var colorOddRows = ColorTranslator.FromHtml( @"#DBE5F1" );
        //var colorLines = ExcelHelper.SafeExcelColors.Gray;
        //var colorHeaderLine = ExcelHelper.SafeExcelColors.Black;

        //cell.Style.ForegroundColor = colorHeader;
        //cell.Style.BackgroundColor = colorHeader;
        //cell.Style.Pattern = BackgroundType.Solid;

        //cell.Style.Font.Color = ExcelHelper.SafeExcelColors.White;
        //cell.Style.Font.IsBold = true;

        //cell.Style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
        //cell.Style.Borders[BorderType.BottomBorder].Color = colorHeaderLine;

        //cell.Style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
        //cell.Style.Borders[BorderType.TopBorder].Color = colorLines;
    }
}