# https://leetcode.com/problems/check-if-every-row-and-column-contains-all-numbers/
# Leetcode 2133. Check if Every Row and Column Contains All Numbers
class Solution:
    def checkValid_Short(self, matrix: List[List[int]]) -> bool:
    n = len(matrix)
    return all(n == len(set(l)) for l in matrix) and all(n == len(set(l)) for l in zip(*matrix)) 

    def checkValid(self, matrix: List[List[int]]) -> bool:
        n = len(matrix)
        for l in matrix:
            if n != len(set(l)):
                return False
        
        for l in zip(*matrix):            
            if n != len(set(l)):
                 return False
        return True
