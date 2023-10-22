class Solution:
    def generate_palindromic_num(self, n:int, b:int) -> bool:
        lst = []
        while n > 0:
            lst.append(n % b)
            n = n//b
        return lst == lst[::-1]
    
    def isStrictlyPalindromic(self, n: int) -> bool:
        for i in range(n-2, 1, -1 ):
            if(not self.generate_palindromic_num(n, i)):
                return False
        return True
