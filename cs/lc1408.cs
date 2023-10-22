public class Solution {
    public IList<string> StringMatching(string[] words) {
        HashSet<string> ans = new HashSet<string>();
        for(int i=0;i<words.Length;i++)
        {
            for(int j=0;j<words.Length;j++)
            {
                if(i!=j)
                {
                    if(words[i].IndexOf(words[j])>=0)
                    {
                        ans.Add(words[j]);
                    }
                }
            }            
        }
        return ans.ToList();
    }
}
