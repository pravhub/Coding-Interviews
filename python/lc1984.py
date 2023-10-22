class Solution:
    # 2 liner
    def minimumDifference(self, nums: List[int], k: int) -> int:
        nums.sort()
        return min(nums[i+k-1] - nums[i] for i in range(len(nums)-k+1))
    # verbose
    def minimumDifference2(self, nums: List[int], k: int) -> int:
        nums.sort()
        minDiff = sys.maxsize
        for i in range(len(nums)-k+1):
            minDiff = min(minDiff, nums[i+k-1] - nums[i])
        if minDiff == sys.maxsize:
            minDiff = 0
        return minDiff
