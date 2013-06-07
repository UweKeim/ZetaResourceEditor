using System.Web;
using ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects;

public class Host
{
	private ElementManager _elementManager;

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

	public static Host Current
	{
		get
		{
			return GetCurrent(HttpContext.Current);
		}
	}

	private void initialize()
	{
		_elementManager = new ElementManager();
	}

	public ElementManager ElementManager
	{
		get
		{
			return _elementManager;
		}
	}
}