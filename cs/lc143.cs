//time = O(n)
//space = O(n)

public class Solution {
    public void ReorderList(ListNode head) {
        Stack<ListNode> s = new Stack<ListNode>();
        ListNode slow = head;
        if(head!=null && head.next != null)
        {
            ListNode fast = head.next;
            while(fast!= null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode temp = slow;
            slow = slow.next;
            temp.next = null;
            while(slow!=null)
            {
                s.Push(slow);
                slow = slow.next;
            }
            //Console.WriteLine("stack filled slow="+temp.val);
            temp = head;
            ListNode nextNode = null;
            while(s.Count > 0 && temp != null)
            {
                //Console.WriteLine(s.Count);
                ListNode top = s.Pop();
                nextNode = temp.next;
                temp.next = top;
                top.next = nextNode;
                temp = nextNode;
            } //1->5->2
        }
    }
}
