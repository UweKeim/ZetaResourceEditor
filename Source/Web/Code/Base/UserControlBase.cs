namespace Web.Code.Base;

public class UserControlBase :
    Zeta.VoyagerLibrary.WebForms.Base.UserControlBase
{
    public new PageBase Page => (PageBase) base.Page;
}