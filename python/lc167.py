class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        start, end = 0, len(numbers)-1
        ans = []
        while start < end:
            if numbers[start] + numbers[end] < target:
                start += 1
            elif numbers[start] + numbers[end] > target:
                end -= 1
            else:
                ans.append(start+1);
                ans.append(end+1);
                break
        return ans
