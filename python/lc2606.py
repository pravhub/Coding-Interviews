class Solution:
    def maximumCostSubstring(self, s: str, chars: str, vals: List[int]) -> int:
        cur_cost = 0
        max_cost = 0
        cost = {
            'a':1,
            'b':2,
            'c':3,
            'd':4,
            'e':5,
            'f':6,
            'g':7,
            'h':8,
            'i':9,
            'j':10,
            'k':11,
            'l':12,
            'm':13,
            'n':14,
            'o':15,
            'p':16,
            'q':17,
            'r':18,
            's':19,
            't':20,
            'u':21,
            'v':22,
            'w':23,
            'x':24,
            'y':25,
            'z':26
            }
        for i in range(len(vals)):
            cost[chars[i]] = vals[i]

        for c in s:
                cur_cost += cost[c]
                max_cost = max(max_cost, cur_cost)
                if cur_cost < 0:
                    cur_cost = 0
        return max_cost
