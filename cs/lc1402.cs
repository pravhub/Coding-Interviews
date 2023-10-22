public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        int n = satisfaction.Length;
        Array.Sort(satisfaction);
        int mult = 1;
        int maxSat = 0;
        int zeroOrPositiveIdx = -1;
        bool zeroOrPositiveIdxFound = false;
        int cumSum = 0;
        for(int i=0;i<n;i++)
        {
            if(!zeroOrPositiveIdxFound && satisfaction[i]>=0)
            {
                zeroOrPositiveIdx = i-1;
                zeroOrPositiveIdxFound = true;
            }
            if(satisfaction[i]<0)
                continue;
            maxSat += satisfaction[i]*mult;
            mult++;
            cumSum+=satisfaction[i];
        }
        while(zeroOrPositiveIdx>=0)
        {
            int curSat = satisfaction[zeroOrPositiveIdx] + maxSat+cumSum;
            if(curSat>maxSat)
            {
                maxSat = curSat;
            }
            cumSum +=satisfaction[zeroOrPositiveIdx];
            zeroOrPositiveIdx--;
        }
        return maxSat;
    }
}
