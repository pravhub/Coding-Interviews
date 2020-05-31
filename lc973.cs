public class Point
{
    public int _x;
    public int _y;
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }
}
public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        int[][] ans = new int[K][];
        SortedDictionary<double,List<Point>> map = new SortedDictionary<double,List<Point>>();
        int n = points.Length;
        for(int i =0;i<n;i++)
        {
           double d = GetDistance(points[i][0],points[i][1]);
            if(!map.ContainsKey(d))
            {
                map.Add(d,new List<Point>());
            }
            map[d].Add(new Point(points[i][0],points[i][1]));
        }
        int count =0;
        foreach(var kvp in map)
        {
            foreach(var p in kvp.Value)
            {
                ans[count] = new int[2];
                ans[count][0] = p._x; 
                ans[count][1] = p._y;
                count++;
                if(count>=K)
                    break;
            }
            if(count>=K)
                break;
        }
        return ans;
    }
    public double GetDistance(int x, int y)
    {
        return Math.Sqrt(x*x + y*y);
    }
}
