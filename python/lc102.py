# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        ans = []
        if not root:
            return ans
        d = deque()
        d.append(root)
        while len(d) > 0:
            cur_list = []
            for i in range(len(d)):
                cur_node = d.popleft()
                cur_list.append(cur_node.val)
                if cur_node.left:
                    d.append(cur_node.left)
                if cur_node.right:
                    d.append(cur_node.right)
            ans.append(cur_list)
        return ans

