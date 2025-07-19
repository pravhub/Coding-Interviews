# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        if not root:
            return []
        d = deque()
        d.append(root)
        ans = []
        cur_level =0
        while len(d) > 0:
            for i in range(len(d)):
                n = d.popleft()
                if cur_level == len(ans):
                    ans.append(n.val)
                else:
                    ans[-1] = n.val
                if n.left:
                    d.append(n.left)
                if n.right:
                    d.append(n.right)
            cur_level += 1
        return ans
    
