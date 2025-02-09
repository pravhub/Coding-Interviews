#https://leetcode.com/problems/sum-of-variable-length-subarrays/
class Solution:
    def subarraySum(self, nums: List[int]) -> int:
        total = 0
        for i in range(0,len(nums)):
            start = max(0, i-nums[i])
            curSum = sum(nums[start:i+1])
            total += curSum
        return total
      
