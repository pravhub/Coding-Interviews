# leetcode problem 1992
#https://leetcode.com/problems/find-all-groups-of-farmland
class Solution:
    
    def traverseAlongCol(self, land: List[List[int]], visited: List[List[bool]], row: int, col:int) -> int:        
        while(row < len(land) and land[row][col] == 1):
            visited[row][col] = True
            row += 1
        return row-1
    
    def traverseAlongRow(self, land: List[List[int]], visited: List[List[bool]], row: int, col: int) -> int:        
        while(col < len(land[0]) and land[row][col] == 1):
            visited[row][col] = True
            col += 1
        return col-1
    
    def markVisited(self, land: List[List[int]], visited: List[List[bool]], startR: int, endR: int,startC: int, endC: int) -> None:
        #print(startR,startC, endR,endC)
        for i in range(startR, endR+1):
            for j in range(startC, endC+1):
                visited[i][j] = True

    def findFarmland(self, land: List[List[int]]) -> List[List[int]]:
        m = len(land)
        n = len(land[0])
        visited = []
        for i in range(m):
            visited.append([False] * n)
        #print(m,n, len(visited),len(visited[0]))
        ans = []
        for i in range(m):
            for j in range(n):
                if(visited[i][j] == False and land[i][j] == 1):
                    endRow = self.traverseAlongCol(land,visited, i, j)
                    endCol = self.traverseAlongRow(land,visited, i, j)
                    self.markVisited(land, visited, i+1, endRow, j+1, endCol)
                    ans.append([i,j, endRow, endCol])
        return ans
                    
        
