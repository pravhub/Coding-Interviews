# https://leetcode.com/problems/number-of-pairs-of-strings-with-concatenation-equal-to-target/
# Leetcode 2023. Number of Pairs of Strings With Concatenation Equal to Target
class Solution:
    def numOfPairs(self, nums: List[str], target: str) -> int:
        c = Counter(nums)
        ans = 0
        for i in range(1,len(target)):
            part1 = target[:i]
            part2 = target[i:] 
            c1 = c[part1]
            c2 = c[part2]
            if(part1 == part2):
                ans += (c1-1) * c2
            else:
                ans += c1 * c2
        return ans
    
    #bruteforce
    def numOfPairs2(self, nums: List[str], target: str) -> int:
        ans = 0
        for i in range(len(nums)):
            for j in range(len(nums)):
                if i!=j and nums[i] + nums[j] == target:
                    ans += 1
        return ans
