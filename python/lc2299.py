class Solution:
    def strongPasswordCheckerII(self, password: str) -> bool:
        l = len(password)
        lowercase = False
        uppercase = False
        foundDigit = False
        foundSpecialChar = False
        repeat = False
        specialChars ="!@#$%^&*()-+"
        prev=''
        for x in password:
            foundDigit = foundDigit or x.isdigit()
            lowercase = lowercase or x.islower()
            uppercase = uppercase or x.isupper()
            foundSpecialChar = foundSpecialChar or (x in specialChars)
            repeat = repeat or (prev == x)
            prev = x
        return l>=8 and lowercase and uppercase and foundDigit and foundSpecialChar and not repeat
