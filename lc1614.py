# https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/
# Leetcode  1614. Maximum Nesting Depth of the Parentheses
class Solution:
     def maxDepth(self, s: str) -> int:
        cur = 0
        ans = 0
        for i, val in enumerate(s):
            if(s[i] == ')'):
                ans = max(ans, cur)
                cur -= 1
            elif(s[i] =='('):                    
                cur += 1
        return ans
                
    def maxDepth2(self, s: str) -> int:
        st = []
        ans = 0
        for i, val in enumerate(s):
            if(s[i] =='(' or s[i] == ')'):
                if(s[i] == ')'):
                    ans = max(ans, len(st))
                    st.pop()
                else:
                    st.append(s[i])
        return ans
