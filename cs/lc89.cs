public class Solution {

    /*
STEP1:building gray code:
for 1 bit then gray code = [0,1]
for 2 bits and more follow the logic below
  - take the (n-1) bits gray code, generate two arrays:
       - first array by prepending "0" to each element in gray code from (n-1) bits
       - second array by prepending "1" to each element in gray code from n-1 bits
       - join first array and "REVERSE" of second array.
   eg: 1-bit array = [0,1]. lets apply above logic for 2bits
       first array = [00,01]
       second array = [10,11]
       final array for 2bits = [00,01] + REVERSE([10,11]) ==> [00,01,11,10]
similarly it works out for 3,4,5.. bits.
convert the binary string to integer and return the list. 
*/
    public IList<int> GrayCode(int n) {
        List<string> ans = new List<string>();
        int count = 0;
        if(n>=0)
        {
            ans.Add("0");            
            count++;
        }
        if(n>=1)
        {
            ans.Add("1");
            count++;
        }
        while(count<=n)
        {
            List<string> newAns = new List<string>();
            for(int i=0;i<ans.Count;i++)
            {
                //newAns.Add(ans[i].Insert(0,"0"));
                newAns.Add("0"+ans[i]);
            }
            for(int i=ans.Count-1;i>=0;i--)
            {
                //newAns.Add(ans[i].Insert(0,"1"));
                newAns.Add("1"+ans[i]);
            }
            ans = newAns;
            count++;
        }
        List<int> res = new List<int>();
        foreach(string s in ans)
        {
            res.Add(Convert.ToInt32(s,2));
        }
        return res;
    }
    
    /*************************/
        public IList<int> GrayCode_Wiki(int n) {
        int max = (int)Math.Pow(2,n);
        IList<int> ans = new List<int>();
        for(int i=0;i<max;i++)
        {
            /* 
            https://en.wikipedia.org/wiki/Gray_code
             * This function converts an unsigned binary
             * number to reflected binary Gray code.
             *
             * The operator >> is shift right. The operator ^ is exclusive or.

            unsigned int BinaryToGray(unsigned int num)
            {
                return num ^ (num >> 1);
            }
            */
            ans.Add(i ^ (i>>1));
        }
        return ans;
    }
}
