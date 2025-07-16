class Solution:
    def maxArea(self, height: List[int]) -> int:
        start, end = 0, len(height)-1
        maxWater = 0
        while(start < end):
            curWater = min(height[start], height[end]) * (end-start)
            maxWater = max(curWater, maxWater)
            if height[start] <= height[end]:
                start += 1
            else:
                end -=1
        return maxWater
