# Leetcode 2124. Check if All A's Appears Before All B's
# https://leetcode.com/problems/check-if-all-as-appears-before-all-bs/
class Solution:
    def checkString(self, s: str) -> bool:
        return s.find('ba') < 0
    def checkString2(self, s: str) -> bool:
        bAppeared = False
        for c in s:
            if bAppeared and c == 'a':
                return False
            elif c == 'b':
                bAppeared = True
        return True
