/*
we are going to use BFS and a queue for this problem.
  1. we are allowed to change only one number in the string at a time.
  2. for every number there are two numbers at a distance of 1.
  3. put those numbers into a map.
  4. have a private function to calculate all the numbers which are at a distance of 1.
  5. use a queue and put the start string in to it
  6. for each entry in the queue (if its not already visited, keep track thru hashset)
     get all the neighbors at a distance of 1.
  7. if any of them are not in the list of "deadends" then add them to queue.
     keep track of number of steps until the current string.
  continue the process until you see the TARGET. keep track of minimum steps when you see target
  once queue becomes empty. whatever the min steps, just return it.
*/


public class Solution {
    Dictionary<char,List<char>> map = new Dictionary<char,List<char>>();
    public int OpenLock(string[] deadends, string target) {
        HashSet<string> dead = new HashSet<string>(deadends);
        map.Add('0',new List<char>() {'1','9'});
        map.Add('1',new List<char>() {'2','0'});
        map.Add('2',new List<char>() {'3','1'});
        map.Add('3',new List<char>() {'4','2'});
        map.Add('4',new List<char>() {'5','3'});
        map.Add('5',new List<char>() {'6','4'});
        map.Add('6',new List<char>() {'7','5'});
        map.Add('7',new List<char>() {'8','6'});
        map.Add('8',new List<char>() {'9','7'});
        map.Add('9',new List<char>() {'0','8'});
        string start = "0000";
        if(dead.Contains(start) || dead.Contains(target))
            return -1;
        int minSteps = int.MaxValue;
        Queue<Node> q = new Queue<Node>();
        HashSet<string> visited = new HashSet<string>();
        q.Enqueue(new Node(start,0));        
        while(q.Count>0)
        {
            Node n = q.Dequeue();            
            if(n.cur == target)
            {
                minSteps = Math.Min(minSteps, n.steps);
            }
            else
            {
                foreach(var s in GetLocksBy1Diff(n.cur))
                {
                    if(!dead.Contains(s) && !visited.Contains(s))
                    {
                        q.Enqueue(new Node(s,n.steps+1));
                        visited.Add(s);
                    }
                }
            }
        }
        if(minSteps == int.MaxValue)
            return -1;
        return minSteps;
    }    
    private List<string> GetLocksBy1Diff(string s)
    {
        List<string> ans = new List<string>();
        char[] arr = s.ToCharArray();
        for(int i = 0;i <4;i++)
        {
            char temp = arr[i];
            foreach(var c in map[arr[i]])
            {
                arr[i] =  c;
                ans.Add(new string(arr));    
            }
            arr[i] = temp;
        }
        return ans;
    }
}
public class Node
{
    public string cur;
    public int steps;
    public Node(string s, int i)
    {
        cur = s;
        steps = i;
    }
}
