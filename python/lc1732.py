class Solution:
    def largestAltitude(self, gain: List[int]) -> int:
        alt =  0
        max_alt = 0
        for i in gain:
            alt += i
            max_alt = max(max_alt, alt)
        return max_alt
