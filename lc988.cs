/*
we will solve this by dynamic programming:
- declare a sum 2D array with same number of rows and colums of A.
- initialize the elements in sum array as int.MaxValue.
- fill the first row in sum array with the first row of A. 
- DP technique:
    - start from SECOND row in A go thru the array and fill the sum array with following conditions:
    - add current element (i,j) with the sum obtained at the (i-1,j), (i-1,j-1), (i-1,j+1) (individually)
    - ** as per the problem definition the different between columns should be atmost 1
      so we get the sum from previous row's column, column+1, column-1.
    --   sum(i,j) will be MIN((i,j)+(i-1,j), (i,j)+(i-1,j-1), (i,j)+(i-1,j+1)) 
         ** keep in mind that I am using only indices here, but we are adding elements at those index
    -- continue all rows with the above logic

- finally go thru the last row in the sum 2d array and find the minimum.
space = O(mn)
time = O(mn);
*/
public class Solution {
    public int MinFallingPathSum(int[][] A) {
        int m = A.Length;
        int n = A[0].Length;
        int[][] sum = new int[m][];
        for(int i= 0;i<m;i++)
        {
            sum[i] = new int[n];            
        }
 
        //initialize the elements in sum array as int.MaxValue.
        for(int i= 0;i<m;i++)
        {
            for(int j = 0;j<n;j++)
            {
                sum[i][j] = int.MaxValue;
            }
        }
        //fill the first row in sum array with the first row of A. 
        for(int j = 0;j<n;j++)
        {
            sum[0][j] = A[0][j];
        }
        

        for(int i= 1;i<m;i++)
        {
            for(int j = 0;j<n;j++)
            {
                if(j-1>=0 && j+1 <n)
                {
                    sum[i][j] = Math.Min(sum[i][j], Math.Min(A[i][j]+sum[i-1][j], Math.Min(A[i][j]+sum[i-1][j-1], A[i][j]+sum[i-1][j+1])));                
                }
                else if(j-1<0 && j+1 <n)
                {
                    sum[i][j] = Math.Min(sum[i][j], Math.Min(A[i][j]+sum[i-1][j], A[i][j]+sum[i-1][j+1]));                
                }
                else if(j-1>=0 && j+1 >=n)
                {
                    sum[i][j] = Math.Min(sum[i][j], Math.Min(A[i][j]+sum[i-1][j], A[i][j]+sum[i-1][j-1]));                
                }
                
            }
        }
        
        int min = int.MaxValue;
        for(int j = 0;j<n;j++)
        {
            min = Math.Min(min, sum[m-1][j]);           
        }
        
        /*for(int i= 0;i<m;i++)
        {
            for(int j = 0;j<n;j++)
            {
                Console.Write("  {0}  ",sum[i][j]);
            }
             Console.WriteLine();
         } */
        return min;
    }
}
