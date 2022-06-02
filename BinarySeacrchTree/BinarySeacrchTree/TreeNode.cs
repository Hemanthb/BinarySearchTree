using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class TreeNode<T>
    {
        public T KeyValue { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T keyValue)
        {
            this.KeyValue = keyValue;
            this.Left = null;
            this.Right = null;
        }

        public void setLeftTree(T data)
        {
            Left = new TreeNode<T>(data);
        }
        public void setRightTree(T data)
        {
            Right = new TreeNode<T>(data);
        }
    }
}
