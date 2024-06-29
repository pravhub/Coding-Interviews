class Solution:
    def numberOfChild(self, n: int, k: int) -> int:
        rounds = k//(n-1)
       
        if rounds % 2 ==0:
            return k % (n-1)
        else:
            return n - 1 - (k% (n-1))
