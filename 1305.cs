/*
Given two binary search trees root1 and root2.

Return a list containing all the integers from both trees sorted in ascending order.
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        List<int> l1 = new List<int>();
        List<int> l2 = new List<int>();
        TraverseBST(root1,l1);
        TraverseBST(root2,l2);
        int idx1 = 0;
        int idx2 = 0;
        IList<int> ans = new List<int>();
        while(idx1<l1.Count && idx2 <l2.Count)
        {
            if(l1[idx1]<l2[idx2])
            {
                ans.Add(l1[idx1]);
                idx1++;
            }
            else if(l1[idx1]>l2[idx2])
            {
                ans.Add(l2[idx2]);
                idx2++;
            }
            else
            {
                ans.Add(l1[idx1]);
                ans.Add(l2[idx2]);
                idx1++;
                idx2++;
            }
        }
        while(idx1<l1.Count)
        {
            ans.Add(l1[idx1]);
            idx1++;
        }
        while(idx2 <l2.Count)
        {
                ans.Add(l2[idx2]);
                idx2++;
        }
        return ans;
    }
    public void TraverseBST(TreeNode root, List<int> l)
    {
        if(root!=null)
        {
            TraverseBST(root.left,l);
            l.Add(root.val);
            TraverseBST(root.right,l);
        }
    }
}
