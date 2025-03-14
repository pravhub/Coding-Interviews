public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int len = grid.Length * grid.Length;
        int []lst = new int[len+1];
        
        var output = new List<int>();
        for(int i=0;i<grid.Length; i++)
        {
            for(int j=0;j< grid.Length; j++)
            {
                if (lst[grid[i][j]] == 0)
                {
                    lst[grid[i][j]] = grid[i][j];
                }
                else
                {
                    output.Add(grid[i][j]);
                }
            }
        }
 
        for(int k =1;k<len+1; k++)
        {
             if (lst[k] == 0)
            {
                output.Add(k);
            }      
        }          
        return output.ToArray();
    }
}

