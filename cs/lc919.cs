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
 
 complete binary tree: 
 
                      1        level0 -1
                  /       \
                2          3   level1 - 2
             /  \            /  \
           4     5          6    7  level-2  -4 
          / \    /\       /  \    / \
         8   9  10 11   12   13  14 15 level-3 - 8
        /\ 
       16 17
         
        insert(17) currentNode =8.
        insert(18) get a node from q. currentNode =9
 We need to have a position for insertion of new node into the tree.
 new node is the node where the node does not have a left child or right child or not having both childs.
 
 remember we are passed with a complete binary tree in constructor. we need to preserve that property.
 we will use modified version of BFS to identify the first such node where {left child or right child or not having both childs}
 while we insert new nodes into the tree, we will append the queue with new nodes.
 simply because new nodes will not have any right or left childs
 
 */
public class CBTInserter {
    TreeNode trRoot=null;
    TreeNode curNode = null; // insertion position for new data. CBTInserter.insert(int v)
    Queue<TreeNode> q = null;
    //time= n - nodes in the initialized binary tree, - O(n).
    //space = h is the final level in the tree. O(2^h)
    public CBTInserter(TreeNode root) {
        q = new Queue<TreeNode>();
        trRoot = root;   
        bool curNodeFound = false;
        Queue<TreeNode> localq = new Queue<TreeNode>();
        localq.Enqueue(root);
        while(localq.Count != 0)
        {
            TreeNode r = localq.Dequeue();
            if(!curNodeFound && (r.left==null || r.right==null))
            {
                curNode = r;
                curNodeFound = true;
            }
            if(r.left != null)
                localq.Enqueue(r.left);
            if(r.right != null)
                localq.Enqueue(r.right);        
            if(curNodeFound)
            {
                q.Enqueue(r); // all future insert node positions
            }
        }
    }
    //time= O(1)
    //space= space for new tree node.
    public int Insert(int v) {
        if(curNode.left==null)
        {
            curNode.left = new TreeNode(v);
            q.Enqueue(curNode.left);
            return curNode.val;
        }
        else if(curNode.right==null)
        {
            curNode.right = new TreeNode(v);
            q.Enqueue(curNode.right);
            return curNode.val;
        }
        else
        {
            curNode = q.Dequeue();
            return Insert(v);
        }
    }
    //time = O(1)
    //space = O(1)
    public TreeNode Get_root() {
        return trRoot;
    }
}

/**
 * Your CBTInserter object will be instantiated and called as such:
 * CBTInserter obj = new CBTInserter(root);
 * int param_1 = obj.Insert(v);
 * TreeNode param_2 = obj.Get_root();
 */
