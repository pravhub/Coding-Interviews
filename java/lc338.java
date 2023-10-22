class Solution {
    public int[] countBits(int num) {
        int[] arr = new int[num+1];
        if(num>=0)
        {
            arr[0] = 0;
        }
        if(num>=1)
        {
            arr[1] = 1;
        }
        if(num>=2)
        {
            arr[2] = 1;
        }
        for(int i=3;i<=num;i++)
        {
            if(i%2==0)
            {
                arr[i] = arr[i/2];
            }
            else
            {
                arr[i] = 1 + arr[i/2];
            }
        }
        return arr;
    }
    }
