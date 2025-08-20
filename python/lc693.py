class Solution:
    def hasAlternatingBits(self, n: int) -> bool:
        prev = n % 2
        n = n // 2
        while n > 0:
            rem = n % 2
            n = n // 2
            if prev == rem:
                return False
            prev = rem
        return True
