class Solution:
    def checkValidGrid(self, grid: List[List[int]]) -> bool:
        combs = [
                [-2,-1],
                [-2,1],
                [-1,-2],
                [-1,2],
                [1,-2],
                [1,2],
                [2,-1],
                [2,1]
                ]
        n = len(grid)
        i,j = 0,0
        if grid[i][j]:
            return False

        num = 1
        foundNext = False
        while num < n*n:
            for row,col in combs:
                newRow = i + row
                newCol = j + col
                if newRow < 0 or newCol < 0 or newRow >= n or newCol >=n:
                    continue
                if grid[newRow][newCol] == num:
                    i = newRow
                    j = newCol
                    num += 1
                    foundNext = True
                    break
            if not foundNext:
                return False
            foundNext = False

        return True
