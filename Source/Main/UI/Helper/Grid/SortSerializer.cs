namespace ZetaResourceEditor.UI.Helper.Grid;

using DevExpress.XtraGrid.Views.Grid;

internal class SortSerializer :
    LayoutSerializerBase
{
    public SortSerializer(
        GridView gridView,
        IPersistentPairStorage storage,
        string key) :
        base(gridView, storage, key)
    {
    }

    protected override string KeyPrefix => @"Sort";

    public override void Reset()
    {
        base.Reset();

        gridView.ClearSorting();

        gridView.SortInfo?.ClearSorting();
        gridView.GroupSummarySortInfo?.Clear();
        gridView.GroupSummarySortInfoState = null;
    }

    protected override string[] Fields => new[]
    {
        @"SortedColumns",
        @"SortInfo"
    };
}