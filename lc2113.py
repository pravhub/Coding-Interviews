class Solution:
    def elementInNums(self, nums: List[int], queries: List[List[int]]) -> List[int]:
        n = len(nums)
        ans = []
        for time,idx in queries:
            time = time % (2*n) if time >= (2*n) else time
            if time == n:
                ans.append(-1)
            elif time < n:
                if(time + idx < n):
                    ans.append(nums[time+idx])
                else:
                    ans.append(-1)
            else:
                time = time - n
                if(idx < time):
                    ans.append(nums[idx])
                else:
                    ans.append(-1)
        return ans
