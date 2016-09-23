namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.FourZeroFour
{
	using System.Data;
	using Base;
	using Zeta.VoyagerLibrary.Data.Caching;

	public class FourZeroFourManager :
		DBObjectsManagerBase
	{
		public FourZeroFourManager(
			ElementManager elementManager)
			: base(elementManager)
		{
		}

		public FourZeroFourRedirectCollection GetFourZeroFourRedirects(
			string categoryName)
		{
			var table =
				ElementManager.DataQuerier.ExecuteTable(
					@"SELECT *
					FROM [404Redirect]
					WHERE [Category]=@C
					AND [IsActive]=$(true)
					ORDER BY [OrderPosition]",
					ElementManager.DataQuerier.CreateParameterCollection(
						ElementManager.DataQuerier.CreateParameter(@"@C", categoryName)
						),
					new DataCacheInformation(@"404Redirect"));

			var result = new FourZeroFourRedirectCollection();

			if (table != null)
			{
				foreach (DataRow row in table.Rows)
				{
					result.Add(new FourZeroFourRedirect().Load(row));
				}
			}

			return result;
		}

		public FourZeroFourEMailNotifyIgnoreCollection GetFourZeroFourEMailNotifyIgnores(
			string categoryName )
		{
			var table =
				ElementManager.DataQuerier.ExecuteTable(
					@"SELECT *
					FROM [404EMailNotifyIgnore]
					WHERE [Category]=@C
					AND [IsActive]=$(true)",
					ElementManager.DataQuerier.CreateParameterCollection(
						ElementManager.DataQuerier.CreateParameter(@"@C", categoryName)
						),
					new DataCacheInformation(@"404EMailNotifyIgnore"));

			var result = new FourZeroFourEMailNotifyIgnoreCollection();

			if (table != null)
			{
				foreach (DataRow row in table.Rows)
				{
					result.Add(new FourZeroFourEMailNotifyIgnore().Load(row));
				}
			}

			return result;
		}
	}
}