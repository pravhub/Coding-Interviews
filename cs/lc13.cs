public class Solution {
    public int RomanToInt(string s) {
        var m = new Dictionary<char,int>();
        m.Add('I',1);
        m.Add('V',5);
        m.Add('X',10);
        m.Add('L',50);
        m.Add('C',100);
        m.Add('D',500);
        m.Add('M',1000);
        int ans = 0;

        for (int i =1;i< s.Length;i++)
        {
            int cur = m[s[i-1]];
            int nxt = m[s[i]];
            if (nxt > cur)
                ans -= cur;
            else
                ans += cur;
        }
        return ans + m[s[s.Length-1]];
    }
}
