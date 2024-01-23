class Solution:
    def minimumPushes(self, word: str) -> int:
        m = {}
        for c in word:
            if c in m:
                m[c] += 1
            else:
                m[c] = 1
        press_round = 1
        cur_count = 0
        total = 0
        m1 = sorted(m.items(), key=lambda item: item[1])
        # print(m1)
        for x, y in reversed(m1):
            # print(x,y)
            if cur_count >= 8:
                press_round += 1
                cur_count = 0
            total += y * press_round
            cur_count += 1
        return total
