using MyLeetCode.linkedlist;
using MyLeetCode.Tree;

TreeNode treeNode = new TreeNode(1,null,new TreeNode(2,new TreeNode(3)));
L144 l144 = new L144();
var s = l144.PreorderTraversal(treeNode);
Console.ReadLine();