namespace ZetaResourceEditor.UI.Helper.Grid
{
    using DevExpress.XtraGrid.Views.Grid;
    using Zeta.VoyagerLibrary.Tools.Storage;

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

        protected override string KeyPrefix
        {
            get
            {
                return @"Sort";
            }
        }

        public override void Reset()
        {
            base.Reset();

            gridView.ClearSorting();

            if (gridView.SortInfo != null)
            {
                gridView.SortInfo.ClearSorting();
            }
            if (gridView.GroupSummarySortInfo != null)
            {
                gridView.GroupSummarySortInfo.Clear();
            }
            gridView.GroupSummarySortInfoState = null;
        }

        protected override string[] Fields
        {
            get
            {
                return
                    new[]
                        {
							@"SortedColumns",
							@"SortInfo"
                        };
            }
        }
    }
}