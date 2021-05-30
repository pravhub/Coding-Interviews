class Solution(object):
    def maxValue(self, n, x):
        #input is valid
        repIdx = -1
        if(n[0]== '-'): #negative numbers
            for i in range(1,len(n)):
                c = n[i]
                if(x < ord(c)-ord('0')):
                    repIdx = i;
                    break
        else:
            for i in range(len(n)):
                c = n[i]
                if(x > ord(c)-ord('0')):
                    repIdx = i
                    break
        if(repIdx == -1):
            return n+ str(x)
        else:
            return n[0:repIdx]+str(x)+n[repIdx:]
