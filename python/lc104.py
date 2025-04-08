# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def maxDepthRecursion(self, root: Optional[TreeNode]) -> int:
        return 1 + max(self.maxDepth(root.left), self.maxDepth(root.right)) if root else 0
    def maxDepth(self, root: Optional[TreeNode]) -> int:
        if not root:
            return 0
        nodes = [root]
        depth = 0
        while len(nodes) > 0:
            nextLevel = []
            while len(nodes) > 0:
                n = nodes.pop()
                if n.left:
                    nextLevel.append(n.left)
                if n.right:
                    nextLevel.append(n.right)
            nodes = nextLevel
            depth += 1
        return depth
