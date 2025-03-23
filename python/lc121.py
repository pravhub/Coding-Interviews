class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        n = len(prices)
        max_profit = 0
        buy = prices[0]
        sell = prices[0]
        for i in range(1,n):            
            if prices[i] > sell:
                sell = prices[i]
                max_profit = max(max_profit, sell - buy)
            elif prices[i] < buy:
                buy = prices[i]
                sell = prices[i]
        return max_profit

