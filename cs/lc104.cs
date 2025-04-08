/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root != null)
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        else
            return 0;
    }
    public int MaxDepthIterative(TreeNode root) {
        if(root == null)
            return 0;
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);
        int depth = 0;
        while(nodes.Count > 0)
        {
            var nextLevel = new Queue<TreeNode>();
            while(nodes.Count > 0)
            {
                TreeNode n = nodes.Dequeue();
                if(n.left != null)
                    nextLevel.Enqueue(n.left);
                if(n.right != null)
                    nextLevel.Enqueue(n.right);
            }
            nodes = nextLevel;
            depth += 1;
        }
        return depth;
    }
}
