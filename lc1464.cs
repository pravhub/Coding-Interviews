public class Solution {
    public int MaxProduct(int[] nums) {
        int i = -1;
        int j = -1;
        int maxi = int.MinValue;
        int maxj = int.MinValue;
        for(int k=0;k<nums.Length;k++)
        {
            if(maxi<nums[k])
            {
                i = k;
                maxi = nums[k];
            }
        }
        for(int k=0;k<nums.Length;k++)
        {
            if(k!=i && maxj<nums[k])
            {
                j = k;
                maxj = nums[k];
            }
        }
        return (maxi-1) * (maxj-1);
    }
}
