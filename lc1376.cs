/*
build a map of levels: [managerId, List of subordinates]
-1 denotes the root.
example4, map will look like:
[[-1, [0]],
 [0, [1,2]],
 [1, [3,4]],
 [2, [5,6]],
 [3, [7,8]],
 [4, [9,10]],
 [5, [11,12]],
 [6, [13,14]]]

once we have this map. use BFS traversal.
we go thru each level and try to calculate time need to pass the information till that level
  -- add the subordinates of the current employee to the queue along with the time sofar.
     -- we defined a new class to hold this info {employee, cumulative time sofar}
  -- keep track of the max cumulative time observed sofar.  
once we pass thru all levels return the max cumulative time.
*/
public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        Dictionary<int,List<int>> levelMap = new Dictionary<int,List<int>>();
        for(int i=0;i<n;i++)
        {
            if(!levelMap.ContainsKey(manager[i]))
            {
                levelMap.Add(manager[i], new List<int>());
            }
            levelMap[manager[i]].Add(i);
        }        
        int time=0;
        
        int maxTime = int.MinValue;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(new Node(-1,0));
        while(q.Count>0)
        {
            Node cur = q.Dequeue();
            maxTime = Math.Max(maxTime,cur.cumulativeTime);
            if(levelMap.ContainsKey(cur.employee))
            {
                foreach(var subord in levelMap[cur.employee])
                {
                    q.Enqueue(new Node(subord,cur.cumulativeTime+informTime[subord]));
                }
            }
        }
        return maxTime;
    }
}
public class Node
{
    public int employee;
    public int cumulativeTime;
    public Node(int e, int c)
    {
        employee = e;
        cumulativeTime = c;
    }
}
