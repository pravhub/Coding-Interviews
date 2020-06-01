public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        Invert(root);
        return root;
    }
    private void Invert(TreeNode root)
    {
        if(root==null)
            return;
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
        Invert(root.left);
        Invert(root.right);
    }
}
