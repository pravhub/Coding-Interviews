# SQL Server
# 2041. Accepted Candidates From the Interviews
# https://leetcode.com/problems/accepted-candidates-from-the-interviews/
select c.candidate_id
from candidates c
inner join rounds r on c.interview_id = r.interview_id
where c.years_of_exp >= 2
group by c.candidate_id--, c.interview_id
having  sum(r.score) > 15
