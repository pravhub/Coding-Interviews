class Solution:
    def convert(self, s: str, numRows: int) -> str:
        ans = []
        idx = 0
        for i in range(numRows):
            if idx < len(s):
                ans.append([s[idx]])
                idx += 1
            else:
                break
        while(idx < len(s)):
            for i in range(numRows-2, 0,-1):
                if idx < len(s):
                    ans[i].append(s[idx])
                    idx += 1
                else:
                    break
            for i in range(numRows):
                if idx < len(s):
                    ans[i].append(s[idx])
                    idx += 1
                else:
                    break
        # print(ans)
        return ''.join(''.join(a) for a in ans)
