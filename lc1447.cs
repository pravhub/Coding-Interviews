public class Solution {
    public IList<string> SimplifiedFractions(int n) {
        IList<string> ans = new List<string>();
        for(int i=1;i<n;i++)
        {
            for(int j=2;j<=n;j++)
            {
                //Console.WriteLine("{0},{1},{2}",i,j,GCD(i,j)); "i/j"
                if(i<j && GCD(i,j) ==1)
                    ans.Add(string.Format("{0}/{1}",i,j));                
            }
        }
        return ans;
    }
    private int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a == 0 ? b : a;
    }
}
