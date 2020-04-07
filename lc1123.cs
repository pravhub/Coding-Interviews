/**
  * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 *
 
 [0 - 1
  1 - 2,3
  2 - 4,5
  3 - 6]
1. get a map of [level, list of nodes in that level]
2. at highest level, check number of nodes, if its only 1 node, then return that node
3.                                          if nodes count > half of that particular depth, return root node
4.                                           >1 and <= half?? -> 
                                a)do inorder traversal for left subtree and right subtree
                                b)check how many are deepest-leaves are in left subtree and right subtree.
                                c)if some are in left and some are in right then that means the current
                                root is the lowest common ancestor
                                d)if all of them or on to left subtree or all of them are onto right subtree 
                                then we have repeat the steps (a,b,c,d) by assuming that left/right subtree's
                                root as next subtree
  */  
public class Solution {
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        if(root == null)
            return root;
         Dictionary<int,List<TreeNode>> map = new Dictionary<int,List<TreeNode>>();
        Traverse(root, 0,map);
        var kvp = map.OrderBy(m=>m.Key).Last();
        int finalLevel =  kvp.Key;
        List<int> finalNodes = kvp.Value.Select(t=>t.val).ToList();
        if(finalNodes.Count == 1)
            return kvp.Value[0];
        else if (finalNodes.Count > (int)Math.Pow(2,finalLevel-1))
        {
            return root;
        }
        else
        {
            TreeNode curRoot = root;
            while(true)
            {
                HashSet<int> left = new HashSet<int>();
                HashSet<int> right = new HashSet<int>();
                Inorder(curRoot.left,left);
                Inorder(curRoot.right,right);
                int leftc = 0;
                int rightc = 0;
                foreach(int leaf in finalNodes)
                {
                    if(left.Contains(leaf))
                    {
                        leftc++;
                    }
                    else if(right.Contains(leaf))
                    {
                        rightc++;
                    }
                }
                if(leftc !=0 && rightc != 0)
                {
                    return curRoot;
                }
                else if(leftc ==0)
                {
                    curRoot = curRoot.right;
                }
                else //rightc==0
                {
                    curRoot = curRoot.left;
                }
            }
        }        
    }
    private void Inorder(TreeNode root, HashSet<int> nodes)
    {
        if(root != null)
        {
            Inorder(root.left,nodes);
            nodes.Add(root.val);
            Inorder(root.right,nodes);
        }
    }
    private void Traverse(TreeNode root, int curLevel, Dictionary<int,List<TreeNode>> map)
    {
        if(root != null)
        {
            if(!map.ContainsKey(curLevel))
            {
                map.Add(curLevel, new List<TreeNode>());
            }
            map[curLevel].Add(root);
            Traverse(root.left, curLevel + 1, map);
            Traverse(root.right, curLevel + 1, map);
        }
    }
}
