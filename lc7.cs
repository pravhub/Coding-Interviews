//https://leetcode.com/problems/reverse-integer/
public class Solution {
    public int Reverse(int x) {
        StringBuilder sb = new StringBuilder();
        
        if(x<0)
        {
            sb.Append("-");
            x = x*-1;
        }
        else if (x==0)
        {
            return 0;
        }
        while(x>0)
        {
            sb.Append(x%10);
            x = x/10;
        }
        int output;
        int.TryParse(sb.ToString(),out output);
        return output;
    }
}
