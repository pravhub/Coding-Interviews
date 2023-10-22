class Solution:
    def climbStairs(self, n: int) -> int:
        a = 1
        b = 0
        for i in range(n-1, -1, -1):
            temp = a + b
            b = a
            a = temp
        return a
