/*
 time = O(n)
 space = O(1)
*/
public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int n = arr.Length;
        int subArrayCount =0;
        double curSum = 0.0;
        for(int i=0; i<n; i++)
        {
            if(i<k)
            {
                curSum+=arr[i];
            }
            else
            {
                if(curSum/k >= threshold)
                {
                    subArrayCount++;
                }
                
                curSum = curSum - arr[i-k];
                //Console.WriteLine("{0},{1},{2}", i, i-k, curSum);
                curSum = curSum + arr[i];
            }
        }
        if(curSum/k >= threshold)
        {
            subArrayCount++;
        }
        
        return subArrayCount;
    }
}
