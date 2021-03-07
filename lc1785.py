class Solution:
    def minElements(self, nums: List[int], limit: int, goal: int) -> int:
        curSum = sum(nums) #O(n)
        count = 0
        diff = goal - curSum;
        diff = -diff if diff < 0 else diff #abs(diff)
        while(diff > 0):
            if(diff >= limit):
                times = diff // limit
                count = count + times
                diff = diff - limit*times
            else:
                limit = limit - 1
                        
        return count
