public class Solution {
    public int MinSteps(string s, string t) {
        Dictionary<char,int> mapS = new Dictionary<char,int>();
        Dictionary<char,int> mapT = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if(!mapS.ContainsKey(c))
            {
                mapS.Add(c,0);
            }
            mapS[c]++;
        }
        foreach(char c in t)
        {
            if(!mapT.ContainsKey(c))
            {
                mapT.Add(c,0);
            }
            mapT[c]++;
        }
        int count = 0;
        foreach(var kvp in mapS)
        {
            if(mapT.ContainsKey(kvp.Key))
            {
                if(mapT[kvp.Key] <= kvp.Value)
                {
                    count+= kvp.Value - mapT[kvp.Key];
                }
            }
            else
            {
                count += kvp.Value;
            }
        }
        return count;
    }
}
