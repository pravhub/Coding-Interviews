public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        string[] words = sentence.Split(" ");
        int idx = -1;
        int cur = 1;
        foreach(string s in words)
        {
            if(s.StartsWith(searchWord))
            {
                idx = cur;
                break;
            }
            cur++;
        }
        return idx;            
    }
}
