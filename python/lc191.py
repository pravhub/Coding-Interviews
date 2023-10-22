class Solution:
    def hammingWeight(self, n: int) -> int:
        ones = 0
        while n > 0:
            ones += 0 if n %2 == 0 else 1
            n = n // 2
        return ones
