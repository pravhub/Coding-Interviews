class Solution:
    def minimumAverage(self, nums: List[int]) -> float:
        nums.sort()
        n = len(nums)
        min_avg = sys.maxsize
        for i in range(n//2):
            cur_avg  = (nums[i] + nums[n-i-1])/2
            min_avg = min(min_avg, cur_avg)
        return min_avg
