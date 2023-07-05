class Solution:
    def longestAlternatingSubarray(self, nums: List[int], threshold: int) -> int:
        l,r = -1,-1
        longest = 0
        for i in range(len(nums)):
            if nums[i] <= threshold:                
                if l == -1 and nums[i] % 2 == 0:
                    l, r = i,i
                elif l != -1 and nums[i-1] %2 != nums[i] %2:
                        r += 1
                elif l != -1:
                    longest = max(longest, r-l+1)
                    if nums[i] % 2 == 0:
                        l, r = i, i
                    else:
                        l, r = -1, -1
            else:
                if l != -1:
                    longest = max(longest, r-l+1)
                    l, r = -1, -1
        if l != -1:
            longest = max(longest, r-l+1)
        return longest
