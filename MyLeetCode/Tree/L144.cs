namespace MyLeetCode.Tree;
public class L144
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        if (root == null) return list;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            list.Add(node.val);

            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);

        }
        return list;
    }
}
