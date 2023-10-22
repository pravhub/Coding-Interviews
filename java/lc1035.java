class Solution {
    public int maxUncrossedLines(int[] A, int[] B) {
        int m = A.length;
        int n = B.length;
        int[][] dp= new int[m][n];
        int count = 0;
        for(int i=0;i<m;i++)
        {
            //dp[i] = new int[n];
            for(int j=0;j<n;j++)
            {
                dp[i][j] = 0;
            }
        }
        boolean foundMatch = false;
        for(int i=0;i<m;i++)
        {
            if(foundMatch)
            {
                dp[i][0] = 1;
            }
            else if(B[0]==A[i])
            {
                dp[i][0] = 1;
                count = 1;
                foundMatch =true;
            }
        }
        foundMatch = false;
        for(int j=0;j<n;j++)
        {
            if(foundMatch)
            {
                dp[0][j] = 1;
            }
            else if(B[j]==A[0])
            {
                dp[0][j] = 1;
                count = 1;
                foundMatch =true;
            }
        }
        
        for(int i=1;i<m;i++)
        {
            for(int j=1;j<n;j++)
            {
                if(A[i]==B[j])
                {
                    dp[i][j] =1+ Math.min(dp[i-1][j-1],Math.min(dp[i][j-1],dp[i-1][j]));
                }
                else
                {
                    dp[i][j] = Math.max(dp[i-1][j-1],Math.max(dp[i][j-1],dp[i-1][j]));
                }
                count = Math.max(dp[i][j],count);
            }
        }
        
        return count;
    }
}
