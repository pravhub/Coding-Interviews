class Solution {
    public int countSubstrings(String s) {
        if(s==null)
            return 0;
        int n = s.length();
        if(n<=1)
            return n;
        
        boolean [][] A = new boolean[n][n];
        int countOfPalindromes =0;
        for(int i=0;i<n;i++)
        {
            A[i][i] = true; //length 1 palindromes
            countOfPalindromes++;
        }
        
        //length =2
        for(int i=1;i<n;i++)
        {
            if(s.charAt(i-1)==s.charAt(i))
            {
                A[i-1][i] = true;
                countOfPalindromes++;
            }
        }
        
        //length>=3.
        for(int len=3;len<=n;len++)
        {
            for(int start=0; start<n;start++)
            {
                int end  = start + len - 1;
                if(end>=n)
                    break;
                if(A[start+1][end-1] == true && s.charAt(start)==s.charAt(end))
                {
                    A[start][end] = true;
                    countOfPalindromes++;
                }
            }
        }
        return countOfPalindromes;
    }
}
