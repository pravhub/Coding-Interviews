public class Solution {
    public int NumSteps(string s) {
        
        BigInteger n = ConvertToBigint(s);
        //Console.WriteLine(n);
        
        int steps = 0;
        while(n!=1)
        {
            if(n%2==0)
            {
                n = n/2;
            }
            else
            {
                n = n + 1;
            }
            steps++;
        }
        return steps;
    }
    private BigInteger ConvertToBigint(string s)
    {
        BigInteger bi = 0;
        foreach(var c in s)
        {
            bi = bi*2 +  (c=='1'?1:0);
        }
        return bi;
    }
}
