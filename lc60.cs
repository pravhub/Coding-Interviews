public class Solution {
    public string GetPermutation(int n, int k) {
        /*int f = factorial(n);
        if(k>f)
            return "";*/
        List<int> nums = new List<int>();
        for(int i=1;i<=n;i++)
        {
            nums.Add(i);
        }
        StringBuilder ans = new StringBuilder();
        while(nums.Count!=0)
        {
            int fact = factorial(n-1);
            int x = (int)Math.Ceiling((double)k/fact);
            int digit = x>0?nums[x-1]:nums[0];
            ans.Append(digit);
            nums.Remove(digit);
            k=k- ((x-1) * fact);         
            n--;
        }
        return ans.ToString();
    }
    private int factorial(int n)
    {
        int ans = 1;
        for(int i=2;i<=n;i++)
        {
            ans*=i;
        }
        return ans;
    }
}
