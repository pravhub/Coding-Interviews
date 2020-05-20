class Solution {
    public int countSquares(int[][] matrix) {
      int m = matrix.length;
        int n = matrix[0].length;
        int count = 0;
        int[][] square = new int[m][n];
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                square[i][j] = 0;
            }
        }
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(i==0 ||j==0)
                {
                    if(matrix[i][j]==1)
                    {
                        square[i][j] = 1;
                        count++;
                    }
                }
                else
                {
                    if(matrix[i][j]==1)
                    {    
                        square[i][j] = 1 + Math.min(Math.min(square[i][j-1],square[i-1][j]), square[i-1][j-1]);
                        count+= square[i][j];
                    }
                }
            }
        }  
        return count;   
    }
}
