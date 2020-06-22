public class Solution {
    public int SingleNumber_sort(int[] nums) {
        Array.Sort(nums);
        int count =1;
        int cur = nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            if(cur==nums[i])
            {
                count++;
            }
            else
            {
                if(count!=3)
                {
                    cur = nums[i-1];
                    break;
                }
                else
                {
                    count = 1;
                    cur = nums[i];
                }
            }
        }
        return cur;
    }
    public int SingleNumber_map(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(!map.ContainsKey(i))
            {
                map.Add(i,0);
            }
            map[i]++;
        }
        return map.Where(m=>m.Value!=3).ToDictionary(m=>m.Key,m=>m.Value).First().Key;
    }
    public int SingleNumber(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        long uniqueSum = 0;
        long totalSum =0;
        foreach(int i in nums)
        {
            if(!hs.Contains(i))
            {
                hs.Add(i);
                uniqueSum+=i;
            }
            totalSum+=i;
        }
        return (int)((3* uniqueSum - totalSum)/2);
    }
}
