class Solution:
    def partitionString(self, s: str) -> List[str]:
        seen = set()
        output = []
        cur = ""
        for c in s:
            cur += c
            if cur not in seen:
                seen.add(cur)
                output.append(cur)
                cur = ""
        return output

