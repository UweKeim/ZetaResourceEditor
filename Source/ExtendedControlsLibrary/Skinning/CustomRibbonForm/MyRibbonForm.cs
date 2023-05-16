namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomRibbonForm;

using DevExpress.XtraBars.Ribbon;

public class MyRibbonForm :
    RibbonForm
{
    public new bool DesignMode => base.DesignMode || DesignModeHelper.IsDesignMode;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        // Do this even in design mode to have valid UI.
        Appearance.Font = SkinHelper.StandardFont;
    }
}