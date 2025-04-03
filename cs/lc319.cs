public class Solution {
    public int BulbSwitch(int n) {
        int i = 1;
        int ans = 0;
        while (i*i <= n)
        {
            i += 1;
            ans +=1;
        }
        return ans;
    }
}
