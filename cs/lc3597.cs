public class Solution {
    public IList<string> PartitionString(string s) {
        var seen = new HashSet<string>();
        var output = new List<string>();
        String cur = "";
        foreach(var c in s)
        {
            cur += c;            
            if (!seen.Contains(cur))
            {
                seen.Add(cur);
                output.Add(cur);
                cur = "";
            }
        }
        return output;
    }
}
