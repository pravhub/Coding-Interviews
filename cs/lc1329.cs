/*indices in the above array:
 [0,0] [0,1] [0,2] [0,3] 
 [1,0] [1,1] [1,2] [1,3] 
 [2,0] [2,1] [2,2] [2,3] 
 
take diff of indices: i-j and get the elements into a list while traversing the matrix. put these elements and correponding diff in a map. for ex: it will look like the following
 rough syntax: map<diff,List<int>>
 0 - [3,2,1] ==> [1,2,3]
 1 - [2,1] --> [1,2]
 2 - [1]
 -1- [3,1,2]
 ...
now sort these individual lists and put them back in to matrix.
*/









public class Solution {
    public int[][] DiagonalSort(int[][] mat) {
        int m = mat.Length;
        int n = mat[0].Length;
        Dictionary<int,List<int>> map = new Dictionary<int,List<int>>();
        //fill dictionary
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                int diff = i-j;
                if(!map.ContainsKey(diff))
                {
                    map.Add(diff,new List<int>());                    
                }
                map[diff].Add(mat[i][j]);
            }
        }
        //sort the list
        foreach(var kvp in map)
        {
            kvp.Value.Sort();
        }
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                int diff = i-j;
                mat[i][j] = map[diff][0];
                map[diff].RemoveAt(0);
            }
         }
        return mat;
    }
}
