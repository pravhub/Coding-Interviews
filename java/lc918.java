class Solution {
    public int maxSubarraySumCircular(int[] A) {
        int maxSum = Integer.MIN_VALUE;
        int minSum = Integer.MAX_VALUE;
        int totalSum = 0;
        int curSumMax = 0;
        int curSumMin = 0;
        for(int i=0;i<A.length;i++)
        {           
            totalSum+=A[i];
            curSumMax = curSumMax + A[i];
            curSumMin = curSumMin + A[i];
            if(curSumMax < A[i])
            {
                curSumMax = A[i];
            } 
            if(maxSum < curSumMax)
            {
                maxSum = curSumMax;
            }
            
            if(curSumMin > A[i])
            {
                curSumMin = A[i];
            } 
            if(minSum>curSumMin)
            {
                minSum = curSumMin;
            }
        }
        if(totalSum == minSum)
            return maxSum;
        else
            return Math.max(maxSum, totalSum-minSum);
    }
}
