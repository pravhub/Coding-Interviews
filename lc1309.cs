//time == O(N)  
//space = O(N/3 to N) = O(N).
//12#26# . == 6
//lz == 2  == (6/3).
//12262 = 5
//abbfb = 5.
public class Solution {
    public string FreqAlphabets(string s) {
        StringBuilder sb = new StringBuilder();
        int i =0;
        while(i<s.Length)
        {
            if(i+2<s.Length && s[i+2]=='#')
            {
                string s1 = string.Format("{0}{1}",s[i],s[i+1]);
                //Console.WriteLine(s1);
                sb.Append( (char) (96+Convert.ToInt32(s1))); //l,z
                i+=3;
            }
            else
            {
                string s2 = string.Format("{0}",s[i]);
                //Console.WriteLine(s2);
                sb.Append((char)(96+Convert.ToInt32(s2)));
                i+=1;
            }
        }
        return sb.ToString();
    }
}
