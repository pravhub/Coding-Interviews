public class Solution {
    public int CountSubstrings(string s) {
        if(string.IsNullOrEmpty(s))
            return 0;
        int n = s.Length;
        if(n==1)
            return 1;
        bool[][] A = new bool[n][];
        int countOfPalindromes =0;
        for(int i=0;i<n;i++)
        {
            A[i] = new bool[n];
            A[i][i] = true; //length-1 palindromes
            countOfPalindromes++;
        }
        
        //length =2
        for(int i=1;i<n;i++)
        {
            if(s[i-1]==s[i])
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
                if(A[start+1][end-1] == true && s[start]==s[end])
                {
                    A[start][end] = true;
                    countOfPalindromes++;
                }
            }
        }
        return countOfPalindromes;
    }
}
