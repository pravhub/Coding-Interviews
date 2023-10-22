public class BrowserHistory {
    ListNode history;
    ListNode cur;
    public BrowserHistory(string homepage) {
        cur = null;
        history = new ListNode(homepage);        
        cur = history;
    }
    
    public void Visit(string url) {
        ListNode lln = new ListNode(url);
        cur.next = null;//clear forward history
        cur.next = lln;
        lln.prev= cur; //important
        cur = cur.next;
    }
    
    public string Back(int steps) {
        while(cur.prev!=null && steps>0)
        {
            cur = cur.prev;
            steps--;
        }
        return cur.str;
    }
    
    public string Forward(int steps) {
        while(cur.next!=null && steps>0)
        {
            cur = cur.next;
            steps--;
        }
        return cur.str;
    }
}
public class ListNode
{
    public string str;
    public ListNode prev;
    public ListNode next;
    public ListNode(string s)
    {
        str = s;
        prev = null;
        next = null;
    }
}
