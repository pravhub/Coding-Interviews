// order of number of nodes in the tree.
//there are N nodes ==> O(N) is time complexity.
public class Solution {
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {
        Traverse(root, null,true, target);
        if(root!=null && root.val == target && root.left==null && root.right==null)
            return null;
        return root;
    }
    public void Traverse(TreeNode root, TreeNode parent, bool left, int target)
    {
        if(root!=null)
        {
            Traverse(root.left, root,true, target);
            Traverse(root.right, root, false,target);
            if(root.val == target)
            {
                if(root.left==null && root.right==null)
                {
                    if(left)
                    {
                        if(parent!=null)
                        {
                            parent.left = null;
                        }
                    }
                    else
                    {
                        if(parent!=null)
                        {
                            parent.right = null;
                        }
                    }
                }
            }
        }
    }
}
