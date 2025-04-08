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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null)
            return true;
        else if((p == null && q != null)||(p != null && q == null))
            return false;
        else
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
