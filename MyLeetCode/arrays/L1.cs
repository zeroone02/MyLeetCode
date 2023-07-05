namespace MyLeetCode.arrays;
public class L1
{
    public int[] TwoSum(int[] nums, int target)
    {
        var pairs = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (pairs.ContainsKey(target - nums[i]))
            {
                return new int[] { pairs[target - nums[i]], i };
            }
            pairs.TryAdd(nums[i], i);
        }
        return default;
    }
}
//Входные данные: числа = [-1,0,1,2,-1,-4]
