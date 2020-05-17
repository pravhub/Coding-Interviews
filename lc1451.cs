public class Solution {
    public string ArrangeWords(string text) {
       string[] strs = text.ToLower().Split(" ");
        int pos = 0;
        List<Node> words = new List<Node>();
        foreach(string s in strs)
        {
            words.Add(new Node(s,pos));
            pos++;
        }
        words.Sort(new ArrangeCompare());
        string finalString =  string.Join(" ", words.Select(w=>w.s));
        char c = finalString[0];
        return Char.ToUpper(c).ToString() + finalString.Substring(1);
    }
}
public class ArrangeCompare: IComparer<Node>
{   
   public int Compare(Node a, Node b)
   {
      int aLen = a.s.Length;
      int bLen = b.s.Length;
      if(aLen==bLen)
      {
        return a.pos.CompareTo(b.pos);
      }
      else
      {
        return aLen.CompareTo(bLen);
      }
   }
}
public class Node
{
    public string s;//word
    public int pos;
    public Node(string st, int p)
    {
        s = st;
        pos = p;
    }
}
