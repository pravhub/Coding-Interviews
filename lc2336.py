class SmallestInfiniteSet:

    def __init__(self):
        self.nums = [x for x in range(1,1001)]
        self.added = set()
        for x in range(1,1001):
            self.added.add(x)
        heapq.heapify(self.nums)

    def popSmallest(self) -> int:        
        if len(self.nums) > 0:
            popped = heapq.heappop(self.nums)
            # print(popped)
            self.added.remove(popped)
            return popped
        else:
            return 0


    def addBack(self, num: int) -> None:
        if num not in self.added:
            heapq.heappush(self.nums, num)
            self.added.add(num)
        


# Your SmallestInfiniteSet object will be instantiated and called as such:
# obj = SmallestInfiniteSet()
# param_1 = obj.popSmallest()
# obj.addBack(num)
