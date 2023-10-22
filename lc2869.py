class Solution:
    def minOperations(self, nums: List[int], k: int) -> int:
        seen = set()
        operations = 0
        while len(seen)<k:            
            popped = nums.pop()
            operations += 1
            if popped <= k:
                seen.add(popped)
        return operations
