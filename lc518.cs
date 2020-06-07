public class Solution { 
    int combinations;
    public int Change(int amount, int[] coins) {
        combinations = 0;
        int n = coins.Length;
        int[][] dp = new int[n][];
        for(int i=0;i<n;i++)
        {
            dp[i] = new int[amount + 1];
            for(int j=0;j<amount+1;j++)
            {
                dp[i][j] = -1;
            }
        }
        combinations = CountRecWithMemoization(amount, coins,0,dp);
        return combinations;
    }
    private int CountRec(int amount, int[] coins , int i)
    {
        if(amount ==0) 
            return 1;
        if(amount < 0)
            return 0;
        if(i>=coins.Length)
            return 0;
        int withCurrentCoin_i = CountRec(amount-coins[i], coins, i);
        int withoutCurrentCoin_i = CountRec(amount, coins, i+1);
        
        int total = withCurrentCoin_i + withoutCurrentCoin_i;
        return total;
    }
    private int CountRecWithMemoization(int amount, int[] coins , int i, int[][] dp)
    {        
        if(amount ==0) 
            return 1;
        if(amount < 0)
            return 0;
        if(i>=coins.Length)
            return 0;
        if(dp[i][amount]!=-1)
            return dp[i][amount];
        
        int withCurrentCoin_i = CountRecWithMemoization(amount-coins[i], coins, i, dp);
        int withoutCurrentCoin_i = CountRecWithMemoization(amount, coins, i+1,dp);
        
        int total = withCurrentCoin_i + withoutCurrentCoin_i;
        dp[i][amount] = total;
        return total;
    }
    }
