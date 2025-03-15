class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        if len(nums) <= 2:
            return len(nums)
        i = 0
        idx = 0
        while i<len(nums): 
            count = 0
            cur = nums[i]
            while i<len(nums) and nums[i] == cur:
                i += 1
                count +=1
            if count >= 2:
                nums[idx] = cur
                idx = idx + 1
                nums[idx] = cur
                idx = idx + 1
            else:
                nums[idx] = cur
                idx +=1
        return idx
