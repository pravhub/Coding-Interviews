    def sortColors_2Pass(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        red = 0
        white = 0
        blue = 0
        for i in nums:
            if i == 0:
                red +=1
            elif i == 1:
                white += 1
            else:
                blue += 1
        idx = 0;
        for i in range(red):
            nums[idx] = 0
            idx += 1
        for i in range(white):
            nums[idx] = 1
            idx += 1
        for i in range(blue):
            nums[idx] = 2
            idx += 1
