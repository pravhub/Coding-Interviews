class Solution:
    def swapNodes(self, head: ListNode, k: int) -> ListNode:
        temp = k
        tempHead = head
        prev  = tempHead        
        while temp > 0:
            prev = tempHead
            tempHead = tempHead.next
            temp = temp-1
        begin = prev        
        prev = head
        kthNodeFromBack = prev
        while tempHead:
            kthNodeFromBack = kthNodeFromBack.next
            tempHead = tempHead.next
        end  = kthNodeFromBack
        val = begin.val
        begin.val = end.val
        end.val = val
        return head

    def swapNodes2Pass(self, head: ListNode, k: int) -> ListNode:
        temp = k
        tempHead = head
        prev  = tempHead
        while temp > 0:
            prev = tempHead
            tempHead = tempHead.next
            temp = temp-1
        begin = prev
        count = k
        prev = head
        while tempHead:            
            tempHead = tempHead.next
            count = count+1
        tempHead = head;
        count = count - k+1
        while count > 0:
            prev = tempHead
            tempHead = tempHead.next
            count = count -1
        end  = prev
        val = begin.val
        begin.val = end.val
        end.val = val
        return head
        
            
