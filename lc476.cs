public class Solution {
    public int FindComplement(int num) {
        int ans=0;
        int i = 0;
        while(num>0)
        {
            int mod = num %2;
            if(mod ==0)
            {
                ans = ans+ (int)Math.Pow(2,i);
            }
            num = num/2;
            i++;
        }
        return ans;
    }
}
