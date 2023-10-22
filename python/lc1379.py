from queue import Queue
class Solution:
    def getTargetCopy(self, original: TreeNode, cloned: TreeNode, target: TreeNode) -> TreeNode:
        q = Queue()
        q.put((original, cloned))
        while q:
            #cur = q.get()
            orig, cln = q.get()
            #orig = getitem(cur,0)
            #cln = getitem(cur, 1)
            if  orig == target:
                return cln
            if orig.left != None:
                q.put((orig.left,cln.left))
            if orig.right != None:
                q.put((orig.right,cln.right))
        return None  
