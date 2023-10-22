public class Solution {
    public int MinNumberOfFrogs(string croakOfFrogs) {
        int n = croakOfFrogs.Length;
        if(n%5!=0 || !croakOfFrogs.StartsWith('c') || !croakOfFrogs.EndsWith('k'))
            return -1;
        Dictionary<char,int> map = new Dictionary<char,int>();
        map.Add('c',0);
        map.Add('r',0);
        map.Add('o',0);
        map.Add('a',0);
        map.Add('k',0);
        Dictionary<string,List<int>> map2 = new Dictionary<string,List<int>>();
        map2.Add("c",new List<int>());
        map2.Add("cr",new List<int>());
        map2.Add("cro",new List<int>());
        map2.Add("croa",new List<int>());
        List<StringBuilder> lst = new List<StringBuilder>();
        HashSet<int> vacated = new HashSet<int>();
        for(int i=0;i<n;i++)
        {
            map[croakOfFrogs[i]]++;
            if(croakOfFrogs[i]=='c')
            {
                StringBuilder sb = new StringBuilder();
                sb.Append('c');
                if(vacated.Count == 0)
                {
                    //Console.WriteLine("adding a new one...");                    
                    map2["c"].Add(lst.Count);
                    lst.Add(sb);
                }
                else
                {                    
                    int idx = vacated.First();
                    //Console.WriteLine("reusing the idx...{0}",idx);
                    lst[idx]=sb;
                    vacated.Remove(idx);
                    map2["c"].Add(idx);
                }
            }
            else if (croakOfFrogs[i]=='r')
            {
                if(map2["c"].Count>0)
                {
                    int idx = map2["c"].First();
                    lst[idx].Append('r');
                    map2["c"].Remove(idx);
                    map2["cr"].Add(idx);
                }
                else
                {
                    return -1;
                }
            }
            else if (croakOfFrogs[i]=='o')
            {
                if(map2["cr"].Count>0)
                {
                    int idx = map2["cr"].First();
                    lst[idx].Append('o');
                    map2["cr"].Remove(idx);
                    map2["cro"].Add(idx);
                }
                else
                {
                    return -1;
                }
            }
            else if (croakOfFrogs[i]=='a')
            {
                if(map2["cro"].Count>0)
                {
                    int idx = map2["cro"].First();
                    lst[idx].Append('a');
                    map2["cro"].Remove(idx);
                    map2["croa"].Add(idx);
                }
                else
                {
                    return -1;
                }
            }
            else if (croakOfFrogs[i]=='k')
            {
                if(map2["croa"].Count>0)
                {
                    int idx = map2["croa"].First();
                    map2["croa"].Remove(idx);
                    lst[idx] = null;
                    vacated.Add(idx);
                }
                else
                {
                    return -1;
                }
                
            }
        }
        if(map['c']==map['r'] && map['r']==map['o'] && map['o'] == map['a'] && map['a']==map['k'])
        {
           return lst.Count==0?-1:lst.Count;
        }
        else
        {
            return -1;
        }  
    }
