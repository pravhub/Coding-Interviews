# https://leetcode.com/problems/primary-department-for-each-employee/
# Leetcode 1789. Primary Department for Each Employee
# MS SQL Server
select employee_id, department_id 
from employee
where primary_flag = 'Y' or employee_id in (
select employee_id
from employee
group by employee_id
having count(*) = 1)
