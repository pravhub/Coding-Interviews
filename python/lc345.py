class Solution:
    def reverseVowels(self, s: str) -> str:
        start, end = 0, len(s)-1
        ans = list(s)
        vowels = {'a', 'e', 'i', 'o', 'u','A', 'E', 'I', 'O', 'U' }
        while start < end:
            while start < end and s[start] not in vowels:
                start += 1
            while start < end and s[end] not in vowels:
                end -= 1
            if start < end:
                ans[start],ans[end] = ans[end],ans[start]
            start += 1
            end -= 1
        return "".join(ans)
