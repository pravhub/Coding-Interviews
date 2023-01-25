class Solution:
    def getValue(self, s:str) -> int:
        return int(s) if s.isnumeric() else len(s)
    
    def maximumValue(self, strs: List[str]) -> int:
        return max([self.getValue(x) for x in strs])
