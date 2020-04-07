//time = O(N) - N is length of nums.
//space = O(N) worst case.
//2,4,6,8,10 = "2","4","6","8","10".
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<String> ranges = new List<String>();
        int n = nums.Length;
        string curRange = "";
        Int64 start = Int64.MaxValue; //int.max
        int rangeCount = 0;
        for(int i=0;i<n;i++)
        {
            if(start == Int64.MaxValue)
            {
                start = nums[i];
                rangeCount++;
            }
            if(i+1<n && nums[i]+1==nums[i+1])
            {    
                rangeCount++;
                continue;
            }
            else
            {
                ranges.Add(GetRangeString(rangeCount, start, nums[i]));
                rangeCount=0;
                start = Int64.MaxValue;
            }
        }
        return ranges;
    }
    private string GetRangeString(int rangeCount, long start, int num)
    {
        if(rangeCount>1)
        {
            return string.Format("{0}->{1}",start,num);
        }
        else
        {
            return string.Format("{0}",start);
        }
    }
}
