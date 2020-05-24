class Solution {
    public TreeNode bstFromPreorder(int[] preorder) {
        int n= preorder.length;
        if(n==0)
            return null;
        return ConstructBst(preorder,0,n-1);
    }
    private TreeNode ConstructBst(int[] preorder, int start, int end)
    {
        if(start>end)
            return null;
        TreeNode root = new TreeNode(preorder[start]);
        int idx = findRightRootIndex(preorder, preorder[start], start+1, end);
        if(idx!=-1)
        {
            root.left = ConstructBst(preorder, start+1, idx-1);
            root.right = ConstructBst(preorder, idx, end);
        }
        else
        {
            root.left = ConstructBst(preorder, start+1, end);
        }
        return root;
    }
    private int findRightRootIndex(int[] preorder, int target, int start, int end)
    {
        int idx = -1;
        for(int i=start;i<=end;i++)
        {
            if(preorder[i]<target)
                continue;
            else
            {
                idx = i;
                break;
            }
        }
        return idx;
    }
}
