class Solution:
    def applyOperations(self, nums: List[int]) -> List[int]:
        for i in range(len(nums)-1):
            if nums[i] == nums[i+1]:
                nums[i] *= 2
                nums[i+1] = 0
        
        
        z_idx =0
        while z_idx < len(nums):
            while z_idx < len(nums) and nums[z_idx] != 0:
                z_idx += 1 
            idx = z_idx
            while idx < len(nums) and nums[idx] == 0:
                idx += 1
            if z_idx < len(nums) and idx < len(nums):
                nums[idx], nums[z_idx] = nums[z_idx], nums[idx]
            idx+=1
            z_idx+=1
                
        return nums
