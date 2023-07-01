namespace MyLeetCode.arrays;
public class L128
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;
        HashSet<int> hs = new HashSet<int>(nums);
        hs = hs.OrderBy(x => x).ToHashSet();
        nums = hs.ToArray();
        int index = 1;
        int count = 1;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(index, count);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] + 1 == nums[i])
            {
                dict[index]++;
            }
            else
            {
                dict.Add(++index, 1);
            }
        }
        dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        return dict.ElementAt(0).Value;
    }
}
