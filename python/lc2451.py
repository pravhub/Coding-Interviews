class Solution:
    def oddString(self, words: List[str]) -> str:
        seen = {}
        for idx, s in enumerate(words):
            diff = ""
            for i in range(len(s)-1):
                diff += str(ord(s[i+1]) - ord(s[i]))
                diff += '#'
            if diff in seen:
                seen[diff].append(idx)
            else:
                seen[diff] = [idx]
        for x,y in seen.items():
            if len(y) == 1:
                return words[y[0]]
        return None
