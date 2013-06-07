namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.FourZeroFour
{
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
			foreach (var i in this)
			{
				if (i.IsMatch(request))
				{
					return true;
				}
			}

			return false;
		}
	}
}