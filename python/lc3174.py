class Solution:
    def clearDigits(self, s: str) -> str:
        digits = {'0','1','2','3','4','5','6','7','8','9'}
        ans = []
        for c in s:
            if c in digits:
                if len(ans)> 0:
                    ans.pop()
            else:
                ans.append(c)
        return ''.join(ans)
