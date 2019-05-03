using System;
using System.Collections;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;

namespace DXData_Hub
{
    public class TreeListViewState {
        private ArrayList expanded;
        private ArrayList selected;
        private object focused;
        private int topIndex;

        public TreeListViewState() : this(null) { }
        public TreeListViewState(TreeList treeList) {
            this.treeList = treeList;
            expanded = new ArrayList();
            selected = new ArrayList();
        }

        public void Clear() {
            expanded.Clear();
            selected.Clear();
            focused = null;
            topIndex = 0;
        }
        private ArrayList GetExpanded() {
            OperationSaveExpanded op = new OperationSaveExpanded();
            TreeList.NodesIterator.DoOperation(op);
            return op.Nodes;
        }
        private ArrayList GetSelected() {
            ArrayList al = new ArrayList();
            foreach(TreeListNode node in TreeList.Selection)
                al.Add(node.GetValue(TreeList.KeyFieldName));
            return al;
        }

        public void LoadState() {
            TreeList.BeginUpdate();
            try {
                TreeList.CollapseAll();
                TreeListNode node;
                foreach(object key in expanded) {
                    node = TreeList.FindNodeByKeyID(key);
                    if(node != null)
                        node.Expanded = true;
                }
                foreach(object key in selected) {
                    node = TreeList.FindNodeByKeyID(key);
                    if(node != null)
                        TreeList.Selection.Add(node);
                }
                TreeList.FocusedNode = TreeList.FindNodeByKeyID(focused);
            }
            finally {
                TreeList.EndUpdate();
                TreeList.TopVisibleNodeIndex = TreeList.GetVisibleIndexByNode(TreeList.FocusedNode) - topIndex;
            }
        }
        public void SaveState() {
            if(TreeList.FocusedNode != null) {
                expanded = GetExpanded();
                selected = GetSelected();
                focused = TreeList.FocusedNode[TreeList.KeyFieldName];
                topIndex = TreeList.GetVisibleIndexByNode(TreeList.FocusedNode) - TreeList.TopVisibleNodeIndex;
            }
            else
                Clear();
        }

        private TreeList treeList;
        public TreeList TreeList {
            get {
                return treeList;
            }
            set {
                treeList = value;
                Clear();
            }
        }

        class OperationSaveExpanded : TreeListOperation {
            private ArrayList al = new ArrayList();
            public override void Execute(TreeListNode node) {
                if(node.HasChildren && node.Expanded)
                    al.Add(node.GetValue(node.TreeList.KeyFieldName));
            }
            public ArrayList Nodes { get { return al; } }
        }
    }
}
