public class Solution {
    public int NumSplits(string s) {
        HashSet<char> hs = new HashSet<char>();
        int n = s.Length;
        int[] lToR = new int[n];
        int[] rToL = new int[n];
        for(int i=0;i<n;i++)
        {
            hs.Add(s[i]);
            lToR[i] = hs.Count;
        }
        hs = new HashSet<char>();
        int ways = 0;
        for(int i=n-1;i>=0;i--)
        {
            hs.Add(s[i]);
            rToL[i] = hs.Count;
            if(i-1>=0)
            {
                if(lToR[i-1]== rToL[i])
                {
                    ways++;
                }   
            }
        }
        
        /*
        for(int i=0;i<n;i++)
        {
            if(i+1<n)
            {
                if(lToR[i]==rToL[i+1])
                {
                    ways++;
                }
            }
        }*/
        return ways;
    }
}
