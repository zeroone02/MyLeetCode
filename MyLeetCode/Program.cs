using MyLeetCode.linkedlist;
using MyLeetCode.Tree;
static int[] TwoSum(int[] nums, int target)
{
   var pairs = new Dictionary<int, int>();
	for (int i = 0; i < nums.Length; i++)
	{
		if (pairs.ContainsKey(target - nums[i]))
		{
			return new int[] {pairs[target - nums[i]],i};
		}
		pairs.TryAdd(nums[i], i);
	}
	return default;
}
//Входные данные: числа = [2,7,11,15], цель = 9 
int[] n = { 2, 7, 11, 15,1,1,2,3 };
TwoSum(n, 4);