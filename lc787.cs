public class Solution {
    Dictionary<int,List<City>> map;
    int minCost;
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        map = new Dictionary<int,List<City>>();
        int m = flights.Length;
        minCost = int.MaxValue;
        for(int i=0;i<m;i++)
        {
            int start = flights[i][0];
            int end = flights[i][1];
            int cost = flights[i][2];
            if(!map.ContainsKey(start))
            {
                map.Add(start, new List<City>());
            }
            map[start].Add(new City(end, cost));
        }
        dfs(src, dst, K, 0, new List<int>() {src}, new HashSet<int>() {src});
        if(minCost == int.MaxValue)
            return -1;
        return minCost;
    }
    private void dfs(int cur, int dst, int k, int cost, List<int> stops, HashSet<int> seen)
    {
        if(k<0)
            return;
        if(!map.ContainsKey(cur))
                return;
        {
            foreach(City c in map[cur])
            {
                if(seen.Contains(c.dest) || cost+c.cost >minCost)
                    continue;
                if(c.dest == dst)
                {
                    minCost = Math.Min(minCost, cost+c.cost);
                                   continue;
                }
                
                stops.Add(c.dest);
                seen.Add(c.dest);
                dfs(c.dest, dst, k-1, cost+c.cost, stops,seen);
                stops.RemoveAt(stops.Count-1);
                seen.Remove(c.dest);
            }
        }
    }
}
public class City
{
    public int dest;
    public int cost;
    public City(int d, int c)
    {
        dest = d;
        cost = c;
    }
}
