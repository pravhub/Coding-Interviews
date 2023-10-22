/*
[3,3,3,3,5,5,5,2,2,7]
map 
KEY-Value
3 - 4
5 - 3
2 - 2
7 - 1

sort by VALUE.
time = O(n * logn) + O(n) = O(n * log(n))
space = O(2 *n) = O(n)
*/
public class Solution {
    public int MinSetSize(int[] arr) {
        int n = arr.Length/2;
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int i in arr)
        {
            if(!map.ContainsKey(i))
            {
                map.Add(i,0);
            }
            map[i]++;
        }
        map = map.OrderByDescending(m=>m.Value).ToDictionary(m=>m.Key,m=>m.Value);
        int countInSet =0; //number of distinct elements 
        int curCount =0; 
        foreach(var kvp in map)
        {
            if(curCount + kvp.Value < n) //n = 5
            {
                countInSet++; //1
                curCount += kvp.Value; //4
            }
            else
            {
                countInSet++; //2
                break;
            }
        }
        return countInSet;
    }
}
