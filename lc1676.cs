public class Solution {
    int found = 0;
    TreeNode lca = null;
    int total = 0;
    
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode[] nodes) {
        HashSet<TreeNode> toFind = new HashSet<TreeNode>(nodes);
        total = nodes.Length;
        //Console.WriteLine(total);
        dfs(root, toFind);
        return lca;
    }
    private int dfs(TreeNode root, HashSet<TreeNode> toFind)
    {
        if(root == null)
            return 0;
        int current = toFind.Contains(root)?1:0;
        int left = dfs(root.left, toFind);
        int right = dfs(root.right, toFind);
        
        //check if all nodes are found or not
        if((left > 0 || right > 0 || current > 0) && (left + right == total || current + left + right == total))
        {
            //Console.WriteLine($"at {root.val} , left= {left}, right = {right}");
            if(lca == null)
            {
               // Console.WriteLine($"setting lca to {root.val}");
                lca = root;
            }
        }
        return current + left + right;
    }
}
