class Solution:
    def countPermutations(self, complexity: List[int]) -> int:
        start, end = 1, len(complexity)
        complexity[start:end] = sorted(complexity[start:end])        
        modulo = pow(10,9) + 7
        ans = 0
        if complexity[0] < complexity[1]:
            ans = 1
            for i in range(1,end):
                ans *= i  
                ans = ans % modulo                       
        return ans
