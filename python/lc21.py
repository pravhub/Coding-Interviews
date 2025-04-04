# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if not list1:
            return list2
        if not list2:
            return list1
        headStart = None
        headEnd = None 
        if list1.val <= list2.val:
            headStart = list1
            headEnd = headStart
            list1 = list1.next
            headEnd.next = None
        else:       
            headStart = list2
            headEnd = headStart
            list2 = list2.next
            headEnd.next = None
        while list1 and list2:
            if list1.val <= list2.val:
                headEnd.next = list1
                list1 = list1.next
                headEnd = headEnd.next
                headEnd.next = None
            else:
                headEnd.next = list2
                list2 = list2.next
                headEnd = headEnd.next
                headEnd.next = None

        if list1:
            headEnd.next = list1
        if list2:
            headEnd.next = list2
        return headStart
