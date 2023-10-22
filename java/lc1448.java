/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public int goodNodes(TreeNode root) {
        if(root == null)
            return 0;
        int count = 0;
        Queue<Node> q = new LinkedList<Node>();
        q.add(new Node(root, root.val));
        while(q.size()!=0)
        {
            Node n = q.remove();
            if(n.tn.val >=n.maxSofar)
            {
                count++;
            }
            if(n.tn.left!=null)
            {
                q.add(new Node(n.tn.left, Math.max(n.maxSofar,n.tn.left.val)));
            }
            if(n.tn.right!=null)
            {
                q.add(new Node(n.tn.right, Math.max(n.maxSofar,n.tn.right.val)));
            }
        }
        return count;    
    }
}
public class Node
{
    public TreeNode tn;
    public int maxSofar;
    public Node(TreeNode t, int max)
    {
        tn = t;
        maxSofar = max;
    }
}
