class Solution:
    def getSum(self, n:int) -> int:
        ans = 0
        while(n > 0):
            ans += n % 10
            n = n // 10
        return ans
    
    def getLucky(self, s: str, k: int) -> int:
        arr = [ord(c)-96 for c in s]
        ans = 0
        while(k > 0):
            for i in arr:                
                ans += self.getSum(i)
            k -= 1     
            arr = [ans]
            ans = 0
        return arr[0]
