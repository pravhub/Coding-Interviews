# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def hasPathSum(self, root: Optional[TreeNode], targetSum: int) -> bool:
        if not root:
            return False
        s = []
        s.append((root, 0))
        
        while len(s) > 0:
            cur = s.pop()
            cur_node = cur[0]
            cur_sum = cur[1]
            cur_sum += cur_node.val
            if cur_sum == targetSum and not cur_node.left and not cur_node.right:
                return True
            if cur_node.right:
                s.append((cur_node.right,cur_sum))
            if cur_node.left:
                s.append((cur_node.left,cur_sum))            
        return False
    def hasPathSumRecur(self, root: Optional[TreeNode], targetSum: int) -> bool:
        if root:
            return self.dfs(root, targetSum, 0)
        else:
            return False
    def dfs(self, root: Optional[TreeNode], targetSum: int, curSum: int) -> bool:
        if not root:
            return False
        if curSum + root.val == targetSum and not root.left and not root.right:
            return True
        return self.dfs(root.left, targetSum, curSum + root.val) or self.dfs(root.right, targetSum, curSum + root.val)
        
