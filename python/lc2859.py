class Solution:
    def sumIndicesWithKSetBits(self, nums: List[int], k: int) -> int:
        return sum(x for i, x in enumerate(nums) if k == len([x for x in format(i, 'b') if x == '1']))

    def sumIndicesWithKSetBits2(self, nums: List[int], k: int) -> int:
        ans = 0
        for i in range(len(nums)):
            bin_num = format(i, 'b')
            if k == len([x for x in bin_num if x == '1']):
                ans += nums[i]
        return ans
