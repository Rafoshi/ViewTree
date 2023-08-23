using BinaryTreeViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewTree
{
    internal class Methods
    {
        public static void InOrder(BinaryTree<int> root)
        {
            if (root == null) return;
            InOrder(root.GetLeftNode());
            Console.Write(" " + root.value);
            InOrder(root.GetRightNode());
        }
    }
}
