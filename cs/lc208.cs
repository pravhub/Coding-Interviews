public class Trie {
    bool wordEnd;
    Trie[] child;
    /** Initialize your data structure here. */
    public Trie() {
        wordEnd = false;
        child = new Trie[26];
        for(int i=0;i<26;i++)
        {
            child[i] = null;
        }            
    }
  
    /** Inserts a word into the trie. 
    */
    public void Insert(string word) {
        Trie t = this;
        for(int i=0;i<word.Length;i++)
        {
            if(t.child[word[i]-'a']==null)
            {
                t.child[word[i]-'a']= new Trie();
            }
            t = t.child[word[i]-'a'];
        }
        t.wordEnd = true;
    }
    
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        Trie t = this;
        for(int i=0;i<word.Length;i++)
        {
            if(t.child[word[i]-'a']==null)
            {
                return false;
            }
            t = t.child[word[i]-'a'];
        }
        return t.wordEnd;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. 
    */
    public bool StartsWith(string prefix) {
        Trie t = this;
        for(int i=0;i<prefix.Length;i++)
        {
            if(t.child[prefix[i]-'a']==null)
            {
                return false;
            }
            t = t.child[prefix[i]-'a'];
        }
        return true;
    }
}
