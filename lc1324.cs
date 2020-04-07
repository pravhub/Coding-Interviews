//m words.
//max length = n. avg length = l.
//O(m*l)

public class Solution {
    public IList<string> PrintVertically(string s) {
        IList<StringBuilder> ans= new List<StringBuilder>();
        string[] words = s.Split(' ');
        int maxLen = 0;
        foreach(string word in words)
        {
            maxLen = Math.Max(word.Length,maxLen);
        }
        Console.WriteLine(maxLen);
        for(int i=0;i<maxLen;i++)
        {
            ans.Add(new StringBuilder());
        }
        
        foreach(string word in words)
        {
            int idx =0;
            foreach(char c in word)
            {
                ans[idx++].Append(c);
            }
            while(idx<maxLen)
            {  
              ans[idx++].Append(" ");                
            }
        }
        return ans.Select(a=>a.ToString().TrimEnd()).ToList();
    }
}
/*
improvement: use stringbuilder instead of string in the List 
and before returning convert the stringbuilder to string.
*/
