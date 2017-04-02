namespace ZetaResourceEditor.UI.Helper
{
	using System;
	using System.Collections.Generic;
	using DevExpress.XtraTreeList.Nodes;
	using DevExpress.XtraTreeList.Nodes.Operations;
	using Zeta.VoyagerLibrary.Common;
	using Zeta.VoyagerLibrary.Logging;
	using Zeta.VoyagerLibrary.Tools;
	using Zeta.VoyagerLibrary.Tools.Storage;

	/// <summary>
	/// See http://www.devexpress.com/Support/Center/KB/p/A1249.aspx.
	/// </summary>
	[Serializable]
	public class TreeListViewState
	{
		private List<Guid> _expanded;
		private List<Guid> _selected;
		private Guid _focused;
		private int _topIndex;

		[NonSerialized]
		private ZetaResourceEditorTreeListControl _treeList;

		public TreeListViewState()
			: this( null )
		{
		}
		public TreeListViewState(
			ZetaResourceEditorTreeListControl treeList )
		{
			_treeList = treeList;
			_expanded = new List<Guid>();
			_selected = new List<Guid>();
		}

		public void Clear()
		{
			_expanded.Clear();
			_selected.Clear();
			_focused = Guid.Empty;
			_topIndex = 0;
		}

		public void PersistsState( string key )
		{
			SaveState();
			var s = StringHelper.SerializeToString( this );

			PersistanceHelper.SaveValue( key, s );
		}

		public void RestoreState( string key )
		{
			var s = PersistanceHelper.RestoreValue( key );
			if ( s != null )
			{
				TreeListViewState state;
				try
				{
					state =
						(TreeListViewState)
						StringHelper.DeserializeFromString(
							s as string );
				}
				catch ( ArgumentException )
				{
					state = null;
				}

				if ( state != null )
				{
					_expanded = state._expanded;
					_focused = state._focused;
					_selected = state._selected;
					_topIndex = state._topIndex;

					loadState();
				}
			}
		}

		private List<Guid> getExpanded()
		{
			var op = new OperationSaveExpanded();
			TreeList.NodesIterator.DoOperation( op );

			// Sort ascending to never need to expand dynamic items.
			op.IDs.Sort();

			return op.IDs;
		}

		private List<Guid> getSelected()
		{
			var al = new List<Guid>();
			foreach ( TreeListNode node in TreeList.Selection )
			{
				var obj = node.Tag as IUniqueID;
				al.Add(obj == null ? Guid.Empty : obj.UniqueID);
			}

			// Sort ascending to never need to expand dynamic items.
			al.Sort();

			return al;
		}

		private void loadState()
		{
			TreeList.BeginUpdate();
			try
			{
				//TreeList.CollapseAll();

				foreach ( var tag in _expanded )
				{
					var node = findNodeByTag( tag );
					if ( node != null )
					{
						TreeList.CheckExpandDynamicNodes( node );
						node.Expanded = true;
					}
				}

				foreach ( var key in _selected )
				{
					var node = findNodeByTag( key );
					if ( node != null )
					{
						TreeList.Selection.Add( node );
					}
				}

				TreeList.FocusedNode = findNodeByTag( _focused );
			}
			finally
			{
				TreeList.EndUpdate();
				TreeList.TopVisibleNodeIndex =
					TreeList.GetVisibleIndexByNode( TreeList.FocusedNode ) - _topIndex;
			}
		}

		private TreeListNode findNodeByTag( Guid tag )
		{
			if ( tag == Guid.Empty )
			{
				return TreeList.Nodes.Count > 0 ? TreeList.Nodes[0] : null;
			}
			else
			{
				return doFindNodeByTag( null, tag );
			}
		}

		private TreeListNode doFindNodeByTag(
			TreeListNode node,
			Guid tag )
		{
			if ( node != null )
			{
				var obj = node.Tag as IUniqueID;

				if ( obj != null )
				{
					var oID = obj.UniqueID;

					if ( oID == tag )
					{
						LogCentral.Current.LogInfo($@"Tree: FOUND(!) ID: {oID} (tag: {tag}).");
						return node;
					}
					else
					{
						LogCentral.Current.LogInfo($@"Tree: Not found; ID: {oID} (tag: {tag}).");
					}
				}
				else
				{
					LogCentral.Current.LogInfo($@"Tree: Not found; Non-ID (tag: {tag}).");
				}
			}

			// --

			var childNodes = node == null ? TreeList.Nodes : node.Nodes;

			foreach ( TreeListNode childNode in childNodes )
			{
				var result = doFindNodeByTag( childNode, tag );

				if ( result != null )
				{
					return result;
				}
			}

			return null;
		}

		public void SaveState()
		{
			_expanded = getExpanded();
			_selected = getSelected();

			var node = TreeList.FocusedNode;
			if ( node != null )
			{
				_topIndex =
					TreeList.GetVisibleIndexByNode( node ) -
					TreeList.TopVisibleNodeIndex;

				var obj = node.Tag as IUniqueID;
				if ( obj != null )
				{
					_focused = obj.UniqueID;
				}
			}
			else
			{
				//Clear();
				_focused = Guid.Empty;
				_topIndex = 0;
			}
		}

		public ZetaResourceEditorTreeListControl TreeList
		{
			get => _treeList;
		    set
			{
				_treeList = value;
				Clear();
			}
		}

		private class OperationSaveExpanded :
			TreeListOperation
		{
		    public override void Execute( TreeListNode node )
			{
				if ( node.HasChildren && node.Expanded )
				{
					var obj = node.Tag as IUniqueID;
					if ( obj != null )
					{
						IDs.Add( obj.UniqueID );
					}
				}
			}

			public List<Guid> IDs { get; } = new List<Guid>();
		}
	}
}