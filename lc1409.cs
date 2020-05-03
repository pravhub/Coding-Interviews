public class Solution {
    public int[] ProcessQueries(int[] queries, int m) {
        List<int> arr = new List<int>();
        List<int> ans = new List<int>();
        for(int i=0;i<m;i++)
        {
            arr.Add(i+1);
        }
        //Console.WriteLine(string.Join(" ",arr));
        for(int j=0;j<queries.Length;j++)
        {
            int query = queries[j];  
            int pos = -1;
            for(int i=0;i<m;i++)
            {
                if(arr[i]==query)
                {
                    pos = i;
                    break;
                }
            }
            ans.Add(pos);
            int toRemove = arr[pos];
            arr.RemoveAt(pos);
            arr.Insert(0,toRemove);
        }
        return ans.ToArray();
    }
}
