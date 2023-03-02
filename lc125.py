class Solution:
    def isPalindrome(self, s: str) -> bool:
        s = ''.join(x for x in s if x.isalnum()).lower()
        return s[::-1] == s
    def isPalindrome_loop(self, s: str) -> bool:
        s = s.lower()
        start =0
        end = len(s)-1
        while start < end:
            if s[start].isalnum() and s[end].isalnum() and s[start] != s[end]:
                return False
            elif not s[start].isalnum():
                start+=1
            elif not s[end].isalnum():
                end -= 1
            else:
                start+= 1
                end -=1                
            
        return True
