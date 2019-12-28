public class Solution {
    public IList<IList<int>> ReconstructMatrix(int upper, int lower, int[] colsum) {
        int n = colsum.Length;
        int sum =0;
        int upperOrLower=0;
        IList<IList<int>> ans = new List<IList<int>>();
        for(int i=0;i<n;i++)
        {
            sum+=colsum[i];
            if(colsum[i]==1)
            {
                upperOrLower++;
            }
        }
        if(sum!=upper+lower)
        {
            return ans;
        }
        else
        {
            int [,] arr = new int[2,n];
            for(int i=0;i<n;i++)
            {
                if(colsum[i]==2)
                {
                    if(upper>0 && lower>0)
                    {
                        arr[0,i] = 1;
                        arr[1,i] = 1;
                        upper--;
                        lower--;
                    }
                    else
                    {
                        return ans;
                    }
                }                  
            }
            for(int i=0;i<n;i++)
            {
                if(colsum[i]==1)
                {
                    if(upper>0)
                    {
                        arr[0,i] = 1;
                        upper--;
                    }
                    else if(lower>0)
                    {
                        arr[1,i] = 1;
                        lower--;
                    }
                    else
                    {
                        return ans;
                    }
                }
            }
            for(int i=0;i<2;i++)
            {
                List<int> curList = new List<int>();
                for(int j=0;j<n;j++)
                {
                    curList.Add(arr[i,j]);
                }
                ans.Add(curList);
            }
            return ans;
        }
    }
}

/*
https://leetcode.com/problems/reconstruct-a-2-row-binary-matrix/submissions/
*/
