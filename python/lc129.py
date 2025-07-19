# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def sumNumbers(self, root: Optional[TreeNode]) -> int:
        s = []
        s.append((root, 0))
        total = 0
        while len(s) > 0:
            cur = s.pop()
            cur_node = cur[0]
            cur_sum = cur[1]
            cur_sum = 10*cur_sum + cur_node.val
            if not cur_node.left and not cur_node.right:
                total += cur_sum
            if cur_node.right:
                s.append((cur_node.right,cur_sum))
            if cur_node.left:
                s.append((cur_node.left,cur_sum))            
        return total
