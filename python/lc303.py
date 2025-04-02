class NumArray:

    def __init__(self, nums: List[int]):
        self.arr = [0] * len(nums)
        prev= 0
        for i in range(len(nums)):
            prev += nums[i]
            self.arr[i] = prev
        

    def sumRange(self, left: int, right: int) -> int:        
        return self.arr[right]- (self.arr[left-1] if left > 0 else 0)
        
