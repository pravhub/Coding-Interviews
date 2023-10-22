/*
https://leetcode.com/problems/sequential-digits/
*/
public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        IList<int> res = new List<int>();
        string lstr = low.ToString();
        int startLen = lstr.Length;
        int endLen = high.ToString().Length;
        int firstDigit = Convert.ToInt32(lstr[0].ToString());
        //Console.WriteLine("endLen={0}",endLen);
        int cur = firstDigit;
        int originalLow = low;
        while(startLen<=endLen && startLen<10 && low<high)
        {
            int len =0;
            StringBuilder sb = new StringBuilder();
            while(len<startLen && cur<10)
            {
                sb.Append(cur);
                cur++;
                len++;
            }
            low = Convert.ToInt32(sb.ToString());
            // Console.WriteLine(low);
            if(low>= originalLow && low<=high)
                res.Add(low);

            if(cur>=10)
            {
                startLen++;
                //Console.WriteLine("startlen={0}",startLen);
                cur = 1;
                firstDigit = 1;
            }
            else
            {
                firstDigit++;
                cur = firstDigit;
            }
        }
        
        return res;
    }
}
