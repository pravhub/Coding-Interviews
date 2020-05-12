public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int start = 0;
        int end = nums.Length -1;
        while(start<end)
        {
            int mid = start + (end-start)/2;
            if((mid%2==0 && nums[mid] == nums[mid+1]) ||  (mid%2==1 && nums[mid] == nums[mid-1]))
            {
                start = mid+1;
            }
            else
            {
                end = mid;
            }
        }
        return nums[start];
    }
    public int SingleNonDuplicate_XOR(int[] nums) {
        
        int ans = nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            ans = ans^ nums[i];
        }
        return ans;
    }
}
