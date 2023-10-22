class Solution:
    def closeStrings(self, word1: str, word2: str) -> bool:
        if (sorted(word1) == sorted(word2)):
            return True
        
        if len(word1) == len(word2) and set(word1) == set(word2) and sorted(Counter(word1).values()) == sorted(Counter(word2).values()):
            return True
        
        return False
