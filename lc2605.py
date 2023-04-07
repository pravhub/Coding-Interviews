class Solution:
    def minNumber(self, nums1: List[int], nums2: List[int]) -> int:
        n1 = min(nums1)
        n2 = min(nums2)
        inter = set(nums1).intersection(nums2)
        if len(inter) > 0:
            return min(inter)
        else:
            return min(n1*10 + n2, n2*10 + n1)
