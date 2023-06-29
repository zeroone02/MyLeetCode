namespace MyLeetCode.arrays;
public class L347
{
    static int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 1);
            }
            else
            {
                dict[nums[i]]++;
            }
        }
        var ordered = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        int[] res = ordered.Select(x => x.Key).Take(k).ToArray();
        return res;
    }
}
