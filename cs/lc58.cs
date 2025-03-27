public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length-1;
        int count =0;
        while (s[i] == ' ')
            i-=1;
        while (i>=0 && s[i] !=' ')
        {
            count += 1;
            i-=1;
        }
        return count;

    }
}
