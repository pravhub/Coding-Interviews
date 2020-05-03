public class Solution {
    public string Reformat(string s) {
        if(s.Length<=1)
            return s;
        int []counts = new int[10]; //0 - 9.
        int []chars = new int[26]; //a -z ==>0th a'scount 1st -b's count.. 25th index z'count
        int charCount = 0;
        int digitCount = 0;
        foreach(char c in s)
        {
            if(Char.IsDigit(c))
            {
                counts[c-'0']++;
                digitCount++;
            }
            else
            {
                chars[c-'a']++;
                charCount++;
            }
        }
        if((digitCount==0 && charCount>1) || (charCount==0 && digitCount>1) || Math.Abs(digitCount-charCount)>1)
            return "";
        //if((digitCount==0&& charCount==1) ||(digitCount==1&& charCount==0))
        StringBuilder sb = new StringBuilder();
        int co_i =0;
        int ch_i = 0;
        while(co_i < 10 && ch_i < 26)
        {
            if(counts[co_i]>0 && chars[ch_i]>0)
            {
                if(charCount > digitCount)
                {
                    sb.Append((char)('a'+ch_i));
                    sb.Append((char)('0'+co_i));
                }
                else
                {
                    sb.Append((char)('0'+co_i));
                    sb.Append((char)('a'+ch_i));
                }
                counts[co_i]--;
                chars[ch_i]--;
                
            }
            else if(counts[co_i]>0)
            {
                ch_i++;
            }
            else
            {
                co_i++;
            }
        }
        while(co_i < 10)
        {
            if(counts[co_i]>0)
            {    
                sb.Append((char)('0'+co_i));
                counts[co_i]--;
            }
            else
            {
                co_i++;
            }
        }
        while(ch_i < 26)
        {
            if( chars[ch_i]>0)
            {
                sb.Append((char)('a'+ch_i));
                chars[ch_i]--;
            }
            else
            {
                ch_i++;
            }
        }
        return sb.ToString();
    }
}
