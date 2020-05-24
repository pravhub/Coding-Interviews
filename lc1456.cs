public class Solution {
    public int MaxVowels(string s, int k) {
       int n = s.Length;
        int max = 0;
        int cur = 0;
        for(int i=0;i<n;i++)
        {
            if(i+1<=k)
            {
                if (s[i]=='a' || s[i]=='e' ||s[i]=='i' ||s[i]=='o' ||s[i]=='u')
                {
                    cur++;
                }
            }
            else
            {                
                max = Math.Max(max, cur);
                int j = i-k;
                //Console.WriteLine("i={0}, j={1}", i, j);
                if (s[j]=='a' || s[j]=='e' ||s[j]=='i' ||s[j]=='o' ||s[j]=='u')
                {
                    cur--;
                }
                if (s[i]=='a' || s[i]=='e' ||s[i]=='i' ||s[i]=='o' ||s[i]=='u')
                {
                    cur++;
                }
            }                
        }
        max = Math.Max(max, cur);
        return max;  
    }
}
