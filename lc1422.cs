public class Solution {
    public int MaxScore(string s) {
        //"011101"
        //time = O(n)
        //space= O(n)
        //ones =
        int n = s.Length;
        int[] zeros = new int[n];
        int[] ones = new int[n];
        int c0=0;
        int c1 = 0;
        //zeros= [1,1,1,1,2,1] 
        for(int i =0;i<s.Length; i++)
        {
            if(s[i]=='0')
            {
                c0++;
                zeros[i] = c0;
            }
        }
        //ones = [4,4,3,2,1,1]
        for(int i =s.Length-1;i>=0; i--)
        {
            if(s[i]=='1')
            {
                c1++;
                ones[i] = c1;
            }
        }
        int maxScore = 0;
        //zeros= [1,1,1,1,2,1] 
        //ones = [4,4,3,2,1,1]
        //maxscore= max(0,1+4) = 5
        // answer 5 
        for(int i =0;i<n; i++)
        {
          if(i+1<n)
          {
              maxScore = Math.Max(maxScore,zeros[i]+ones[i+1]);
          }
        }
        return maxScore;
    }
}
