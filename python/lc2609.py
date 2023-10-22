class Solution:
    def findTheLongestBalancedSubstring(self, s: str) -> int:
        idx = 0
        ones =0
        zeros = 0
        max_len =0
        prev = ''
        for i in s:
            if i == '0': 
                if prev == '1':                    
                    max_len = max(max_len, min(zeros, ones))
                    zeros = 0
                    ones = 0
                zeros += 1
            else:
                ones += 1
            prev = i
        max_len = max(max_len, min(zeros, ones))
        return max_len * 2
