class Solution:
    def bulbSwitch(self, n: int) -> int:
        i = 1
        ans = 0
        while i*i <= n:
            i += 1
            ans +=1
        return ans
