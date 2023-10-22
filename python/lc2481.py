class Solution:
    def pivotInteger(self, n: int) -> int:
        total = (n * (n+1))//2
        cur_sum = 0
        for i in range(1,n+1):
            cur_sum += i
            if cur_sum == total + i - cur_sum:
                return i
        return -1
