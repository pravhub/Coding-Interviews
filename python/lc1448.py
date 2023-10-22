# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    good = 0
    def goodNodes(self, root: TreeNode) -> int:
        self.countGoodNodes(root, root.val)
        return self.good

    def countGoodNodes(self, root:TreeNode, sofarMax : int) -> None:
        if root:
            if root.val >= sofarMax:
                self.good += 1
            self.countGoodNodes(root.left, max(sofarMax, root.val))
            self.countGoodNodes(root.right, max(sofarMax, root.val))
        
