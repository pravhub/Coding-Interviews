class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        si, ti = 0,0
        while si <len(s) and ti < len(t):
            if s[si] == t[ti]:
                si += 1
                ti += 1
            else:
                ti += 1
        return si == len(s)
