public class Solution {
    public int[] GetSumAbsoluteDifferences(int[] nums) {
        int n = nums.Length;
        int sum = nums.Sum();
        int[] ans = new int[n];
        int cur = 0;
        
        for(int i=0;i<n;i++)
        {
            int curSum = Math.Abs(cur - (i * nums[i])) + Math.Abs(sum-cur - (n-i)* nums[i]);
            ans[i] =curSum;
            cur+= nums[i];
        }
        return ans;
    }
}
