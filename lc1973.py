#leetcode 1973
#https://leetcode.com/problems/count-nodes-equal-to-sum-of-descendants/
# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    ans = 0
    def recur(self, root: Optional[TreeNode]) -> int:
        if root == None:
            return 0
        leftSum = self.recur(root.left)
        rightSum = self.recur(root.right)
        if root.val == leftSum + rightSum:
            self.ans += 1
        #print("at ",root.val, leftSum + rightSum)
        return root.val + leftSum + rightSum
    
    def equalToDescendants(self, root: Optional[TreeNode]) -> int:
        self.recur(root)
        return self.ans
