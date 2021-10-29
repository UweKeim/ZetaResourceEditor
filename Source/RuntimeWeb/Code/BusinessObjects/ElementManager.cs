namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects;

using Base;
using FourZeroFour;
using System.Configuration;
using System.Net.Mail;
using Zeta.VoyagerLibrary.Common;
using Zeta.VoyagerLibrary.Data;
using Zeta.VoyagerLibrary.Data.Abstract;
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

        CacheManager?.StartScavenge();
    }

    public MailAddress OwnerEMailAddress => new(
        ConfigurationManager.AppSettings[@"web.ownerEMailAddress"],
        ConfigurationManager.AppSettings[@"web.ownerEMailDisplayName"]);

    public FourZeroFourManager FourZeroFourManager => _fourZeroFourManager ??= new FourZeroFourManager(this);

    public DataCacheManager CacheManager { get; }

    public IAdoNetQuerier DataQuerier { get; }

    public AdoNetUpdaterInformation DataUpdaterInfo { get; }
}