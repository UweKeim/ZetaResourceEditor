public class UserControlBase :
	Zeta.EnterpriseLibrary.Web.Base.UserControlBase
{
	public new PageBase Page
	{
		get
		{
			return (PageBase)base.Page;
		}
	}
}