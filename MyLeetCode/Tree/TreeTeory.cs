using System.Collections.Generic;

namespace MyLeetCode.Tree;
public class TreeTeory
{
    //DFS, Depth-first search, или же обходы в глубину

    //1.Префиксный обход, или же Preorder            5
    //    Элемент                                  /   \
    //    Левое                                   3     8
    //    Правое                                 / \   / \
    //                                          1   4  7  9
    //                                           \    /
    //                                            2  6
   // например Копирование

    //                                        5 3 1 2 4 8 7 6 9 
    public void Preorder(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();

            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);

        }
    }

    //2.Постфиксный обход, или же Postorder           5
    //    Левое                                     /   \
    //    Правое                                   3     8
    //    Элемент                                 / \   / \
    //                                          1   4  7  9
    //                                           \    /
    //                                            2  6
    // например Удаление

    //                                        2 1 4 3 6 7 9 8 5

    public void Postorder(TreeNode root)
    {
        var list = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            list.Insert(0, node.val);
            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);

        }
        //return list
    }


    //3.Инфиксный обход, или же Inorder              5
    //    Левое                                    /   \
    //    Элемент                                 3     8
    //    Правое                                 / \   / \
    //                                          1   4  7  9
    //                                           \    /
    //                                            2  6
    // например сортировка для binary search tree

    //                                        1 2 3 4 5 6 7 8 9

    public void Inorder(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while (stack.Count > 0 || root != null)
        {
            if (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            else
            {
                root = stack.Pop();
                root = root.right;
            }
        }
    }


    //BFS 
  //4.Обход по уровням, или же Breadth-First Search  5
    //    Элемент                                  /   \
    //    Соседи 1 уровня                         3     8
    //    Соседи N уровня                       / \   / \
    //                                          1   4  7  9
    //                                           \    /
    //                                            2  6
    // 

    //                                        5 3 8 1 4 7 9 2 6 

    public void LevelOrder()
    {

    }

}
