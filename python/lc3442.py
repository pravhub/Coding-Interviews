# https://leetcode.com/problems/maximum-difference-between-even-and-odd-frequency-i/
class Solution:
    def maxDifference(self, s: str) -> int:
        counts = Counter(s)
        odd = 0
        even = 9999
        for c in counts:
            if counts[c] %2 == 0:
                even = min(even, counts[c])
            else:
                odd = max(odd, counts[c])

        return odd - even
