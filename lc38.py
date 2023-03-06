class Solution:
    def Say(self, s:str) -> str:
        idx = 1
        ans = ""
        cur_char = s[0]
        cur_count = 1
        for idx in range(1, len(s)):
            if s[idx-1] == s[idx]:
                cur_count +=1
            else:
                ans = ans + str(cur_count) + cur_char
                cur_char = s[idx]
                cur_count = 1

        ans = ans + str(cur_count) + cur_char
        return ans

    def countAndSay(self, n: int) -> str:
        start = "1"
        n -= 1
        while n > 0:
            print(start)
            start = self.Say(start)
            n -= 1
        return start
