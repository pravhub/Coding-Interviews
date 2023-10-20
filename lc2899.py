class Solution:
    def lastVisitedIntegers(self, words: List[str]) -> List[int]:
        lastVisited = -1
        ans = []
        nums = []
        for s in words:
            if s == "prev":
                ans.append(-1 if lastVisited < 0 else nums[lastVisited])
                lastVisited -= 1
            else:
                nums.append(int(s))
                lastVisited = len(nums) - 1
        return ans
