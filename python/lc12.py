class Solution:
    def intToRoman(self, num: int) -> str:
        roman = {1:'I',4:'IV', 5:'V', 9:'IX', 10:'X',40:'XL',50:'L', 90:'XC',100:'C',400:'CD', 500: 'D', 900:'CM', 1000:'M'}
        ans = []
        while num > 0:
            if num >= 1000:
                num -= 1000
                ans.append(roman[1000])
            elif num >= 900:
                num -= 900
                ans.append(roman[900])
            elif num >= 500:
                num -= 500
                ans.append(roman[500])
            elif num >= 400:
                num -= 400
                ans.append(roman[400])
            elif num >= 100:
                num -= 100
                ans.append(roman[100])
            elif num >= 90:
                num -= 90
                ans.append(roman[90])
            elif num >= 50:
                num -= 50
                ans.append(roman[50])
            elif num >= 40:
                num -= 40
                ans.append(roman[40])
            elif num >= 10:
                num -= 10
                ans.append(roman[10])
            elif num >= 9:
                num -= 9
                ans.append(roman[9])
            elif num >= 5:
                num -= 5
                ans.append(roman[5])
            elif num >= 4:
                num -= 4
                ans.append(roman[4]) 
            elif num >= 1:
                num -= 1
                ans.append(roman[1])
        return ''.join(ans)              
