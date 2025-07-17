class Solution:
    def summaryRanges(self, nums: List[int]) -> List[str]:
        ans = []
        if len(nums) < 1:
            return ans
        start = nums[0]
        end = nums[0]
        for i in range(1, len(nums)):
            if end+1 == nums[i]:
                end = nums[i]
            else:
                if start == end:
                    ans.append(str(start))
                else:
                    ans.append(str(start) + "->" + str(end))
                start,end = nums[i],nums[i]
        if start == end:
            ans.append(str(start))
        else:
            ans.append(str(start) + "->" + str(end))

        return ans
            

        
