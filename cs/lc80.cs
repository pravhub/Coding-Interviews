public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 2)
            return nums.Length;
        int i = 0;
        int idx = 0;
        while (i<nums.Length)
        { 
            int count = 0;
            int cur = nums[i];
            while(i<nums.Length && nums[i] == cur)
            {
                i += 1;
                count +=1;
            }
            if (count >= 2)
            {
                nums[idx] = cur;
                idx = idx + 1;
                nums[idx] = cur;
                idx = idx + 1;
            }
            else
            {
                nums[idx] = cur;
                idx +=1;
            }
        }
        return idx;
    }
}
