namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.CoreExcel2
{
    using System;
    using System.Data;
    using Net.SourceForge.Koogra.Excel2007;

    internal static class CoreExcelImporter
    {
        public static DataSet ImportExcelFromFile(
            string filePath)
        {
            var wb = new Workbook(filePath);

            var ds = new DataSet();

            var wss = wb.GetWorksheets();
            foreach (var ws in wss)
            {
                ds.Tables.Add(createDataTable(ws));
            }

            return ds;
        }

        private static DataTable createDataTable(Worksheet ws)
        {
            var dtResult = new DataTable();
            var cols = Convert.ToInt32(ws.CellMap.LastCol - ws.CellMap.FirstCol) + 1;
            var colsDefined = false;

            for (var row = ws.CellMap.FirstRow; row <= ws.CellMap.LastRow; row++)
            {
                var data = new object[cols];
                var pos = 0;
                
                for (var col = ws.CellMap.FirstCol; col <= ws.CellMap.LastCol; col++)
                {
                    if (colsDefined)
                    {
                        data[pos] = ws?.GetRow(row)?.GetCell(col)?.Value;
                        pos++;
                    }
                    else
                    {
                        var dc = dtResult.Columns.Add();
                        dc.ColumnName = ws?.GetRow(row)?.GetCell(col)?.Value?.ToString()?? dc.ColumnName;
                    }
                }

                if (pos > 0)
                {
                    dtResult.LoadDataRow(data, true);
                }
                else
                {
                    colsDefined = true;
                }
            }
            return dtResult;
        }
    }
}