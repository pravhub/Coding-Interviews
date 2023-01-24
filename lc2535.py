#multiple solutions
class Solution:
    def getSum(self, num:int) -> int:
        if num < 10:
            return num
        dig_sum = 0
        while num > 0:
            dig_sum += num % 10
            num = num // 10
        return dig_sum

    def differenceOfSum(self, nums: List[int]) -> int:
        ele_sum = sum(nums)
        dig_sum = sum(self.getSum(x) for x in nums)
        return abs(ele_sum - dig_sum)
    
    def getDiff(self, nums: List[int]) -> int:
        ele_sum = 0
        dig_sum = 0
        for x in nums:
            ele_sum += x
            dig_sum += getSum(x)
        return ele_sum - dig_sum

