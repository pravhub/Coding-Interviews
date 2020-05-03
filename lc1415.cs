public class Solution {
    public string GetHappyString(int n, int k) {
        List<string> allStrings = GetLexicographicalStrings(n);
        //Console.WriteLine(string.Join(" ",allStrings));
        //Console.WriteLine("{0}--{1}",n, allStrings.Count);
        if(k <= allStrings.Count)
            return allStrings[k-1];
        else
            return "";
    }
    private List<string> GetLexicographicalStrings(int len)
    {
        List<string> start = new List<string>();
        char[] arr = new char[3] {'a', 'b', 'c'};
        start.Add("a");
        start.Add("b");
        start.Add("c");
        // we already have strings of length 1, so starting to generate length =2.
        for(int i=2;i<=len;i++)
        {
            List<string> next = new List<string>();
            foreach(string s in start)
            {
                for(int j=0;j<3;j++)
                {
                    if(s[i-2]!=arr[j]) // we are making sure the strings last character is not the same as what we are adding.
                    {
                        next.Add(s+arr[j]);
                    }
                }
            }
            start = next.ToList();
        }
        return start;
    }
}
