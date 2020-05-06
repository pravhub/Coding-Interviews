public class Solution {
    public int MajorityElement(int[] nums) {
        int majority = nums[0];
        int count=1;
        for(int i=1;i<nums.Length;i++)
        {
            if(majority == nums[i])
            {
                count++;
            }
            else
            {
                count--;
                if(count<=0)
                {
                    count = 1;
                    majority = nums[i];
                }
            }
        }
        return majority;
    }
}
