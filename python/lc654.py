# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
#
# Leetcode 654. Maximum Binary Tree
# https://leetcode.com/problems/maximum-binary-tree/

class Solution: 
    def constructMaximumBinaryTree(self, nums: List[int]) -> Optional[TreeNode]:
        d = {}
        for i,val in enumerate(nums):
            d[val] = i
        return self.constructTree(nums, 0, len(nums),d)
    def constructTree(self, nums: List[int], start: int, end:int, d:{}) -> Optional[TreeNode]:
        if(start >= end):
            return None
        #print(start, end)
        maxVal = max(nums[start:end])
        node = TreeNode(maxVal)
        node.left = self.constructTree(nums,start, d[maxVal], d)
        node.right = self.constructTree(nums,d[maxVal]+1, end, d)
        return node
