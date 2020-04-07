/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 
 we will use BFS traversal of the tree.
 we need to hold the pointers to the node in original tree and pointer to a node in cloned tree
 so, we create a new Node class to hold the references for original and clone treenodes at each level
 we will use a queue to go thru the nodes in tree
 once we find the node==target, we are going to return the corresponding clone node.
 */

public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
       if(original == null || cloned==null || target==null)
           return null;
        if(original == target)
            return cloned;
        Queue<Node> q= new Queue<Node>();
        q.Enqueue(new Node(original, cloned));
        while(q.Count!=0)
        {
            Node cur = q.Dequeue();
            if(cur.orig == target)
                return cur.clone;
            if(cur.orig.left != null)
            {
                q.Enqueue(new Node(cur.orig.left, cur.clone.left));
            }
            if(cur.orig.right != null)
            {
                q.Enqueue(new Node(cur.orig.right, cur.clone.right));
            }
        }
        return null;
    }
}
public class Node
{
    public TreeNode orig;
    public TreeNode clone;
    public Node(TreeNode o, TreeNode c)
    {
        orig = o;
        clone = c;
    }
}
