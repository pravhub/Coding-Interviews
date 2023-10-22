public class Solution {
    public bool HasAllCodes(string s, int k) {
        int n = s.Length;
        HashSet<string> distinctCodes = new HashSet<string>();
        int start =0;
        for(int i=0;i<n-k+1;i++)
        {
            string str = s.Substring(i,k);
            //Console.WriteLine(str);
            distinctCodes.Add(str);
            start++;
        }
        return distinctCodes.Count == (int)Math.Pow(2,k);
    }
    public bool HasAllCodes_Possible_TLE(string s, int k) {        
        int end = (int)Math.Pow(2,k);
        for(int i=0;i<end;i++)
        {
            string str = Convert.ToString(i,2);
            if(str.Length<k)
            {
                string prefix = new string('0',k-str.Length);
                str = prefix+str;
            }
            if(s.IndexOf(str)==-1)
                return false;
        }
        return true;
    }
}
