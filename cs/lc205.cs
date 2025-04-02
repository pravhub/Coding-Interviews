public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var m1 = new Dictionary<char,char>();
        var m2 = new Dictionary<char,char>();
        for(int i=0;i<s.Length;i++)
        {
            if( m1.ContainsKey(s[i]))
            {
                if (m1[s[i]] != t[i])
                    return false;
            }
            else
            {
                if(m2.ContainsKey(t[i]))
                    return false;
                m1.Add(s[i], t[i]);
                m2.Add(t[i], s[i]);
            }
        }
        return true;
    }
}
