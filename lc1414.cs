public class Solution {
    public int FindMinFibonacciNumbers(int k) {
        int f1 = 1;
        int f2 = 1;
        List<int> fibs = new List<int>();
        fibs.Add(f1);
        fibs.Add(f2);
        while(f2< 1000000000)
        {
            int next = f1 + f2;
            fibs.Add(next);
            f1 = f2;
            f2 = next;
        }
        //Console.WriteLine(string.Join(" ",fibs));
        int len = fibs.Count;
        HashSet<int> hs = new HashSet<int>();
        int idx = len-1;
        while(k>0)
        {
            if(k>=fibs[len-1])
            {
                hs.Add(fibs[len-1]);
                k = k - fibs[len-1];
            }
            else
            {
                len--;
            }
        }
        return hs.Count;
    }
}
