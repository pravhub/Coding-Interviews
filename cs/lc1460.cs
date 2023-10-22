public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        int m = target.Length;
        int n = arr.Length;
        if(m!=n)
            return false;
        Dictionary<int,int> map1 = new Dictionary<int,int>();
        Dictionary<int,int> map2 = new Dictionary<int,int>();
        for(int j=0;j<n;j++)
        {
            int i = target[j];
            if(!map1.ContainsKey(i))
            {
                map1.Add(i,0);
            }
            map1[i]++;
            i = arr[j];
            if(!map2.ContainsKey(i))
            {
                map2.Add(i,0);
            }
            map2[i]++;
        }
        foreach(var kvp in map1)
        {
            if(!map2.ContainsKey(kvp.Key) || map2[kvp.Key]!=kvp.Value)
            {
                return false;
            }
        }
        return true;
    }
}
