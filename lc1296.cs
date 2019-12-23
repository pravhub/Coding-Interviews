/*
https://leetcode.com/problems/divide-array-in-sets-of-k-consecutive-numbers/
*/
public class Solution {
    public bool IsPossibleDivide(int[] nums, int k) {
        int n=nums.Length;
        // number of elements should be divisible by k. otherwise return false.
        if(n%k!=0)
            return false;
        /*
        store the counts of each element in sorted map.
        process this dictionary for "k" with each startkey. 
        if there is any element missing in the sequence return false.
        finally the curCount should be 0 for a successful sequences of k numbers. otherwise return false,
        */
        SortedDictionary<int,int> map = new SortedDictionary<int,int>();
        foreach(int i in nums)
        {
            if(!map.ContainsKey(i))
            {
                map.Add(i,0);
            }
            map[i]++;
        }
        int curCount =k;
        while(map.Count>0)
        {            
            int startKey = map.First().Key;            
            curCount =k;
            while(curCount>0)
            {
                //Console.WriteLine("looking for {0}",startKey);
                if(!map.ContainsKey(startKey))
                    return false;
                map[startKey]--;
                if(map[startKey]==0)
                {
                    map.Remove(startKey);                    
                }
                startKey++;
                curCount--;
            }
            
        }
        //Console.WriteLine("curCount={0}",curCount);
        return curCount==0;
    }
}
