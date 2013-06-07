namespace ZetaResourceEditor.Runtime.Excel
{
	using System.IO;
	using System.Text;
	using Properties;

	public static class AsposeLicenseHelper
	{
		public static void SetLicenses()
		{
			var s = Resources.SR_Aspose_Cells_License;
			if ( !string.IsNullOrEmpty( s ) && s.Trim().Length > 0 )
			{
				using ( var ms = new MemoryStream( Encoding.UTF8.GetBytes( s ) ) )
				{
					ms.Seek( 0, SeekOrigin.Begin );
					new Aspose.Cells.License().SetLicense( ms );
				}
			}
		}
	}
}