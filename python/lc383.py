class Solution:
    def canConstruct(self, ransomNote: str, magazine: str) -> bool:
        rmap = Counter(ransomNote)
        mmap = Counter(magazine)
        for k,v in rmap.items():
            if k in mmap and mmap[k] >= v:
                pass
            else:
                return False
        return True
