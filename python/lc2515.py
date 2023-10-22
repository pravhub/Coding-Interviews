class Solution:
    def closetTarget(self, words: List[str], target: str, startIndex: int) -> int:
        if target == words[startIndex]:
            return 0
        
        left = startIndex - 1
        right = startIndex + 1
        left = len(words)-1 if left < 0 else left
        right = 0 if right >=len(words) else right
        lfound = False
        rfound = False
        lmove = 1
        rmove = 1
        for i in range(len(words)):
            if not lfound:
                if words[left] == target:
                    lfound = True
                else:
                    lmove +=1
                left -=1
                if left < 0:
                    left = len(words) - 1
            if not rfound:
                if words[right] == target:
                    rfound = True
                else:
                    rmove +=1
                right += 1
                if right >=len(words):
                    right =0
        if lfound == False and rfound ==False:
            return -1
        return min(lmove, rmove)
