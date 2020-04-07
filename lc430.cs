public class Solution {
    public Node Flatten(Node head) {
        Node temp = head;
        if(temp == null)
            return head;
        //Console.WriteLine(temp.val);
        while(temp != null) 
        {
            if(temp.child != null)
            {
                Node lowerTail = FlattenInner(temp.child);
                Node tempNext = temp.next;
                temp.next = temp.child;
                temp.child.prev = temp;
                if(tempNext != null)
                {
                    lowerTail.next = tempNext;
                    tempNext.prev = lowerTail;
                }
                temp.child = null;
                temp = temp.next;
            }
            else
            {
                temp = temp.next;
            }
        }
        //temp = head;
        /* while(temp != null)
        {
            Console.WriteLine("{0},{1},{2},{3}",temp.val,temp.child==null,temp.next==null,temp.prev==null);
            temp = temp.next;
        } */
        return head;
    }
    private Node FlattenInner(Node head) {
        Node temp = head;
        while(temp.next != null)
        {
            temp = temp.next;
        }
        return temp; //last node in the second level linked list
        
    }
}
