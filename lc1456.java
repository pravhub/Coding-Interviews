class Solution {
    public int maxVowels(String s, int k) {
        int n = s.length();
        int max = 0;
        int cur = 0;
        for(int i=0;i<n;i++)
        {
            if(i+1<=k)
            {//we are still building sliding window.
                if (s.charAt(i)=='a' || s.charAt(i)=='e' ||s.charAt(i)=='i' ||s.charAt(i)=='o' ||s.charAt(i)=='u')
                {
                    cur++;
                }
            }
            else
            {                
                max = Math.max(max, cur);
                int j = i-k; //oldest character index.
                if (s.charAt(j)=='a' || s.charAt(j)=='e' ||s.charAt(j)=='i' ||s.charAt(j)=='o' ||s.charAt(j)=='u')
                {
                    cur--;
                }
                if (s.charAt(i)=='a' || s.charAt(i)=='e' ||s.charAt(i)=='i' ||s.charAt(i)=='o' ||s.charAt(i)=='u')
                {
                    cur++;
                }
            }                
        }
        max = Math.max(max, cur);
        return max;  
    }
}
