public class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        List<int> subArraySum = new List<int>();
        int mod = 1000000007;
        int[] cum = new int[n];
        cum[0] = nums[0];
        subArraySum.Add(cum[0]);
        BigInteger sum = 0;
        for(int i=1;i<n;i++)
        {
            cum[i]= nums[i] + cum[i-1];
            subArraySum.Add(cum[i]);
        }
        
        for(int i=1;i<n;i++)
        {
            for(int j=i;j<n;j++)
            {
                subArraySum.Add(cum[j]-cum[i-1]);
            }
        }                
        subArraySum.Sort();        
        //Console.WriteLine(string.Join(" ", subArraySum));
        for(int i=left-1;i<right;i++)
        {
            sum+=subArraySum[i];
            sum = sum % mod;
        }
        return (int)sum;
    }
}
