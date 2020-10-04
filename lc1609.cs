public class Solution {
     public bool IsEvenOddTree(TreeNode root) {
        if(root==null)
            return true;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int level = 0;
        while(q.Count>0)
        {
            int count = q.Count;
            //List<int> curLevel = new List<int>();
            int prev =0;
            for(int i=0;i<count;i++)
            {
                TreeNode n = q.Dequeue();
                //curLevel.Add(n.val);
                if(level%2==0) //even level
                {
                    if(n.val%2==0)
                        return false;
                    if(prev==0)
                        prev = n.val;
                    else
                    {
                        if(prev>=n.val)
                            return false;
                        prev = n.val;
                    }
                }
                else //odd level.
                {
                    if(n.val%2==1)
                        return false;
                    if(prev==0)
                        prev = n.val;
                    else
                    {
                        if(prev<=n.val)
                            return false;
                        prev = n.val;
                    }
                }
                if(n.left!=null)
                    q.Enqueue(n.left);
                if(n.right!=null)
                    q.Enqueue(n.right);
            }
            //Console.WriteLine($"l={level}, {string.Join(",",curLevel)}");            
            level++;
        }
        return true;
    }
    
    /*
    time= n nodes in BT. O(2n) => O(n)
    spcae= q, l-level 2^l number of elements in curLevel list.
    O(n/2)+ O(n/2) ==> O(n)
    */
    public bool IsEvenOddTree_space(TreeNode root) {
        if(root==null)
            return true;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int level = 0;
        while(q.Count>0)
        {
            int count = q.Count;//1
            List<int> curLevel = new List<int>();
            for(int i=0;i<count;i++)
            {
                TreeNode n = q.Dequeue();
                curLevel.Add(n.val);
                if(n.left!=null)
                    q.Enqueue(n.left);
                if(n.right!=null)
                    q.Enqueue(n.right);
            }
            //Console.WriteLine($"l={level}, {string.Join(",",curLevel)}");
            if(level%2==0)//even level conditions#2
            {
                if(curLevel[0]%2==0)
                    return false;
                for(int i=1;i<count;i++)
                {
                    if(curLevel[i]%2==0 || curLevel[i]<=curLevel[i-1])
                        return false;
                }
            }
            else//odd level conditions#3
            {
                if(curLevel[0]%2==1)
                    return false;
                for(int i=1;i<count;i++)
                {
                    if(curLevel[i]%2==1 ||curLevel[i]>=curLevel[i-1])
                        return false;                   
                }
            }
            level++;
        }
        return true;
    }
}
