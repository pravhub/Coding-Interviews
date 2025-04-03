# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def oddEvenList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head:
            oddStart = head
            oddEnd = head
            head = head.next
            oddEnd.next = None
            if head:        
                evenStart = head
                evenEnd = head        
                head = head.next
                evenEnd.next = None
            else:
                return oddStart
        else:
            return head
        odd = True
        while head:
            if odd:
                oddEnd.next = head
                oddEnd = oddEnd.next
                head = head.next
                oddEnd.next = None
                odd = False
            else:
                evenEnd.next = head
                evenEnd = evenEnd.next
                head = head.next
                evenEnd.next = None
                odd = True
            
        oddEnd.next = evenStart
        return oddStart



