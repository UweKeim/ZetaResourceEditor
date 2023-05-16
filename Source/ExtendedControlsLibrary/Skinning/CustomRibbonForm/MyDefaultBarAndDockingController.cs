namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomRibbonForm;

using DevExpress.XtraBars;

public class MyDefaultBarAndDockingController :
    DefaultBarAndDockingController
{
    public void Apply()
    {
        // http://devexpress.com/Support/Center/p/B191307.aspx

        Controller.AppearancesRibbon.Item.Font = SkinHelper.StandardFont;
        Controller.AppearancesRibbon.PageHeader.Font = SkinHelper.StandardFont;
        Controller.AppearancesRibbon.PageGroupCaption.Font = SkinHelper.StandardFont;

        Controller.AppearancesBar.Bar.Font = SkinHelper.StandardFont;
        Controller.AppearancesBar.ItemsFont = SkinHelper.StandardFont;
        Controller.AppearancesBar.MainMenu.Font = SkinHelper.StandardFont;
        Controller.AppearancesBar.SubMenu.Menu.Font = SkinHelper.StandardFont;
        Controller.AppearancesBar.SubMenu.MenuBar.Font = SkinHelper.StandardFont;
        Controller.AppearancesBar.SubMenu.MenuCaption.Font = SkinHelper.StandardFont;
        Controller.AppearancesBar.SubMenu.SideStrip.Font = SkinHelper.StandardFont;
        Controller.AppearancesBar.SubMenu.SideStripNonRecent.Font = SkinHelper.StandardFont;

        Controller.PropertiesBar.ScaleEditors = true;
        Controller.PropertiesRibbon.ScaleEditors = true;
    }
}