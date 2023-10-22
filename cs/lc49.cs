public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<int, IList<string>> map = new Dictionary<int, IList<string>>();
        foreach(string s in strs)
        {
            int code = GetModifiedString(s);
            //Console.WriteLine(code);
            if(!map.ContainsKey(code))
            {
                map.Add(code, new List<string>());
            }
            map[code].Add(s);
        }
        return map.Values.ToList();
    }
    private int GetModifiedString(string s)
    {
        int[] counts = new int[26];
        foreach(char c in s)
        {
            counts[c-'a']++;
        }
        return string.Join("#",counts).GetHashCode();
    }
}
