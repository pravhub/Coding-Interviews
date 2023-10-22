class Solution:
    def reversePrefix(self, word: str, ch: str) -> str:
        i = word.find(ch)
        if(i == -1):
            return word
        return word[0:i+1][::-1] + word[i+1:len(word)]
