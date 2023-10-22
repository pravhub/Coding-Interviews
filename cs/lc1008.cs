public class Solution {
    public TreeNode BstFromPreorder(int[] preorder) {
        return ConstructBST(preorder, 0, preorder.Length-1);
    }
    private TreeNode ConstructBST(int[] preorder, int start, int end)
    {
        if(start<0 || start>end)
            return null;   
        TreeNode t = new TreeNode(preorder[start]);        
        int endIdx = FindIdxofElementGTX(preorder[start],preorder, start+1, end);
        if(endIdx ==-1)
        {
            t.left = ConstructBST(preorder, start+1, end);
            //t.right = ConstructBST(preorder, endIdx, end);
        }
        else
        {
            t.left = ConstructBST(preorder, start+1, endIdx-1);
            t.right = ConstructBST(preorder, endIdx, end);
        }
        
        
        return t;
    }
    private int FindIdxofElementGTX(int x, int[] preorder, int start, int end)
    {
        for(int i=start;i<=end;i++)
        {
            if(preorder[i]>x)
                return i;
        }
        return -1;
    }
}
