namespace ExtendedControlsLibrary.Skinning.CustomTreeList
{
    using DevExpress.XtraTreeList;

    public static class TreeListHelper
	{
		public static void ConfigureTreeUI(
			TreeList treeView)
		{
			treeView.OptionsBehavior.ImmediateEditor = false;
			treeView.OptionsBehavior.Editable = false;

			treeView.OptionsView.ShowColumns = false;
            treeView.OptionsView.FocusRectStyle= DrawFocusRectStyle.None;
			treeView.OptionsView.ShowHorzLines = false;
			treeView.OptionsView.ShowIndentAsRowStyle = true; // Do not use in hover trees.
			treeView.OptionsView.ShowIndicator = false;
			treeView.OptionsView.ShowVertLines = false;
		}
	}
}