/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SufficientSubset(TreeNode root, int limit) {
        if(root == null)
            return root;
        bool finalres = DfsRecur(root, limit,0);
        if(finalres)
            return null;
        else return root;
    }
    private bool DfsRecur(TreeNode root, int limit, int sumsofar)
    {
        if(root == null)
            return true;
        //Console.WriteLine("processing {0}",root.val);
        if(sumsofar+root.val < limit && root.left==null && root.right== null)
        {
            //Console.WriteLine("hit the leafnode and lesser than limit");
            return true;
        }
        if(sumsofar+root.val >= limit && root.left==null && root.right== null)
        {
                return false;
        }
        bool left = false;
        bool right = false;
        
        left = DfsRecur(root.left, limit, sumsofar+root.val);
        right = DfsRecur(root.right, limit, sumsofar+root.val);
        if(left)
        {
            //Console.WriteLine("left subtree returned true at {0}",root.val);
            root.left = null;
        }
        if(right)
        {
            //Console.WriteLine("right subtree returned true at {0}",root.val);
            root.right = null;
        }
        return left && right;
    }
}
