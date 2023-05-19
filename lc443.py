class Solution:
    def compress(self, chars: List[str]) -> int:
        ans = [chars[0]]        
        count = 1
        idx = 1
        for i in range(1, len(chars)):            
            if chars[i] == chars[i-1]:
                count += 1                
            else:                
                if count > 1:
                    l = list(str(count))
                    for j in range(len(l)):
                        chars[idx] = l[j]
                        idx += 1
                chars[idx] = chars[i]
                idx += 1
                count = 1
        if count > 1:
            l = list(str(count))
            for j in range(len(l)):
                chars[idx] = l[j]
                idx += 1
        return idx
