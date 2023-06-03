class Solution:
    def decodeString(self, s: str) -> str:
        st = []
        alph = set(['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'])
        num = set([0,1,2,3,4,5,6,7,8,9])
        output = ''
        for c in s:
            if c in alph:
                st.append(c)
            elif c in ['1','2','3','4','5','6','7','8','9','0']:
                st.append(int(c))
            elif c =='[':
                st.append(c)
            elif c ==']':
                prev_str = ''
                while len(st) > 0 and st[-1] != '[' and (st[-1] in alph or st[-1] not in num):
                    prev_str = st.pop() + prev_str
                
                if len(st) > 0 and st[-1] == '[':
                    st.pop()
                prev_num = 0
                idx = 0
                while len(st)> 0 and st[-1] in num:
                    prev_num = st.pop() * pow(10, idx) + prev_num                     
                    idx += 1

                # print(prev_str, prev_num)
                if len(st) != 0:
                    st.append(prev_str * prev_num)
                else:
                    output += prev_str * prev_num
        left_over = ''
        while len(st) > 0:
            left_over = st.pop() + left_over
        return output + left_over
                
