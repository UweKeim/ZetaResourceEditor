namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.Import
{
    #region Using directives.
    // ----------------------------------------------------------------------

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using BL;
    using CoreExcel;
    using DynamicSettings;
    using Export;
    using FileGroups;
    using Language;
    using Projects;
    using Properties;
    using Runtime;
    using Runtime.FileAccess;
    using Zeta.EnterpriseLibrary.Common;
    using Zeta.EnterpriseLibrary.Common.Collections;
    using Zeta.EnterpriseLibrary.Tools;
    using ZetaLongPaths;

    // ----------------------------------------------------------------------
    #endregion

    public class ExcelImportController
    {
        private ExcelImportInformation _information;

        public void Prepare(
            ExcelImportInformation information)
        {
            _information = information;
        }

        public static FileGroup[] DetectFileGroupsFromExcelFile(
            Project project,
            string filePath)
        {
            if (string.IsNullOrEmpty(filePath) ||
                (
                StringExtensionMethods.ToLowerInvariantIntelligent(ZlpPathHelper.GetExtension(filePath)) != @".xls" &&
                StringExtensionMethods.ToLowerInvariantIntelligent(ZlpPathHelper.GetExtension(filePath)) != @".xlsx"
                )
                ||
                !ZlpIOHelper.FileExists(filePath))
            {
                return null;
            }
            else
            {
                using (var tfc = new TemporaryFileCloner(filePath))
                {
                    var ds = CoreExcelImporter.ImportExcelFromFile(tfc.FilePath);

                    return detectFileGroupsFromWorkbook(project, ds);
                }
            }
        }

        private static FileGroup[] detectFileGroupsFromWorkbook(
            Project project,
            DataSet dataSet)
        {
            var result = new List<FileGroup>();

            var checkSums = new Set<long>();

            foreach (DataTable table in dataSet.Tables)
            {
                int totalChecksumRows;
                var ix = extractColumnCheckSums(table, out totalChecksumRows);
                foreach (var pair in ix)
                {
                    checkSums.Add(pair.First);
                }
            }

            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (var checkSum in checkSums)
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                var group = getFileGroupForCheckSum(project, checkSum);

                if (group != null)
                {
                    if (!group.IgnoreDuringExportAndImport &&
                        (group.ParentSettings == null || !group.ParentSettings.EffectiveIgnoreDuringExportAndImport))
                    {
                        result.Add(group);
                    }
                }
            }

            return result.ToArray();
        }

        private static List<Pair<long, int>> extractColumnCheckSums(
            DataTable table,
            out int totalChecksumRows)
        {
            totalChecksumRows = 0;
            var result = new List<Pair<long, int>>();

            if (table.Columns.Count >= 1)
            {
                for (var rowIndex = 0/*1*/; rowIndex < table.Rows.Count; rowIndex++)
                {
                    // Could have column 0 or column 1 (or none at all) as the checksum.
                    for (var columnIndex = 0; columnIndex < 2; ++columnIndex)
                    {
                        var cellValue = ConvertHelper.ToString(table.Rows[rowIndex][columnIndex]);

                        // First blank line to stop.
                        if (string.IsNullOrEmpty(cellValue))
                        {
                            break;
                        }
                        else
                        {
                            var checkSum = ConvertHelper.ToInt64(cellValue);
                            if (checkSum > 0)
                            {
                                totalChecksumRows++;
                                var found = false;

                                // ReSharper disable LoopCanBeConvertedToQuery
                                foreach (var pair in result)
                                // ReSharper restore LoopCanBeConvertedToQuery
                                {
                                    if (pair.First == checkSum)
                                    {
                                        found = true;
                                        break;
                                    }
                                }

                                if (!found)
                                {
                                    result.Add(new Pair<long, int>(checkSum, columnIndex));
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }

        private static FileGroup getFileGroupForCheckSum(
            Project project,
            long checkSum)
        {
            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (var fileGroup in project.FileGroups)
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                if (fileGroup.GetChecksum(project) == checkSum)
                {
                    return fileGroup;
                }
            }

            return null;
        }

        public static string[] DetectLanguagesFromExcelFile(
            string filePath)
        {
            if (string.IsNullOrEmpty(filePath) ||
                (
                StringExtensionMethods.ToLowerInvariantIntelligent(ZlpPathHelper.GetExtension(filePath)) != @".xls" &&
                StringExtensionMethods.ToLowerInvariantIntelligent(ZlpPathHelper.GetExtension(filePath)) != @".xlsx"
                ) ||
                !ZlpIOHelper.FileExists(filePath))
            {
                return null;
            }
            else
            {
                using (var tfc = new TemporaryFileCloner(filePath))
                {
                    var wb = CoreExcelImporter.ImportExcelFromFile(tfc.FilePath);
                    return detectLanguagesFromWorkbook(wb);
                }
            }
        }

        private static string[] detectLanguagesFromWorkbook(
            DataSet dataSet)
        {
            var result = new Set<string>();

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (var pair in dectectLanguageCodesFromTable(table))
                {
                    result.Add(pair.First);
                }
            }

            return result.ToArray();
        }

        private static List<Pair<string, int>> dectectLanguageCodesFromTable(
            DataTable table)
        {
            // Make no Set type to keep order.
            var result = new List<Pair<string, int>>();

            // --
            // Header.

            const int columnStartIndex = 0;

            for (var columnIndex = columnStartIndex + 0; columnIndex < table.Columns.Count; ++columnIndex)
            {
                var languageCode = string.IsNullOrEmpty(table.Columns[columnIndex].Caption)
                                       ? table.Columns[columnIndex].ColumnName
                                       : table.Columns[columnIndex].Caption;

                if (languageCode != Resources.SR_CommandProcessorSend_Process_Name &&
                    languageCode != Resources.SR_CommandProcessorSend_Process_Comment &&
                    languageCode != Resources.SR_CommandProcessorSend_Process_Group)
                {
                    if (string.IsNullOrEmpty(languageCode) ||
                        languageCode.Trim().Length <= 0)
                    {
                        break;
                    }
                    else
                    {
                        var lc = StringExtensionMethods.ToLowerInvariantIntelligent(languageCode.Trim());
                        if (LanguageCodeDetection.IsValidCultureName(lc))
                        {
                            var found = false;

                            // ReSharper disable LoopCanBeConvertedToQuery
                            foreach (var pair in result)
                            // ReSharper restore LoopCanBeConvertedToQuery
                            {
                                if (pair.First == lc)
                                {
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                result.Add(new Pair<string, int>(lc, columnIndex));
                            }
                        }
                    }
                }
            }

            return result;
        }

        public ExcelImportResult Process(
            BackgroundWorker bw)
        {
            using (var tfc = new TemporaryFileCloner(_information.SourceFilePath))
            {
                var dataSet = CoreExcelImporter.ImportExcelFromFile(tfc.FilePath);

                var result = new ExcelImportResult();

                var tableIndex = 0;
                foreach (DataTable table in dataSet.Tables)
                {
                    if (bw.CancellationPending)
                    {
                        throw new OperationCanceledException();
                    }

                    processTableFileIntelligent(
                        result,
                        tableIndex,
                        dataSet,
                        table,
                        bw);

                    tableIndex++;
                }

                return result;
            }
        }

        private void processTableFileIntelligent(
            ExcelImportResult result,
            int tableIndex,
            DataSet dataSet,
            DataTable table,
            BackgroundWorker bw)
        {
            var sourceRows = table.Rows;
            var sourceRowCount = table.Rows.Count;

            var checksumColumnIndex = getChecksumTableColumnIndex(table);
            var nameColumnIndex = getNameTableColumnIndex(table);

            int referenceLanguageColumnIndex;
            string referenceLanguageName;
            getReferenceLanguageTableColumnIndex(
                table,
                out referenceLanguageColumnIndex,
                out referenceLanguageName);

            var hasChecksumColumn = checksumColumnIndex >= 0;
            var hasNameColumn = nameColumnIndex >= 0;
            var hasReferenceLanguageColumn = referenceLanguageColumnIndex >= 0;

            // --

            var fgCache = new Dictionary<Guid, DBFileGroupCacheHelper>();

            for (var sourceRowIndex = 0; sourceRowIndex < sourceRowCount; ++sourceRowIndex)
            {
                // Need to process all file groups if not has any specified.
                var fileGroups =
                    _information.HasFileGroups
                        ? _information.FileGroups
                        : _information.Project.FileGroups.ToArray();

                foreach (var fileGroup in fileGroups)
                {
                    var checksum = fileGroup.GetChecksum(_information.Project);

                    // --

                    DBFileGroupCacheHelper ch;

                    if (!fgCache.TryGetValue(fileGroup.UniqueID, out ch))
                    {
                        ch = new DBFileGroupCacheHelper
                                {
                                    DB = new DataProcessing(fileGroup)
                                };

                        ch.Table = ch.DB.GetDataTableFromResxFiles(_information.Project);

                        fgCache[fileGroup.UniqueID] = ch;
                    }

                    // --

                    foreach (var languageCode in _information.LanguageCodes)
                    {
                        // UI progress and cancelation handling.
                        if ((sourceRowIndex + 1) % 20 == 0)
                        {
                            if (bw.CancellationPending)
                            {
                                throw new OperationCanceledException();
                            }

                            bw.ReportProgress(
                                0,
                                string.Format(
                                    Resources.SR_CommandProcessorReceive_Process_ProcessingWorkSheetOfRowOf,
                                    tableIndex + 1,
                                    dataSet.Tables.Count,
                                    sourceRowIndex + 1,
                                    sourceRowCount,
                                    (int)
                                    (((sourceRowIndex + 1.0) /
                                      (table.Rows.Count) *
                                      ((tableIndex + 1.0) /
                                       (dataSet.Tables.Count))) * 100)));
                        }

                        // --

                        var destinationTableColumnIndex =
                            getDestinationTableColumnIndex(
                                fileGroup.ParentSettings,
                                ch.Table,
                                languageCode);

                        // Column 0=FileGroup checksum, column 1=Tag name.
                        if (destinationTableColumnIndex > 1)
                        {
                            // We now have multiple possible options, based on the
                            // source lookup information provided. A maximum number
                            // of provided source information is:
                            //
                            //     - A file group checksum column.
                            //     - A name column.
                            //     - A reference language column.
                            //
                            // These information are calculated above. Decide now
                            // which actually to use.

                            var passedChecksum =
                                hasChecksumColumn &&
                                checksum == ConvertHelper.ToInt64(sourceRows[sourceRowIndex][checksumColumnIndex]) ||
                                !hasChecksumColumn;

                            if (passedChecksum)
                            {
                                List<DataRow> destinationRows;

                                if (hasNameColumn)
                                {
                                    var tagName =
                                        ConvertHelper.ToString(sourceRows[sourceRowIndex][nameColumnIndex]);

                                    if (string.IsNullOrEmpty(tagName))
                                    {
                                        // Skip empty table rows.
                                        destinationRows = null;
                                    }
                                    else
                                    {
                                        var destinationColumnIndex =
                                            getDestinationTableColumnIndex(
                                                fileGroup.ParentSettings,
                                                ch.Table,
                                                hasReferenceLanguageColumn
                                                    ? referenceLanguageName
                                                    : _information.Project.NeutralLanguageCode);

                                        destinationRows =
                                            getDestinationTableRowsByTagName(
                                                ch.Table,
                                                tagName,
                                                hasChecksumColumn,
                                                languageCode,
                                                destinationColumnIndex);
                                    }
                                }
                                else if (hasReferenceLanguageColumn)
                                {
                                    var refLanguageValue =
                                        ConvertHelper.ToString(
                                            sourceRows[sourceRowIndex][referenceLanguageColumnIndex]);

                                    if (string.IsNullOrEmpty(refLanguageValue))
                                    {
                                        // Skip empty table rows.
                                        destinationRows = null;
                                    }
                                    else
                                    {
                                        var refLanguageDestinationColumnIndex =
                                            getDestinationTableColumnIndex(
                                                fileGroup.ParentSettings,
                                                ch.Table,
                                                referenceLanguageName);

                                        // 2011-01-24, Uwe Keim:
                                        // If for one file, the language does not exist, simply skip.
                                        if (refLanguageDestinationColumnIndex < 0)
                                        {
                                            destinationRows = null;
                                        }
                                        else
                                        {
                                            destinationRows =
                                                getDestinationTableRowsByReferenceLanguageValue(
                                                    ch.Table,
                                                    refLanguageValue,
                                                    refLanguageDestinationColumnIndex,
                                                    hasChecksumColumn);
                                        }
                                    }
                                }
                                else
                                {
                                    throw new Exception(
                                        Resources.ExcelImportController_processWorkSheetFileIntelligent_Neither_name_column_nor_reference_language_column_present_);
                                }

                                // --

                                if (destinationRows != null && destinationRows.Count > 0)
                                {
                                    foreach (var row in destinationRows)
                                    {
                                        var tableSourceColumnIndex =
                                            getTableColumnIndex(table, languageCode);

                                        var sourceValue =
                                            ConvertHelper.ToString(
                                                sourceRows[sourceRowIndex][tableSourceColumnIndex],
                                                string.Empty);

                                        if (!string.IsNullOrEmpty(sourceValue))
                                        {
                                            var originalValue =
                                                ConvertHelper.ToString(
                                                    row[destinationTableColumnIndex],
                                                    string.Empty);

                                            if (originalValue != sourceValue)
                                            {
                                                row[destinationTableColumnIndex] = sourceValue;
                                                result.ImportedRowCount++;
                                                ch.HasAnychanges = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // --

            var saveCount = 0;
            var saveIndex = 0;

            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (var p in fgCache)
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                saveCount += p.Value.HasAnychanges ? 1 : 0;
            }

            foreach (var ch in fgCache)
            {
                if (ch.Value.HasAnychanges)
                {
                    bw.ReportProgress(
                        0,
                        string.Format(
                            Resources.ExcelImportController_processWorkSheetFileIntelligent_Saving_file__0__of__1____,
                            saveIndex + 1,
                            saveCount));

                    ch.Value.DB.SaveDataTableToResxFiles(_information.Project, ch.Value.Table);
                    saveIndex++;
                }
            }
        }

        private static void getReferenceLanguageTableColumnIndex(
            DataTable table,
            out int referenceLanguageColumnIndex,
            out string referenceLanguageName)
        {
            var languageCodes = dectectLanguageCodesFromTable(table);

            if (languageCodes.Count <= 1)
            {
                // Only one language; this cannot be the reference language.
                referenceLanguageName = null;
                referenceLanguageColumnIndex = -1;
            }
            else
            {
                referenceLanguageName = languageCodes[0].First;
                referenceLanguageColumnIndex = languageCodes[0].Second;
            }
        }

        private static int getNameTableColumnIndex(
            DataTable table)
        {
            // For now, use "poor-man's-check" by simply looking which
            // header column contains "Name". 
            // Later, iterate all file groups and check for a reasonable
            // amout of matching file group tag names with Excel worksheet
            // column values.

            // --
            // Header.

            const int columnStartIndex = 0;

            for (var columnIndex = columnStartIndex + 0; columnIndex < table.Columns.Count; ++columnIndex)
            {
                var headerCaption = string.IsNullOrEmpty(table.Columns[columnIndex].Caption)
                                        ? table.Columns[columnIndex].ColumnName
                                        : table.Columns[columnIndex].Caption;

                if (string.Compare(headerCaption, Resources.SR_CommandProcessorSend_Process_Name, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return columnIndex;
                }
            }

            // --

            // Not found.
            return -1;
        }

        private static int getChecksumTableColumnIndex(
            DataTable table)
        {
            int totalChecksumRows;
            var ps = extractColumnCheckSums(table, out totalChecksumRows);

            if (ps.Count <= 0 || totalChecksumRows != table.Rows.Count - 1)
            {
                return -1;
            }
            else
            {
                return ps[0].Second;
            }
        }

        private int getDestinationTableColumnIndex(
            IInheritedSettings settings,
            DataTable dataTable,
            string languageCode)
        {
            var columnIndex = 0;
            foreach (DataColumn column in dataTable.Columns)
            {
                if (columnIndex > 1) // Column 0=FileGroup checksum, column 1=Tag name.
                {
                    var lc =
                        ExcelExportController.IsFileName(column.ColumnName)
                            ? new LanguageCodeDetection(
                                _information.Project)
                                .DetectLanguageCodeFromFileName(
                                    settings,
                                    column.ColumnName)
                            : column.ColumnName;

                    if (string.Compare(lc, languageCode, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        return column.Ordinal;
                    }
                }

                columnIndex++;
            }

            // --
            // 2011-01-24, Uwe Keim: No direct (like "en-US") found, try fuzzy (like "en").

            columnIndex = 0;
            foreach (DataColumn column in dataTable.Columns)
            {
                if (columnIndex > 1) // Column 0=FileGroup checksum, column 1=Tag name.
                {
                    var lc =
                        ExcelExportController.IsFileName(column.ColumnName)
                            ? new LanguageCodeDetection(
                                _information.Project)
                                .DetectLanguageCodeFromFileName(
                                    settings,
                                    column.ColumnName)
                            : column.ColumnName;

                    if (lc.StartsWith(languageCode, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return column.Ordinal;
                    }
                }

                columnIndex++;
            }

            // --

            return -1;
        }

        private static List<DataRow> getDestinationTableRowsByTagName(
            DataTable table,
            string tagName,
            bool allowCreateNewIfNotFound,
            string languageValueForNewRow,
            int destinationColumnIndex)
        {
            if (string.IsNullOrEmpty(tagName))
            {
                throw new ArgumentException(
                    Resources.ExcelImportController_getDestinationTableRowsByTagName_Reference_tag_name_must_be_provided_but_is_currently_NULL_or_empty_,
                    @"tagName");
            }
            else
            {
                var result = new List<DataRow>();

                // --

                // ReSharper disable LoopCanBeConvertedToQuery
                foreach (DataRow row in table.Rows)
                // ReSharper restore LoopCanBeConvertedToQuery
                {
                    var lk = ConvertHelper.ToString(row[1]); // Column 0=FileGroup checksum, column 1=Tag name.

                    if (string.Compare(lk, tagName, StringComparison.OrdinalIgnoreCase) == 0 &&
                        !FileGroup.IsInternalRow(row))
                    {
                        result.Add(row);
                    }
                }

                // --
                // Create new.

                if (result.Count <= 0 && allowCreateNewIfNotFound)
                {
                    var nr = table.NewRow();
                    nr[0] = string.Empty; // Column 0=FileGroup checksum, column 1=Tag name.
                    nr[1] = tagName; // Column 0=FileGroup checksum, column 1=Tag name.
                    nr[destinationColumnIndex] = languageValueForNewRow;
                    table.Rows.Add(nr);

                    result.Add(nr);
                }

                // --

                return result;
            }
        }

        private static List<DataRow> getDestinationTableRowsByReferenceLanguageValue(
            DataTable table,
            string referenceLanguageValue,
            int referenceLanguageDestinationColumnIndex,
            bool allowCreateNewIfNotFound)
        {
            if (string.IsNullOrEmpty(referenceLanguageValue))
            {
                throw new ArgumentException(
                    Resources.SR_CommandProcessorReceive_getTableRows_Reference_language_value,
                    @"referenceLanguageValue");
            }
            else
            {
                var result = new List<DataRow>();

                // --

                // ReSharper disable LoopCanBeConvertedToQuery
                foreach (DataRow row in table.Rows)
                // ReSharper restore LoopCanBeConvertedToQuery
                {
                    var lk = ConvertHelper.ToString(row[referenceLanguageDestinationColumnIndex]);
                    if (string.Compare(lk, referenceLanguageValue, StringComparison.OrdinalIgnoreCase) == 0 &&
                        !FileGroup.IsInternalRow(row))
                    {
                        result.Add(row);
                    }
                }

                // --
                // Create new.

                if (result.Count <= 0 && allowCreateNewIfNotFound)
                {
                    var nr = table.NewRow();
                    nr[0] = string.Empty; // Column 0=FileGroup checksum, column 1=Tag name.
                    nr[1] = StringHelper.GenerateMatchCode(referenceLanguageValue); // Column 0=FileGroup checksum, column 1=Tag name.
                    nr[referenceLanguageDestinationColumnIndex] = referenceLanguageValue;
                    table.Rows.Add(nr);

                    result.Add(nr);
                }

                // --

                return result;
            }
        }

        private static int getTableColumnIndex(
            DataTable table,
            string languageCode)
        {
            foreach (DataColumn column in table.Columns)
            {
                var lc = string.IsNullOrEmpty(column.Caption) ? column.ColumnName : column.Caption;
                if (string.Compare(lc, languageCode, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return column.Ordinal;
                }
            }

            return -1;
        }

        private class DBFileGroupCacheHelper
        {
            public DataProcessing DB { get; set; }
            public DataTable Table { get; set; }
            public bool HasAnychanges { get; set; }
        }
    }
}