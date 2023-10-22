#Leetcode 2046. Sort Linked List Already Sorted Using Absolute Values
#https://leetcode.com/problems/sort-linked-list-already-sorted-using-absolute-values/
class Solution:
    def sortLinkedList(self, head: Optional[ListNode]) -> Optional[ListNode]:        
        prev = None
        temp = head
        newTail = None
        newHead = None
        # if the list starts with -ve values, we should process them first.
        while temp != None and temp.val < 0:
            prev = temp
            temp = temp.next
            prev.next = None
            if(newTail == None):
                newTail = prev
            if(newHead == None):
                newHead = prev
            else:
                prev.next = newHead
                newHead = prev
        # if there were -ve values at the start of list, newHead would not be None.
        if (newHead != None):
            head = newHead
            newTail.next = temp
            
        prev = None
        while temp:
            if(temp.val < 0):
                prev.next = temp.next
                temp.next = head
                head = temp
                temp = prev.next
            else:
                prev = temp
                temp = temp.next
        return head
