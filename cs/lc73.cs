public class Solution {
    public void SetZeroes(int[][] matrix) {
        HashSet<int> rows = new HashSet<int>();
        HashSet<int> cols = new HashSet<int>();
        for(int i=0;i< matrix.Length;i++)
        {
            for(int j=0;j< matrix[0].Length;j++)
            {
                if(matrix[i][j] == 0)
                {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }

        foreach(int i in rows)
        {
            for(int j=0;j< matrix[0].Length;j++)
            {
                matrix[i][j] = 0;
            }
        }
        
        foreach(int i in cols)
        {
            for(int j=0;j< matrix.Length;j++)
            {
                matrix[j][i] = 0;
            }
        }
    }
}
