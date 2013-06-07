namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.Import
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using Aspose.Cells;
	using BL;
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
	using Zeta.EnterpriseLibrary.Common.IO;
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
					var wb = new Workbook();
					wb.Open(tfc.FilePath);

					return detectFileGroupsFromWorkbook(project, wb);
				}
			}
		}

		private static FileGroup[] detectFileGroupsFromWorkbook(
			Project project,
			Workbook workbook)
		{
			var result = new List<FileGroup>();

			var checkSums = new Set<long>();

			foreach (Worksheet worksheet in workbook.Worksheets)
			{
				int totalChecksumRows;
				var ix = extractColumnCheckSums(worksheet, out totalChecksumRows);
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
			Worksheet worksheet,
			out int totalChecksumRows)
		{
			totalChecksumRows = 0;
			var result = new List<Pair<long, int>>();

			var cells = worksheet.Cells;

			if (cells.Columns.Count >= 1)
			{
				for (var rowIndex = 1; rowIndex < cells.Rows.Count; rowIndex++)
				{
					// Could have column 0 or column 1 (or none at all) as the checksum.
					for (var columnIndex = 0; columnIndex < 2; ++columnIndex)
					{
						var cellValue = ConvertHelper.ToString(cells[rowIndex, columnIndex].Value);

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
					var wb = new Workbook();
					wb.Open(tfc.FilePath);

					return detectLanguagesFromWorkbook(wb);
				}
			}
		}

		private static string[] detectLanguagesFromWorkbook(
			Workbook workbook)
		{
			var result = new Set<string>();

			foreach (Worksheet worksheet in workbook.Worksheets)
			{
				foreach (var pair in dectectLanguageCodesFromWorksheet(worksheet))
				{
					result.Add(pair.First);
				}
			}

			return result.ToArray();
		}

		private static List<Pair<string, int>> dectectLanguageCodesFromWorksheet(
			Worksheet worksheet)
		{
			// Make no Set type to keep order.
			var result = new List<Pair<string, int>>();

			var cells = worksheet.Cells;

			// --
			// Header.

			const int headerStartRowIndex = 0;
			const int columnStartIndex = 0;

			for (var columnIndex = columnStartIndex + 0; columnIndex < 30; ++columnIndex)
			{
				var languageCode =
					(string)cells[headerStartRowIndex, columnIndex].Value;

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
				var workbook = new Workbook();
				workbook.Open(tfc.FilePath);

				var result = new ExcelImportResult();

				var worksheetIndex = 0;
				foreach (Worksheet worksheet in workbook.Worksheets)
				{
					if (bw.CancellationPending)
					{
						throw new OperationCanceledException();
					}

					processWorkSheetFileIntelligent(
						result,
						worksheetIndex,
						workbook,
						worksheet,
						bw);

					worksheetIndex++;
				}

				return result;
			}
		}

		private void processWorkSheetFileIntelligent(
			ExcelImportResult result,
			int worksheetIndex,
			Workbook workbook,
			Worksheet worksheet,
			BackgroundWorker bw)
		{
			const int headerStartRowIndex = 0;

			var sourceCells = worksheet.Cells;
			var sourceRowCount = sourceCells.Rows.Count;

			var checksumColumnIndex = getChecksumWorksheetColumnIndex(worksheet);
			var nameColumnIndex = getNameWorksheetColumnIndex(worksheet);

			int referenceLanguageColumnIndex;
			string referenceLanguageName;
			getReferenceLanguageWorksheetColumnIndex(
				worksheet,
				out referenceLanguageColumnIndex,
				out referenceLanguageName);

			var hasChecksumColumn = checksumColumnIndex >= 0;
			var hasNameColumn = nameColumnIndex >= 0;
			var hasReferenceLanguageColumn = referenceLanguageColumnIndex >= 0;

			// --

			var fgCache = new Dictionary<Guid, DBFileGroupCacheHelper>();

			for (var sourceRowIndex = headerStartRowIndex + 1;
				sourceRowIndex < sourceRowCount; ++sourceRowIndex)
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
									worksheetIndex + 1,
									workbook.Worksheets.Count,
									sourceRowIndex + 1,
									sourceRowCount,
									(int)
									(((sourceRowIndex + 1.0) /
									  (worksheet.Cells.Rows.Count) *
									  ((worksheetIndex + 1.0) /
									   (workbook.Worksheets.Count))) * 100)));
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
								checksum == ConvertHelper.ToInt64(sourceCells[sourceRowIndex, checksumColumnIndex].Value) ||
								!hasChecksumColumn;

							if (passedChecksum)
							{
								List<DataRow> destinationRows;

								if (hasNameColumn)
								{
									var tagName =
										ConvertHelper.ToString(sourceCells[sourceRowIndex, nameColumnIndex].Value);

									if (string.IsNullOrEmpty(tagName))
									{
										// Skip empty worksheet rows.
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
											sourceCells[sourceRowIndex, referenceLanguageColumnIndex].Value);

									if (string.IsNullOrEmpty(refLanguageValue))
									{
										// Skip empty worksheet rows.
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
										var worksheetSourceColumnIndex =
											getWorksheetColumnIndex(
												worksheet,
												languageCode);

										var sourceValue =
											ConvertHelper.ToString(
												sourceCells[sourceRowIndex,
															worksheetSourceColumnIndex].Value,
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

		private static void getReferenceLanguageWorksheetColumnIndex(
			Worksheet worksheet,
			out int referenceLanguageColumnIndex,
			out string referenceLanguageName)
		{
			var languageCodes = dectectLanguageCodesFromWorksheet(worksheet);

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

		private static int getNameWorksheetColumnIndex(
			Worksheet worksheet)
		{
			var cells = worksheet.Cells;

			// For now, use "poor-man's-check" by simply looking which
			// header column contains "Name". 
			// Later, iterate all file groups and check for a reasonable
			// amout of matching file group tag names with Excel worksheet
			// column values.

			// --
			// Header.

			const int headerStartRowIndex = 0;
			const int columnStartIndex = 0;

			for (var columnIndex = columnStartIndex + 0; columnIndex < 30; ++columnIndex)
			{
				var headerCaption =
					(string)cells[headerStartRowIndex, columnIndex].Value;

				if (string.Compare(headerCaption, Resources.SR_CommandProcessorSend_Process_Name, true) == 0)
				{
					return columnIndex;
				}
			}

			// --

			// Not found.
			return -1;
		}

		private static int getChecksumWorksheetColumnIndex(
			Worksheet worksheet)
		{
			int totalChecksumRows;
			var ps = extractColumnCheckSums(worksheet, out totalChecksumRows);

			if (ps.Count <= 0 ||
				totalChecksumRows != worksheet.Cells.Rows.Count - 1)
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

					if (string.Compare(lc, languageCode, true) == 0)
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

					if (string.Compare(lk, tagName, true) == 0 &&
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
					if (string.Compare(lk, referenceLanguageValue, true) == 0 &&
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

		private static int getWorksheetColumnIndex(
			Worksheet worksheet,
			string languageCode)
		{
			foreach (Column column in worksheet.Cells.Columns)
			{
				var lc =
					ConvertHelper.ToString(
						worksheet.Cells[0, column.Index].Value);
				if (string.Compare(lc, languageCode, true) == 0)
				{
					return column.Index;
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