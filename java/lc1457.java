class Solution {
    
    Map<Integer,Integer> map = new HashMap<Integer,Integer>();
    int pseudo_palindromic = 0;
    
    public int pseudoPalindromicPaths (TreeNode root) {
        dfs(root);
        return pseudo_palindromic;
    }
    
    private void dfs(TreeNode cur)
    {
        if(cur == null)
            return;
        if(!map.containsKey(cur.val))
        {
            map.put(cur.val,1);
        }
        else
        {
            map.put(cur.val, 1+ map.get(cur.val));
        }
        //check if its a leaf.
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
        map.put(cur.val, map.get(cur.val)-1);
        if(map.get(cur.val)<=0)
        {
            map.remove(cur.val);
        }
    }

    private boolean IsPalindrome(Map<Integer,Integer> map)
    {
        if(map.size()<=1)
            return true;
        int odd = 0; 
        for(var key : map.keySet())
        {
            if(map.get(key)%2==1)
            {
                odd++;
                if(odd>1)
                    return false;
            }
        }
        return true;
    }
}
