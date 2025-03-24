import random
class RandomizedSet:
   
    def __init__(self):
        self.s = {}
        self.lst = []


    def insert(self, val: int) -> bool:
        if val in self.s:
            return False
        else:
            self.lst.append(val)
            self.s[val] = len(self.lst) - 1            
            return True

    def remove(self, val: int) -> bool:
        # print('remove ', val, self.s)
        if val in self.s:
            rem_idx = self.s[val]
            del self.s[val]
            if rem_idx != len(self.lst) - 1:
                update_val = self.lst[len(self.lst) - 1]
                self.lst[rem_idx] = self.lst[len(self.lst) - 1]
                self.s[update_val] = rem_idx
            self.lst.pop()
            return True
        else:
            return False

    def getRandom(self) -> int:        
        rnd_idx = random.randint(0, len(self.lst) - 1)
        return self.lst[rnd_idx]
