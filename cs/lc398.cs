public class Solution {

    Dictionary<int, Node> map = new Dictionary<int, Node>();
    public Solution(int[] nums) {
        for(int i=0;i<nums.Length;i++)
        {
            if(!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], new Node());
            }
            map[nums[i]].Add(i);
        }
    }
    
    public int Pick(int target) {
        return map[target].GetRandom();
        //return map[target].GetRoundRobin();
    }
}
public class Node
{
    public int start;
    public List<int> indices;
    Random rand;
    public Node()
    {
        start = 0;
        indices = new List<int>();
        rand = new Random();
    }
    public void Add(int i)
    {
        indices.Add(i);
    }
    public int GetRoundRobin()
    {//round robin
        if(start>=indices.Count)
        {
            start = 0;
        }
        int ret = indices[start];
        start++;
        return ret;
    }
    public int GetRandom()
    {
        if(start>=indices.Count)
        {
            start = 0;
        }
        int idx = rand.Next(start,indices.Count);
        int ret = indices[idx];        
        indices[idx] = indices[start];
        indices[start] = ret;
        start++;
        return ret;
    }
}
