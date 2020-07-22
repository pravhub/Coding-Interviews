public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> ans = new List<IList<int>>();
        if(root==null)
            return ans;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        bool leftToRight = true;
        while(q.Count>0)
        {
            int qCount = q.Count;
            IList<int> curLevel = new List<int>();
            for(int i=0;i<qCount;i++)
            {
                TreeNode cur = q.Dequeue();       
                if(leftToRight)
                {
                    curLevel.Add(cur.val);                    
                }
                else
                {
                    curLevel.Insert(0,cur.val);
                }
                if(cur.left!=null)
                    q.Enqueue(cur.left);
                if(cur.right!=null)
                    q.Enqueue(cur.right);
            }           
            ans.Add(curLevel);
            leftToRight = !leftToRight;
        }
        return ans;
    }
}
