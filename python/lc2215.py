class Solution:
    def diff(self, nums1: List[int], nums2: List[int]) -> List[int]:
        ans = set()
        for i in nums1:
            if i not in nums2:
                ans.add(i)
        return ans
    def findDifference_old(self, nums1: List[int], nums2: List[int]) -> List[List[int]]:
        return [self.diff(nums1,nums2), self.diff(nums2, nums1)]

    def findDifference(self, nums1: List[int], nums2: List[int]) -> List[List[int]]:
        s1 = set(nums1)
        s2 = set(nums2)
        return [s1.difference(s2), s2.difference(s1)]
