public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,Place> map = new Dictionary<char,Place>();
        for(int i=0;i<s.Length;i++)
        {
            if(!map.ContainsKey(s[i]))
            {
                map.Add(s[i], new Place(i,i));
            }
            map[s[i]].end = i;
        }
        int minIdx = int.MaxValue;
        foreach(var kvp in map)
        {
            int start = kvp.Value.start;
            int end = kvp.Value.end;
            if(start-end==0)
            {
                minIdx = Math.Min(minIdx, start);
            }
        }
        if(minIdx==int.MaxValue)
            minIdx = -1;
        return minIdx;
    }
}
public class Place
{
    public int start;
    public int end;
    public Place(int s, int e)
    {
        start = s;
        end = e;
    }
        
}
