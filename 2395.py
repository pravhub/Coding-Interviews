class Solution:
    def findSubarrays(self, nums: List[int]) -> bool:
        sub_array_sums = set()
        for i in range(len(nums)-1):
            cur_sum = nums[i] + nums[i+1]
            if cur_sum in sub_array_sums:
                return True
            else:
                sub_array_sums.add(cur_sum)
        return False
