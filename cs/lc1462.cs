public class Solution {
    public IList<bool> CheckIfPrerequisite(int n, int[][] prerequisites, int[][] queries)
    {
        bool[][] reachable = new bool[n][];
        for(int i=0;i<n;i++)
        {
            reachable[i] = new bool[n];
            for(int j=0;j<n;j++)
            {
                reachable[i][j] = false;
            }
        }
        int m = prerequisites.Length;
        for(int i=0;i<m;i++)
        {
            int prereq = prerequisites[i][0];
            int course = prerequisites[i][1];
            reachable[prereq][course] = true;
        }
        for(int k=0;k<n;k++)
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if(!reachable[i][j])
                        reachable[i][j] = reachable[i][k] && reachable[k][j];
                }
            }
        }
        int q = queries.Length;
        bool[] ans = new bool[q];
        for(int i=0;i<q;i++)
        {
            int fr = queries[i][0];
            int to = queries[i][1];
            ans[i] = reachable[fr][to];
        }
        return ans;
    }
    }
