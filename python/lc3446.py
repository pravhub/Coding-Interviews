class Solution:
    def sortMatrix(self, grid: List[List[int]]) -> List[List[int]]:
        n = len(grid)
        m = {}
        for i in range(n):
            for j in range(n):
                if i-j in m:
                    m[i-j].append(grid[i][j])
                else:
                    m[i-j] = [grid[i][j]]
        for x,y in m.items():
            if x < 0:
                m[x] = sorted(y, reverse=True)
            else:
                m[x] = sorted(y)
        for i in range(n):
            for j in range(n):
                grid[i][j] = m[i-j].pop()
        return grid
