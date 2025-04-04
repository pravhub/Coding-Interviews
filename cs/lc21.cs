/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1==null)
            return list2;
        if(list2==null)
            return list1;
        ListNode headStart = null;
        ListNode headEnd = null; 
        if(list1.val <= list2.val)
        {
            headStart = list1;
            headEnd = headStart;
            list1 = list1.next;
            headEnd.next = null;
        }
        else
        {
            headStart = list2;
            headEnd = headStart;
            list2 = list2.next;
            headEnd.next = null;
        }
        while(list1!=null &&list2 !=null)
        {
            if (list1.val <= list2.val)
            {
                headEnd.next = list1;
                list1 = list1.next;
                headEnd = headEnd.next;
                headEnd.next = null;
            }
            else
            {
                headEnd.next = list2;
                list2 = list2.next;
                headEnd = headEnd.next;
                headEnd.next = null;
            }   

        }
        if (list1 !=null)
            headEnd.next = list1;
        if (list2 !=null)
            headEnd.next = list2;
        return headStart;
    }
}
