public class Solution {
    public int NumTeams(int[] rating) {
        int n = rating.Length;
        int teams = 0;
        for(int i=0;i<n;i++)
        {
            for(int j= i+1;j<n;j++)
            {
                for(int k = j+1;k<n;k++)
                {
                   if((rating[i] < rating[j] && rating[j] < rating[k]) || (rating[i] > rating[j] && rating[j]> rating[k]))
                   {
                       teams++;
                   }
                }
            }
        }
        return teams;
    }
}
