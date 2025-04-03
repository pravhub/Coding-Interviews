class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        m = Counter(s)
        for c in t:
            if c in m:
                m[c] -= 1
                if m[c] == 0:
                    del m[c]
            else:
                return False
        return len(m) == 0
