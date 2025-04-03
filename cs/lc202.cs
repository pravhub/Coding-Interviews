public class Solution {
    public bool IsHappy(int n) {
        var m = new HashSet<int>();
        while(n > 1)
        {
            int cur = n;
            int nxt = 0;
            while(cur > 0)
            {
                int rem = cur % 10;
                nxt = nxt + rem * rem;
                cur = cur / 10;
            }
            if(m.Contains(nxt))
                return false;
            else
                m.Add(nxt);
            n = nxt;
        }
        return n == 1;
    }
}
