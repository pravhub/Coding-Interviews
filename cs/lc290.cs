public class Solution {
    public bool WordPattern(string pattern, string s) {
        var m1 = new Dictionary<char,string>();
        var m2 = new Dictionary<string,char>();
        string []toks = s.Split(" ");
        if (pattern.Length != toks.Length)
            return false;
        for(int i=0;i<pattern.Length;i++)
        {
            if( m1.ContainsKey(pattern[i]))
            {
                if (m1[pattern[i]] != toks[i])
                    return false;
            }
            else
            {
                if(m2.ContainsKey(toks[i]))
                    return false;
                m1.Add(pattern[i], toks[i]);
                m2.Add(toks[i], pattern[i]);
            }
        }
        return true;
    }
}
