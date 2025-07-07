public class Solution {
    public string ConvertToBase(int n, int b)
    {
        string ans = "";
        string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        while(n >0)
        {
            int rem = n % b;
            n = n / b;
            ans = digits[rem] + ans;
        }
        return ans;
    }

    public string ConcatHex36(int n) {
        return ConvertToBase(n*n, 16) + ConvertToBase(n*n*n, 36);
    }
}
