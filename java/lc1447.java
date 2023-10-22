class Solution {
    public List<String> simplifiedFractions(int n) {
        List<String> ans = new ArrayList<String>();
        for(int i=1;i<n;i++)
        {
            for(int j=2;j<=n;j++)
            {                
                if(i<j && GCD(i,j) ==1)
                    ans.add(i + "/"+j);                
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
