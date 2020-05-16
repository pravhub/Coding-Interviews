class Solution {
    public int maxPower(String s) {        
        int maxLen = 1;
        int n = s.length();
        int curLen = 1;
        for(int i=1;i<n;i++)
        {
            if(s.charAt(i-1)==s.charAt(i))
            {
                curLen++;
            }
            else
            {
                maxLen = Math.max(maxLen,curLen);
                curLen = 1;
            }
        }
        maxLen = Math.max(maxLen,curLen);
        return maxLen;
    }
}
