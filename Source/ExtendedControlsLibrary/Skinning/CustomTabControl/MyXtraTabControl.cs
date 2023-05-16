namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomTabControl;

using DevExpress.XtraTab;

/// <summary>
/// A tab control that is not "visible" during runtime and only
/// serves as a way to allow for programmatical switching between 
/// multiple layered pages.
/// </summary>
public class MyXtraTabControl :
    XtraTabControl
{
    protected override XtraTabPageCollection CreateTabCollection()
    {
        // http://www.devexpress.com/Support/Center/p/S130636.aspx
        // http://www.devexpress.com/Support/Center/p/CQ23743.aspx

        return new MyXtraTabPageCollection(this);
    }
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Font = SkinHelper.StandardFont;
        AppearancePage.Header.Font = SkinHelper.StandardFont;
    }
}