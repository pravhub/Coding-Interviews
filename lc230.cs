public class Solution {
   int kthSmall = int.MinValue;
    public int KthSmallest(TreeNode root, int k) {
        TraverseInorder(root, ref k);
        return kthSmall;
        /*
        // with extra space;
        List<int> l = new List<int>();
        TraverseInorderWithSpace(root, l);
        return l[k-1];
        */
    }
    private void TraverseInorder(TreeNode tn, ref int k)
    {
        if(tn==null)
            return;
        
        TraverseInorder(tn.left,ref k);
        k--;
        if(k==0)
        {
            kthSmall = tn.val;
            return;
        }
        TraverseInorder(tn.right,ref k);
    }
    private void TraverseInorderWithSpace(TreeNode tn,List<int> l)
    {
        if(tn=null)
            return;
        TraverseInorderWithSpace(tn.left,l);
        l.Add(tn.val);
        TraverseInorderWithSpace(tn.right,l);
    }
}
