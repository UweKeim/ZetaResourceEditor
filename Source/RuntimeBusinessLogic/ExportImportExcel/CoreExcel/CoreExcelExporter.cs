namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.CoreExcel
{
    using System;
    using System.Data;
    using ExcelLibrary.SpreadSheet;
    using Zeta.EnterpriseLibrary.Common.IO;

    /// <summary>
    /// 2013-06-09, Uwe Keim:
    /// This class encapsulates the writing of Excel documents. The interface is standard DataSet/DataTable
    /// to keep the implementation hidden and enable it to be changed anytime.
    /// </summary>
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
            if (!filePath.EndsWith(@".xls", StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception("Currently only XLS (i.e. not XLSX) is supported when writing Excel files.");
            }

            var wb = new Workbook();
            wb.Worksheets.Clear();

            foreach (DataTable table in dataSet.Tables)
            {
                var ws = new Worksheet(table.TableName);
                wb.Worksheets.Add(ws);
                processSheet(table, ws);
            }

            SafeFileOperations.SafeDeleteFile(filePath);
            wb.Save(filePath);
        }

        private static void processSheet(DataTable table, Worksheet ws)
        {
            // Make the header.

            foreach (DataColumn dataColumn in table.Columns)
            {
                var headerCell = new Cell(string.IsNullOrEmpty(dataColumn.Caption)
                                              ? dataColumn.ColumnName
                                              : dataColumn.Caption,
                                          CellFormat.General);
                makeHeaderCell(headerCell);
                ws.Cells[0, dataColumn.Ordinal] = headerCell;
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

                    var destinationCell = new Cell(sourceValue);
                    ws.Cells[rowIndex, sourceColumn.Ordinal] = destinationCell;

                    if (!string.IsNullOrEmpty(sourceColumn.Namespace) && sourceColumn.Namespace == ReadOnlyFlag)
                    {
                        makeCellReadOnly(destinationCell);
                    }
                }

                rowIndex++;
            }
        }

        private static void makeCellReadOnly(Cell cell)
        {
            //cell.Style.IsLocked = true;
        }

        private static void makeHeaderCell(Cell cell)
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
}