class Solution:
    def alternateDigitSum(self, n: int) -> int:
        pos = True
        sums = 0
        for x in str(n):
            if pos:
                sums += int(x)
                pos = False
            else:
                sums -= int(x)
                pos = True
        return sums
