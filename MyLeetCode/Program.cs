static int MaxProfit(int[] prices)
{
	List<int> maxPrice = new List<int>();
	int buy = prices[0];
	for (int i = 1; i < prices.Length; i++)
	{
		if (buy > prices[i])
		{
			buy = prices[i];
		}
		if (buy < prices[i])
		{
			maxPrice.Add(prices[i] - buy);
		}
	}
	if (maxPrice.Count == 0) return 0;
	return maxPrice.Max();
}
int[] prices = { 1,4,2};
var c = MaxProfit(prices);
Console.WriteLine(c);
//Входные данные: цены = [7,2,5,3,6,1]