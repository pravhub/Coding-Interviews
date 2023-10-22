/*
https://leetcode.com/problems/find-the-smallest-divisor-given-a-threshold/

first calculate the sum of the array elements and also max of the array elements.
if the sum is less than threshold then the smallestDivisor=1
otherwise we need to do a binary search from [1 to max of array].
while doing binary search calculate the division output. here division output is rounded to next number.
*/
public class Solution {
    public int SmallestDivisor(int[] nums, int threshold) {
        Int64 sum =0;
        int smallestDivisor = 1;
        
        int max = int.MinValue;
        for(int i=0;i<nums.Length;i++)
        {
            max = Math.Max(max,nums[i]);
            sum+=nums[i];
        }
        if(sum>threshold)
        {
            int mid = (int)Math.Ceiling((smallestDivisor+max)/2.0);
            while(smallestDivisor < max)
            {
                Console.WriteLine("min= {0} max= {1}, mid = {2}",smallestDivisor,max,mid);
                sum =0;
                
                for(int i=0;i<nums.Length;i++)
                {
                    sum+= (int)Math.Ceiling((double)nums[i]/mid);
                }
                Console.WriteLine("sum= {0} threshold ={1}",sum,threshold);
                if(sum>threshold)
                {
                    smallestDivisor = mid;
                }
                else//if(sum<=threshold)
                {
                    max = mid;                    
                }
                int newMid = (int)Math.Ceiling((smallestDivisor+max)/2.0);
                if(newMid == mid)
                {
                    smallestDivisor = mid;
                    break;
                }
                else
                {
                    mid = newMid;
                }
            }
        }
        return smallestDivisor;
    }
}
