class Solution:
    def simplifyPath(self, path: str) -> str:
        parts = path.split('/')
        ans = []
        for p in parts:
            if p:
                if p == '.':
                    pass
                elif p == '..':
                    if len(ans) > 0:
                        ans.pop()
                else:
                    ans.append(p)

                
        return '/'+'/'.join(ans)
