public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        Dictionary<string,string> map = new Dictionary<string,string>();
        HashSet<string> cities = new HashSet<string>();
        foreach(List<string> l in paths)
        {
            string fr = l[0];
            string to = l[1];
            map.Add(fr,to);
            cities.Add(fr);
            cities.Add(to);
        }
        string dest= null;
        foreach(var city in cities)
        {
            string cur = city;
            while(map.ContainsKey(cur))
            {
                cur = map[cur];
            }
            dest = cur;
            break;
        }
        return dest;
    }
}
