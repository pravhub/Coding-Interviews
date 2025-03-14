public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int idx = m+n-1;
        int i = m-1;
        int j = n-1;        
        while(i >=0 && j >=0)
        {
            if(nums1[i] > nums2[j])
            {
                nums1[idx] = nums1[i];
                idx--;
                i--;
            }
            else if(nums1[i] < nums2[j])
            {
                nums1[idx] = nums2[j];
                idx--;
                j--;
            }
            else
            {
                nums1[idx] = nums1[i];
                idx--;
                i--;
                nums1[idx] = nums2[j];
                idx--;
                j--;
            }
        }
        while(j>=0)
        {
            nums1[idx] = nums2[j];
            idx--;
            j--;
        }
    }
}
