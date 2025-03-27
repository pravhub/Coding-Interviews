class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        ans = []
        for i in range(len(strs[0])):
            cur = strs[0][i]
            end = False
            for s in strs[1:]:
                if i >= len(s) or cur != s[i]:
                    end = True
                    break
            if end:
                break
            else:
                ans.append(cur)            

        return ''.join(ans)
