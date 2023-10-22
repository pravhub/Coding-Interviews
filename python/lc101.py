# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isSymmetric(self, root: Optional[TreeNode]) -> bool:
        if not root:
            return True
        st = []
        st.append(root)
        while len(st) != 0:
            next_st = []
            for cur in st:
                if cur:
                    next_st.append(cur.left)
                    next_st.append(cur.right)
            st = next_st
            start = 0
            end = len(next_st) -1
            while start < end:
                if next_st[start] and next_st[end] and next_st[start].val != next_st[end].val:
                    return False
                elif (next_st[start] and not next_st[end]) or (not next_st[start] and next_st[end]):
                    return False
                start +=1
                end -= 1
        return True
