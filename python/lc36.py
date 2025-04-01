class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        for i in range(9):
            rowMap = set()
            for j in range(9):
                if board[i][j] == '.':
                    pass
                elif board[i][j] in rowMap:
                    # print(board[i][j], 'rows already in set')
                    return False
                else:
                    rowMap.add(board[i][j])
        
        for j in range(9):
            colMap = set()
            for i in range(9):
                if board[i][j] == '.':
                    pass
                elif board[i][j] in colMap:
                    # print(board[i][j], 'cols already in set')
                    return False
                else:
                    colMap.add(board[i][j])
        
       
        boxes = [[0,0],[0,3],[0,6],[3,0],[3,3],[3,6],[6,0],[6,3],[6,6]]
        for x,y in boxes:
            boxMap = set()
            for i in range(x, x+3):
                for j in range(y,y+3):
                    if board[i][j] == '.':
                        pass
                    elif board[i][j] in boxMap:
                        # print(board[i][j], 'box already in set')
                        return False
                    else:
                        boxMap.add(board[i][j])
        
        return True


