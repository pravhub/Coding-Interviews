public class Solution {
    public int MaxPower(string s) {
        int maxLen = 1;
        int n = s.Length;
        int curLen = 1;
        for(int i=1;i<n;i++)
        {
            if(s[i-1]==s[i])
            {
                curLen++;
            }
            else
            {
                maxLen = Math.Max(maxLen,curLen);
                curLen = 1;
            }
        }
        maxLen = Math.Max(maxLen,curLen);
        return maxLen;
    }
}
