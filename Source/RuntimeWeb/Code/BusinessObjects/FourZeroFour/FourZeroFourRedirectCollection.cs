namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.FourZeroFour
{
	using System.Collections.Generic;

	public class FourZeroFourRedirectCollection :
		List<FourZeroFourRedirect>
	{
		public FourZeroFourRedirectCollection()
		{
		}

		public FourZeroFourRedirectCollection(
			IEnumerable<FourZeroFourRedirect> collection)
		{
			if (collection != null)
			{
				AddRange(collection);
			}
		}
	}
}