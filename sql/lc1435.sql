#MYSQL
#leetcode 1435. Create a Session Bar Chart
#https://leetcode.com/problems/create-a-session-bar-chart/
select '[0-5>' as bin ,count(duration) as total
from sessions
where duration<300
union
select '[5-10>' as bin ,count(duration) as total
from sessions
where duration between 300 and 600
union
select '[10-15>' as bin ,count(duration) as total
from sessions
where duration between 600 and 900
union
select '15 or more' as bin ,count(duration) as total
from sessions
where duration>900
