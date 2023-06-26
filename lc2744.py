class Solution:
    def maximumNumberOfStringPairs(self, words: List[str]) -> int:
        m = {}
        count = 0
        for word in words:
            rev = word[::-1]
            if rev in m:
                m[rev] += 1
                count += 1
            else:
                m[word] = 1
        return count
