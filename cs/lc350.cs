public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int,int> map1 = new Dictionary<int,int>();
        Dictionary<int,int> map2 = new Dictionary<int,int>();
        foreach(int i in nums1)
        {
            if(map1.ContainsKey(i))
            {
                map1[i]++;
            }
            else
            {
                map1.Add(i,1);
            }                
        }
        foreach(int i in nums2)
        {
            if(map2.ContainsKey(i))
            {
                map2[i]++;
            }
            else
            {
                map2.Add(i,1);
            }                
        }
        
        List<int> ans  = map1.Count>map2.Count?CompareMaps(map2,map1): CompareMaps(map1,map2);
        return ans.ToArray();
    }
    private List<int> CompareMaps(Dictionary<int,int> map1 , Dictionary<int,int> map2)
    {
        List<int> ans = new List<int>();
        foreach(var kvp in map1)
        {
            if(map2.ContainsKey(kvp.Key))
            {
                int num = Math.Min(kvp.Value,map2[kvp.Key]);
                for(int i=0;i<num;i++)
                {
                    ans.Add(kvp.Key);
                }
            }
        }
        return ans;
    }
}
