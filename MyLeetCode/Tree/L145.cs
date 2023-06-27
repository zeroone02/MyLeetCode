
namespace MyLeetCode.Tree;
public class L145
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> list = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode curr = root;
        while (stack.Count > 0 || curr != null)
        {
            if (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            else
            {
                curr = stack.Pop();
                list.Add(curr.val);
                curr = curr.right;
            }
        }
        return list;
    }
}
