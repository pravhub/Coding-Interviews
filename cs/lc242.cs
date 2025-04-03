public class Solution {
    public bool IsAnagram(string s, string t) {
        if( s.Length != t.Length)
            return false;
        Dictionary<char,int> m = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if (m.ContainsKey(c))
                m[c]++;
            else
                m.Add(c,1);
        }
        foreach(char c in t)
        {
            if(m.ContainsKey(c))
            {
                m[c] -= 1;
                if (m[c] == 0)
                    m.Remove(c);
            }
            else
                return false;
        }
        return m.Count == 0;
    }
}
