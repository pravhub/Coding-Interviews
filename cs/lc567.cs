public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(char c in s1)
        {
            if(!map.ContainsKey(c))
            {
                map.Add(c,0);
            }
            map[c]++;
        }
        Dictionary<char, int> smap = new Dictionary<char, int>();
        for(int i=0;i<s2.Length;i++)
        {
            if(!smap.ContainsKey(s2[i]))
            {
                smap.Add(s2[i],0);
            }            
            smap[s2[i]]++;
            if(i>=s1.Length-1)
            {
                if(CheckIfMapsAreEqual(map, smap))
                {
                    return true;
                }
                smap[s2[i-s1.Length+1]]--;
                if(smap[s2[i-s1.Length+1]]==0)
                {
                    smap.Remove(s2[i-s1.Length+1]);
                }
            }
        }
        return false;
    }
    private bool CheckIfMapsAreEqual(Dictionary<char, int> a, Dictionary<char, int> b)
    {
        if(a.Count != b.Count)
            return false;
        foreach(var kvp in a)
        {
            if(b.ContainsKey(kvp.Key) && a[kvp.Key] ==b[kvp.Key])
            {
                //we are good
            }
            else
            {
                return false;
            }
        }
        return true;
    }    
}
