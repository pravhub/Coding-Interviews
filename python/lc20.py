class Solution:
    def isValid(self, s: str) -> bool:
        paren = {')': '(', '}': '{', ']' : '['}
        st = []
        for c in s:
            if c in ['(', '{', '[' ]:
                st.append(c)
            else:
                if len(st) == 0:
                    return False

                last = st.pop()
                if paren[c] != last:
                    return False
        return True and len(st) == 0
