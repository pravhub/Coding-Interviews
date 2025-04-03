class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        m = {}
        for word in strs:
            converted = str(sorted(word))
            if converted in m:
                m[converted].append(word)
            else:
                m[converted] = [word]
        # print(m.values())
        return list(m.values())
