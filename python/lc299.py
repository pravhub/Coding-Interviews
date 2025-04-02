class Solution:
    def getHint(self, secret: str, guess: str) -> str:
        bulls = 0
        cows = 0
        bmap = {}
        cmap = {}
        for i in range(len(secret)):
            if secret[i] == guess[i]:
                bulls +=1
            else:
                if secret[i] in bmap:
                    bmap[secret[i]] +=1
                else:
                    bmap[secret[i]] =1
                if guess[i] in cmap:
                    cmap[guess[i]] +=1
                else:
                    cmap[guess[i]] = 1
        for x,y in bmap.items():
            if x in cmap:
                cows += min(y, cmap[x])
        return str(bulls)+'A'+str(cows)+'B'

