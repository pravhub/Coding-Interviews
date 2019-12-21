/*
https://leetcode.com/problems/add-and-search-word-data-structure-design/
*/

public class WordDictionary {

    bool wordEnd =false;
    WordDictionary[] children;
    int r = 26;
    /** Initialize your data structure here. */
    public WordDictionary() {
     children = new WordDictionary[r];
        for(int i=0;i<r;i++)
        {
            children[i]= null;
        }
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        WordDictionary temp=this;
        for(int i=0;i<word.Length;i++)
        {
            char curChar = word[i];

                
                if(temp.children[curChar-'a'] != null)
                {
                    //Console.WriteLine("ADD--{0}-{1}",curChar,curChar-'a');
                    temp = temp.children[curChar-'a'];
                    //Console.WriteLine(" temp {0}",temp == null);
                }
                else
                {
                    //Console.WriteLine("ADD-null-{0}-{1}",curChar,curChar-'a');
                    temp.children[curChar-'a'] = new WordDictionary();
                    temp = temp.children[curChar-'a'];
                    //Console.WriteLine(" temp-null {0}",temp == null);
                }
          
        }
        temp.wordEnd = true;
        //Console.WriteLine("temp.wordEnd set {0}",temp.wordEnd);
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        WordDictionary temp=this;
        for(int i=0;i<word.Length;i++)
        {
            char curChar = word[i];
            //Console.WriteLine("Cur -{0}",curChar);
            if(curChar =='.')
            {
                    List<WordDictionary> toBeProcessed = new List<WordDictionary>();
                    for(int j=0;j<r;j++)
                    {
                        if(temp.children[j] != null)
                        {
                            toBeProcessed.Add(temp.children[j]);
                        }
                    }
                 //Console.WriteLine("toBeProcessed.Count{0}",toBeProcessed.Count);
                    if(toBeProcessed.Count==0)
                        return false;
                    else
                    {
                        foreach(var ch in toBeProcessed)
                        {
                            if((word.Length <2 && ch.wordEnd ==true)|| (word.Length>=2 && ch.Search(word.Substring(i+1))))
                               return true;
                        }
                        return false;
                    }                
            }
            else
            {
                    if(temp.children[curChar-'a'] != null)
                    {
                        temp = temp.children[curChar-'a'];
                    }
                    else
                    {
                        return false;
                    }
                
            }
        }
        //Console.WriteLine("{0} --{1}",temp!=null,string.Join("|",(object[])temp.children));
        return temp!=null && temp.wordEnd ==true;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
