class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        min_k = 1
        max_k =max(piles)

        while min_k < max_k:
            k = (min_k + max_k) // 2
            temp_h = 0
            for i in piles:
                temp_h += math.ceil(i / k)
            if temp_h > h:
                min_k = k+1
            else:
                max_k = k
        return min_k


                



    
