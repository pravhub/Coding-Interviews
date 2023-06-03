class Solution:
    def pivotIndex(self, nums: List[int]) -> int:
        n = len(nums)
        right = [0] * n
        right[-1] = nums[-1]

        for j in range(n-2, -1,-1):
            right[j] = right[j+1] + nums[j]
        
        left_sum = 0
        right_sum = right[0]
        right.append(0)
        for i in range(n):
            if left_sum == right[i+1]:
                return i
            right_sum -= nums[i]
            left_sum += nums[i]

        return -1
