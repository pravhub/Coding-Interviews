/*
the idea is to first build the array/list for gray code for n-bits and rotate the list/array from where "start" is occuring.

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

STEP2: now we have gray code array in binary strings. we need to convert to integer list
      - while converting check if the element == "start". 
          - if start is not found just append the element to list
          - if start is FOUND, then insert the element at index i (initialized to 0, increment for each insert)

return the list
start =3;
i = 0;
list = [3,2,0,1]
i++ ==> i=1
*/
public class Solution {
    int firstElementIdx = -1;
    public IList<int> CircularPermutation(int n, int start) {
        IList<int> res = GrayCode(n,start);
        // rotate the list
       return res;
    }
     public IList<int> GrayCode(int n, int start) {
        List<string> ans = new List<string>();
        int count = 0;
        if(n>0)
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
                newAns.Add(ans[i].Insert(0,"0"));
            }
            for(int i=ans.Count-1;i>=0;i--)
            {
                newAns.Add(ans[i].Insert(0,"1"));
            }
            ans = newAns;
            count++;
        }
        List<int> res = new List<int>();
         int idx = 0;
         bool startFound = false;
        foreach(string s in ans)
        {
            int x = Convert.ToInt32(s,2);            
            if(x == start)
            {
                startFound = true;
            }
            if(startFound)
            {
                res.Insert(idx,x);
                idx++;
            }
            else
            {
                res.Add(x);            
            }
        }
        return res;
    }
}
