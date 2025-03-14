class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        if len(nums) < 1:
            return 0
        idx = 0
        while idx < len(nums) and nums[idx] != val:
            idx += 1
        for i in range(idx, len(nums)):
            if nums[i] != val:
                nums[idx] = nums[i]
                idx +=1
        return idx
