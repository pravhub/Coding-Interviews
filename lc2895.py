class Solution:
    def minProcessingTime(self, processorTime: List[int], tasks: List[int]) -> int:
        processorTime.sort()
        tasks.sort()
        n = len(processorTime)
        m = n * 4
        cur_max = 0
        j = 0
        for i in range(m-4, -1, -4):
            cur_max = max(cur_max, processorTime[j] + tasks[i], processorTime[j] + tasks[i+1], processorTime[j] + tasks[i+2],processorTime[j] + tasks[i+3])
            j += 1
        return cur_max
