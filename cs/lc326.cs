public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n < 1)
            return false;
        while(n > 1)
        {
            if(n % 3 == 0)
                n = n / 3;
            else
                return false;
        }
        return true;
    }
}
