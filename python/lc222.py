# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def countNodes(self, root: Optional[TreeNode]) -> int:
        if not root:
            return 0
        s  = []
        s.append((root,0))
        max_depth = 0
        max_depth_count = 0
        while len(s) > 0:
            cur = s.pop()
            curNode = cur[0]
            curDepth = cur[1] 
            if not curNode.left and not curNode.right:                
                if curDepth < max_depth:
                    break
                elif curDepth > max_depth:
                    max_depth = curDepth
                    max_depth_count = 1
                else:
                    max_depth_count +=1 
                # print(curNode.val, "depth", curDepth, max_depth_count)
            if curNode.right:
                # print(curNode.val, "right", curDepth)
                s.append((curNode.right,curDepth+1))
            if curNode.left:
                s.append((curNode.left, curDepth+1))
        # print("final ", max_depth, max_depth_count)
        return pow(2, max_depth) - 1 + max_depth_count
            
