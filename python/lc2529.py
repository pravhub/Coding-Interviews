class Solution:
    def maximumCount(self, nums: List[int]) -> int:
        pos = 0
        neg =0
        for x in nums:
            if x==0:
                continue
            elif x>0:
                pos += 1
            elif x<0:
                neg += 1
        return max(pos, neg)
