public class Solution {
    
    int sum;
    int[] cumSum;
    Random rand;
    public Solution(int[] w) {
        sum = 0;
        cumSum = new int[w.Length];
        rand = new Random();
        for(int i=0;i<w.Length;i++)
        {
            sum+= w[i];
            cumSum[i] = sum;
        }
    }
    
    public int PickIndex() {
        int target=rand.Next(0,sum);
        return BinarySearch(0, cumSum.Length-1,target);
    }
    private int BinarySearch(int start, int end, int target)
    {
        if(start ==end)
            return start;
        
        int mid=start+(end-start)/2;
            if(cumSum[mid] == target)
            {              
                return mid+1;
            }
            else if(cumSum[mid]<target)
                return BinarySearch(mid+1, end, target);
            else
                return BinarySearch(start, mid, target);
    }
   
}
