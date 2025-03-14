class Solution:
    def findMissingAndRepeatedValues(self, grid: List[List[int]]) -> List[int]:
        lst = [0]* (len(grid)*len(grid)+1)
        output = []
        for i in range(len(grid)):
            for j in range(len(grid)):
                if lst[grid[i][j]] == 0:
                    lst[grid[i][j]] = grid[i][j]
                else:
                    output.append(grid[i][j])
        for k in range(1, len(grid)*len(grid)+1):
            if lst[k] == 0:
                output.append(k)
        return output
