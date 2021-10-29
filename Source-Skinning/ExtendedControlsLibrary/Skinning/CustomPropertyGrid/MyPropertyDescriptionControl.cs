namespace ExtendedControlsLibrary.Skinning.CustomPropertyGrid;

using DevExpress.XtraVerticalGrid;

public class MyPropertyDescriptionControl :
    PropertyDescriptionControl
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Font = SkinHelper.StandardFont;
    }
}