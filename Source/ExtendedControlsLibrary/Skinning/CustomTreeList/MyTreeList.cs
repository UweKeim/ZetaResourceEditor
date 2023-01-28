namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomTreeList;

using CustomForm;
using General.ExtendedTree;

public class MyTreeList :
    ExtendedTreeListControl
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Font = SkinHelper.StandardFont;
        ViewInfo.PaintAppearance.Empty.Font = SkinHelper.StandardFont;
        ViewInfo.PaintAppearance.HeaderPanel.Font = SkinHelper.StandardFont;
        ViewInfo.PaintAppearance.OddRow.Font = SkinHelper.StandardFont;
        ViewInfo.PaintAppearance.EvenRow.Font = SkinHelper.StandardFont;
        ViewInfo.PaintAppearance.Row.Font = SkinHelper.StandardFont;
    }

    protected override void OnLoaded()
    {
        base.OnLoaded();

        if (!DesignModeHelper.IsDesignMode)
        {
            MenuManager = MyXtraForm.CheckGetMenuBarManager(this);
        }
    }
}