class Solution {
   int kthSmall = Integer.MIN_VALUE;
    int _k= -1;
     public int kthSmallest(TreeNode root, int k) {
         _k=k;
        TraverseInorder(root);
        return kthSmall;
        /*
        // with extra space;
        List<Integer> l = new ArrayList<Integer>();
        TraverseInorderWithSpace(root, l);
        return l[k-1];
        */
    }
    private void TraverseInorder(TreeNode tn)
    {
        if(tn==null)
            return;
        
        TraverseInorder(tn.left);
        _k--;
        if(_k==0)
        {
            kthSmall = tn.val;
            return;
        }
        TraverseInorder(tn.right);
    }
    private void TraverseInorderWithSpace(TreeNode tn, List<Integer> l)
    {
        if(tn==null)
            return;
        TraverseInorderWithSpace(tn.left,l);
        l.add(tn.val);
        TraverseInorderWithSpace(tn.right,l);
    }
}
