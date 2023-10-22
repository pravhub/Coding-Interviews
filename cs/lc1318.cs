
/*1 | 1 == 1
1 | 0 == 1
0 | 1 == 1
0 | 0 == 0

2 = 10 = 2 --> 0010
5 = 101 = 3 --> 0101
8 = 1000 = 4 --> 1000
    max(2,3,4) = 4.
    
    

1.convert the numbers to binary
2.make them same length by prepending zeros
3.calculate the diff and count the bits to be changed.
*/

public class Solution {
    public int MinFlips(int a, int b, int c) {
        string a1 = Convert.ToString(a, 2);
        string b1 = Convert.ToString(b, 2);
        string c1 = Convert.ToString(c, 2);
        
       /* int aIdx = a1.Length-1;
        int bIdx = b1.Length-1;
        int cIdx = c1.Length-1;*/
        int max = Math.Max(Math.Max(a1.Length,b1.Length),c1.Length);
        a1 = PrependZeroes(a1,max-a1.Length);
        b1 = PrependZeroes(b1,max-b1.Length);
        c1 = PrependZeroes(c1,max-c1.Length);
        //Console.WriteLine("{0},{1},{2}",a1,b1,c1);
        int diffBits =0;
        int idx =0;
        while(idx<max)
        {
            if(c1[idx]=='1' && a1[idx]=='0' && b1[idx]=='0')
            {
                diffBits = diffBits+1;
            }
            else if(c1[idx]=='0' && (a1[idx]=='1' || b1[idx]=='1'))
            {
               if(a1[idx]=='1')
                   diffBits++;
                if(b1[idx]=='1')
                   diffBits++;
            }
            idx++;
        }
        return diffBits;
    }
    private string PrependZeroes(string str, int n)
    {
        if(n>0)
        {
            return new string('0',n)+str;
        }
        else
            return str;
    }
}
