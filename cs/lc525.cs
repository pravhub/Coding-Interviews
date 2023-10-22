public class Solution {
    public int FindMaxLength(int[] nums) {
        int count =0;
        int maxLen = 0;
        Dictionary<int,Node> map = new Dictionary<int,Node>();
        map.Add(0,new Node(-1,-1));
        for(int i=0;i<nums.Length;i++)
        {
            count+= nums[i]==0?1:-1;
            if(!map.ContainsKey(count))
            {
                map.Add(count,new Node(i,-1));
            }
            map[count].end = i;
        }
        foreach(var kvp in map)
        {
            maxLen = Math.Max(maxLen, kvp.Value.end-kvp.Value.start);
        }
        return maxLen;
    }
}
public class Node
{
    public int start;
    public int end;
    public Node(int s, int e)
    {
        start = s;
        end = e;
    }
}
