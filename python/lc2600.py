class Solution:
    def kItemsWithMaximumSum(self, numOnes: int, numZeros: int, numNegOnes: int, k: int) -> int:
        ans = 0
        if k < numOnes:
            return k
        else:
            ans += numOnes
            k -= numOnes
            if k < numZeros:
                return ans
            else:
                k -= numZeros
                m = min(k, numNegOnes)
                ans += -m
        return ans
