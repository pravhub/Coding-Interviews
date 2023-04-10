class Solution:
    def isPrime(self, num:int) -> bool:
        if num == 1:
            return False
        for i in range(2, int(math.sqrt(num)) + 1):
            if num % i == 0:
                return False
        return True
    
    def diagonalPrime(self, nums: List[List[int]]) -> int:
        l = len(nums)
        ans = 0
        for i in range(l):
            if self.isPrime(nums[i][i]):
                ans = max(ans, nums[i][i])
        idx = l-1
        for i in range(l):
            if self.isPrime(nums[i][idx]):
                ans = max(ans, nums[i][idx])
            idx -= 1

        return ans
