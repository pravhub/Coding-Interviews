public class Solution {
    public int MinDistance(string word1, string word2) {        
        int m = word1.Length;
        int n = word2.Length;
        if(m==0)
            return n;
        if(n==0)
            return m;
        int[][] arr = new int[m][];
        for(int i=0;i<m;i++)
        {
            arr[i] = new int[n];
            for(int j=0;j<n;j++)
            {
                arr[i][j] = 0;
            }
        }
        int repCount =0;
        bool seenSamechar = false;
        for(int i=0;i<m;i++)
        {
            if(word1[i]!=word2[0] || seenSamechar)
            {
                repCount++;
                arr[i][0] = repCount;
            }
            else
            {
                seenSamechar = true;                
                arr[i][0] = repCount;
            }
        }
        repCount = 0;
        seenSamechar = false;
        for(int j=0;j<n;j++)
        {
            if(word2[j]!=word1[0]|| seenSamechar)
            {
                repCount++;
                arr[0][j] = repCount;
            }
            else
            {
                seenSamechar = true; 
                arr[0][j] = repCount;
            }
        }
        for(int i=1;i<m;i++)
        {
            for(int j=1;j<n;j++)
            {
                if(word1[i]==word2[j])
                {
                    arr[i][j] = arr[i-1][j-1];//Math.Min(Math.Min(arr[i-1][j],arr[i][j-1]),arr[i-1][j-1]);
                }
                else
                {
                    arr[i][j] = 1+ Math.Min(Math.Min(arr[i-1][j],arr[i][j-1]),arr[i-1][j-1]);
                }
            }
        }
       /* for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                Console.Write("{0} ",arr[i][j]);
            }
            Console.WriteLine();
        } */
        return arr[m-1][n-1];
    }
}
