# Leetcode 2095. Delete the Middle Node of a Linked List
# https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/
class Solution:
    def deleteMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:
        dummy = ListNode()
        dummy.next = head
        slow = dummy;
        fast = slow.next
        while( fast != None and fast.next != None ):
            slow = slow.next;
            fast = fast.next.next
        
        slow.next = slow.next.next
        return dummy.next
