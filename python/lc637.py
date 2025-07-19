# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def averageOfLevels(self, root: Optional[TreeNode]) -> List[float]:
        d = deque()
        d.append(root)
        ans = []
        while len(d) > 0:
            d2 = deque()
            count,cur_sum = 0,0
            for i in range(len(d)):
                n = d.popleft()
                count += 1
                cur_sum += n.val
                if n.left:
                    d2.append(n.left)
                if n.right:
                    d2.append(n.right)
            ans.append(cur_sum / count)
            d = d2
        return ans

