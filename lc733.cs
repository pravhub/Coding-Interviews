public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        int m = image.Length;
        int n = image[0].Length;
        int oldColor = image[sr][sc];
        if(oldColor == newColor)
            return image;
        Fill(ref image, sr,  sc,  oldColor,  newColor,  m,  n);
        return image;
    }
    private void Fill(ref int[][] image, int row, int col, int oldColor, int newColor, int m, int n)
    {
        if(row>=0 && row<m && col>=0 && col<n && image[row][col] == oldColor)
        {
            image[row][col] = newColor;
            Fill(ref image, row-1,  col,  oldColor,  newColor,  m,  n);
            Fill(ref image, row+1,  col,  oldColor,  newColor,  m,  n);
            Fill(ref image, row,  col-1,  oldColor,  newColor,  m,  n);
            Fill(ref image, row,  col+1,  oldColor,  newColor,  m,  n);
        }
    }
}
