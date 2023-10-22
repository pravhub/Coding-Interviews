# https://leetcode.com/problems/customers-who-never-order/
# Leetcode 183. Customers Who Never Order
# MS SQL Server
select c.name as Customers
from customers c
left join orders o on c.id = o.customerid
where o.customerid is NULL
