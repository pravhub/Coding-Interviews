-- Leetcode 2020. Number of Accounts That Did Not Stream
-- https://leetcode.com/problems/count-number-of-maximum-bitwise-or-subsets/
select count(su.account_id) as accounts_count
from subscriptions su
left join streams st on su.account_id = st.account_id
where year(su.start_date) <= 2021 and year(su.end_date) >=2021 and 
year(st.stream_date) != 2021
