public class Solution {
    public int MaxSubarraySumCircular(int[] A) {  
        int maxSum = int.MinValue;
        int minSum = int.MaxValue;
        int totalSum = 0;
        int curSumMax = 0;
        int curSumMin = 0;
        for(int i=0;i<A.Length;i++)
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
            return Math.Max(maxSum, totalSum-minSum);
    }
    public int MaxSubarraySumCircular_nSquare(int[] A) {   
        
        int overallMax = int.MinValue;
        
        for(int start = 0;start<A.Length;start++)
        {
            int startIdx = start;
            int endIdx = start;
            int maxSum = int.MinValue;
            int curSum = 0;
            for(int i=start;i<A.Length;i++)
            {
                curSum = curSum + A[i];
                if(maxSum < curSum)
                {
                    maxSum = curSum;
                    endIdx++;
                }
                if(maxSum<A[i])
                {
                    maxSum = A[i];
                    startIdx = i;
                    endIdx = i;
                }
                if(curSum < A[i])
                {
                    curSum = A[i];
                    startIdx = i;
                    endIdx = i;
                }
            }

            for(int i=0;i<start;i++)
            {
                curSum+=A[i];
                if(curSum> maxSum)
                {
                    maxSum = curSum;
                }
            }            
            overallMax = Math.Max(overallMax, maxSum); 
        }
        return overallMax;
    }
}
