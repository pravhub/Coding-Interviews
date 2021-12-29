# Leetcode 2109. Adding Spaces to a String
# https://leetcode.com/problems/adding-spaces-to-a-string/
class Solution:
    def addSpaces(self, s: str, spaces: List[int]) -> str:
        ans = []
        idx = 0
        for i, c in enumerate(s):
            if(idx < len(spaces) and i == spaces[idx]):
                ans.append(" ")
                idx += 1
            ans.append(c)
        return "".join(ans)
      
    def addSpaces2(self, s: str, spaces: List[int]) -> str:
        ans = ""
        idx = 0
        for i, c in enumerate(s):
            if(idx < len(spaces) and i == spaces[idx]):
                ans += " "                
                idx += 1
            ans += c
        return ans
