"""
# Definition for a Node.
class Node:
    def __init__(self, val = 0, neighbors = None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []
"""

from typing import Optional
class Solution:
    m = {}
    def cloneGraph(self, node: Optional['Node']) -> Optional['Node']:
        if not node:
            return node
        n = Node()
        # print('processing ', node.val)
        n.val = node.val
        n.neighbors = []
        self.m[node] = n
        for nei in node.neighbors:
            if nei in self.m:
                n.neighbors.append(self.m[nei])
            else:    
                n_nei = self.cloneGraph(nei)
                n.neighbors.append(n_nei)
                self.m[nei] = n_nei
        return n
