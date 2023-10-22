public class Solution {
    public int[][] IntervalIntersection(int[][] A, int[][] B) {
        int m = A.Length;
        int n = B.Length;
        List<int[]> ans = new List<int[]>();
        int i =0;
        int j=0;
        while(i<m && j<n)
        {
            int a0 = A[i][0];
            int a1 = A[i][1];
            int b0 = B[j][0];
            int b1 = B[j][1];
            if(a0<b0 && a1<b0)
            {
                i++;
            }
            else if((b0 <=a0 && a0<=b1) || (b0 <=a1 && a1<=b1) || (a0<=b0 && b0<=a1) || (a0<=b1 && b1<=a1))
            {
                //Console.WriteLine("{0}-{1}-{2}-{3}",a0,a1,b0,b1);
                int x = Math.Max(a0,b0);
                int y = Math.Min(a1,b1);
                //Console.WriteLine("[{0},{1}]",x,y);
                ans.Add(new int[] {x,y});
                if(a1<b1)
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            else
            {
                j++;
            }
        }
        return ans.ToArray();
    }
    public int[][] IntervalIntersection_n_2(int[][] A, int[][] B) {        
        int m = A.Length;
        int n = B.Length;
        List<int[]> ans = new List<int[]>();
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                int a0 = A[i][0];
                int a1 = A[i][1];
                int b0 = B[j][0];
                int b1 = B[j][1];
                
                if(a0<b0 && a1<b0)
                {
                    break;
                }
                if((b0 <=a0 && a0<=b1) || (b0 <=a1 && a1<=b1) || (a0<=b0 && b0<=a1) || (a0<=b1 && b1<=a1))
                {
                    //Console.WriteLine("{0}-{1}-{2}-{3}",a0,a1,b0,b1);
                    int x = Math.Max(a0,b0);
                    int y = Math.Min(a1,b1);
                    //Console.WriteLine("[{0},{1}]",x,y);
                    ans.Add(new int[] {x,y});
                }
            }
        }
        return ans.ToArray();
    }
}
