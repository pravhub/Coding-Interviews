class Solution:
    def distinctAverages(self, nums: List[int]) -> int:
        nums.sort()
        i = 0
        j = len(nums)-1
        s = set()
        while i < j:
            s.add((nums[i]+nums[j])/2)
            i += 1
            j -= 1
        return len(s)
