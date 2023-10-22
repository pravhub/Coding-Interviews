class Solution:
    def findDist(self, a:str,b:str)->int:
        diff = 0
        for i in range(len(a)):
            if a[i] != b[i]:
                diff += 1
        return diff

    def twoEditWords(self, queries: List[str], dictionary: List[str]) -> List[str]:
        output = []
        for q in queries:
            for d in dictionary:
                dist = self.findDist(q,d)
                if dist <= 2:
                    output.append(q)
                    break
        return output
