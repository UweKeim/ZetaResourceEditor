namespace ZetaResourceEditor.UI.Helper
{
	using System;
	using DevExpress.XtraTreeList.Nodes;

	public class ExpandDynamicChildrenEventArgs :
		EventArgs
	{
	    public ExpandDynamicChildrenEventArgs(
			TreeListNode node )
		{
			Node = node;
		}

		public TreeListNode Node { get; }
	}
}