public class Solution {
    Dictionary<int,int> map = new Dictionary<int,int>();
    int pseudo_palindromic = 0;
    public void dfs(TreeNode cur)
    {
        if(cur == null)
            return;
        if(!map.ContainsKey(cur.val))
        {
            map.Add(cur.val,0);
        }
        map[cur.val]++;
        if(cur.left==null && cur.right==null)
        {
            if(IsPalindrome(map))
            {
                pseudo_palindromic++;
            }
        }
        else
        {
            dfs(cur.left);
            dfs(cur.right);
        }        
        map[cur.val]--;
        if(map[cur.val]==0)
        {
            map.Remove(cur.val);
        }
    }
        
    public int PseudoPalindromicPaths (TreeNode root) {
        dfs(root);
        return pseudo_palindromic;
    }
    private bool IsPalindrome(Dictionary<int,int> map)
    {
        if(map.Count<=1)
            return true;
        int odd = 0; 
        foreach(var kvp in map)
        {
            if(kvp.Value%2==1)
            {
                odd++;
                if(odd>1)
                    return false;
            }
        }
        return true;
    }
}
