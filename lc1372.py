# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
from collections import deque
class Solution:
    def longestZigZag(self, root: Optional[TreeNode]) -> int:
        q = deque()
        q.append((root,'T', 0, 0))

        longest = 0
        while q:
            next_q = deque()
            for r in range(len(q)):
                cur_node, path, cur_len, max_len = q.pop()

                if cur_node.left:
                    next_cur_len = cur_len
                    if path[-1] in ['T', 'R']:
                        next_cur_len += 1
                    else:
                        next_cur_len = 1
                    next_max_len = max(next_cur_len, max_len)
                    longest = max(longest, next_max_len)
                    next_q.append((cur_node.left, path+'L', next_cur_len, next_max_len))

                if cur_node.right:
                    next_cur_len = cur_len
                    if path[-1] in ['T', 'L']:
                        next_cur_len += 1
                    else:
                        next_cur_len = 1
                    next_max_len = max(next_cur_len, max_len)
                    longest = max(longest, next_max_len)
                    next_q.append((cur_node.right, path+'R', next_cur_len, next_max_len))

            q = next_q


        return longest
