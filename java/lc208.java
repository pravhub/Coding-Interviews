class Trie {
    boolean wordEnd;
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
    
    /** Inserts a word into the trie. */
    public void insert(String word) {
         Trie t = this;
        for(int i=0;i<word.length();i++)
        {
            if(t.child[word.charAt(i)-'a']==null)
            {
                t.child[word.charAt(i)-'a']= new Trie();
            }
            t = t.child[word.charAt(i)-'a'];
        }
        t.wordEnd = true;
    }
    
    /** Returns if the word is in the trie. */
    public boolean search(String word) {
                Trie t = this;
        for(int i=0;i<word.length();i++)
        {
            if(t.child[word.charAt(i)-'a']==null)
            {
                return false;
            }
            t = t.child[word.charAt(i)-'a'];
        }
        return t.wordEnd;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public boolean startsWith(String prefix) {
                Trie t = this;
        for(int i=0;i<prefix.length();i++)
        {
            if(t.child[prefix.charAt(i)-'a']==null)
            {
                return false;
            }
            t = t.child[prefix.charAt(i)-'a'];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.insert(word);
 * boolean param_2 = obj.search(word);
 * boolean param_3 = obj.startsWith(prefix);
 */
