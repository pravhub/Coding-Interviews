class Solution:
    def nearestExit(self, maze: List[List[str]], entrance: List[int]) -> int:
        st = deque()
        st.append((entrance[0],entrance[1], 0))
        visited = set()
        m = len(maze)
        n = len(maze[0])
        shortest = float(inf)
        dirs = [[0,-1],[-1,0],[1,0],[0,1]]
        while st:
            cur_row, cur_col, cur_steps = st.popleft()
            # print("cur", cur_row, cur_col, cur_steps)
            if maze[cur_row][cur_col] == '+':
                visited.add((cur_row, cur_col))
                continue

            if (cur_row, cur_col) not in visited and maze[cur_row][cur_col] == '.':
                for d in dirs:
                    next_r = cur_row + d[0]
                    next_c = cur_col + d[1]

                    if next_r >=0 and next_r < m and next_c >=0 and next_c < n:
                        # print("next", next_r,next_c)
                        st.append((next_r,next_c, cur_steps+1))
                    else:
                        if cur_row == entrance[0] and cur_col == entrance[1]:
                            continue
                        shortest = min(shortest, cur_steps)

                visited.add((cur_row, cur_col))

        if shortest == float(inf):
            shortest = -1
        return shortest
