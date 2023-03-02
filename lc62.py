class Solution:
    def uniquePaths(self, m: int, n: int) -> int:
        rlower = n * [0]
        rupper = n * [0]
        rupper[n-1] = 1
        for j in range(m-1, -1, -1):
            for i in range(n-2, -1, -1):
                rupper[i] = rupper[i+1] + rlower[i]
            rlower = rupper
            rupper = n * [0]
            rupper[n-1] = 1
        return rlower[0]
