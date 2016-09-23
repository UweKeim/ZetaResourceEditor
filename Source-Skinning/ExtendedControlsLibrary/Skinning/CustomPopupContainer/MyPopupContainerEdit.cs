namespace ExtendedControlsLibrary.Skinning.CustomPopupContainer
{
    using DevExpress.XtraEditors;

    public class MyPopupContainerEdit :
		PopupContainerEdit
	{
		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			Font = SkinHelper.StandardFont;
		}
	}
}