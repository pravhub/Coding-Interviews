class Solution:
    def similarPairs(self, words: List[str]) -> int:
        d = {}
        for x in words:
            cur = ''.join(sorted(set(x)))
            d[cur] = 1 + d.get(cur,0)
        pairs = 0
        print(d)
        for x,y in d.items():
            if y >1:
                pairs += y*(y-1) //2
        return pairs
