public class Solution {
    public int FindJudge(int N, int[][] trust) {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>(); //O (N *N-1)
        int len = trust.Length;
        if(len==0 && N==1)
            return 1;
        for(int i=0;i<len;i++)
        {
            int a = trust[i][0];
            int b = trust[i][1];
            if(!map.ContainsKey(a))
            {
                map.Add(a,new List<int>());
            }
            map[a].Add(b);
        }
        HashSet<int> judge = new HashSet<int>();//p = O(p) = n-1
        bool judgeInitHappened = false;
        for(int i=1;i<=N;i++)
        {
            if(map.ContainsKey(i))
            {
                if(judge.Count==0)
                {
                    if(!judgeInitHappened)
                    {
                        judge = new HashSet<int>(map[i]);
                        judgeInitHappened = true;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    List<int> intersection = map[i].Intersect(judge).ToList();
                    judge = new HashSet<int>(intersection);
                }
            }
        }
        if(judge.Count!=1)
            return -1;
        else return judge.First();
    }
}
