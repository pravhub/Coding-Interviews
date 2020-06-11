public class Solution {
    public void SortColors_countingsort(int[] nums) {
        int[] counts = new int[3];
        for(int i=0;i<nums.Length;i++)
        {
           counts[nums[i]]++; 
        }
        int j=0;
        for(int i=0;i<nums.Length;i++)
        {
            while(counts[j]<=0)
            {
                j++;
            }
            nums[i] = j;
            counts[j]--;            
        }
    }
    public void SortColors(int[] nums) {
        int n = nums.Length;        
        int next0Pos = 0;
        int next1Pos = 0;
        int next2Pos = n-1;
        while(next1Pos<=next2Pos)
        {
            if(nums[next1Pos]==0)
            {
                int temp = nums[next0Pos];
                nums[next0Pos] = nums[next1Pos];
                nums[next1Pos] = temp;
                next0Pos++;
                next1Pos++;
            }
            else if (nums[next1Pos]==1)
            {
                next1Pos++;
            }
            else if(nums[next1Pos]==2)
            {
                int temp = nums[next1Pos];
                nums[next1Pos] = nums[next2Pos];
                nums[next2Pos] = temp;
                next2Pos--;
            }
        }
     }
}
