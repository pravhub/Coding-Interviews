class Solution:
    def concatHex36(self, n: int) -> str:
        hexadecimal  = {0:'0',1:'1',2:'2',3:'3',4:'4',5:'5',6:'6',7:'7',8:'8',9:'9',10:'A',11:'B',12:'C',13:'D',14:'E',15:'F'}
        hexatrigesimal  = {0:'0',1:'1',2:'2',3:'3',4:'4',5:'5',6:'6',7:'7',8:'8',9:'9',10:'A',11:'B',12:'C',13:'D',14:'E',15:'F',16:'G',17:'H',18:'I',19:'J',
                        20:'K',21:'L',22:'M',23:'N',24:'O',25:'P',26:'Q',27:'R',28:'S',29:'T',
                        30:'U',31:'V',32:'W',33:'X',34:'Y',35:'Z'}
        sq = n*n
        cube = n*n*n
        ans16 = ''
        ans36 = ''
        while sq > 0:
            rem = sq % 16
            sq = sq // 16
            ans16 = hexadecimal[rem] + ans16
        while cube > 0:
            rem = cube % 36
            cube = cube // 36
            ans36 = hexatrigesimal[rem] + ans36
        return ans16 + ans36
