----------------------------------------
--Update -> to Update Record(s) of data
----------------------------------------

--Update all records in table
Update Employees
Set Salary = Salary + 200;

-- update 2 records (rows)
Update Employees
Set FirstName='abo-eid'
WHERE FirstName='Ahmed';

--delete record
Delete Employees
WHERE Salary < 300;

-- WHERE Condetion

select * from Employees;