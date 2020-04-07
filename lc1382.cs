
/*
 
 this will be two steps process:
 1. first get all the values from the given tree using inorder traversal into array. 
    remember its a BST, so inorder gives you the elements in sorted order
2. construct BST using the array. and return the tree.
 
 
 */
public class Solution {
    public TreeNode BalanceBST(TreeNode root) {
        List<int> arr = new List<int>();
        InorderTraversal(root,arr);
        //Console.WriteLine(string.Join(" ",arr));
        return ConstructBinaryTree(arr.ToArray(),0,arr.Count-1);
    }
    private void InorderTraversal(TreeNode root,List<int> arr)
    {
        if(root!=null)
        {
            InorderTraversal(root.left,arr);
            arr.Add(root.val);
            InorderTraversal(root.right,arr);
        }
    }
    private TreeNode ConstructBinaryTree(int[] arr, int start, int end)
    {
        if(start<=end)
        {
            int mid = (start + end)/2;
            TreeNode tn = new TreeNode(arr[mid]);
            tn.left = ConstructBinaryTree(arr,start, mid-1);
            tn.right = ConstructBinaryTree(arr,mid+1, end);
            return tn;
        }
        else
        {
            return null;
        }
    }
}
