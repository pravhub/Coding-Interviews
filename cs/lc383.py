public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {

        Dictionary<char,int> rmap = new Dictionary<char,int>();
        var mmap = new Dictionary<char,int>();
        foreach(char c in ransomNote)
        {
            if(!rmap.ContainsKey(c))
            {
                rmap.Add(c,1);
            }
            else
            {
                rmap[c]++;
            }
        }
        foreach(char c in magazine)
        {
            if(!mmap.ContainsKey(c))
            {
                mmap.Add(c,1);
            }
            else
            {
                mmap[c]++;
            }
        }
        foreach(var kvp in rmap)
        {
            if(mmap.ContainsKey(kvp.Key) && mmap[kvp.Key] >= kvp.Value)
                continue;
            else
                return false;
        }
        return true;
    }
}
