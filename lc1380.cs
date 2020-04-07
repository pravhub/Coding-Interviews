public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        int r = matrix.Length;
        int c = matrix[0].Length;
        int[] rowmins = new int[r];
        int[] colmaxs = new int[c];
        int idx =0;
        for(int i=0;i<r;i++)
        {
            int min = int.MaxValue;
            for(int j=0;j<c;j++)
            {
                min =Math.Min(min, matrix[i][j]);
            }
            rowmins[idx++]=min;
        }
         idx =0;
        for(int j=0;j<c;j++)
        {
            int max = int.MinValue;
            for(int i=0;i<r;i++)
            {
                max = Math.Max(max, matrix[i][j]);
            }
            colmaxs[idx++] = max;
        }
        IList<int> ans = new List<int>();
        for(int i=0;i<r;i++)
        {            
            for(int j=0;j<c;j++)
            {
                if(rowmins[i]==matrix[i][j] && colmaxs[j]==matrix[i][j])
                {
                    ans.Add(matrix[i][j]);
                }
            }            
        }
        return ans;
    }
}
