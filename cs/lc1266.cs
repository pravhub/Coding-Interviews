//https://leetcode.com/problems/minimum-time-visiting-all-points/
public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        /*
           draw a 2D graph, put points and try traversing. 
           from a given point find the difference between x and y coordinates. max diff is the travel distance.
           this solution takes O(N) time where N is the number of points. Constant Space.
        */
        int n = points.Length;
        int dist =0;
        for(int i =1;i<n;i++)
        {
            int x1 = points[i-1][0];
            int y1 = points[i-1][1];
            int x2 = points[i][0];
            int y2 = points[i][1];
            
            dist += Math.Max(Math.Abs(x1-x2),Math.Abs(y1-y2));
            
        }
        return dist;
    }
}
