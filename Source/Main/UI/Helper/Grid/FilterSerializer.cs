namespace ZetaResourceEditor.UI.Helper.Grid;

using DevExpress.XtraGrid.Views.Grid;
using Zeta.VoyagerLibrary.Tools.Storage;

internal class FilterSerializer :
    LayoutSerializerBase
{
    public FilterSerializer(
        GridView gridView,
        IPersistentPairStorage storage,
        string key) :
        base(gridView, storage, key)
    {
    }

    protected override string KeyPrefix => @"Filter";

    public override void Reset()
    {
        base.Reset();

        gridView.ClearColumnsFilter();

        gridView.ActiveFilter?.Clear();

        gridView.ActiveFilterEnabled = false;
        gridView.ActiveFilterCriteria = null;
        gridView.ActiveFilterString = null;

        gridView.MRUFilters?.Clear();
    }

    protected override string[] Fields => new[]
    {
        //@"ActiveFilterEnabled",
        @"ActiveFilterString"
        //@"MRUFilters",
        //@"ActiveFilter",
    };
}