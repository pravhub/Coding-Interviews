class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        intervals.sort()
        ans = []
        # print(intervals)
        start,end = intervals[0][0], intervals[0][1]
        for i in range(1, len(intervals)):
            cur_start = intervals[i][0]
            cur_end = intervals[i][1]
            if end < cur_start:
                ans.append([start,end])
                start = cur_start
                end = max(end, cur_end)
            else:
                end = max(end, cur_end)
        ans.append([start,end])
        return ans
