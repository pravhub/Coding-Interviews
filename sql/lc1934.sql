select user_id, CAST(confirmation_rate AS DECIMAL(7,2)) as confirmation_rate
from (
select s.user_id,
(sum(case when action='confirmed' then 1 else 0 end)/ CAST(count(*) AS DECIMAL(7,2))) as confirmation_rate
from signups s left join confirmations c 
on s.user_id = c.user_id
group by s.user_id
) a
