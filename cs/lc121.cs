public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int max_profit = 0;
        int buy = prices[0];
        int sell = prices[0];
        for(int i = 1;i<n; i++)        
        {
            if (prices[i] > sell)
            {
                sell = prices[i];
                max_profit = Math.Max(max_profit, sell - buy);
            }
            else if (prices[i] < buy)
            {
                buy = prices[i];
                sell = prices[i];
            }
        }
        return max_profit;
    }
}
