class Solution:
    def canVisitAllRooms(self, rooms: List[List[int]]) -> bool:
        visited = set()
        q = deque()
        q.append(0)

        while q:
            cur_key = q.popleft()
            if cur_key not in visited:
                for key in rooms[cur_key]:
                    q.append(key)           
                visited.add(cur_key)
        # print(visited)
        return len(visited) == len(rooms)
