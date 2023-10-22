public class Solution {
    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        Dictionary<int,List<int>> map =new Dictionary<int,List<int>>();
        int n = nums.Count;
        for(int i=n-1;i>=0;i--)
        {
            for(int j=0;j<nums[i].Count;j++)
            {
                if(!map.ContainsKey(i+j))
                {
                    map.Add(i+j,new List<int>());
                }
                map[i+j].Add(nums[i][j]);
            }
        }
        List<int> ans = new List<int>();
        for(int i=0;i<map.Count;i++)
        {
            ans.AddRange(map[i]);
        }
        return ans.ToArray();
    }
