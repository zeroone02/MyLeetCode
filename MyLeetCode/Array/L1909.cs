namespace MyLeetCode.Array;
public class L1909
{
    public bool CanBeIncreasing(int[] nums)
    {
        int count = 0;
        int value = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > value)
            {
                value = nums[i];
                i++;
            }
            else
            {
                count++;
                if (count > 2)
                {
                    return false;
                }
                value = nums[i - 1];
            }
        }
        return true;
    }
}

