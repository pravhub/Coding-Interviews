class Solution {
    public int isPrefixOfWord(String sentence, String searchWord) {
        String[] words = sentence.split(" ");
        int idx = -1;
        int cur = 1;
        for(String s: words)
        {
            if(s.startsWith(searchWord))
            {
                idx = cur;
                break;
            }
            cur++;
        }
        return idx;   
    }
}
