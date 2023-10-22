class Solution:
    def maximumOddBinaryNumber(self, s: str) -> str:
        zeros = ""
        ones = ""
        last_digit_1 = False
        for c in s:
            if c=='0':
                zeros = '0' + zeros
            elif c == '1':
                if not last_digit_1:
                    zeros = zeros + '1'
                    last_digit_1 = True
                else:
                    ones = '1'+ones
        return ones + zeros
