namespace ZetaResourceEditor.UI.Helper.Grid;

using DevExpress.XtraGrid.Views.Grid;
using Zeta.VoyagerLibrary.Tools.Storage;

internal class AllLayoutSerializer
{
    private readonly FilterSerializer _filterSerializer;
    private readonly SortSerializer _sortSerializer;

    public AllLayoutSerializer(
        GridView gridView,
        IPersistentPairStorage storage,
        string key)
    {
        _filterSerializer = new FilterSerializer(gridView, storage, key);
        _sortSerializer = new SortSerializer(gridView, storage, key);
    }

    public void Save()
    {
        _filterSerializer.Save();
        _sortSerializer.Save();
    }

    public void Restore()
    {
        _filterSerializer.Restore();
        _sortSerializer.Restore();
    }

    public virtual void Reset()
    {
        _filterSerializer.Reset();
        _sortSerializer.Reset();
    }
}