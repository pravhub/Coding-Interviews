public class Solution {
    public bool CheckIfCanBreak(string s1, string s2) {
        int[] c1 =  GetOccurences(s1);//O(n)
        int[] c2 =  GetOccurences(s2);//O(n)
        bool canBreak1 = true;
        bool canBreak2 = true;  
        //s1 breaks s2
        int diff = 0;
        for(int i = 0;i<26;i++)//O(26)
        {
            if(c2[i]==c1[i])
            {
                
            }
            else if(c1[i]>c2[1])
            {
                diff+=c1[i]-c2[i];
            }
            else
            {
                diff-=c2[i]-c1[i];
            }
            if(diff<0)
            {
                canBreak1 = false;
                break;
            }
        }
        if(canBreak1)
            return true;
        //s2 breaks s1
        diff = 0;
        for(int i = 0;i<26;i++)//O(26)
        {
            if(c2[i]==c1[i])
            {
                
            }
            else if(c2[i]>c1[1])
            {
                diff+=c2[i]-c1[i];
            }
            else
            {
                diff-=c1[i]-c2[i];
            }
            if(diff<0)
            {
                canBreak2 = false;
                break;
            }
        }
        //Console.WriteLine(diff);
        return canBreak1 || canBreak2;
    }
    public int[] GetOccurences(string s)
    {
        int[] counts = new int[26];//index 0- count of a's, 1-count of b-s.. 25- count of z;s
        foreach(char c in s)
        {
            counts[c-'a']++;
        }
        return counts;
    }
}
