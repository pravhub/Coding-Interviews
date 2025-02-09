#https://leetcode.com/problems/zigzag-grid-traversal-with-skip/description/
class Solution:
    def zigzagTraversal(self, grid: List[List[int]]) -> List[int]:
        i,j=0,0
        m = len(grid)
        n = len(grid[0])
        output = []
        skip = False
        right = True
        counter = m*n
        while counter > 0:
            counter-= 1
            if not skip:
                output.append(grid[i][j])
                skip = True
            else:
                skip = False
            if right:
                j+=1
                if j == n:
                    i+=1
                    j= n-1
                    right = False
            else:
                j-=1
                if j == -1:
                    i+=1
                    j = 0
                    right = True
        return output 
            

