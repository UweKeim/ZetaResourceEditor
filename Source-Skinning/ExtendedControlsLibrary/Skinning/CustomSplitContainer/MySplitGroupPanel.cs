namespace ExtendedControlsLibrary.Skinning.CustomSplitContainer;

using DevExpress.XtraEditors;

public class MySplitGroupPanel :
    SplitGroupPanel
{
    public MySplitGroupPanel(SplitContainerControl owner)
        : base(owner)
    {
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Font = SkinHelper.StandardFont;
    }
}