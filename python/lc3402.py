#https://leetcode.com/problems/minimum-operations-to-make-columns-strictly-increasing/description/
class Solution:
    def minimumOperations(self, grid: List[List[int]]) -> int:
        m,n = len(grid), len(grid[0])
        ops = 0
        for j in range(n):
            prev = -1
            for i in range(1,m):
                if grid[i][j] > max(grid[i-1][j], prev):
                    continue
                else:
                    prev = max(prev, grid[i-1][j])+1
                    ops += prev - grid[i][j]
        return ops
