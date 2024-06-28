class Solution:
    def minimumOperations(self, nums: List[int]) -> int:
        ans = 0
        for i in nums:
            rem =  i % 3
            ans += min(rem, abs(rem-3))
        return ans
