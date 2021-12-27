# https://leetcode.com/problems/watering-plants/
# Leetcode 2079. Watering Plants
class Solution:
    def wateringPlants(self, plants: List[int], capacity: int) -> int:
        ans = 0
        curCapacity = capacity
        for i,val in enumerate(plants):
            if(val <= curCapacity):
                curCapacity -= val
                ans += 1
            else:
                ans += 2*i + 1                
                curCapacity = capacity - val
        return ans;
