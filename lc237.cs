public class Solution {
    public void DeleteNode(ListNode node) {
        ListNode temp = node.next.next;
        node.val = node.next.val;
        node.next = temp;
    }
}
