public class Solution {
    public int GoodNodes(TreeNode root) {
        if(root == null)
            return 0;
        int count = 0;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(new Node(root, root.val));
        while(q.Count!=0)
        {
            Node n = q.Dequeue();
            if(n.tn.val >=n.maxSofar)
            {
                count++;
            }
            if(n.tn.left!=null)
            {
                q.Enqueue(new Node(n.tn.left, Math.Max(n.maxSofar,n.tn.left.val)));
            }
            if(n.tn.right!=null)
            {
                q.Enqueue(new Node(n.tn.right, Math.Max(n.maxSofar,n.tn.right.val)));
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
