class Solution:
    def isPrefixString(self, s: str, words: List[str]) -> bool:
        n = len(s)
        created = ""
        i = 0
        while(len(created)< n and s != created and i < len(words)):
            created += words[i]
            i += 1
        return created == s
