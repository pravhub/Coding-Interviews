public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length < 1)
            return 0;
        int idx = 0;
        while(idx < nums.Length && nums[idx] != val)
        {
            idx++;
        }
        for(int i=idx;i< nums.Length;i++)
        {
            if (nums[i] != val)
            {
                nums[idx] = nums[i];
                idx++;
            }
        }
        return idx;
    }
}
