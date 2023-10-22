class Solution:
    def longestString(self, x: int, y: int, z: int) -> int:
        low = 0
        low_plus_1 = 0
        if x == y:
            low = x
            low_plus_1 = x
        else:
            low = min(x,y)
            low_plus_1 = low + 1
        return low * 2 + low_plus_1 * 2 + z*2        
