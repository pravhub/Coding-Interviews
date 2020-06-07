public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] ans = new int[2*n];
        int i =0;//x1 starts.
        int j=n; //y1 starts.
        int idx = 0;
        while(i<n)
        {
            ans[idx++]=nums[i++];
            ans[idx++]=nums[j++];
        }
        return ans;
    }
}
