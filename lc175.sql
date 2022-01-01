# My SQL
# Leetcode 175. Combine Two Tables
# https://leetcode.com/problems/combine-two-tables/
select p.firstname, p.lastname, d.city, d.state
from person p
left join address d on p.personId = d.personId
