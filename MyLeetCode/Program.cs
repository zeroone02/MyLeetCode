using MyLeetCode.linkedlist;
using MyLeetCode.Tree;
using System.Collections.Generic;

static int[] TopKFrequent(int[] nums, int k)
{
	var dict = new Dictionary<int, int>();
	for (int i = 0; i < nums.Length; i++)
	{
		if (!dict.ContainsKey(nums[i]))
		{
			dict.Add(nums[i],1);
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

int[] arr = { 1, 1, 1, 2, 2, 3,4,4,4,4 };
var a = TopKFrequent(arr,2);
//1.пройтись по всему массиву 
//    если в dict нет элемента добавить его в key и затем value++,
//    если же он есть в dict, то value++ от его key;
//Ввод: nums = [1, 1, 1, 2, 2, 3], k = 2
//key:1 value 3
//key:2 value 2
//key:3 value 1

//2.Отсортировать словарь и выбрать его первые k элементов
