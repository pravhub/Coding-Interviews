class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        m, n = len(grid), len(grid[0])
        dirs = [[1,0],[0,1],[-1,0],[0,-1]]
        def dfs(i,j):
            if i >=0 and j>=0 and i<m and j <n and grid[i][j] == "1":
                grid[i][j] = "-1"
                for d in dirs:
                    dfs(i+d[0], j+d[1])
        
        islands = 0
        for a in range(m):
            for b in range(n):
                if grid[a][b] == "1":
                    islands += 1
                    dfs(a,b)
        return islands
