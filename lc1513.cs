public class Solution {
    Dictionary<int,int> map = new Dictionary<int,int>();
    int mod = 1000000007;
    public int NumSub(string s) {
        map.Add(1,1);
        int subStringCount = 0;
        int start =-1;
        int end = -1;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='1')                
            {
                if(start==-1)
                {
                    start = i;
                    end = i;                    
                }
                else
                {
                    end++;
                }
            }
            else
            {
                if(start!=-1 && end!=-1)
                {
                    subStringCount += GetSubStringCount(end-start+1);
                    subStringCount = subStringCount % mod;
                    start = -1;
                    end =-1;
                }
            }
        }
        if(start!=-1 && end!=-1)
        {
            subStringCount += GetSubStringCount(end-start+1);
            subStringCount = subStringCount % mod;            
        }
        return subStringCount;
    }
    private int GetSubStringCount(int len)
    {
        if(map.ContainsKey(len))
            return map[len];
        BigInteger ans =  ((BigInteger)len * (len+1))/2;
        //Console.WriteLine($"before mod {len}={ans}");
        ans = ans %mod;
        map.Add(len,(int)ans);
        //Console.WriteLine($"{len}={ans}");
        return (int)ans;
    }
    private int GetSubStringCount2(int len)
    {
        if(map.ContainsKey(len))
            return map[len];
        int count = len % mod;
        for(int i=2;i<=len;i++)
        {
            count+=len-i+1;
            count = count % mod;
        }
        map.Add(len,count);
        Console.WriteLine($"{len}={count}");
        return count;
    }
}
