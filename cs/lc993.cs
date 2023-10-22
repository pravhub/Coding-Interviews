public class Solution {
    public bool IsCousins(TreeNode root, int x, int y) {
        List<int> xPath = SearchForNode( root,  x);
        List<int> yPath = SearchForNode( root,  y);
        Console.WriteLine(string.Join(" ", xPath));
        Console.WriteLine(string.Join(" ", yPath));
        if(xPath.Count==yPath.Count)
        {
            int n = xPath.Count;
            if(xPath[n-2]!=yPath[n-2])
                return true;
            else
                return false;
        }
        else
        {
            return false;
        }
    }
    private List<int> SearchForNode(TreeNode root, int x)
    {
        List<int> ans = new List<int>();
        if(root == null)
            return ans;
       Stack<Node> q = new Stack<Node>();
        q.Push(new Node(root,0));
        bool foundx = false;
        while(q.Count>0)
        {
            var cur = q.Pop();
            bool addedAtEnd = false;
            if(ans.Count <= cur.level)
            {
                ans.Add(cur.tn.val);
                addedAtEnd = true;
            }
            else
            {
                ans[cur.level] = cur.tn.val;
            }            
            if(cur.tn.val == x)
            {
                foundx=true;
                if(!addedAtEnd)
                {
                    for(int i=ans.Count-1;i>=cur.level+1;i--)
                    {
                        ans.RemoveAt(i);
                    }
                }
                break;
            }
            if(cur.tn.right!=null)
            {
                q.Push(new Node(cur.tn.right,cur.level+1));
            }  
            if(cur.tn.left!=null)
            {
                q.Push(new Node(cur.tn.left,cur.level+1));
            }
          
        }
        if(!foundx)
            ans = new List<int>();
        return ans;
    }
}
public class Node
{
    public TreeNode tn;
    public int level;
    public Node(TreeNode t, int l)
    {
        tn = t;
        level = l;
    }
}
