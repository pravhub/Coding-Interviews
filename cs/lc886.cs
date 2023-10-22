public class Solution {
    Dictionary<int,HashSet<int>> map;
    Dictionary<int,int> groups;
    public bool PossibleBipartition(int N, int[][] dislikes) {
       
        map = new Dictionary<int,HashSet<int>>();
        groups = new Dictionary<int, int>();
        int m = dislikes.Length;
        for(int i=1;i<=N;i++)
        {
            map.Add(i, new HashSet<int>());
        }
        for(int i=0;i<m;i++)
        {
            int from = dislikes[i][0];
            int to = dislikes[i][1];
            
            map[from].Add(to);
            map[to].Add(from); //essential.
        }        
        for(int i=1;i<=N;i++)
        {
          if(!groups.ContainsKey(i))
          {
              if(dfs(i, 1))
              {
                  //means i and its dislikes belong to different groups
                  //we are good
              }
              else
              {
                 return false;
              }
          }
        }
        return true;
    }
    private bool dfs(int i, int groupId)
    {        
        if(groups.ContainsKey(i))
        {
            return groups[i]==groupId;
        }
        groups.Add(i, groupId);
        
        
        foreach(int dislike in map[i])
        {
            if(!dfs(dislike, groupId==1?2:1))
                return false;
        }
        return true;
    }
}
