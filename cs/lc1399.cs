public class Solution {
    public int CountLargestGroup(int n) {
       //Console.WriteLine(GetSum(13));
        
        Dictionary<int,List<int>> map = new  Dictionary<int,List<int>>();
        int maxSize = 0;
        for(int i=1;i<=n;i++)
        {
            int sum = GetSum(i);
            if(!map.ContainsKey(sum))
            {
                map.Add(sum,new List<int>());
            }
            map[sum].Add(i);
            maxSize = Math.Max(maxSize,map[sum].Count);
        }
        int groups = 0;
        foreach(var kvp in map)
        {
            //Console.WriteLine("{0}, {1}",kvp.Key, String.Join(" ", kvp.Value));
            if(kvp.Value.Count == maxSize)
            {
                
                groups++;
            }
        }
        return groups; 
        //return 0;
    }
    private int GetSum(int n)
    {
        //while(n>=10)
        {
            int start = n;
            int sum = 0;
            while(start>0)
            {
                sum += start%10;
                start = start/10;
            }
            //Console.WriteLine(sum);
            n = sum;
        }
        return n;
    }
}
