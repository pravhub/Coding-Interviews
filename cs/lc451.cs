public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if(!map.ContainsKey(c))
            {
                map.Add(c,0);
            }
            map[c]++;
        }
        StringBuilder sb= new StringBuilder();
        foreach(var kvp in map.OrderByDescending(m=>m.Value))
        {
            sb.Append(new string(kvp.Key,kvp.Value));
        }
        return sb.ToString();
    }
}
