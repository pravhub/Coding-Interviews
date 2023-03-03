# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def getIntersectionNode(self, headA: ListNode, headB: ListNode) -> Optional[ListNode]:
        m = 0
        n = 0
        tempA = headA
        tempB = headB
        while tempA:
            m += 1
            tempA = tempA.next
        while tempB:
            n += 1
            tempB = tempB.next
        tempA = headA
        tempB = headB
        if m < n:
            while m != n:
                n -= 1
                tempB = tempB.next
        if m > n:
            while m != n:
                m -= 1
                tempA = tempA.next
        while tempA and tempB:
            if tempA == tempB:
                return tempA
            else:
                tempA = tempA.next
                tempB = tempB.next
        
        return None
