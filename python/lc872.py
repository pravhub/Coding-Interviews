# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:    
    def leafSimilar(self, root1: Optional[TreeNode], root2: Optional[TreeNode]) -> bool:
        def bfs(root) -> List[int]:
            output = []
            q = deque()
            q.append(root)
            while q:
                cur = q.pop()
                if not cur.left and not cur.right:
                    output.append(cur.val)
                if cur.left:
                    q.append(cur.left)
                if cur.right:
                    q.append(cur.right)
            return output
        
        l1 = bfs(root1)
        l2 = bfs(root2)
        print(l1)
        print(l2)
        if len(l1) != len(l2):
            return False
        return all(l1[i] == l2[i] for i in range(len(l1)))

