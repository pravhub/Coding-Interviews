class Solution:
    def isHappy(self, n: int) -> bool:
        m = set()
        while n > 1:
            cur = n
            nxt = 0
            while cur > 0:
                rem = cur % 10
                nxt = nxt + rem * rem
                cur = cur // 10
            if nxt in m:
                return False
            else:
                m.add(nxt)
            n = nxt
        return n == 1
