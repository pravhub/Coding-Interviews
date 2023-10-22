/*
Lets use Dynamic programming for this.
obstacles - 1s
empty  -- 0s
try to understand by using few primitive cases:
1x1 grid = only 1 cell so there is only 1 path.
2X2 grid = there are no obstacles so there are two possible paths:

[[0,0],
 [0,0]] 
          (0,0)-->(1,0)->(1,1)
         (0,0)-->(0,1)->(1,1)

Lets add obstacle at (0,1):
[[0,1],
 [0,0]] 
 now from (0,0), you can only move one direction (down), since we cannot move RIGHT
 since that cell has obstacle
if there is obstacle at (0,0), irrespective of the size of array answer will be 0.
 DP technique:
 ------------
 lets create a array mXn to store number of paths
 arr=[[0,0],
      [0,0]]
 (0,0) th cell will be 1 because that is the starting point.
 remember that we can move only two directions: right and down.
 lets try to fill first row and first column:
    we can move along the row/colum only if there is no obstacle.
    if we hit obstacle then we cannot move further.
 but in the array with obstacles:
 from (0,0) to (1,0) there is only 1 path.
 so arr will look like this now: 
 arr=[[1,0],
      [1,0]]
 from (0,0) to (1,1) we have two paths:
         (0,0)-->(1,0)->(1,1) 
what we can essentially do here is add the contents of (1,0) and (0,1) and put in (1,1)
after this arr will be
[[1,0],
 [1,1]]
we continue this DP technique for m rows and n cols.
finally whatever numbe appears in the cell (m-1,n-1) is the answer.
*/
public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;
        int[][] paths = new int[m][];
        for(int i=0; i<m; i++)
        {
            paths[i] = new int[n];
        }
        if(obstacleGrid[0][0]==1)
            return 0;
        
        paths[0][0] = 1;
        for(int i=0; i<m; i++)
        {
            if(obstacleGrid[i][0]==0)
            {
                paths[i][0] = 1;
            }
            else
            {
                break;
            }
        }
        for(int j=0;j<n;j++)
        {
            if(obstacleGrid[0][j]==0)
            {
                paths[0][j] = 1;
            }
            else
            {
                break;
            }
        }
        for(int i=1; i<m; i++)
        {
            for(int j=1;j<n;j++)
            {
                if(obstacleGrid[i][j]!=1)
                {
                    paths[i][j] =  paths[i-1][j] + paths[i][j-1];
                }
                
            }
        }
         for(int i=0; i<m; i++)
        {
            for(int j=0;j<n;j++)
            {
                Console.Write(" {0}",paths[i][j]);
            }
             Console.WriteLine();
         }
        return paths[m-1][n-1];
    }
}
