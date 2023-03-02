class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        ans = []
        carry = 1
        for i in range(len(digits)-1, -1, -1):
            sum = carry + digits[i]
            carry = sum // 10
            ans.append(sum % 10)
        if carry > 0:
            ans.append(carry)
        ans.reverse()
        return ans
