public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int n = nums.Length;
        if(n==0)
            return 0;
        int start =0;
        int end = n-1;
        while(start<end)
        {            
            int mid = start + (end-start)/2;
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid]>target)
            {
                end = mid-1;
            }
            else
            {
                start = mid+1;
            }
        }
        if(start<=end && nums[end]<target)
            return end+1;
        return start;
    }
}
