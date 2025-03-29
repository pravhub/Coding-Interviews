public class Solution {
    public string Convert(string s, int numRows) {
        List<List<char>> ans = new List<List<char>>();
        int idx = 0;
        for(int i = 0;i< Math.Min(numRows, s.Length);i++)
        {
            ans.Add(new List<char>());
        }
        
        while(idx < s.Length)
        {
            for(int i = 0;i< numRows;i++)
            {
                if(idx < s.Length)
                {
                    ans[i].Add(s[idx]);
                    idx++;
                }
                else
                    break;
            }
            for(int i = numRows-2; i>0; i--)
            {
                if(idx < s.Length)
                {
                    ans[i].Add(s[idx]);
                    idx++;
                }
                else
                    break;
            }
        }
        
        StringBuilder sb = new StringBuilder();
        foreach(var l in ans)
        {
            sb.Append(String.Join("",l));
        }
        return sb.ToString();
    }
}
