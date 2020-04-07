/*
we are given with a pattern and set of string to match CAMEL case.
even though its a camel case there are some interesting things that we need to consider.
like following (from description: We may insert each character at any position):
["CompetitiveProgramming","CounterPick","ControlPanel"]
"CooP"
[false,false,true]

the logic we are going to follow is:
we will have an index to track the pattern (idx) and an index to track the query string (qidx).
1. if the character in query id uppercase
     - if the characters in pattern and query string match then increment idx, qidx
     - otherwise return false;
2. if the character in pattern is lowercase and character from query string is also lowercase
     - if it matches with the querystring then increment idx, qidx
     - otherwise increment ONLY qidx
3. if the character in pattern is uppercase and character in the querystring is lowercase
     - increment qidx for next comparison.

Repeat 1,2,3 until either pattern or query string exhausts.
if the pattern is not exhausted then obviously the query string does not follow the pattern so return false;
if the querystring is not exhausted then check whether remaining characters are lower case otherwise return false;

finally if all the checks pass then return true;

complexity:
lets say lenght of pattern = p
lets say average length of string is m
so timecomplexity for IsMatch(..) function is O(pm)
space complexity: O(1)
overall time = n *O(pm)
overall space = O(n)  -- boolean array that we are returning.

USING TRIE
 trie node need to hold a-z and A-Z so we will have 26+26 placeholders in child array.
 helper method to get the character for a given index : GetLetterForIndex
 helper method to get the index for a given character : GetIndexForLetter
 AddString(..) adds the strings to trie node use GetIndexForLetter
 SearchPattern(..) searches words for a given pattern and returns the words satisfying the pattern.
 based on the words found, return true or false for each word.
 
 space: each trie node has two placeholders {pointer to child nodes, word end}
 we need to create Trie of depth = longest word in the queries
 so if you say there are n words and there are 52 references. total space complexity for AVG case=O(52n)
 time: worst case with n words = O(52n).
 for a densly populated trie the space complexity will be obviously more which could go upto O(52^l)
 where l is the average length of the word.
*/
public class Solution {
        public IList<bool> CamelMatch(string[] queries, string pattern) {
        bool[] ans = new bool[queries.Length];
        for(int i=0;i<queries.Length;i++)
        {
            ans[i] = IsMatch(queries[i],pattern);
        }
    }
    public IList<bool> CamelMatchTRIE(string[] queries, string pattern) {
        TrieNode tn = new TrieNode();
        bool[] ans = new bool[queries.Length];
        for(int i=0;i<queries.Length;i++)
        {
           tn.AddString(queries[i]);
        }
        HashSet<string> found = tn.SearchForPattern(pattern);
        for(int i=0;i<queries.Length;i++)
        {
            ans[i] = found.Contains(queries[i]);
        }
        /*
        bool[] ans = new bool[queries.Length];
        for(int i=0;i<queries.Length;i++)
        {
            ans[i] = IsMatch(queries[i],pattern);
        }*/
        return ans.ToList(); 
    }
    private bool IsMatch(string query, string pattern)
    {
        int idx =0;
        int qidx = 0;
        while(qidx<query.Length && idx < pattern.Length)
        {
            char c = query[qidx];
            if(char.IsUpper(c))
            {
                if(pattern[idx] != c)
                {
                    return false;
                }
                else
                {
                    qidx++;
                    idx++;
                }
            }
            else if(char.IsLower(c) && char.IsLower(pattern[idx]))
            {
                if(pattern[idx] != c)
                {                 
                    qidx++;
                   //return false;                    
                }
                else
                {
                    qidx++;
                    idx++;
                }
            }
            else if(char.IsLower(c) && !char.IsLower(pattern[idx]))
            {
                qidx++;                
            }            
        }
        if(idx < pattern.Length)
            return false;
        while(qidx<query.Length)
        {
            if(char.IsUpper(query[qidx++]))
            {
                return false;
            }
        }
        return true;
    }
}
public class TrieNode
{
    TrieNode[] child;
    bool wordEnd = false;
    public TrieNode()
    {
        //0-25 lower case letters
        //25-51 uppper case letters
        child = new TrieNode[52]; 
        for(int i=0;i<52;i++)
        {
            child[i] = null;
        }
    }
    public void AddString(string s)
    {
        TrieNode temp = this;
        for(int i=0; i<s.Length; i++)
        {
            int idx = GetIndexForLetter(s[i]);
            if(temp.child[idx]==null)
            {
                temp.child[idx] = new TrieNode();                
            }
            temp = temp.child[idx];
        }
        temp.wordEnd = true;
    }    
    public HashSet<string> SearchForPattern(string pattern)
    {
        HashSet<string> found = new HashSet<string>();
        camelMatch(pattern,found,this,0,"");
        return found;
    }
    private void camelMatch(string pattern,HashSet<string> found, TrieNode root,int idx, string wordSofar)
    {
        if(root == null)
            return;
        if(idx>=pattern.Length)
        {
            if(root.wordEnd)
            {
                found.Add(wordSofar);
            }
            else
            {
                for(int i=0;i<26;i++)
                {
                    if(root.child[i]!=null)
                    {
                        camelMatch(pattern,found,root.child[i],idx,wordSofar+GetLetterForIndex(i));
                    }
                }
            }

        }
        else
        {
            for(int i=0;i<52;i++)
            {
                if(pattern[idx]== GetLetterForIndex(i))
                {
                    camelMatch(pattern,found,root.child[i],idx+1,wordSofar+GetLetterForIndex(i));
                }
                else if(i<26)
                {
                    camelMatch(pattern,found,root.child[i],idx,wordSofar+GetLetterForIndex(i));
                }
            }
        }
    }
    private char GetLetterForIndex(int i)
    {
        if(i>=26)
        {
            return (char)(65 + i-26);
        }
        else
        {
            return (char)(97 + i);
        }
    }
    private int GetIndexForLetter(char c)
    {
        if(char.IsUpper(c))
        {
            return 26+(c-'A');
        }
        else
        {
            return c-'a';
        }
    }
}
