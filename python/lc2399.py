class Solution:
    def checkDistances(self, s: str, distance: List[int]) -> bool:
        seen = {}
        for i, c in enumerate(s):            
            if c in seen:
                diff = i - seen[c] - 1
                if diff != distance[ord(c)-97]:
                    return False
            else:
                seen[c] = i        
        return True
