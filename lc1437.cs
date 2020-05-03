public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int idx = 0;
        int n = nums.Length;
        bool apart = true;
        while(idx<n && nums[idx]!=1)
        {
            idx++;
        }
        int onesIdx = idx+k+1;
        idx++;
        while(idx<n)
        {
            //Console.WriteLine("onesIdx = {0}, idx = {1}",onesIdx, idx);
            if(idx<onesIdx )
            {
                if(nums[idx]==1)
                {
                    return false;
                }
            }
            else 
            {
                if(nums[idx]==1)
                    onesIdx = idx+k+1;
            }
            idx++;
        }
        return apart;
    }
}
