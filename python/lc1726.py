class Solution:    
    def tupleSameProduct(self, nums: List[int]) -> int:
        counts = {}
        for i in range(len(nums)):
            for j in range(i+1, len(nums)):
                prod = nums[i] * nums[j]
                if prod in counts:
                    counts[prod] = counts[prod]+1
                else :
                    counts[prod] = 1
        ans = 0
        for x,y in counts.items():
            if y > 1:
                ans = ans +  ((y * (y-1))//2)*8
        return ans
                
                
