/*
we need to verify path starting at all cells potentially.
first, lets have a function which will traverse from a given cell. -GrabGold(..)
        -- keep track of the gold collected for each cell.
        -- update the overall max gold that can be collected
return the overall max gol collected at the end.
*/
public class Solution {
    int maxGoldForForCell = int.MinValue;
    int overMaxGold = int.MinValue;
    public int GetMaximumGold(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        Console.WriteLine("******");
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j] !=0)
                {
                   bool[][] visited = ResetVisited(m,n);
                   maxGoldForForCell = int.MinValue;
                   GrabGold(grid, ref visited,  m,  n, i,  j, 0); 
                    if(maxGoldForForCell != int.MinValue)
                    {
                        overMaxGold = Math.Max(overMaxGold,maxGoldForForCell);
                        Console.WriteLine("cell={0},{1},overall={2}",grid[i][j],maxGoldForForCell,overMaxGold);
                    }
                }
            }
        }
        return overMaxGold;
    }
    private bool[][]  ResetVisited(int m, int n)
    {
        bool[][] visited = new bool[m][];
        for(int i=0;i<m;i++)
        {
            visited[i] = new bool[n];
        }
        return visited;
    }
    private void GrabGold(int[][] grid, ref bool[][] visited, int m, int n, int curRow, int curCol, int curGoldCount)
    {
        if(curRow>=0 && curCol >=0 && curRow <m && curCol <n && grid[curRow][curCol]!=0 && !visited[curRow][curCol])
        {
            visited[curRow][curCol] = true;
            curGoldCount+=grid[curRow][curCol];
            GrabGold(grid, ref visited,  m,  n, curRow,  curCol-1, curGoldCount); //left
            GrabGold(grid, ref visited,  m,  n, curRow,  curCol+1, curGoldCount); //right
            GrabGold(grid, ref visited,  m,  n, curRow-1,  curCol, curGoldCount); //up
            GrabGold(grid, ref visited,  m,  n, curRow+1,  curCol, curGoldCount); //down
            visited[curRow][curCol] = false;
        }
        else
        {
            maxGoldForForCell = Math.Max(maxGoldForForCell, curGoldCount);
        }
    }
}
