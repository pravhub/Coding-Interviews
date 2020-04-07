
public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
        int max = arr[arr.Length-1];
        arr[arr.Length-1] = -1;
        for(int i = arr.Length-2;i>=0;i--)
        {
            int nextMax = Math.Max(max, arr[i]);
            arr[i] = max;
            max = nextMax;
        }
        return arr;
    }
}
