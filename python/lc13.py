class Solution:
    def romanToInt(self, s: str) -> int:
        m = {'I':1,'V':5,'X':10,'L':50,'C':100,'D':500, 'M':1000}
        ans = 0
        prev = 4000
        if len(s) == 1:
            return m[s]
        for i in range(1,len(s)):
            cur = m[s[i-1]]
            nxt = m[s[i]]
            if nxt > cur:
                ans -= cur
            else:
                ans += cur

        return ans + m[s[-1]]

        
