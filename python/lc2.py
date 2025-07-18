# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        ans = ListNode()
        ansEnd = ans
        carry = 0
        while l1 or l2:
            cur_sum = carry
            if l1:
                cur_sum += l1.val
            if l2:
                cur_sum += l2.val
            carry = cur_sum // 10
            cur_sum = cur_sum % 10
            
            n = ListNode(cur_sum)
            ansEnd.next = n
            ansEnd = ansEnd.next
            if l1:
                l1 = l1.next
            if l2:
                l2 = l2.next
    def addTwoNumbers_redundant_code(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        ans = ListNode()
        ansEnd = ans
        carry = 0
        while l1 and l2:
            cur_sum = l1.val + l2.val + carry
            carry = cur_sum // 10
            cur_sum = cur_sum % 10
            
            n = ListNode(cur_sum)
            ansEnd.next = n
            ansEnd = ansEnd.next
            l1 = l1.next
            l2 = l2.next
        while l1:
            cur_sum = l1.val + carry
            carry = cur_sum // 10
            cur_sum = cur_sum % 10

            n = ListNode(cur_sum)
            ansEnd.next = n
            ansEnd = ansEnd.next
            l1 = l1.next
        while l2:
            cur_sum = carry + l2.val
            carry = cur_sum // 10
            cur_sum = cur_sum % 10

            n = ListNode(cur_sum)
            ansEnd.next = n
            ansEnd = ansEnd.next
            l2 = l2.next
        if carry > 0:
            n = ListNode(carry)
            ansEnd.next = n
            ansEnd = ansEnd.next
        return ans.next



        
