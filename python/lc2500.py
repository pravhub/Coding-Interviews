class Solution:
    def deleteGreatestValue(self, grid: List[List[int]]) -> int:
        for i in range(len(grid)):
            grid[i] = sorted(grid[i], reverse=True)
        
        ret_sum = 0
        for j in range(len(grid[0])):
            cur_max = 0 
            for i in range(len(grid)):
                cur_max = max(cur_max, grid[i][j])
            ret_sum += cur_max

        return ret_sum
