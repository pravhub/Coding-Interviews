class Solution:
    def findMaxAverage(self, nums: List[int], k: int) -> float:
        max_avg = float(-inf)
        cur_sum = 0
        for i in range(len(nums)):
            if i < k:
                cur_sum += nums[i]
            else:
                max_avg = max(max_avg, cur_sum/k)
                cur_sum = cur_sum + nums[i] - nums[i-k]
        max_avg = max(max_avg, cur_sum/k)
        return max_avg
