class Solution:
    def reverseSubmatrix(self, grid: List[List[int]], x: int, y: int, k: int) -> List[List[int]]:
        for j in range(y, y+k):
            start, end = x, x+k-1
            while start < end:
                grid[start][j], grid[end][j] = grid[end][j], grid[start][j]
                start += 1
                end -= 1
        return grid
