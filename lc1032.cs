/*
  we will use trie data structure for this.
  from description, it looks like the strings will have only the lower case english chars
  so our Trie will have 26 child pointer and a placeholder whether its a word end or not
  Trie will have two methods:
  1. Add string to trie: 
        if the given strings curent character's corresponding node is null in the trie that 
        means this is the first word in that path. so create a new node and continue building trie
        if there exists a node already then move to its child pointer
        once we reach end of string mark end of word to true.
        one important thing to note here is we are going to insert the words in REVERSE order
        since we have to search for most recent few/all characters.
  2. Search for a string in trie:
       here we are interested in the last (most recent) few/all characters from "query" function.
       so we will do the search from most recent character
       anywhere in the search if we come across wordEnd to be true, we will return true
       otherwise return false.
    
    so in our main function we will use these two above functions from trie to solve this problem
    
*/
public class StreamChecker {

    Trie t;
    StringBuilder searchedSofar;
    
    public StreamChecker(string[] words) {
        t = new Trie();
        foreach(string w in words)
        {
            char[] arr = w.ToCharArray();
            Array.Reverse(arr);
            t.AddString(new string(arr));
        }
        searchedSofar = new StringBuilder();
    }
    
    public bool Query(char letter) {
        searchedSofar.Append(letter);
        string str = searchedSofar.ToString();       
        return t.Search(str);        
    }
}
public class Trie
{
    Trie[] child;
    bool wordEnd;
    //public int maxDepth;
    public Trie()
    {
        child = new Trie[26];
        for(int i=0;i<26;i++)
        {
            child[i] =null;
        }
        wordEnd = false;
        //maxDepth = -1;
    }
    public void AddString(string s)
    {
        Trie temp = this;
        for(int i = 0;i<s.Length;i++)
        {
            int idx = GetIndexForLetter(s[i]);
            if(temp.child[idx]== null)
            {
                temp.child[idx] = new Trie();
            }
            temp = temp.child[idx];
        }
        temp.wordEnd = true;
        //maxDepth = Math.Max(s.Length,maxDepth);
    }
    public bool Search(string s)
    {
        Trie temp = this;
        for(int i = s.Length-1;i>=0;i--)
        {
            int idx = GetIndexForLetter(s[i]);
             if(temp.child[idx]== null)
                 return false;
            temp = temp.child[idx];
            if(temp.wordEnd)
                return true;
        }
        return temp.wordEnd;
    }
    private int GetIndexForLetter(char c)
    {
        return c-'a';
    }
}
