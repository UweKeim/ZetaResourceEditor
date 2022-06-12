namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.FourZeroFour;

using System.Collections.Generic;
using System.Web;

public class FourZeroFourEMailNotifyIgnoreCollection :
    List<FourZeroFourEMailNotifyIgnore>
{
    public FourZeroFourEMailNotifyIgnoreCollection()
    {
    }

    public FourZeroFourEMailNotifyIgnoreCollection(
        IEnumerable<FourZeroFourEMailNotifyIgnore> collection)
    {
        if (collection != null)
        {
            AddRange(collection);
        }
    }

    public bool IsMatch(HttpRequest request)
    {
        return this.Any(i => i.IsMatch(request));
    }
}