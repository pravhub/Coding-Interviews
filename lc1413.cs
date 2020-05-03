public class Solution {
    public int MinStartValue(int[] nums) {
        int n = nums.Length;
        int[] sum = new int[n]; //int sum = 0;
        sum[0] = nums[0];
        int min = sum[0];
        for(int i=1;i<n;i++)
        {
            sum[i] = sum[i-1]+nums[i];// update
            min = Math.Min(min, sum[i]); //update
        }
        Console.WriteLine(string.Join(" ",sum));
        if(min>0)
            return 1;
        else
            return 1 + -1*min; 
    }
}
