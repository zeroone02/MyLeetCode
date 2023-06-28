namespace MyLeetCode.arrays;
public class L217
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> visited = new HashSet<int>(nums);
        if (nums.Length == visited.Count)
        {
            return false;
        }
        return true;
    }
}
