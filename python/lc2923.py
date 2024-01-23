class Solution:
    def findChampion(self, grid: List[List[int]]) -> int:
        m = len(grid)
        n = len(grid[0])
        max_stronger_count = -1
        max_stronger_team = -1
        for i in range(m):
            strong_counter = 0
            for j in range(n):
                if grid[i][j] == 1:
                    strong_counter +=1
            if strong_counter > max_stronger_count:
                max_stronger_count = strong_counter
                max_stronger_team = i
        return max_stronger_team

