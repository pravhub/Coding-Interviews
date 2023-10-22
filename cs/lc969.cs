/*
the idea is to sort/move 1 element to its final position.
total elements = n
find max element's index and flip the elements from 1 to max element. (now max element is at 1st position)
        flip all n elements -- (this makes max element to goto last position)

total elements = n-1
find the max element index and flip elements from 1 to max element (now max element is at 1st position)
      -- flip n-1 elements -- this makes "next" max element goto last-1 position
continue this process.
*/

public class Solution {
    int[]arr;
    public IList<int> PancakeSort(int[] A) {
        arr = new int[A.Length];
        Array.Copy(A,arr,A.Length);
      int length = arr.Length;
      IList<int> ans = new List<int>();
      //O(N*N) O(N*K)
      for(int i=length-1;i>0;i--)
      {
        //N times - N length
        int maxIdx = GetMaxElementIdxBeforeK(i);        
        Flip(maxIdx+1);
        Flip(i+1);
        ans.Add(maxIdx+1);
          ans.Add(i+1);
      }
      return ans;  
    }
    private int GetMaxElementIdxBeforeK(int k)
    {
        int maxIdx= 0;
        for(int i=1;i<=k;i++)
        {
          if(arr[maxIdx] < arr[i])
          {
            maxIdx = i;
          }
        }
    return maxIdx;
    }
    private void Flip(int k)
    {
        if(k>1)
        {
            int start = 0;
            int end = k-1;
            while(start<end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
