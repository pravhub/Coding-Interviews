class Solution:
    def minimumPushes(self, word: str) -> int:
        m = len(word)
        total = 0
        press_round = 1
        while m > 0:
            if m >= 8:
                m = m-8
                total += 8 * press_round
            else:
                total += m * press_round
                m = 0
            press_round += 1
        return total
        