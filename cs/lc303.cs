public class NumArray {
    private int[] arr;
    public NumArray(int[] nums) {
        this.arr = new int[nums.Length];
        this.arr[0] = nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            this.arr[i] = this.arr[i-1] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        if(left >0)
            return this.arr[right] - this.arr[left-1];
        else 
            return this.arr[right];
    }
}
