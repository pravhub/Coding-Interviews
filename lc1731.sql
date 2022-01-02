#MS SQL Server
# https://leetcode.com/problems/the-number-of-employees-which-report-to-each-employee/
# Leetcode 1731. The Number of Employees Which Report to Each Employee
select e2.employee_id,e2.name, count(*) as reports_count, ROUND(SUM(e1.age)/CAST(COUNT(e1.age) as float),0) as average_age
from employees e1
join employees e2 on e1.reports_to = e2.employee_id
group by e2.employee_id,e2.name
order by 1
