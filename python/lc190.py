class Solution:

    def reverseBits(self, n: int) -> int:
        bits = []
        ans = 0
        length = 0
        while n > 0:
            carry = n%2
            n = n // 2
            ans = ans * 2 + carry
            length +=1

        while length < 32:
            length += 1
            ans *= 2
        return ans
