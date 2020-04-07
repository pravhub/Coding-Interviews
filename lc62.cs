/*
Lets use Dynamic programming for this.
try to understand by using few primitive cases:
1x1 grid = only 1 cell so there is only 1 path.
2X2 grid 
[[0,0],
 [0,0]]
 DP technique:
 ------------
 lets create a array mXn to store number of paths
 arr=[[0,0],
      [0,0]]
 (0,0) th cell will be 1 because that is the starting point.
 remember that we can move only two directions: right and down.
 from (0,0) to (0,1) there is only 1 path.
 also from (0,0) to (1,0) there is only 1 path.
 so arr will look like this now: 
 arr=[[1,1],
      [1,0]]
 from (0,0) to (1,1) we have two paths:
         (0,0)-->(1,0)->(1,1)
         (0,0)-->(0,1)->(1,1)
what we can essentially do here is add the contents of (1,0) and (0,1) and put in (1,1)
we continue this DP technique for m rows and n cols.
finally whatever numbe appears in the cell (m-1,n-1) is the answer.
*/
public class Solution {
    public int UniquePaths(int m, int n) {
        int [][]arr = new int[m][];
        for(int i=0;i<m; i++)
        {
            arr[i] =new int[n];            
        }
        
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if((i==0 && j==0) || (i!=0 && j==0) || (i==0 && j!=0))
                {
                    arr[i][j] = 1;
                }
                else
                {
                    arr[i][j] = arr[i-1][j]+arr[i][j-1];
                }
            }
        }
        return arr[m-1][n-1];
    }
}
