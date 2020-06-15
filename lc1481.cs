public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int i in arr)
        {
            if(!map.ContainsKey(i))
            {
                map.Add(i,0);
            }
            map[i]++;
        }
        map = map.OrderBy(m=>m.Value).ToDictionary(m=>m.Key, m=>m.Value);//sort by num of occurences
        int ans = map.Count;
        foreach(var kvp in map)
        {
            if(kvp.Value<=k)
            {
                k = k-kvp.Value;
                ans--;
            }
            else
            {
                break;
            }
        }
        return ans;
    }
}
