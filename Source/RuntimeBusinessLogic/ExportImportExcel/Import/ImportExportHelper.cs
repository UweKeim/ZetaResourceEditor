namespace ZetaResourceEditor.RuntimeBusinessLogic.ExportImportExcel.Import
{
	using System;
	using Aspose.Cells;
	using BL;
	using Export;
	using FileGroups;
	using Projects;
	using Runtime.Excel;

	internal class ImportExportHelper
	{
		private static bool _everLicensed;

		#region Properties
		// ------------------------------------------------------------------

		private static void checkLicense()
		{
			if ( !_everLicensed )
			{
				AsposeLicenseHelper.SetLicenses();

				_everLicensed = true;
			}
		}

		public static void ExportFileGroups(
			Project project,
			string destinationFilePath,
			FileGroupCollection groups,
			ImportExportType type )
		{
			if ( groups != null && groups.Count > 0 )
			{
				checkLicense();

				switch ( type )
				{
					case ImportExportType.Excel:
						{
							var excel = new Workbook();
							excel.Worksheets.Clear();
							AsposeHelper.AddWorkbookStyles( excel );

							foreach ( var fileGroup in groups )
							{
								var worksheet = excel.Worksheets[excel.Worksheets.Add()];
								worksheet.Name = fileGroup.GetChecksum(project).ToString();
								worksheet.Cells[0, 0].Style.Font.Size = 15;
								worksheet.Cells[0, 0].PutValue( fileGroup.GetNameIntelligent(project) );

								var sf =
									new StyleFlag
									{
										All = true
									};
								worksheet.Cells.Rows[1].ApplyStyle( excel.Styles[@"Custom_Style3"], sf );

								var data = new DataProcessing( fileGroup );
								var table = data.GetDataTableFromResxFiles(project);

								// Column 0=FileGroup checksum, column 1=Tag name.
								worksheet.Cells.ImportDataTable( table, true, 1, 1, true );
								worksheet.AutoFitColumns();
								worksheet.AutoFitRows();
							}

							excel.Save( destinationFilePath, FileFormatType.Excel2003 );

							break;
						}
					default:
						throw new ArgumentOutOfRangeException( @"type" );
				}
			}
		}

		public static void ImportExcel(
			string sourceFilePath,
			ImportExportType type )
		{
			checkLicense();

			throw new NotImplementedException( @"ImportExcel" );
		}

		// ------------------------------------------------------------------
		#endregion
	}
}
