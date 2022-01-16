# https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
# Leetcode 2130. Maximum Twin Sum of a Linked List
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
        slow = head
        fast = slow.next.next
        stack = []
        while(fast and fast.next):
            stack.append(slow.val)
            slow = slow.next
            fast = fast.next.next
        maxSum = 0
        stack.append(slow.val)
        slow = slow.next
        #print(stack, slow.val)
        while(slow):
            top = stack.pop()
            maxSum  = max(maxSum, top + slow.val)
            slow = slow.next
        return maxSum
            
        
