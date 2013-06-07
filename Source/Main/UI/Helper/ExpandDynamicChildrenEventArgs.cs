namespace ZetaResourceEditor.UI.Helper
{
	using System;
	using DevExpress.XtraTreeList.Nodes;

	public class ExpandDynamicChildrenEventArgs :
		EventArgs
	{
		private readonly TreeListNode _node;

		public ExpandDynamicChildrenEventArgs(
			TreeListNode node )
		{
			_node = node;
		}

		public TreeListNode Node
		{
			get
			{
				return _node;
			}
		}
	}
}