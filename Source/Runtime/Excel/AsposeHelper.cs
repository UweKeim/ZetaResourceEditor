namespace ZetaResourceEditor.Runtime.Excel
{
	using Aspose.Cells;

	public class AsposeHelper
	{
		public static void AddWorkbookStyles(Workbook workbook)
		{
			Style style;
			for (int i = 1; i < 7; i++)
			{
				int index = workbook.Styles.Add();
				style = workbook.Styles[index];
				style.Name = @"Custom_Style" + i;
				style.ForegroundColor = ExcelHelper.SafeExcelColors.White;
				style.Pattern = BackgroundType.Solid;
				//style.HorizontalAlignment = TextAlignmentType.Center;
				style.VerticalAlignment = TextAlignmentType.Bottom;
				style.Font.Name = @"Arial";
				style.Font.Size = 10;
			}

			//Custom_Style1
			style = workbook.Styles[@"Custom_Style1"];
			style.Custom = @"[>0] ##,###,##0.0000 ""Euro"";";
			style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.BottomBorder].Color = ExcelHelper.SafeExcelColors.Silver;
			style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.RightBorder].Color = ExcelHelper.SafeExcelColors.Black;

			//Custom_Style2
			style = workbook.Styles[@"Custom_Style2"];
			style.HorizontalAlignment = TextAlignmentType.Left;
			style.ForegroundColor = ExcelHelper.SafeExcelColors.Black;
			style.Font.Color = ExcelHelper.SafeExcelColors.White;
			style.Font.IsBold = true;
			style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.BottomBorder].Color = ExcelHelper.SafeExcelColors.Silver;
			style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.RightBorder].Color = ExcelHelper.SafeExcelColors.Black;

			//Custom_Style3
			style = workbook.Styles[@"Custom_Style3"];
			style.HorizontalAlignment = TextAlignmentType.Left;
			style.ForegroundColor = ExcelHelper.SafeExcelColors.Black;
			style.Font.Color = ExcelHelper.SafeExcelColors.White;
			style.Font.IsBold = true;
			style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.BottomBorder].Color = ExcelHelper.SafeExcelColors.Silver;
			style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.RightBorder].Color = ExcelHelper.SafeExcelColors.Black;

			//Custom_Style4
			style = workbook.Styles[@"Custom_Style4"];
			style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.BottomBorder].Color = ExcelHelper.SafeExcelColors.Silver;
			style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.RightBorder].Color = ExcelHelper.SafeExcelColors.Black;

			//Custom_Style5
			style = workbook.Styles[@"Custom_Style5"];
			style.ForegroundColor = ExcelHelper.SafeExcelColors.White;
			style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.BottomBorder].Color = ExcelHelper.SafeExcelColors.Silver;
			style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
			style.Borders[BorderType.RightBorder].Color = ExcelHelper.SafeExcelColors.Black;

			//Custom_Style6
			style = workbook.Styles[@"Custom_Style6"];
			style.Custom = @"[>0] ##,###,##0.0000 ""Euro"";";
			style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Double;
			style.Borders[BorderType.TopBorder].Color = ExcelHelper.SafeExcelColors.Black;
		}

	}
}
