using System.Web;
using ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects;

namespace Web.Code;

public class Host
{
    public static Host GetCurrent(HttpContext context)
    {
        var host = context.Session[@"Host.Current"] as Host;

        if ( host == null )
        {
            lock ( context )
            {
                // ReSharper disable ConditionIsAlwaysTrueOrFalse
                if ( host == null )
                    // ReSharper restore ConditionIsAlwaysTrueOrFalse
                {
                    host = new Host();
                    host.initialize();
                    context.Session[@"Host.Current"] = host;
                }
            }
        }

        return host;
    }

    public static Host Current => GetCurrent(HttpContext.Current);

    private void initialize()
    {
        ElementManager = new ElementManager();
    }

    public ElementManager ElementManager { get; private set; }
}