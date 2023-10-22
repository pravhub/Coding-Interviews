# https://leetcode.com/problems/number-of-laser-beams-in-a-bank/
# Leetcode 2125. Number of Laser Beams in a Bank
class Solution:
    def numberOfBeams(self, bank: List[str]) -> int:
        prevCount = 0
        beams = 0
        for i in range(len(bank)):
            curCount = bank[i].count('1')
            #print(curCount)
            if(curCount != 0):
                beams += curCount * prevCount
                prevCount = curCount
        return beams
