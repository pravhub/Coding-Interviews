public class Solution {
    public double[] SampleStats(int[] count) {
        double[] ans = new double[5];
        int maxSofar = -1;
        int minSofar = 256;
        int highestCount = -1;
        int highestCountNum = -1;
        long sum = 0;
        int nonZeroCountElement = 0;
        for(int i=0;i<=255;i++)
        {
            sum += i*count[i];
            nonZeroCountElement += count[i];
            if(count[i]!=0)
            {
                maxSofar = Math.Max(maxSofar,i);
                minSofar = Math.Min(minSofar,i);
            }
            if(count[i]>highestCount)
            {
                highestCount = count[i];
                highestCountNum = i;
            }
        }
        
        if(nonZeroCountElement %2 == 0) //even
        {
            int mid1 = nonZeroCountElement/2;
            int mid2 = mid1+1;   
            ans[3] = ((double)GetKthElement(mid1,count) + (double)GetKthElement(mid2, count))/2.0;
        }
        else //odd
        {
            int mid = nonZeroCountElement/2 + 1;
            ans[3] = GetKthElement(mid,count);
        }
        
        ans[0] = minSofar;
        ans[1] = maxSofar;
        ans[2] = (double)sum/nonZeroCountElement;
        
        ans[4] = highestCountNum;
        return ans;
    }
    private int GetKthElement(int k, int[] count)
    {
        int i = 0;
        int curCount = 0;
        for(i=0;i<=255;i++)
        {
            if(curCount<k && curCount+count[i]>=k)
            {
                return i;
            }
            curCount+=count[i];
        }
        return -1;
    }
}
