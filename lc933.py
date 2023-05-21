from collections import deque
class RecentCounter:

    def __init__(self):
        self.d = deque()
        

    def ping(self, t: int) -> int:
        self.d.append(t)
        while len(self.d) > 0 and self.d[0] < t - 3000:
            self.d.popleft()
        return len(self.d)


# Your RecentCounter object will be instantiated and called as such:
# obj = RecentCounter()
# param_1 = obj.ping(t)
