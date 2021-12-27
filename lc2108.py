# Leetcode 2108. Find First Palindromic String in the Array
# https://leetcode.com/problems/find-first-palindromic-string-in-the-array/
class Solution:
    # with our own palindrome function
    def firstPalindrome2(self, words: List[str]) -> str:
        def isPalindrom(word) -> bool:
            for i in range(len(word)//2):
                if word[i] != word[~i]:
                    return False
            return True
        for w in words:
            if (isPalindrom(w)):
                return w
        return ""
    
    # use builtin stuff
    def firstPalindrome(self, words: List[str]) -> str:
        for w in words:
            if w == w[::-1] :
                return w
        return ""
