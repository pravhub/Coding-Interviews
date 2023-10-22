# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    ans = None
    def covers(self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> bool:
        output = [False, False]
        if self.ans:
            return output

        if root:              
            if root.val == p.val:
                output[0] = True
            elif root.val == q.val:
                output[1] = True
            left_output = self.covers(root.left,p,q)
            right_output = self.covers(root.right,p,q)
            output[0] = output[0] or left_output[0] or right_output[0]
            output[1] = output[1] or left_output[1] or right_output[1]
            if output[0] and output[1] and not self.ans:
                self.ans = root
        return output
    def lowestCommonAncestor(self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> 'TreeNode':
        self.covers(root, p, q)
        return self.ans
