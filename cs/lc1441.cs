public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        IList<string> ans = new List<string>();
        int idx = 0;
        int len = target.Length;
        for(int i=1;i<=n;i++)
        {
            if(idx >= len)
                break;
            if(i==target[idx])
            {
                ans.Add("Push");
                idx++;
            }
            else
            {
                ans.Add("Push");
                ans.Add("Pop");
            }            
        }
        return ans;
    }
}
