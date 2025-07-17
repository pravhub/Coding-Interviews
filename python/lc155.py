class MinStack:
    stak, mstak = [],[]
    def __init__(self):
        self.stak = []
        self.mstak = []        

    def push(self, val: int) -> None:
        self.stak.append(val)
        temp = []
        topidx = len(self.mstak)-1
        while len(self.mstak) > 0 and self.mstak[topidx] < val:
            temp.append(self.mstak.pop())
            topidx -= 1
        self.mstak.append(val)
        while len(temp) > 0:
            self.mstak.append(temp.pop())
        # print('push')
        # print(self.stak)
        # print(self.mstak)
        
    def pop(self) -> None:
        temp = []
        popped = self.stak.pop()
        topidx = len(self.mstak)-1
        while len(self.mstak) > 0 and self.mstak[topidx] != popped:
            temp.append(self.mstak.pop())
            topidx -= 1
        if len(self.mstak) >0:
            self.mstak.pop()
        while len(temp) > 0:
            self.mstak.append(temp.pop())
        # print('pop')
        # print(self.stak)
        # print(self.mstak)

    def top(self) -> int:
        return self.stak[(len(self.stak) - 1)]


    def getMin(self) -> int:
        if len(self.mstak) > 0:
            return self.mstak[len(self.mstak) - 1]
        else:
            return None
        


# Your MinStack object will be instantiated and called as such:
# obj = MinStack()
# obj.push(val)
# obj.pop()
# param_3 = obj.top()
# param_4 = obj.getMin()
