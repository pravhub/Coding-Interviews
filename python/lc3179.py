class Solution:
    def valueAfterKSeconds(self, n: int, k: int) -> int:
        a = n * [1]
        b = n * [0]
        modulo = 7 + 10 ** 9        
        for i in range(k):
            b[0] = 1
            for i in range(1, n):
                b[i] = (b[i-1] + a[i]) % modulo
            a = b

        return a[n-1]
