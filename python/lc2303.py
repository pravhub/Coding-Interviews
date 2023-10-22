class Solution:
    def calculateTax(self, brackets: List[List[int]], income: int) -> float:
        prev = 0
        ans = 0.0
        for br in brackets:
            if(income > 0):                                
                ans += min((br[0]- prev), income) * br[1]/100.0                
                income -= (br[0]- prev)
                prev = br[0]
            else:
                break
        return ans
