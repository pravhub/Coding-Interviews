import heapq

class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:
        # heapq.heapify(nums)
        lst = heapq.nlargest(k, nums)
        return lst[-1]
