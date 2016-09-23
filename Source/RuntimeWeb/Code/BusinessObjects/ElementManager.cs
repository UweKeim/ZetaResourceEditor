namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects
{
	using System.Configuration;
	using System.Net.Mail;
	using Base;
	using FourZeroFour;
	using Zeta.VoyagerLibrary.Common;
	using Zeta.VoyagerLibrary.Data;
	using Zeta.VoyagerLibrary.Data.Base;
	using Zeta.VoyagerLibrary.Data.Caching;
	using Zeta.VoyagerLibrary.Data.Common;
	using Zeta.VoyagerLibrary.Data.Sql;

	public class ElementManager :
		DBObjectsManagerBase
	{
		private FourZeroFourManager _fourZeroFourManager;

		public ElementManager() :
			base(null)
		{
			ElementManager = this;

			if (ConvertHelper.ToBoolean(ConfigurationManager.AppSettings[@"dataCache.enable"], true))
			{
				CacheManager = new DataCacheManager();
				CacheManager.Initialize(new DataCacheManagerConfiguration());
			}
			else
			{
				CacheManager = null;
			}

			DataQuerier = new AdoNetSqlQuerier();
			DataQuerier.Initialize(CacheManager);

			DataQuerier.ConnectionString = new SmartConnectionString(
				ConfigurationManager.ConnectionStrings[@"web"].ConnectionString);

			// --

			// Do this AFTER initializing the configuration.
			DataUpdaterInfo = new AdoNetUpdaterInformation(false);

			// --

			if (CacheManager != null)
			{
				CacheManager.StartScavenge();
			}
		}

		public MailAddress OwnerEMailAddress
		{
			get
			{
				return new MailAddress(
					ConfigurationManager.AppSettings[@"web.ownerEMailAddress"],
					ConfigurationManager.AppSettings[@"web.ownerEMailDisplayName"]);
			}
		}

		public FourZeroFourManager FourZeroFourManager
		{
			get
			{
				if (_fourZeroFourManager == null)
				{
					_fourZeroFourManager = new FourZeroFourManager(this);
				}

				return _fourZeroFourManager;
			}
		}

		public DataCacheManager CacheManager
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the data querier.
		/// </summary>
		/// <value>The data querier.</value>
		public IAdoNetQuerier DataQuerier
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the data updater info.
		/// </summary>
		/// <value>The data updater info.</value>
		public AdoNetUpdaterInformation DataUpdaterInfo
		{
			get;
			private set;
		}
	}
}