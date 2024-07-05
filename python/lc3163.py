class Solution:
    def compressedString(self, word: str) -> str:
        comp  = ''
        cur_char = word[0]
        count = 1
        for i in range(1,len(word)):
            if cur_char == word[i] and count < 9:
                count += 1
            else:
                comp += str(count)
                comp += cur_char
                count = 1
                cur_char = word[i]        
        comp += str(count)
        comp += cur_char        

        return comp
