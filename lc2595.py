class Solution:
    def evenOddBit(self, n: int) -> List[int]:
        even = 0
        odd = 0
        idx = 0
        while n > 0:
            rem = n % 2
            if rem == 1:
                if idx %2 == 0:
                    even += 1
                else:
                    odd +=1
            n = n//2
            idx += 1
        return [even, odd]
