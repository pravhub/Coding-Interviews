class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        k = 0
        nxt = 1
        while nxt < len(nums):
            if nums[k] == nums[nxt]:
                nxt += 1
            else:
                nums[k+1] = nums[nxt]
                k += 1
                nxt += 1
        return k+1
