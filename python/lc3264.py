#https://leetcode.com/problems/final-array-state-after-k-multiplication-operations-i/

import queue
class Solution:
    def getFinalState(self, nums: List[int], k: int, multiplier: int) -> List[int]:

        pq = queue.PriorityQueue()
        for idx, val in enumerate(nums):
            # print(idx,val)
            pq.put((val,idx))

        for i in range(k):
            t = pq.get()
            pq.put((t[0]*multiplier, t[1]))
        
        while not pq.empty():
            t = pq.get()
            nums[t[1]] = t[0]
        return nums
        
