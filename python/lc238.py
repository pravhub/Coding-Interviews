class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prefix,suffix =  [0] * len(nums), [0] * len(nums)
        prefix[0] = nums[0]
        suffix[len(nums)-1] = nums[len(nums)-1]
        ans = [0] * len(nums)

        for i in range(1, len(nums)):
            prefix[i] = prefix[i-1]*nums[i]
        for i in range(len(nums)-2, -1,-1):
            suffix[i] = suffix[i+1]*nums[i]

        ans[0] = suffix[1]
        ans[len(nums)-1] = prefix[len(nums)-2]
        for i in range(1,len(nums)-1):
            ans[i] = prefix[i-1] * suffix[i+1]
        return ans
