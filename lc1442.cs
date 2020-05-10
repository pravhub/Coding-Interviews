public class Solution {
    public int CountTriplets(int[] arr) {
        int n = arr.Length;
        int count=0;
        
        int i = 0;
        int j = -1;
        int k = -1;
        for(int z=0;z<n;z++)   
        {
            int leftXor = -1;
            int rightXor = -1;
            for(int x=z;x<n;x++)
            {
                if(leftXor ==-1)
                {
                    leftXor = arr[x];
                }
                else
                {
                    leftXor= leftXor ^ arr[x];
                }
                j = x+1;
                for(int y=x+1;y<n;y++)
                {
                    if(leftXor == arr[y] && y == x+1)
                    {
                        count++;
                        rightXor = arr[y];
                    }                
                    else
                    {
                        if(rightXor ==-1)
                        {
                            rightXor = arr[y];
                        }
                        else
                        {
                            rightXor= rightXor ^ arr[y];
                        }
                        if(leftXor == rightXor && i!=j)
                        {
                            k = y;
                            count++;
                        }
                    }
                }
                rightXor = -1;
            }
        }
        return count;
    }
}
