public class Solution {
    public int DeepestLeavesSum(TreeNode root) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        TraverseTree(root,map,0);
        //return map.OrderByDescending(m=>m.Key).First().Value;
        return map.OrderBy(m=>m.Key).Last().Value;
    }
    public void TraverseTree(TreeNode root,Dictionary<int,int> map, int level)
    {
        if(root!=null)
        {
            if(!map.ContainsKey(level))
            {
                map.Add(level,0);
            }
            map[level]+=root.val;
            TraverseTree(root.left,map,level+1);
            TraverseTree(root.right,map,level+1);
        }
    }
}
