class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if len(s) <=1 :
            return len(s)
        seen = {}
        maxLen = 0
        start = 0
        end = 0
        for i,c in enumerate(s):
            if c in seen:                           
                maxLen = max(end-start+1, maxLen)
                prev = seen[c] + 1
                for j in range(start, seen[c]+1):
                    # print("deleting ", s[j])
                    del seen[s[j]]
                seen[c] = i                
                # print("seen contains",c, start, end, maxLen)                 
                start = prev
                end = i
            else:
                seen[c] = i
                end = i
        maxLen = max(end-start+1, maxLen)
        return maxLen
