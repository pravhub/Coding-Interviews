public class Solution {
    public bool IsSubsequence(string s, string t) {        
        int m = s.Length;
        int n = t.Length;
        if((m==0 && n==0) || (m==0 &&n!=0))
            return true;
        else if(m!=0 && n==0)
            return false;
            
        int[][] arr = new int[m][];
        int maxLen = 0;
        for(int i=0;i<m;i++)
        {
            arr[i] = new int[n];
            for(int j=0;j<n;j++)
            {
                arr[i][j] =0;
            }
        }
        bool foundMatch = false;
        for(int i=0;i<m;i++)
        {
            if(foundMatch)
            {
                arr[i][0] = 1;
            }
            else if(s[i] ==t[0])
            {
                arr[i][0] = 1;
                maxLen = 1;
                foundMatch = true;
            }
        }
        foundMatch = false;
        for(int j=0;j<n;j++)
        {
            if(foundMatch)
            {
                arr[0][j] = 1;
            }
            else if(t[j]==s[0])
            {
                arr[0][j] =1;
                maxLen =1;
                foundMatch = true;
            }
        }
        for(int i=1;i<m;i++)
        {
            for(int j=1;j<n;j++)
            {
                if(s[i]==t[j])
                {
                    arr[i][j] = 1+ arr[i-1][j-1];
                }
                else
                {
                    arr[i][j] = Math.Max(arr[i-1][j-1],Math.Max(arr[i][j-1],arr[i-1][j]));
                }
                maxLen= Math.Max(maxLen, arr[i][j]);
            }
        }
       /* for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                Console.Write("{0}",arr[i][j]);
            }
            Console.WriteLine();
        } */
        return m==maxLen;
    }
    public bool IsSubsequence2(string s, string t) {
        
        if(s.Length>t.Length)
            return false;
        
        int i = 0;
        int j=0;
        while(i<s.Length && j<t.Length)
        {
            if(t[j] == s[i])   
            {
                i++;
                j++;
            }
            else
            {
                j++;
            }
        }
        if(i== s.Length)
            return true;
        else
            return false;
    }
}
