/*
Given an array of non-negative integers arr, you are initially positioned at start index of the array. When you are at index i, you can jump to i + arr[i] or i - arr[i], check if you can reach to any index with value 0.

Notice that you can not jump outside of the array at any time.

 
*/
public class Solution {
    public bool CanReach(int[] arr, int start) {
        Queue<int> q = new Queue<int>();
        q.Enqueue(start);
        HashSet<int> indexVisited = new HashSet<int>();
        while(q.Count>0)
        {
            
            int curIdx = q.Dequeue();
            //Console.WriteLine(curIdx);
            if(indexVisited.Contains(curIdx))
            {
                continue;
                //return false;
            }
            if(arr[curIdx] == 0)
                return true;
            indexVisited.Add(curIdx);
            int nextIdx1 =  curIdx + arr[curIdx];
            int nextIdx2 = curIdx - arr[curIdx];
            if(nextIdx1>=0 && nextIdx1<arr.Length)
            {
                q.Enqueue(nextIdx1);
            }
            if(nextIdx2>=0 && nextIdx2<arr.Length)
            {
                q.Enqueue(nextIdx2);
            }
        }
        return false;
    }
}
