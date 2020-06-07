public class Solution {
    public int[] GetStrongest(int[] arr, int k) {
        Array.Sort(arr);
        int n = arr.Length;
        int median = arr[(n-1)/2];
        Array.Sort(arr, new StrongCompare(median));
        return arr.Take(k).ToArray();
    }
}
public class StrongCompare: IComparer<int>
{
int m;
  public StrongCompare(int median)
  {
   m = median;
  }
  public int Compare(int a, int b)
  {
     int i = Math.Abs(a-m);
     int j = Math.Abs(b-m);
      if(i==j)
      {
         return b.CompareTo(a);
      }
      else
      {
         return j.CompareTo(i);
      }
  }
}
