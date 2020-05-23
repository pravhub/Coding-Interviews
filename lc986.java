class Solution {
    public int[][] intervalIntersection(int[][] A, int[][] B) {
        int m = A.length;
        int n = B.length;
        List<int[]> ans = new ArrayList<int[]>();
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
                int x = Math.max(a0,b0);
                int y = Math.min(a1,b1);
                ans.add(new int[] {x,y});
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
        int[][] ansArr = new int[ans.size()][2]; 
        ansArr = ans.toArray(ansArr); 
  
        return ansArr;
    
    }
}
