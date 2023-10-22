class Solution:
    ans = ""
    s = set()
    n= 0
    def backtrack(self,i:int,  sofar:str) ->bool:
        if i==self.n:
            if(sofar not in self.s):
                self.ans = sofar
                return True
            else:
                return False
        for d in range(2):
            if(self.backtrack(i+1,sofar+str(d))):
                return True
     
    def findDifferentBinaryString(self, nums: List[str]) -> str:
        self.n = len(nums[0])
        self.s = set(nums)
        self.backtrack(0,"")
        return self.ans
