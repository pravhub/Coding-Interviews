public class Solution {
    int sum = 0;
    public int SumNumbers(TreeNode root) {
        StringBuilder sb = new StringBuilder();
        Traverse(root,sb);
        return sum;
    }
    private void Traverse(TreeNode root,StringBuilder str)
    {
        if(root==null)
            return;
        str.Append(root.val);
        if(root.left==null && root.right==null)
        {  //if leaf          
            sum+= int.Parse(str.ToString());
        }
        else 
        {
            Traverse(root.left,str);
            Traverse(root.right,str);
        }
        //str = str.Remove(str.Length-1);
        str.Length--;
    }
}
