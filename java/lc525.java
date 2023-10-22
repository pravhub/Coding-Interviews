class Solution {
    public int findMaxLength(int[] nums) {        
        int count =0;
        int maxLen = 0;
        Map<Integer,Node> map = new HashMap<Integer,Node>();
        map.put(0,new Node(-1,-1));
        for(int i=0;i<nums.length;i++)
        {
            count+= nums[i]==0?1:-1;
            if(!map.containsKey(count))
            {
                map.put(count,new Node(i,-1));
            }
            int start = map.get(count).start;
            map.put(count,new Node(start,i));
        }
        for(int kvp: map.keySet())
        {
            maxLen = Math.max(maxLen, map.get(kvp).end - map.get(kvp).start);
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
