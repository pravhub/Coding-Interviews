# Leetcode 2105. Watering Plants II
# https://leetcode.com/problems/watering-plants-ii/
class Solution:
    def minimumRefill(self, plants: List[int], capacityA: int, capacityB: int) -> int:
        refill = 0
        i = 0
        j = len(plants)-1
        alice = capacityA
        bob = capacityB
        while(i <= j):
            if(i == j):
                if(alice >= bob):
                    if(plants[i] > alice):
                        refill += 1
                        alice = capacityA
                    alice -= plants[i]
                else: #(alice < bob):
                    if(plants[j] > bob):
                        refill += 1
                        bob = capacityB
                    bob -= plants[j]
            else:                            
                if(plants[i] > alice):
                    refill += 1
                    alice = capacityA
                alice -= plants[i]
                if(plants[j] > bob):
                    refill += 1
                    bob = capacityB
                bob -= plants[j]
            i += 1
            j -= 1
        return refill
