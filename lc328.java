class Solution {
    public ListNode oddEvenList(ListNode head) {
   
        if(head==null || head.next==null || head.next.next==null)
            return head;
        ListNode temp = head;
        ListNode oddStart = null;
        ListNode oddEnd = null;
        ListNode evenStart = null;
        ListNode evenEnd = null;
        int id = 1;
        while(temp!=null)
        {
            if(id%2==1) //odd
            {
                if(oddStart==null)
                {
                    oddStart = temp;
                    oddEnd = temp;
                }
                else
                {
                    oddEnd.next = temp;
                    oddEnd = oddEnd.next;
                }   
                temp = temp.next;                        
                oddEnd.next = null;
            }
            else
            {
                if(evenStart==null)
                {
                    evenStart = temp;
                    evenEnd = temp;
                }
                else
                {
                    evenEnd.next = temp;
                    evenEnd = evenEnd.next;
                }          
                temp = temp.next;    
                evenEnd.next = null;
            }
            id++;
        }
        oddEnd.next = evenStart;
        return oddStart;
    }
}
