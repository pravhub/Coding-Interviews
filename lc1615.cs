public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        int m = roads.Length;
        if(m<1)
            return m;
        Dictionary<int,HashSet<int>> graph = new Dictionary<int,HashSet<int>>();
        for(int i=0;i<n;i++)
        {
            graph.Add(i,new HashSet<int>());
        }
        for(int i=0;i<m;i++)
        {
            int start = roads[i][0];
            int end = roads[i][1];
            graph[start].Add(end);
            graph[end].Add(start);
        }        
              
        int maxNR = 0;
        for(int i=0;i<n;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                int curMax = graph[i].Count + graph[j].Count - (graph[i].Contains(j)?1:0);
                maxNR = Math.Max(maxNR, curMax);
            }
        }
        
        return maxNR;
    }
}
