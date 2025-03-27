public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var ans = new StringBuilder();
        for(int i=0;i<strs[0].Length;i++)
        {
            bool end = false;
            char prev = strs[0][i];
            for(int j = 1;j<strs.Length;j++)
            {
                if(i >= strs[j].Length || prev != strs[j][i])
                {
                    end = true;
                    break;
                }
            }
            if(end)
                break;
            else
                ans.Append(prev);
        }
        return ans.ToString();
    }
}
