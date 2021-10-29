namespace ExtendedControlsLibrary.Skinning.CustomGrid;

using CustomForm;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

// http://www.devexpress.com/Support/Center/p/A859.aspx

public class MyGridControl :
    GridControl
{
    protected override BaseView CreateDefaultView()
    {
        return CreateView(@"MyGridView");
    }

    protected override void RegisterAvailableViewsCore(InfoCollection collection)
    {
        base.RegisterAvailableViewsCore(collection);
        collection.Add(new MyGridInfoRegistrator());
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