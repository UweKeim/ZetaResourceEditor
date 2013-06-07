namespace ZetaResourceEditor.UI.Helper.Grid
{
    using DevExpress.XtraGrid.Views.Grid;
    using Zeta.EnterpriseLibrary.Tools.Storage;

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

        protected override string KeyPrefix
        {
            get
            {
                return @"Filter";
            }
        }

        public override void Reset()
        {
            base.Reset();

            gridView.ClearColumnsFilter();
            
            if (gridView.ActiveFilter != null)
            {
                gridView.ActiveFilter.Clear();
            }

            gridView.ActiveFilterEnabled = false;
            gridView.ActiveFilterCriteria = null;
            gridView.ActiveFilterString = null;

            if (gridView.MRUFilters != null)
            {
                gridView.MRUFilters.Clear();
            }
        }

        protected override string[] Fields
        {
            get
            {
                return
                    new[]
                        {
							//@"ActiveFilterEnabled",
							@"ActiveFilterString"
							//@"MRUFilters",
							//@"ActiveFilter",
                        };
            }
        }
    }
}