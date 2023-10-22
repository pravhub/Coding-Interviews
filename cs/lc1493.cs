public class Solution {
    public int LongestSubarray(int[] nums) {
        
        int len = nums.Length;
        int countOf0s =0;
        int prevZero = -1;
        int start1=-1;
        int end1 = -1; 
        int max = 0;
          for(int i=0;i<len;i++)
          {
              if(nums[i]==0)
              {
                  if(countOf0s <1)
                  {
                      prevZero = i;
                      countOf0s++;
                      end1++;
                  }
                  else
                  {
                      if(start1!=-1)                          
                        max = prevZero<start1?Math.Max(max, end1-start1+1): Math.Max(max, end1-start1); 
                      //Console.WriteLine("start={0}, end={1},max={2}",start1,end1,max);
                      start1=start1!=-1?prevZero+1:-1;
                      end1=i;
                      prevZero = i;
                      countOf0s=1;
                  }
              }
              else
              {
                  if(start1==-1)
                  {
                      start1= i;
                      end1 = i;
                  }
                  else
                  {
                      end1++;
                  }
              }
          }
        //Console.WriteLine("after loop start={0}, end={1}",start1,end1);
        if(prevZero==-1)
        {
            max = Math.Max(max, end1-start1);
        }
        else if(start1==-1)
        {
            max = 0;
        }
        else
        {
            max = prevZero<start1?Math.Max(max, end1-start1+1): Math.Max(max, end1-start1);                  
        }
        return max;
    }
}
