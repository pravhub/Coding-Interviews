class Solution:
    def uniqueOccurrences(self, arr: List[int]) -> bool:
        count_map = {}
        for i in arr:
            if i in count_map:
                count_map[i] = count_map[i] + 1
            else:
                count_map[i] = 1

        return len(count_map) == len(set(count_map.values()))
