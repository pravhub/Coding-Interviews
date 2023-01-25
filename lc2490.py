class Solution:
    def isCircularSentence(self, sentence: str) -> bool:
        parts = sentence.split()
        cicular = True
        for i in range(1,len(parts)):
            cicular &= parts[i-1][-1] == parts[i][0]
        return cicular and sentence[0] == sentence[-1]
