namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomPanel;

using DevExpress.XtraEditors;

public class MyPanelControl :
    PanelControl
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        ViewInfo.Appearance.Font = SkinHelper.StandardFont;
    }
}