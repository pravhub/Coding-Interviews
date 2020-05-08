public class Solution {
    public bool IsCompleteTree(TreeNode root) {
        if(root==null)
            return true;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(new Node(root, 1));
        int id =1;
        while(q.Count!=0)
        {
            Node cur = q.Dequeue();
            if(cur.id != id)
                return false;
            id++;
            if(cur.tn.left!=null)
            {
                q.Enqueue(new Node(cur.tn.left, 2*cur.id));
            }
            if(cur.tn.right!=null)
            {
                q.Enqueue(new Node(cur.tn.right, 2*cur.id+1));
            }
        }
        return true;
    }    
}
