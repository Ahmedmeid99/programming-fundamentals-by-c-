-----------------------------------------
-- DQL Language
-----------------------------------------
--  Disitinct
--  IS NOT AND OR
--  = <>
--  IN
--  AS
--  Order By
--  Group By
-- Between 
-- Count Sum Avg Min Max
-- Wildcards Like  % _ [] [-]
-----------------------------------------

use HR_Database;

Select * from Employees;

Select FirstName,LastName,Gendor from Employees;

Select FirstName,LastName,Gendor from Employees
Where Gendor='M';

Select FirstName,LastName,Gendor,DepartmentID from Employees
Where Gendor='M' and DepartmentID = 1;

Select FirstName,LastName,Gendor,DepartmentID from Employees
Where Gendor='M' and DepartmentID <> 1;

Select FirstName,LastName,Gendor,DepartmentID,ExitDate,MonthlySalary from Employees
Where (ExitDate is Not Null ) or (Gendor='F' and MonthlySalary < 500);

-- Unrepeted data
Select Distinct DepartmentID from Employees;

Select FirstName,LastName,Gendor,DepartmentID,ExitDate,MonthlySalary from Employees
Where DepartmentID in (1,2);

Select * from Departments;

Select FirstName,LastName,ExitDate from Employees 
Where DepartmentID in (1,2)

Select Departments.Name from Departments
Where ID in (Select Distinct DepartmentID from Employees Where MonthlySalary >2000);

Select FirstName,LastName,Gendor,DepartmentID,ExitDate,MonthlySalary from Employees
Order By FirstName ASC;

Select FirstName,LastName,Gendor,DepartmentID,ExitDate,MonthlySalary from Employees
Order By FirstName DESC;

Select FirstName,LastName,Gendor,DepartmentID,ExitDate,MonthlySalary from Employees
Order By MonthlySalary DESC;

Select TOP 10 Percent * From Employees; -- 100 from 1000

-- Get Names of top 3 Employees MonthlySalary  
Select Distinct TOP 3 FirstName,LastName,Gendor,DepartmentID,ExitDate,MonthlySalary from Employees
Order By MonthlySalary DESC;

-----------------------------------------
-- = AS
-- Between 
-- Count Sum Avg Min Max
-----------------------------------------
Select Today=GETDATE();
Select FullName =FirstName + ' ' + LastName,MonthlySalary from Employees;
Select FirstName + ' ' + LastName AS FullName,MonthlySalary from Employees;
Select FirstName,LastName,MonthlySalary from Employees Where MonthlySalary Between 900 and 1000;
Select 
	TotalCount=Count(ID),
	TotalSum=Sum(MonthlySalary),
	Average = Avg(MonthlySalary),
	MinSalary = Min(MonthlySalary),
	MaxSalary = Max(MonthlySalary)

from Employees;
-- Group By to parting data depend on something
-- Group each DepartmentID and get count sum avg min max of it
Select 
	TotalCount = Count(ID),
	TotalSum = Sum(MonthlySalary),
	Average = Avg(MonthlySalary),
	MinSalary = Min(MonthlySalary),
	MaxSalary = Max(MonthlySalary)

from Employees
Group By DepartmentID ; -- 7

Select 
	TotalCount = Count(ID),
	TotalSum = Sum(MonthlySalary),
	Average = Avg(MonthlySalary),
	MinSalary = Min(MonthlySalary),
	MaxSalary = Max(MonthlySalary)

from Employees 
Group By DepartmentID having Count(MonthlySalary) > 100 ; -- 6


Select 
	TotalCount = Count(ID),
	TotalSum = Sum(MonthlySalary),
	Average = Avg(MonthlySalary),
	MinSalary = Min(MonthlySalary),
	MaxSalary = Max(MonthlySalary)

from Employees 
Group By DepartmentID having DepartmentID = 2  ; -- 1

-----------------------------------------
-- Wildcards Like % _ [] [-]
-----------------------------------------

Select FirstName,LastName,Gendor from Employees Where FirstName Like 'a%'; -- first char is a
Select FirstName,LastName,Gendor from Employees Where FirstName Like '%a'; -- last char is a
Select FirstName,LastName,Gendor from Employees Where FirstName Like '%a%'; -- mid char is a
Select FirstName,LastName,Gendor from Employees Where FirstName Like '_a%'; -- second char is a
Select FirstName,LastName,Gendor from Employees Where FirstName Like 'a__%'; --  3 char at lest
Select FirstName,LastName,Gendor from Employees Where FirstName Like 'a___%'; -- 4 char at lest
Select FirstName,LastName,Gendor from Employees Where FirstName Like '[abc]%'; -- first char is a or b or c
Select FirstName,LastName,Gendor from Employees Where FirstName Like '[a-f]%'; -- first char is a to f
Select FirstName,LastName,Gendor from Employees Where FirstName Not Like '[a-f]%'; -- first char is a to f