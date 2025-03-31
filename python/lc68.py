class Solution:
    def convertToLine(self, words: List[str], maxWidth: int) -> str:
        finalString =  words[0]
        totalChars = sum(len(s) for s in words)
        # print(words)
        leftOverWidth = maxWidth - totalChars
        evenSpaces = (leftOverWidth // (len(words) -1)) if len(words) > 1 else 0
        leftOverSpaces = maxWidth - totalChars - ((evenSpaces * (len(words)-1)) if evenSpaces !=0 else 0)
        seperator = ' ' * evenSpaces
        # print(totalChars,leftOverWidth,evenSpaces,seperator, leftOverSpaces)
        
        for w in words[1:]:
            finalString = finalString + seperator + (' ' if leftOverSpaces > 0 else '') + w
            # print(finalString)
            leftOverSpaces -=1
        if leftOverSpaces > 0:
            finalString = finalString + (' ' * leftOverSpaces)

        return finalString

    def fullJustify(self, words: List[str], maxWidth: int) -> List[str]:
        ans = []
        curWidth = maxWidth 
        curList = []
        for w in words:            
            if len(w) <= curWidth:                
                curList.append(w)
                curWidth = curWidth - len(w)
                curWidth = curWidth - 1
            else:                
                ans.append(self.convertToLine(curList, maxWidth))
                curList = [w]
                curWidth = maxWidth - len(w)
                curWidth = curWidth - 1
        if len(curList) > 0:
            lastLine = ' '.join(curList)
            lastLine += ' ' * (maxWidth - len(lastLine))
            ans.append(lastLine)
        return ans
