using BinaryTreeViewer;
using System.Runtime.CompilerServices;
using ViewTree;
using ViewTree.BinaryTrees;

BinaryTree<int> tree = new BinaryTree<int>(15);
BinaryTree<int> tree2 = new BinaryTree<int>(7);
tree.SetLeftNode(tree2);
tree2.SetLeftNode(new BinaryTree<int>(4));
BinaryTree<int> tree3 = new BinaryTree<int>(51);
tree.SetRightNode(tree3);
tree3.SetLeftNode(new BinaryTree<int>(25));
tree3.SetRightNode(new BinaryTree<int>(100));

BTViewer.View(tree);

Console.WriteLine("In order ");
Methods.InOrder(tree);

