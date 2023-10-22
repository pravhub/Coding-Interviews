class Solution:
    def minMaxGame(self, nums: List[int]) -> int:
        if(len(nums) == 1):
            return nums[0]
        
        n = len(nums)
        arr = []
        while(n > 1):   
            for i in range(int(n/2)):
                if i % 2 == 0:
                    arr.append(min(nums[2*i], nums[2 * i+1]))
                else:
                    arr.append(max(nums[2*i], nums[2 * i+1]))
            n = len(arr)
            nums = arr
            if(len(arr) != 1):
                arr= []            
        return arr[0]
