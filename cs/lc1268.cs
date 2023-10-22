/*
https://leetcode.com/problems/search-suggestions-system/
*/
public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        TrieNode trie = new TrieNode();
        foreach(string p in products)
        {
            trie.AddWord(p);
        }
        //Console.WriteLine("words added to trie");
        IList<IList<string>> ans = new List<IList<string>>();
        for(int i=0;i<searchWord.Length;i++)
        {
            string subStr = searchWord.Substring(0,i+1);
            ans.Add(trie.Search(subStr));
        }
        return ans;
    }
}
public class Solution2 {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Dictionary<string,SortedSet<string>> map = new Dictionary<string,SortedSet<string>>();
        foreach(string p in products)
        {
            for(int i=0;i<p.Length;i++)
            {
                string subStr = p.Substring(0,i+1);
                //Console.WriteLine(subStr);
                if(!map.ContainsKey(subStr))
                {
                    map.Add(subStr,new SortedSet<string>());
                }
                map[subStr].Add(p);
            }
        }
        
        IList<IList<string>> ans = new List<IList<string>>();
        for(int i=0;i<searchWord.Length;i++)
        {
            string subStr = searchWord.Substring(0,i+1);
            if(map.ContainsKey(subStr))
            {
                ans.Add(map[subStr].Take(3).ToList());
            }
            else
            {
                ans.Add(new List<string>());
            }
        }
        return ans;
    }
}
public class TrieNode {
    bool wordEnds;    
    TrieNode[] childs;
    public TrieNode()
    {
        wordEnds = false;
        childs = new TrieNode[26];
        for(int i=0;i<26;i++)
        {
            childs[i]= null;
        }
    }
    public void AddWord(string w)
    {
        TrieNode temp = this;
        for(int i=0;i<w.Length;i++)
        {
            if(temp.childs[w[i]-'a'] == null)
            {                
                temp.childs[w[i]-'a'] = new TrieNode();
                temp = temp.childs[w[i]-'a'];
            }
            else
            {
                temp = temp.childs[w[i]-'a'];
            }
        }
        temp.wordEnds = true;
    }
    public List<string> Search(string w)
    {
        List<string> ans = new List<string>();
        TrieNode temp = this;
        for(int i=0;i<w.Length;i++)
        {
            if(temp.childs[w[i]-'a']!=null)
            {
                temp = temp.childs[w[i]-'a'];
            }
            else
            {
                return ans;
            }
        }
        //find the first non-null child node
        SearchUnderNonNullNode(temp,ans,w);
        return ans;
    }
    private void SearchUnderNonNullNode(TrieNode cur,List<string> ans, string w)
    {
        if(ans.Count ==3)
            return;
        if(cur.wordEnds)
            ans.Add(w);
        for(int i=0;i<26;i++)
        {
            if(cur.childs[i] != null)
            {                
                SearchUnderNonNullNode(cur.childs[i],ans,w+ (char)(i+97));
            }
        }            
    }
}
    
