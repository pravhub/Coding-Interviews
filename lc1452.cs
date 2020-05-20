public class Solution {
    public IList<int> PeopleIndexes(IList<IList<string>> fc) {
        List<int> ans = new List<int>();
        int n = fc.Count;
        Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
        for(int i=0;i<n;i++)
        {
           foreach(string s in fc[i])
           {
               if(!map.ContainsKey(s))
               {
                   map.Add(s,new List<int>());
               }
               map[s].Add(i);
           }
        }
        
        HashSet<int> hs = new HashSet<int>();
        for(int i=0;i<n;i++)
        {
            hs = new HashSet<int>(map[fc[i][0]]);
            for(int j=1;j<fc[i].Count;j++)
            {
                hs.IntersectWith(map[fc[i][j]]);
                if(hs.Count==1)
                    break;                    
            }
            if(hs.Count==1)
                ans.Add(i);
        }
        
        return ans;
    }
  }
