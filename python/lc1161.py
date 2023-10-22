# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def maxLevelSum(self, root: Optional[TreeNode]) -> int:
        q = deque()
        q.append(root)
        cur_level, cur_sum = 1, float(-inf)
        max_level, max_sum = 1, float(-inf)
        while q:
            next_q = deque()
            cur_sum = 0
            for i in range(len(q)):
                cur_node = q.pop()
                cur_sum += cur_node.val
                if cur_node.left:
                    next_q.append(cur_node.left)
                if cur_node.right:
                    next_q.append(cur_node.right)
            if cur_sum > max_sum:
                max_sum = cur_sum
                max_level = cur_level
            cur_level += 1
            q = next_q


        return max_level
