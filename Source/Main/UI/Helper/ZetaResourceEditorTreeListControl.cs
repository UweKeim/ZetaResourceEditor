namespace ZetaResourceEditor.UI.Helper
{
    using DevExpress.XtraTreeList.Nodes;
    using ExtendedControlsLibrary.Skinning.CustomTreeList;
    using System;
    using System.Windows.Forms;
    using ZetaAsync;

    public partial class ZetaResourceEditorTreeListControl :
        MyTreeList
    {
        public ZetaResourceEditorTreeListControl()
        {
            InitializeComponent();
        }

        public bool WasDoubleClick { get; set; }

        private const int WmLbuttondblclk = 0x203;

        protected override void WndProc(ref Message m)
        {
            // http://groups.google.com/group/microsoft.public.dotnet.framework.windowsforms/msg/d16ac686dc6b42?hl=en&lr=&ie=UTF-8
            if (m.Msg == WmLbuttondblclk)
            {
                WasDoubleClick = true;
            }

            base.WndProc(ref m);
        }

        private const string DummyNode = @"8f6daa3-3e1c-4a55-b53c-6ca8e68a282a";

        protected override bool RaiseBeforeExpand(
            TreeListNode node)
        {
            CheckExpandDynamicNodes(node);
            return base.RaiseBeforeExpand(node);
        }

        public event EventHandler<ExpandDynamicChildrenEventArgs> ExpandDynamicChildren;

        public void CheckExpandDynamicNodes(
            TreeListNode node)
        {
            if (
                (node.Nodes.Count > 0 &&
                 node.Nodes[0][0] as string == DummyNode) ||
                (node[0] as string == DummyNode))
            {
                ExpandDynamicChildren?.Invoke(this, new ExpandDynamicChildrenEventArgs(node));
            }
        }

        public void CheckAddDummyNode(TreeListNode node)
        {
            if (node.Nodes.Count <= 0)
            {
                AppendNode(
                    new object[]
                    {
                        DummyNode,
                        null,
                        null,
                        null,
                        null
                    },
                    node);
            }
        }

        public void ClearSelection()
        {
            var prevCount = Selection.Count + 1;
            while (Selection.Count > 0 && prevCount > Selection.Count)
            {
                Selection[0].Selected = false;
                prevCount = Selection.Count;
            }
        }

        public TreeListNode SelectedNode
        {
            get => Selection.Count <= 0 ? null : Selection[0];
            set
            {
                ClearSelection();

                if (value != null)
                {
                    value.Selected = true;
                }

                FocusedNode = value;

                if (value != null)
                {
                    MakeNodeVisible(value);
                }
            }
        }

        /// <summary>
        /// Moves the specified node up by one,
        /// staying in the same level.
        /// Wraps if at the top.
        /// </summary>
        /// <param name="item">The item.</param>
        public void MoveItemUpByOne(
            TreeListNode item)
        {
            BeginUpdate();
            try
            {
                var nodes = item.ParentNode == null ? Nodes : item.ParentNode.Nodes;

                var itemIndex = GetNodeIndex(item);

                var newItemIndex = itemIndex - 1;
                SetNodeIndex(item, newItemIndex < 0 ? nodes.Count : newItemIndex);
            }
            finally
            {
                EndUpdate();
            }
        }

        /// <summary>
        /// Moves the specified node down by one,
        /// staying in the same level.
        /// Wraps if at the top.
        /// </summary>
        /// <param name="item">The item.</param>
        public void MoveItemDownByOne(
            TreeListNode item)
        {
            BeginUpdate();
            try
            {
                var nodes = item.ParentNode == null ? Nodes : item.ParentNode.Nodes;

                var itemIndex = GetNodeIndex(item);

                var newItemIndex = itemIndex + 1;
                SetNodeIndex(item, newItemIndex >= nodes.Count ? 0 : newItemIndex);
            }
            finally
            {
                EndUpdate();
            }
        }

        public void SortChildrenAlphabetically(
            TreeListNode item)
        {
            BeginUpdate();
            try
            {
                // http://de.wikipedia.org/wiki/Bubblesort.
                var n = item.Nodes.Count;
                bool changed;

                do
                {
                    changed = false;
                    for (var i = 0; i < n - 1; i++)
                    {
                        var iA = item.Nodes[i].GetDisplayText(0);
                        var iB = item.Nodes[i + 1].GetDisplayText(0);

                        if (string.Compare(iA, iB, StringComparison.OrdinalIgnoreCase) > 0)
                        {
                            var xA = GetNodeIndex(item.Nodes[i]);
                            var xB = GetNodeIndex(item.Nodes[i + 1]);

                            SetNodeIndex(item.Nodes[i + 1], xA);

                            changed = true;
                        }
                    }

                } while (changed);

                //var nodes = item.Nodes.Cast<TreeListNode>().ToList();

                //nodes.Sort((x, y) => x.GetDisplayText(0).CompareTo(y.GetDisplayText(0)));

                //item.Nodes.Clear();
                //nodes.ForEach(item.Nodes.Add);

                // --

                //var nodes = item.ParentNode == null ? Nodes : item.ParentNode.Nodes;

                //var itemIndex = GetNodeIndex(item);

                //var newItemIndex = itemIndex + 1;
                //SetNodeIndex(item, newItemIndex >= nodes.Count ? 0 : newItemIndex);
            }
            finally
            {
                EndUpdate();
            }
        }

        /// <summary>
        /// Ensures the items order positions set.
        /// </summary>
        public void EnsureItemsOrderPositionsSet(
            object threadPoolManager,
            TreeListNode parentNode,
            AsynchronousMode asynchronousMode)
        {
            var previousOrderPosition = -1;

            var nodes = parentNode == null ? Nodes : parentNode.Nodes;

            // Take the current item order of the items in the
            // list and ensure the order position is
            // ascending (not naturally immediate following numbers).
            var itemIndex = 0;
            while (itemIndex < nodes.Count)
            {
                var listViewItem = nodes[itemIndex];

                var obj = (IOrderPosition)listViewItem.Tag;

                var currentOrderPosition = obj.OrderPosition;

                // Must adjust.
                if (currentOrderPosition <= previousOrderPosition)
                {
                    // Increment.
                    var newCurrentOrderPosition = previousOrderPosition + 1;

                    if (obj.OrderPosition != newCurrentOrderPosition)
                    {
                        // New order position.
                        obj.OrderPosition = newCurrentOrderPosition;

                        // Mark as modified, but do no display update,
                        // since nothing VISUAL has changed.
                        obj.StoreOrderPosition(threadPoolManager, null, asynchronousMode, null);
                    }

                    // Remember for next turn.
                    previousOrderPosition = newCurrentOrderPosition;
                }
                else
                {
                    // Remember for next turn.
                    previousOrderPosition = currentOrderPosition;
                }

                itemIndex++;
            }
        }

        public static bool IsNodeChildNodeOf(TreeListNode nodeToTest, TreeListNode potentialParentNode)
        {
            if (nodeToTest == potentialParentNode)
            {
                return true;
            }
            else
            {
                foreach (TreeListNode node in potentialParentNode.Nodes)
                {
                    if (IsNodeChildNodeOf(nodeToTest, node)) return true;
                }

                return false;
            }
        }
    }
}