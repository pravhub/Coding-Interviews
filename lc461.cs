public class Solution {
    public int HammingDistance(int x, int y) {
        int ans = x ^ y;
        return Get1s(ans);
    }
    private int Get1s(int x)
    {
        int count = 0;
        while(x>0)
        {
            if(x%2==1)
                count++;
            x = x/2;
        }
        return count;
    }
}
