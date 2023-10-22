/*
Lets try solving with Dynamic programming.
for m*n array there are several paths possible (starting at (0,0) to (m-1,n-1))
our goal is to find out the minimum sum path.
lets examine various array sizes:
[[5]] ==> 1x1 array = (0,0)-->(0,0) = 5
[[1,3],
 [1,5]] => 2x2 array
 possible paths: 1->3->5, 1->1->5, ans =7
 lets have another array of size mXn to keep track of the sum ending at (i,j)
 
   - initialize
   - first row sum, first col sum
   - use DP technique: 
       - for cell (1,1), you can reach either from (0,1) or (1,0) 
            so you need to choose the minimum of two choices.
        - continue this thru full 2-D array
   - finally return whatever its there in [m-1,n-1] index.     
                
lets follow the above steps and walk thru for 2X2 array. 
   
 [[0,0], ==>  [[1,4],  ==>  [[1,4],
  [0,0]]       [2,0]]        [2,7]]
*/
public class Solution {
    public int MinPathSum(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int[][] sum = new int[m][];
        for(int i= 0;i<m;i++)
        {
            sum[i] = new int[n];            
        }
        
        sum[0][0] = grid[0][0];
        
        //initialize the first col sum
        for(int i=1; i<m;i++)
        {
            sum[i][0] = sum[i-1][0] +  grid[i][0];
        }
        
        //initialize the first row sum
        for(int j=1; j<n;j++)
        {
            sum[0][j] = sum[0][j-1]+grid[0][j];
        }
        
       
        for(int i=1; i<m;i++)
        {
            for(int j=1;j<n;j++)
            {
                sum[i][j] = Math.Min(sum[i][j-1]+grid[i][j], sum[i-1][j]+grid[i][j]);
            }
        }
        
       /* for(int i=0; i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                Console.Write(" {0} ",sum[i][j]);
            }
            Console.WriteLine();
        } */
        return sum[m-1][n-1];
    }
}
