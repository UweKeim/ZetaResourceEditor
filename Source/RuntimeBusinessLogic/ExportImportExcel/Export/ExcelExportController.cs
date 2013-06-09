namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.Export
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using BL;
    using CoreExcel;
    using DynamicSettings;
    using FileGroups;
    using Language;
    using Projects;
    using Properties;
    using Runtime;
    using Runtime.FileAccess;
    using Snapshots;
    using WebServices;
    using Zeta.EnterpriseLibrary.Common;
    using Zeta.EnterpriseLibrary.Common.Collections;
    using Zeta.EnterpriseLibrary.Common.IO.Compression;
    using ZetaLongPaths;
    using ZetaUploader;

    public class ExcelExportController
    {
        private PreparedInformationCollection _preparedInformations;

        public void Prepare(
            ExcelExportInformation information)
        {
            var preparedInformations = new PreparedInformationCollection(information);

            // --

            var oneExcelFilePerGroup =
                information.ExportAllGroupsMode ==
                ExcelExportInformation.ExportFileGroupMode.OneExcelFilePerGroup;
            var oneExcelFilePerLanguage =
                information.ExportEachLanguageIntoSeparateExcelFile;

            if (oneExcelFilePerGroup || oneExcelFilePerLanguage)
            {
                // Multiple files.

                if (oneExcelFilePerGroup && oneExcelFilePerLanguage)
                {
                    // ReSharper disable LoopCanBeConvertedToQuery
                    foreach (var fileGroup in information.FileGroups)
                    // ReSharper restore LoopCanBeConvertedToQuery
                    {
                        // ReSharper disable LoopCanBeConvertedToQuery
                        foreach (var destinationLanguageCode in information.DestinationLanguageCodes)
                        // ReSharper restore LoopCanBeConvertedToQuery
                        {
                            preparedInformations.Add(
                                new PreparedInformation
                                    {
                                        DestinationFilePath =
                                            replacePlaceholders(
                                                replacePlaceholders(information.DestinationFilePath, destinationLanguageCode),
                                                fileGroup),
                                        DestinationLanguageCodes = new[] { destinationLanguageCode },
                                        EliminateDuplicateRows = information.EliminateDuplicateRows,
                                        ExportAllGroups =
                                            information.ExportAllGroupsMode ==
                                            ExcelExportInformation.ExportFileGroupMode.AllGroupsIntoOneWorksheet,
                                        ExportNameColumn = information.ExportNameColumn,
                                        ExportCommentColumn = information.ExportCommentColumn,
                                        ExportReferenceLanguageColumn = information.ExportReferenceLanguageColumn,
                                        ExportFileGroupColumn = information.ExportFileGroupColumn,
                                        UseCrypticExcelExportSheetNames = information.UseCrypticExcelExportSheetNames,
                                        FileGroups = new[] { fileGroup },
                                        OnlyExportRowsWithNoTranslation = information.OnlyExportRowsWithNoTranslation,
                                        ExportCompletelyEmptyRows = information.ExportCompletelyEmptyRows,
                                        OnlyExportRowsWithChangedTexts = information.OnlyExportRowsWithChangedTexts,
                                        Project = information.Project,
                                        ReferenceLanguageCode = information.ReferenceLanguageCode
                                    });
                        }
                    }
                }
                else if (oneExcelFilePerGroup)
                {
                    // ReSharper disable LoopCanBeConvertedToQuery
                    foreach (var fileGroup in information.FileGroups)
                    // ReSharper restore LoopCanBeConvertedToQuery
                    {
                        preparedInformations.Add(
                            new PreparedInformation
                            {
                                DestinationFilePath =
                                    replacePlaceholders(
                                        replacePlaceholders(information.DestinationFilePath, information.DestinationLanguageCodes[0]),
                                        fileGroup),
                                DestinationLanguageCodes = information.DestinationLanguageCodes,
                                EliminateDuplicateRows = information.EliminateDuplicateRows,
                                ExportAllGroups =
                                    information.ExportAllGroupsMode ==
                                    ExcelExportInformation.ExportFileGroupMode.AllGroupsIntoOneWorksheet,
                                ExportFileGroupColumn = information.ExportFileGroupColumn,
                                ExportNameColumn = information.ExportNameColumn,
                                ExportCommentColumn = information.ExportCommentColumn,
                                ExportReferenceLanguageColumn = information.ExportReferenceLanguageColumn,
                                UseCrypticExcelExportSheetNames = information.UseCrypticExcelExportSheetNames,
                                FileGroups = new[] { fileGroup },
                                OnlyExportRowsWithNoTranslation = information.OnlyExportRowsWithNoTranslation,
                                ExportCompletelyEmptyRows = information.ExportCompletelyEmptyRows,
                                OnlyExportRowsWithChangedTexts = information.OnlyExportRowsWithChangedTexts,
                                Project = information.Project,
                                ReferenceLanguageCode = information.ReferenceLanguageCode
                            });
                    }
                }
                else // oneExcelFilePerLanguage.
                {
                    // ReSharper disable LoopCanBeConvertedToQuery
                    foreach (var destinationLanguageCode in information.DestinationLanguageCodes)
                    // ReSharper restore LoopCanBeConvertedToQuery
                    {
                        preparedInformations.Add(
                            new PreparedInformation
                            {
                                DestinationFilePath =
                                    replacePlaceholders(
                                        replacePlaceholders(information.DestinationFilePath, destinationLanguageCode),
                                        information.FileGroups[0]),
                                DestinationLanguageCodes = new[] { destinationLanguageCode },
                                EliminateDuplicateRows = information.EliminateDuplicateRows,
                                ExportAllGroups =
                                    information.ExportAllGroupsMode ==
                                    ExcelExportInformation.ExportFileGroupMode.AllGroupsIntoOneWorksheet,
                                ExportFileGroupColumn = information.ExportFileGroupColumn,
                                ExportNameColumn = information.ExportNameColumn,
                                ExportCommentColumn = information.ExportCommentColumn,
                                ExportReferenceLanguageColumn = information.ExportReferenceLanguageColumn,
                                UseCrypticExcelExportSheetNames = information.UseCrypticExcelExportSheetNames,
                                FileGroups = information.FileGroups,
                                OnlyExportRowsWithNoTranslation = information.OnlyExportRowsWithNoTranslation,
                                ExportCompletelyEmptyRows = information.ExportCompletelyEmptyRows,
                                OnlyExportRowsWithChangedTexts = information.OnlyExportRowsWithChangedTexts,
                                Project = information.Project,
                                ReferenceLanguageCode = information.ReferenceLanguageCode
                            });
                    }
                }

                ensureFileNamesUnique(preparedInformations);
            }
            else
            {
                // Only one.

                preparedInformations.Add(
                    new PreparedInformation
                        {
                            DestinationFilePath =
                                replacePlaceholders(
                                    replacePlaceholders(information.DestinationFilePath, information.DestinationLanguageCodes[0]),
                                    information.FileGroups[0]),
                            DestinationLanguageCodes = information.DestinationLanguageCodes,
                            EliminateDuplicateRows = information.EliminateDuplicateRows,
                            ExportAllGroups =
                                information.ExportAllGroupsMode ==
                                ExcelExportInformation.ExportFileGroupMode.AllGroupsIntoOneWorksheet,
                            ExportFileGroupColumn = information.ExportFileGroupColumn,
                            ExportNameColumn = information.ExportNameColumn,
                            ExportCommentColumn = information.ExportCommentColumn,
                            ExportReferenceLanguageColumn = information.ExportReferenceLanguageColumn,
                            UseCrypticExcelExportSheetNames = information.UseCrypticExcelExportSheetNames,
                            FileGroups = information.FileGroups,
                            OnlyExportRowsWithNoTranslation = information.OnlyExportRowsWithNoTranslation,
                            ExportCompletelyEmptyRows = information.ExportCompletelyEmptyRows,
                            OnlyExportRowsWithChangedTexts = information.OnlyExportRowsWithChangedTexts,
                            Project = information.Project,
                            ReferenceLanguageCode = information.ReferenceLanguageCode
                        });
            }

            // --

            _preparedInformations = preparedInformations;
        }

        private static void ensureFileNamesUnique(
            IEnumerable<PreparedInformation> preparedInformations)
        {
            var prevFilePaths = new Set<string>();

            foreach (var preparedInformation in preparedInformations)
            {
                var dp = preparedInformation.DestinationFilePath;
                var dpl = dp.ToLowerInvariant();

                if (prevFilePaths.Contains(dpl))
                {
                    var index = 1;
                    var guidCount = 0;
                    while (prevFilePaths.Contains(dpl))
                    {
                        var dir = ZlpPathHelper.GetDirectoryPathNameFromFilePath(dp);
                        var fn = ZlpPathHelper.GetFileNameWithoutExtension(dp);
                        var ext = ZlpPathHelper.GetExtension(dp);

                        dp = ZlpPathHelper.Combine(
                            dir,
                            string.Format(@"{0}{1}{2}", fn, index, ext));

                        dpl = dp.ToLowerInvariant();

                        if (!prevFilePaths.Contains(dpl))
                        {
                            prevFilePaths.Add(dpl);
                            preparedInformation.DestinationFilePath = dp;
                            break;
                        }
                        else
                        {
                            index++;

                            if (index > 100)
                            {
                                index = Math.Abs(Guid.NewGuid().GetHashCode());
                                guidCount++;

                                if (guidCount > 100)
                                {
                                    throw new Exception(
                                        Resources.SR_CommandProcessorSend_ensureFileNamesUnique_Failed_to_generate_unique_file_names_);
                                }
                            }
                        }
                    }
                }
                else
                {
                    prevFilePaths.Add(dpl);
                }
            }
        }

        private class PreparedInformationCollection :
            List<PreparedInformation>
        {
            private readonly ExcelExportInformation _originalInformation;

            public PreparedInformationCollection(
                ExcelExportInformation originalInformation)
            {
                _originalInformation = originalInformation;
            }

            public int FileGroupsLength
            {
                get
                {
                    var result = 0;
                    // ReSharper disable LoopCanBeConvertedToQuery
                    foreach (var i in this)
                    // ReSharper restore LoopCanBeConvertedToQuery
                    {
                        result += i.FileGroups.Length;
                    }
                    return result;
                }
            }

            public ExcelExportInformation OriginalInformation
            {
                get { return _originalInformation; }
            }
        }

        /// <summary>
        /// Helper class to contain the relevant information for the core
        /// work routine.
        /// </summary>
        private class PreparedInformation
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
            public bool ExportAllGroups { get; set; }
            public bool ExportFileGroupColumn { get; set; }
            public bool ExportNameColumn { get; set; }
            public bool ExportCommentColumn { get; set; }
            public bool UseCrypticExcelExportSheetNames { get; set; }
            public bool ExportReferenceLanguageColumn { get; set; }
        }

        public void Process(
            BackgroundWorker bw)
        {
            var savedFiles = new List<string>();

            foreach (var preparedInformation in _preparedInformations)
            {
                doProcess(
                    preparedInformation,
                    bw,
                    _preparedInformations.FileGroupsLength,
                    savedFiles);
            }

            // --

            if (_preparedInformations.OriginalInformation.SendFilesWithZetaUploader)
            {
                doSendFilesWithZetaUploader(bw, savedFiles.ToArray());
            }
        }

        private void doSendFilesWithZetaUploader(BackgroundWorker bw, string[] filePathsToSend)
        {
            if (filePathsToSend.Length > 0)
            {
                bw.ReportProgress(
                    0,
                    new ExcelProgressInformation
                        {
                            TemporaryProgressMessage =
                                string.Format(
                                    Resources.ExcelExportController_doSendFilesWithZetaUploader_Sending__0__files_through_Zeta_Uploader___,
                                    filePathsToSend.Length)
                        });

                var sendInfo =
                    new ZetaUploaderCommunicationClientTransferInformation2
                        {
                            EMailReceiverAddresses =
                                splitEMailAddresses(
                                    _preparedInformations.OriginalInformation.SendFilesEMailReceivers),
                            EMailSubject =
                                replaceEMailPlaceholders(
                                    _preparedInformations.OriginalInformation.SendFilesEMailSubject),
                            AdditionalRemarks =
                                replaceEMailPlaceholders(
                                    _preparedInformations.OriginalInformation.SendFilesEMailBody),
                            Language =
                                CultureHelper.GetSupportedUICultureFromThreeLetterWindowsLanguageName(
                                    CultureInfo.CurrentUICulture.ThreeLetterWindowsLanguageName).TwoLetterISOLanguageName,
                            UserStates = new[] { new ZulPair { Name = @"allow-browse", Value = bool.FalseString } },
                        };

                // --

                if (filePathsToSend.Length == 1)
                {
                    sendInfo.FileName = ZlpPathHelper.GetFileNameFromFilePath(filePathsToSend[0]);
                    sendInfo.FileContent = ZlpIOHelper.ReadAllBytes(filePathsToSend[0]);
                }
                else
                {
                    sendInfo.FileName = replaceEMailPlaceholders(@"ZRE-Files-To-Translate-{SafeProjectName}.zip");

                    var compressInfos = new CompressHeterogeneousInfos();

                    compressInfos.AddFiles(filePathsToSend);

                    sendInfo.FileContent =
                        CompressionHelper.CompressHeterogeneous(
                            compressInfos);
                }

                var ws = WebServiceManager.Current.ZetaUploaderWS;
                ws.SendFile2(sendInfo);
            }
        }

        private string replaceEMailPlaceholders(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            else
            {
                text = text.Replace(@"{ProjectName}", _preparedInformations.OriginalInformation.Project.Name);
                text = text.Replace(@"{SafeProjectName}", ZrePathHelper.MakeValidObjectID(_preparedInformations.OriginalInformation.Project.Name));

                return text;
            }
        }

        private static string[] splitEMailAddresses(string sendFilesEMailReceivers)
        {
            var result = new List<string>();

            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (var email in sendFilesEMailReceivers.Split(','))
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                var e = email.Trim();

                if (e.Length > 0)
                {
                    result.Add(e);
                }
            }

            return result.ToArray();
        }

        private static void doProcess(
            PreparedInformation preparedInformation,
            BackgroundWorker bw,
            int fileGroupsLength,
            ICollection<string> savedFiles)
        {
            var ssc = new SnapshotController(preparedInformation.Project, @"XLS");
            ssc.Initialize();

            // --

            var exportedReferenceLanguageValues = new Set<string>();

            var dataSet = new DataSet();

            dataSet.Tables.Clear();

            DataTable dataTable = null;
            var currentRowIndex = 0;

            var suggestedWorkSheetNamesToRemove = new List<string>();

            var fileGroupIndex = 0;
            foreach (var fileGroup in preparedInformation.FileGroups)
            {
                if (bw.CancellationPending)
                {
                    throw new OperationCanceledException();
                }

                var isFirstFileGroup = fileGroupIndex == 0;
                var isLastFileGroup = fileGroupIndex == preparedInformation.FileGroups.Length - 1;

                var worksheetIndex = -1;

                if (preparedInformation.ExportAllGroups)
                {
                    if (dataTable == null)
                    {
                        dataSet.Tables.Add();
                        worksheetIndex = dataSet.Tables.Count - 1;
                        dataTable = dataSet.Tables[worksheetIndex];
                        dataTable.TableName = Resources.SR_CommandProcessorSend_Process_ZRE_Export;
                    }
                }
                else
                {
                    dataSet.Tables.Add();
                    worksheetIndex = dataSet.Tables.Count - 1;
                    dataTable = dataSet.Tables[worksheetIndex];
                    dataTable.TableName = generateWorksheetName(preparedInformation, fileGroup, preparedInformation.Project);
                }

                var rows = dataTable.Rows;

                var wantNewSheet = !preparedInformation.ExportAllGroups || isFirstFileGroup;

                // --
                // Header.

                const int headerStartRowIndex = 0;
                const int columnStartIndex = 0;

                if (wantNewSheet)
                {
                    if (preparedInformation.ExportFileGroupColumn)
                    {
                        // Checksum.
                        dataTable.Columns.Add(Resources.SR_CommandProcessorSend_Process_Group, typeof(int));
                    }
                    if (preparedInformation.ExportNameColumn)
                    {
                        // String name.
                        dataTable.Columns.Add(Resources.SR_CommandProcessorSend_Process_Name, typeof(string));
                    }
                    if (preparedInformation.ExportReferenceLanguageColumn)
                    {
                        // Reference language.
                        dataTable.Columns.Add(preparedInformation.ReferenceLanguageCode, typeof(string));
                    }

                    // Destination languages.
                    // ReSharper disable ForCanBeConvertedToForeach
                    for (var runningColIndex = 0;
                        // ReSharper restore ForCanBeConvertedToForeach
                         runningColIndex < preparedInformation.DestinationLanguageCodes.Length;
                         ++runningColIndex)
                    {
                        var destinationLanguageCode =
                            preparedInformation.DestinationLanguageCodes[runningColIndex];

                        if (string.Compare(preparedInformation.ReferenceLanguageCode, destinationLanguageCode,
                            StringComparison.OrdinalIgnoreCase) != 0)
                        {
                            dataTable.Columns.Add(destinationLanguageCode, typeof(string));
                        }
                    }

                    if (preparedInformation.ExportCommentColumn)
                    {
                        // String name.
                        dataTable.Columns.Add(Resources.SR_CommandProcessorSend_Process_Comment, typeof(string));
                    }

                    currentRowIndex = headerStartRowIndex;
                }

                // --
                // Content.

                var dp = new DataProcessing(fileGroup);
                var table =
                    dp.GetDataTableFromResxFiles(preparedInformation.Project, preparedInformation.ExportCommentColumn);
                table =
                    removeUnusedColumns(
                        preparedInformation,
                        fileGroup.ParentSettings,
                        table);

                var rowIndex = 0;

                foreach (DataRow row in table.Rows)
                {
                    if ((rowIndex + 1) % 20 == 0)
                    {
                        bw.ReportProgress(
                            0,
                            new ExcelProgressInformation
                                {
                                    TemporaryProgressMessage =
                                        string.Format(
                                            Resources.SR_CommandProcessorSend_Process_ProcessingFileGroupOfRowOf,
                                            fileGroupIndex + 1,
                                            fileGroupsLength,
                                            rowIndex + 1,
                                            table.Rows.Count,
                                            (int)(((rowIndex + 1.0) /
                                                    (table.Rows.Count) *
                                                    ((fileGroupIndex + 1.0) /
                                                     (fileGroupsLength))) * 100))
                                });

                        if (bw.CancellationPending)
                        {
                            throw new OperationCanceledException();
                        }
                    }

                    if (wantExportRow(
                        ssc,
                        preparedInformation,
                        fileGroup.ParentSettings,
                        row,
                        CommentVisibilityScope.InMemory))
                    {
                        if (!wasAlreadyExported(
                            exportedReferenceLanguageValues,
                            preparedInformation,
                            fileGroup.ParentSettings,
                            row))
                        {
                            var offset = 0;

                            if (preparedInformation.ExportFileGroupColumn)
                            {
                                // Checksum.
                                checkEnsureRowPresent(dataTable, currentRowIndex);
                                rows[currentRowIndex][columnStartIndex] = fileGroup.GetChecksum(preparedInformation.Project);
                                makeCellReadOnly(dataTable.Columns[columnStartIndex]);
                                offset++;
                            }
                            if (preparedInformation.ExportNameColumn)
                            {
                                // String name.
                                checkEnsureRowPresent(dataTable, currentRowIndex);
                                rows[currentRowIndex][columnStartIndex + offset] = row[1]; // Column 0=FileGroup checksum, column 1=Tag name.
                                makeCellReadOnly(dataTable.Columns[columnStartIndex + offset]);

                                offset++;
                            }

                            var effectiveDestinationColumnIndex = 1;
                            // Column 0=FileGroup checksum, column 1=Tag name.
                            for (var sourceColumnIndex = 2;
                                sourceColumnIndex < table.Columns.Count - (preparedInformation.ExportCommentColumn ? 1 : 0); // Subtract 1, because last column is ALWAYS the comment.
                                ++sourceColumnIndex)
                            {
                                var languageValue = row[sourceColumnIndex] as string;
                                var languageCode =
                                    IsFileName(table.Columns[sourceColumnIndex].ColumnName)
                                        ? new LanguageCodeDetection(preparedInformation.Project)
                                            .DetectLanguageCodeFromFileName(
                                                fileGroup.ParentSettings,
                                                table.Columns[sourceColumnIndex].ColumnName)
                                        : table.Columns[sourceColumnIndex].ColumnName;
                                var isReferenceLanguage =
                                    string.Compare(preparedInformation.ReferenceLanguageCode, languageCode,
                                    StringComparison.OrdinalIgnoreCase) == 0;

                                if (isReferenceLanguage && preparedInformation.ExportReferenceLanguageColumn ||
                                    !isReferenceLanguage)
                                {
                                    checkEnsureRowPresent(dataTable, currentRowIndex);
                                    var columnIndex = (columnStartIndex - 1) + effectiveDestinationColumnIndex + offset;
                                    rows[currentRowIndex][columnIndex] = languageValue;

                                    if (isReferenceLanguage)
                                    {
                                        makeCellReadOnly(dataTable.Columns[columnIndex]);

                                        exportedReferenceLanguageValues.Add(
                                            string.IsNullOrEmpty(languageValue)
                                                ? string.Empty
                                                : languageValue);
                                    }

                                    effectiveDestinationColumnIndex++;
                                }
                            }

                            if (preparedInformation.ExportCommentColumn)
                            {
                                // Comment.
                                checkEnsureRowPresent(dataTable, currentRowIndex);
                                rows[currentRowIndex][(columnStartIndex - 1) + effectiveDestinationColumnIndex + offset]
                                    = DataProcessing.GetComment(preparedInformation.Project, row);

                                /*offset++;*/
                            }

                            currentRowIndex++;
                        }
                    }

                    // In every loop, check again.
                    suggestedWorkSheetNamesToRemove.Remove(dataTable.TableName);

                    //CHANGED if worksheet empty: remove it)
                    if (currentRowIndex == headerStartRowIndex + 1 &&
                        !preparedInformation.ExportAllGroups)
                    {
                        // http://www.codeproject.com/Messages/3539004/Export-to-Excel-bug.aspx
                        if (worksheetIndex < dataSet.Tables.Count)
                        {
                            suggestedWorkSheetNamesToRemove.Add(dataTable.TableName);
                        }
                    }

                    rowIndex++;
                }

                //dataTable.AutoFitRow(currentRowIndex - 1);

                if (bw.CancellationPending)
                {
                    throw new OperationCanceledException();
                }

                // --

                if (!preparedInformation.ExportAllGroups ||
                    isLastFileGroup)
                {
                    var offset = 0;

                    if (preparedInformation.ExportFileGroupColumn)
                    {
                        // Checksum.
                        //dataTable.AutoFitColumn(
                        //    columnStartIndex,
                        //    headerStartRowIndex,
                        //    currentRowIndex);
                        offset++;
                    }
                    if (preparedInformation.ExportNameColumn)
                    {
                        // String name.
                        //dataTable.AutoFitColumn(
                        //    columnStartIndex + offset,
                        //    headerStartRowIndex,
                        //    currentRowIndex);
                        offset++;
                    }
                    if (preparedInformation.ExportReferenceLanguageColumn)
                    {
                        // Reference language.
                        //dataTable.AutoFitColumn(
                        //    columnStartIndex + offset,
                        //    headerStartRowIndex,
                        //    currentRowIndex);
                        offset++;
                    }

                    // Destination languages.
                    int runningColIndex;
                    for (runningColIndex = 0;
                         runningColIndex < preparedInformation.DestinationLanguageCodes.Length;
                         ++runningColIndex)
                    {
                        //dataTable.AutoFitColumn(
                        //    columnStartIndex + runningColIndex + offset,
                        //    headerStartRowIndex,
                        //    currentRowIndex);
                    }

                    if (preparedInformation.ExportCommentColumn)
                    {
                        // Comment.
                        //dataTable.AutoFitColumn(
                        //    columnStartIndex + offset + runningColIndex,
                        //    headerStartRowIndex,
                        //    currentRowIndex);
                        /*offset++;*/
                    }
                }

                // --

                fileGroupIndex++;
            }

            // --

            // 2011-01-31, Uwe Keim.
            // http://www.codeproject.com/Messages/3559812/Export-error.aspx
            foreach (var name in suggestedWorkSheetNamesToRemove)
            {
                dataSet.Tables.Remove(name);
            }

            // --

            if (dataSet.Tables.Count > 0)
            {
                bw.ReportProgress(
                    0,
                    new ExcelProgressInformation
                        {
                            TemporaryProgressMessage =
                                string.Format(
                                    Resources.SR_CommandProcessorSend_Process_SavingMicrosoftOfficeExcelDocument)
                        });

                savedFiles.Add(preparedInformation.DestinationFilePath);
                CoreExcelExporter.ExportToExcelFile(dataSet, preparedInformation.DestinationFilePath);
            }
            else
            {
                bw.ReportProgress(
                    0,
                    new ExcelProgressInformation
                        {
                            TemporaryProgressMessage =
                                Resources.ExcelExportController_doProcess_Skipping_Microsoft_Office_Excel_document_,
                            WarningMessage =
                                string.Format(
                                    Resources.ExcelExportController_doProcess_Skipping_Excel_document___0___because_it_contains_no_work_sheets_,
                                    ZlpPathHelper.GetFileNameFromFilePath(preparedInformation.DestinationFilePath))
                        });
            }

            // --

            // At very last, to not overwrite before comparing.
            if (preparedInformation.Project.EnableExcelExportSnapshots)
            {
                ssc.TakeFullSnapshot(
                    preparedInformation.FileGroups,
                    new[] { preparedInformation.ReferenceLanguageCode },
                    bw);
            }
        }

        private static void checkEnsureRowPresent(DataTable table, int rowIndex)
        {
            while (table.Rows.Count - 1 < rowIndex)
            {
                table.Rows.Add(table.NewRow());
            }
        }

        /// <summary>
        /// Check whether the export of duplicates is enabled/disabled and then
        /// check whether was exported in the past.
        /// </summary>
        private static bool wasAlreadyExported(
            ICollection<string> exportedReferenceLanguageValues,
            PreparedInformation preparedInformation,
            IInheritedSettings parentSettings,
            DataRow row)
        {
            if (preparedInformation.EliminateDuplicateRows)
            {
                // Column 0=FileGroup checksum, column 1=Tag name.
                for (var columnIndex = 2; columnIndex < row.Table.Columns.Count; ++columnIndex)
                {
                    var languageCode =
                        IsFileName(row.Table.Columns[columnIndex].ColumnName)
                            ? new LanguageCodeDetection(preparedInformation.Project).DetectLanguageCodeFromFileName(
                                parentSettings,
                                row.Table.Columns[columnIndex].ColumnName)
                            : row.Table.Columns[columnIndex].ColumnName;

                    if (string.Compare(preparedInformation.ReferenceLanguageCode, languageCode,
                        StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        var languageValue = ConvertHelper.ToString(row[columnIndex]);
                        return exportedReferenceLanguageValues.Contains(languageValue);
                    }
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        private static string generateWorksheetName(
            PreparedInformation preparedInformation,
            FileGroup fileGroup,
            Project project)
        {
            // http://social.msdn.microsoft.com/Forums/en-US/vsto/thread/84c0c4d2-52b9-4502-bece-fdc616db05f8

            const int maxLength = 31;

            var ni =
                (preparedInformation.UseCrypticExcelExportSheetNames
                    ? fileGroup.UniqueID.ToString()
                    : fileGroup.GetNameIntelligent(project))
                    .Replace('\\', '#')
                    .Replace('/', '#')
                    .Replace('?', '_')
                    .Replace('*', '_')
                    .Replace('[', '_')
                    .Replace(']', '_')
                    .Replace(':', '_');
            //var cs = fileGroup.Checksum.ToString();

            //var s1 = string.Format( @" ({0})", cs );
            //var len = maxLength - s1.Length;

            var ni2 = FileGroup.ShortenFilePath(ni, maxLength);

            return ni2;
        }

        private static bool wantExportRow(
            SnapshotController ssc,
            PreparedInformation preparedInformation,
            IInheritedSettings settings,
            DataRow row,
            CommentVisibilityScope commentVisibilityScope)
        {
            if ((FileGroup.IsCompleteRowEmpty(row, commentVisibilityScope) &&
                !preparedInformation.ExportCompletelyEmptyRows) ||
                // http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx?msg=3367544#xx3367544xx)
                FileGroup.IsInternalRow(row))
            {
                return false;
            }

            if (preparedInformation.OnlyExportRowsWithNoTranslation)
            {
                var emptyCount = 0;

                // ReSharper disable LoopCanBeConvertedToQuery
                foreach (DataColumn column in row.Table.Columns)
                // ReSharper restore LoopCanBeConvertedToQuery
                {
                    // Column 0=FileGroup checksum, column 1=Tag name.
                    if (column.Ordinal != 0 && column.Ordinal != 1 && !isCommentColumn(column))
                    {
                        var languageCode =
                            IsFileName(column.ColumnName)
                                ? new LanguageCodeDetection(preparedInformation.Project).DetectLanguageCodeFromFileName(
                                    settings,
                                    column.ColumnName)
                                : column.ColumnName;

                        if (string.Compare(languageCode, preparedInformation.ReferenceLanguageCode,
                            StringComparison.OrdinalIgnoreCase) != 0)
                        {
                            if (ConvertHelper.ToString(row[column], string.Empty).Trim().Length <= 0)
                            {
                                emptyCount++;
                            }
                        }
                    }
                }

                if (preparedInformation.Project.EnableExcelExportSnapshots)
                {
                    return emptyCount > 0 ||
                           (preparedInformation.OnlyExportRowsWithChangedTexts &&
                            hasChangedTextSinceLastExport(ssc, preparedInformation, settings, row));
                }
                else
                {
                    return emptyCount > 0;
                }
            }
            else
            {
                if (preparedInformation.Project.EnableExcelExportSnapshots)
                {
                    return !preparedInformation.OnlyExportRowsWithChangedTexts ||
                           hasChangedTextSinceLastExport(ssc, preparedInformation, settings, row);
                }
                else
                {
                    return true;
                }
            }
        }

        private static bool isCommentColumn(
            DataColumn column)
        {
            return string.Compare(column.ColumnName, @"Comment", StringComparison.OrdinalIgnoreCase) == 0;
        }

        private static bool hasChangedTextSinceLastExport(
            SnapshotController ssc,
            PreparedInformation preparedInformation,
            IInheritedSettings settings,
            DataRow row)
        {
            var lcs = new List<string>(new[] { preparedInformation.ReferenceLanguageCode });
            for (var i = 0; i < lcs.Count; ++i) lcs[i] = lcs[i].ToLowerInvariant();

            // ReSharper disable LoopCanBeConvertedToQuery);
            foreach (DataColumn column in row.Table.Columns)
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                // Column 0=FileGroup checksum, column 1=Tag name.
                if (column.Ordinal != 0 && column.Ordinal != 1 && !isCommentColumn(column))
                {
                    var languageCode =
                        IsFileName(column.ColumnName)
                            ? new LanguageCodeDetection(preparedInformation.Project).DetectLanguageCodeFromFileName(
                                settings,
                                column.ColumnName)
                            : column.ColumnName;
                    languageCode = languageCode.ToLowerInvariant();

                    if (/*lcs.Contains(languageCode.Substring(0, 2)) ||*/
                        lcs.Contains(languageCode))
                    {
                        var languageValue = ConvertHelper.ToString(row[column], string.Empty);
                        if (!StringExtensionMethods.IsNullOrWhiteSpace(languageValue))
                        {
                            var fileGroup = row[0] as string;
                            var tagName = row[1] as string;
                            if (hasValueChanged(ssc, fileGroup, tagName, languageCode, languageValue))
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private static bool hasValueChanged(
            SnapshotController ssc,
            string fileGroup,
            string tagName,
            string languageCode,
            string languageValue)
        {
            var baseKey = ssc.MakeBaseKey(fileGroup, tagName);
            var key = ssc.MakeFullKey(baseKey, languageCode);

            var prevValue = ssc.GetSettingValue(key);
            var currValue = languageValue;

            if (string.IsNullOrEmpty(prevValue) && string.IsNullOrEmpty(currValue))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(prevValue) || string.IsNullOrEmpty(currValue))
            {
                return true;
            }
            else
            {
                return string.Compare(prevValue, currValue, StringComparison.OrdinalIgnoreCase) != 0;
            }
        }

        private static DataTable removeUnusedColumns(
            PreparedInformation preparedInformation,
            IInheritedSettings settings,
            DataTable table)
        {
            var result = new DataTable();

            // --
            // Columns.

            // Order:
            // 1. The filegroup checksum column.
            // 2. The name column.
            // 3. The reference language column.
            // 4. All other columns.
            // 5. The comment column.

            // 1.
            result.Columns.Add(table.Columns[0].ColumnName, typeof(string));

            // 2.
            result.Columns.Add(table.Columns[1].ColumnName, typeof(string));

            // 3. 
            foreach (DataColumn column in table.Columns)
            {
                // Column 0=FileGroup checksum, column 1=Tag name.
                if (column.Ordinal != 0 && column.Ordinal != 1)
                {
                    var languageCode =
                        IsFileName(column.ColumnName)
                            ? new LanguageCodeDetection(preparedInformation.Project).DetectLanguageCodeFromFileName(
                                settings,
                                column.ColumnName)
                            : column.ColumnName;

                    if (string.Compare(preparedInformation.ReferenceLanguageCode, languageCode,
                        StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        result.Columns.Add(column.ColumnName);
                        break;
                    }
                }
            }

            // 4.
            foreach (DataColumn column in table.Columns)
            {
                // Column 0=FileGroup checksum, column 1=Tag name.
                if (column.Ordinal != 0 && column.Ordinal != 1)
                {
                    var languageCode =
                        IsFileName(column.ColumnName)
                            ? new LanguageCodeDetection(preparedInformation.Project).DetectLanguageCodeFromFileName(
                                settings,
                                column.ColumnName)
                            : column.ColumnName;

                    if (string.Compare(preparedInformation.ReferenceLanguageCode, languageCode,
                        StringComparison.OrdinalIgnoreCase) != 0)
                    {
                        if (wantExportLanguageCode(preparedInformation, languageCode))
                        {
                            result.Columns.Add(column.ColumnName);
                        }
                    }
                }
            }

            // 5.
            if (preparedInformation.ExportCommentColumn)
            {
                result.Columns.Add(table.Columns[table.Columns.Count - 1].ColumnName, typeof(string));
            }

            // --
            // Rows.

            foreach (DataRow sourceRow in table.Rows)
            {
                var destinationRow = result.NewRow();

                foreach (DataColumn column in result.Columns)
                {
                    destinationRow[column.ColumnName] = sourceRow[column.ColumnName];
                }

                result.Rows.Add(destinationRow);
            }

            // --

            return result;
        }

        public static bool IsFileName(string columnName)
        {
            return
                columnName.ToLowerInvariant().EndsWith(@".resx") ||
                columnName.ToLowerInvariant().EndsWith(@".resw");
        }

        private static bool wantExportLanguageCode(
            PreparedInformation preparedInformation,
            string languageCode)
        {
            if (string.IsNullOrEmpty(languageCode))
            {
                return false;
            }
            else
            {
                if (string.Compare(languageCode, preparedInformation.ReferenceLanguageCode,
                    StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return true;
                }
                else
                {
                    // ReSharper disable LoopCanBeConvertedToQuery
                    foreach (var destinationLanguageCode in preparedInformation.DestinationLanguageCodes)
                    // ReSharper restore LoopCanBeConvertedToQuery
                    {
                        if (string.Compare(languageCode, destinationLanguageCode,
                            StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            return true;
                        }
                    }

                    return false;
                }
            }
        }

        private static void makeCellReadOnly(DataColumn column)
        {
            column.Namespace = CoreExcelExporter.ReadOnlyFlag;
        }

        //private static void makeHeaderCell(Cell cell)
        //{
        //    var colorHeader = ExcelHelper.SafeExcelColors.Green;
        //    //var colorOddRows = ColorTranslator.FromHtml( @"#DBE5F1" );
        //    var colorLines = ExcelHelper.SafeExcelColors.Gray;
        //    var colorHeaderLine = ExcelHelper.SafeExcelColors.Black;

        //    cell.Style.ForegroundColor = colorHeader;
        //    cell.Style.BackgroundColor = colorHeader;
        //    cell.Style.Pattern = BackgroundType.Solid;

        //    cell.Style.Font.Color = ExcelHelper.SafeExcelColors.White;
        //    cell.Style.Font.IsBold = true;

        //    cell.Style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
        //    cell.Style.Borders[BorderType.BottomBorder].Color = colorHeaderLine;

        //    cell.Style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
        //    cell.Style.Borders[BorderType.TopBorder].Color = colorLines;
        //}

        private const string PlaceholderFileGroupName = @"{FileGroupName}";
        private const string PlaceholderFileGroupNumber = @"{FileGroupNumber}";
        private const string PlaceholderLanguageName = @"{LanguageName}";

        public static string[] GetDirectoryPaths(
            ExcelExportInformation information)
        {
            var raw = information.DestinationFilePath;
            var rawDir = raw.Substring(0, raw.LastIndexOf(@"\", StringComparison.Ordinal));

            if (rawDir.Contains(@"{"))
            {
                var result = new Set<string>();

                foreach (var fileGroup in information.FileGroups)
                {
                    var raw1 = replacePlaceholders(rawDir, fileGroup);

                    foreach (var destinationLanguageCode in information.DestinationLanguageCodes)
                    {
                        var raw2 = replacePlaceholders(raw1, destinationLanguageCode);
                        result.Add(raw2);
                    }
                }

                return result.ToArray();
            }
            else
            {
                return new[] { rawDir };
            }
        }

        private static string replacePlaceholders(string text, string languageCode)
        {
            return text.Replace(PlaceholderLanguageName, languageCode);
        }

        private static string replacePlaceholders(string text, FileGroup fileGroup)
        {
            return text
                .Replace(PlaceholderFileGroupName, makeFolderNameCompatible(fileGroup.Name))
                .Replace(PlaceholderFileGroupNumber,
                         Math.Abs(fileGroup.UniqueID.GetHashCode()).ToString(CultureInfo.InvariantCulture));
        }

        public static string[] GetFilePaths(
            ExcelExportInformation information)
        {
            var raw = information.DestinationFilePath;

            if (raw.Contains(@"{"))
            {
                var result = new Set<string>();

                foreach (var fileGroup in information.FileGroups)
                {
                    var raw1 = replacePlaceholders(raw, fileGroup);

                    foreach (var destinationLanguageCode in information.DestinationLanguageCodes)
                    {
                        var raw2 = replacePlaceholders(raw1, destinationLanguageCode);
                        result.Add(raw2);
                    }
                }

                return result.ToArray();
            }
            else
            {
                return new[] { raw };
            }
        }

        private static string makeFolderNameCompatible(
            string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }
            else
            {
                var invalids = new List<char>(Path.GetInvalidFileNameChars());

                var sb = new StringBuilder(name);

                for (var i = 0; i < sb.Length; ++i)
                {
                    if (invalids.Contains(sb[i]))
                    {
                        sb[i] = '-';
                    }
                }

                return sb.ToString();
            }
        }
    }
}