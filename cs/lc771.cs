public class Solution {
    public int NumJewelsInStones(string J, string S) {
        HashSet<char> jewels = new HashSet<char>(J.ToCharArray());
        int count =0;
        foreach(char c in S)
        {
            if(jewels.Contains(c))
                count++;
        }
        return count;
    }
}
