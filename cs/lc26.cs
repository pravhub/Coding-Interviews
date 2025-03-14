public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if( nums.Length <=1)
            return nums.Length;
        int idx = 1;
        int i = 1;
        while(i < nums.Length)
        {
            if(nums[i] == nums[i-1])
            {
                i++;
            }
            else
            {
                nums[idx] = nums[i];
                idx++;
                i++;
            }
        }
        return idx;
    }
}
