class Solution:
    def wordPattern(self, pattern: str, s: str) -> bool:
        toks = s.split(' ')
        if len(pattern)!= len(toks):
            return False
        
        m1 = {}
        m2 = {}
        for i in range(len(pattern)):
            if pattern[i] in m1:
                if m1[pattern[i]] != toks[i]:
                    return False
            else:
                if toks[i] in m2:
                    return False
                m1[pattern[i]] = toks[i]
                m2[toks[i]] = pattern[i]
        return True
