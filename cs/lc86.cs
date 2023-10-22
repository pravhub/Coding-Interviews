
// time = O(N) N- lists length
//space = O(1)
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode temp = head;
        ListNode prev = null;
        ListNode tailListHead = null;
        ListNode tailListTail = null;
        
        while(temp!= null)
        {            
            if(temp.val < x)
            {
                if(prev == null)
                    head = temp;
                prev = temp;
                temp = temp.next;                
            }
            else
            {
                if(prev != null)
                    prev.next = temp.next;
                if(tailListHead == null)
                {
                    tailListHead = temp;
                    tailListTail = temp;
                    temp = temp.next;
                    tailListHead.next = null;
                    tailListTail.next = null;
                    
                }
                else
                {
                    tailListTail.next = temp;
                    tailListTail = tailListTail.next;
                    temp = temp.next;
                    tailListTail.next = null;                    
                }
            }
        }
        if(prev != null)
            prev.next = tailListHead;
        else
            head = tailListHead;
        return head;
    }
}
