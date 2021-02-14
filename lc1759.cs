public class Solution {
    public int CountHomogenous(string s) {
        int mod = 1000000007;
        long count = 0;
        int curCount = 1;
        Console.WriteLine(s.Length);
        for(int i =1;i<s.Length;i++)
        {
            if(s[i-1]==s[i])
            {
                curCount++;
            }
            else
            {
                long homCount = GetHomogenousCount(curCount);
                homCount = homCount % mod;
                count += homCount;
                count = count % mod;                
                curCount = 1;
            }
        }
        long hCount = GetHomogenousCount(curCount);
        hCount = hCount % mod;
        count = count + hCount;
        count = count % mod;
        return (int)count;
    }
    private long GetHomogenousCount(int cur)
    {
        return (long)cur * (cur+1)/2;
    }
}
