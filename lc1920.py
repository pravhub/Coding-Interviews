class Solution:
    def buildArray1Liner(self, nums: List[int]) -> List[int]:
        return [ nums[nums[i]] for i in range(len(nums)) ]
