//time: O(number of digits in the number)
//space : O(number of digits in the number)
public class Solution {
    public int Maximum69Number (int num) { //num = 9669
        int n = num.ToString().Length;
       int[] digits = new int[n]; //[ 9,9,6,9 ]
        int idx =  n-1;
        while(num > 0)
        {
            digits[idx--] = num % 10;
            num = num / 10;   //966         
        }
        int updateNum =0;
        bool seenSix = false;
        for(int i=0;i<n;i++)
        {
            if(!seenSix && digits[i]==6)
            {
                seenSix = true;
                digits[i] = 9;
            }
            updateNum = updateNum * 10 + digits[i]; //9 , when i =0
        }                                           // i= 1, 99
        return updateNum; //9969
    }
}
