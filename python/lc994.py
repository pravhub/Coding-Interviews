class Solution:
    def orangesRotting(self, grid: List[List[int]]) -> int:
        m = len(grid)
        n = len(grid[0])


        q = deque()
        fresh = 0
        for i in range(m):
            for j in range(n):
                if grid[i][j] == 1:
                    fresh += 1
                elif grid[i][j] == 2:
                    q.append((i,j,0))

        path = [[1,0], [0,1], [-1,0], [0,-1]]
        max_min = 0
        while q:
            i,j,t = q.popleft()

            max_min = max(max_min, t)
            for idx in path:
                next_i = i + idx[0]
                next_j = j + idx[1]
                if next_i >=0 and next_i < m and next_j >=0 and next_j < n and grid[next_i][next_j] == 1:

                        grid[next_i][next_j] = 2
                        fresh -= 1
                        q.append((next_i, next_j, t+1))

        return max_min if fresh == 0 else -1
