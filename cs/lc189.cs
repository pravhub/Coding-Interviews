public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;
        int[] ans = new int[n];
        for(int i = 0;i<n-k; i++)
        {
            ans[i+k] = nums[i];
        }
        int idx = 0;
        for(int i = n-k;i<n; i++)
        {
            ans[idx++] = nums[i];
        }
        for(int i=0;i<n;i++)
        {
            nums[i] = ans[i];
        }
    }
}
