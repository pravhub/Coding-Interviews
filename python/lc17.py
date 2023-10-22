class Solution:
    def letterCombinations(self, digits: str) -> List[str]:
        if not digits:
            return []
        num_map = {
            '2' : ['a','b','c'],
            '3' : ['d','e','f'],
            '4' : ['g','h','i'],
            '5' : ['j','k','l'],
            '6' : ['m','n','o'],
            '7' : ['p','q','r','s'],
            '8' : ['t','u','v'],
            '9' : ['w','x','y','z']
        }
        ans = ['']
        for d in digits:
            next_list = []
            for s in ans:
                for c in num_map[d]:
                    next_list.append(s+c)
            ans = next_list
            # print(ans)

        return ans

