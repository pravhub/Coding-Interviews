class Solution:
    def findMatrix(self, nums: List[int]) -> List[List[int]]:
        l = len(nums)
        counts = [0]*201
        for i in nums:
            counts[i] += 1
        
        ans = []
        while l > 0:
            cur = []
            for idx, val in enumerate(counts):
                if val > 0:
                    cur.append(idx)
                    counts[idx] -= 1
                    l -= 1
            ans.append(cur)
        return ans

    def findMatrix_lookups(self, nums: List[int]) -> List[List[int]]:
        ans = [[]]
        for i in nums:
            added = False
            for l in ans:
                if i not in l:
                    l.append(i)
                    added = True
                    break
            if not added:
                ans.append([i])

        return ans
