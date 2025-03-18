class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        d = {}
        majority = 0
        max_count = 0
        for n in nums:
            if n in d:
                d[n] += 1
            else:
                d[n] = 1
            if max_count < d[n]:
                max_count = d[n]
                majority = n
        return majority
