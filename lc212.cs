public class Solution {
    Trie t = new Trie();
    int m = 0;
    int n = 0;
    HashSet<string> ans = new HashSet<string>();
    bool[][] visited;
    public IList<string> FindWords(char[][] board, string[] words) {        
        m = board.Length;
        n = board[0].Length;
        foreach(string s in words)
        {
            t.Insert(s);
            //Console.WriteLine($" {s}={t.Search(s)}");
        }    
       
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                ResetVisited();
                TraverseBoard(board, i, j, new StringBuilder());
            }
        } 
        return ans.ToList();
    }
    private void ResetVisited()
    {
        visited = new bool[m][];
        for(int i=0;i<m;i++)
        {
            visited[i] = new bool[n];
            for(int j=0;j<n;j++)
            {
                visited[i][j] = false;
            }
        }
    }
    private void TraverseBoard(char[][] board,int i, int j, StringBuilder sb)
    {
        if(i>=0 && j>=0 && i<m&&j<n && !visited[i][j])
        {
            visited[i][j] = true;
            sb.Append(board[i][j]);
            if(t.PrefixExists(sb.ToString()))
            {
                if(t.Search(sb.ToString()))
                    ans.Add(sb.ToString());            
                int len = sb.Length;
                TraverseBoard(board, i+1, j, sb); //down
                if(sb.Length>len)
                {
                    visited[i+1][j] = false;
                    sb.Length--;
                }
                TraverseBoard(board, i-1, j, sb);//up
                if(sb.Length>len)
                {
                    visited[i-1][j] = false;
                    sb.Length--;
                }
                TraverseBoard(board, i, j+1, sb);//right
                if(sb.Length>len)
                {
                    visited[i][j+1] = false;
                    sb.Length--;
                }
                TraverseBoard(board, i, j-1, sb);//left
                if(sb.Length>len)
                {
                    visited[i][j-1] = false;
                    sb.Length--;
                }  
            }
            if(sb.Length>0)
            {
                visited[i][j] = false;
                sb.Length--;
            }
        }
    }
}
public class Trie
{
    private Trie[] child;
    private bool wordEnd;
    public Trie()
    {
        child = new Trie[26];
        for(int i=0;i<26;i++)
        {
            child[i] = null;
        }
        wordEnd = false;
    }
    public void Insert(string word)
    {
        Trie temp = this;
        foreach(char c in word)
        {
            if(temp.child[c-'a']==null)
            {
                temp.child[c-'a'] = new Trie();
            }
            temp= temp.child[c-'a'];
        }
        temp.wordEnd = true;
    }
    public bool Search(string word)
    {        
        Trie temp = this;
        foreach(char c in word)
        {
            if(temp.child[c-'a']==null)
            {
                return false;
            }
            temp= temp.child[c-'a'];
        }
        return temp.wordEnd;
    }
    public bool PrefixExists(string prefix)
    {//op
        Trie temp = this;
        foreach(char c in prefix)
        {
            if(temp.child[c-'a']==null)
            {
                return false;
            }
            temp= temp.child[c-'a'];
        }
        return true;
    }
}
