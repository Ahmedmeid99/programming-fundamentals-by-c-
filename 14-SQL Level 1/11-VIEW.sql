------------------------------------
--- VIEW
------------------------------------
-- to save big Query & use it later
-- organize yor database
------------------------------------

use HR_Database;

--Select * from 
--(Select C=count(MonthlySalary),DepartmentID from Employees Group by DepartmentID)  R1

--Where R1.DepartmentID >1;


Create View FullData_Employees As
Select Employees.FirstName,Employees.LastName,Employees.Gendor,Employees.MonthlySalary ,
CountryName = Countries.Name, DepartmentName=Departments.Name
from Employees
JOIN Countries ON CountryID = Countries.ID
JOIN Departments ON DepartmentID=Departments.Id;


Create View ActiveEmployees AS 
Select FirstName,LastName,Gendor,ExitDate from Employees Where ExitDate is Null;


Create View ShortEmployees As
Select FirstName,LastName,Gendor,Age=DATEDIFF(YEAR ,DateOfBirth,GETDate()),MonthlySalary from Employees ;

-- List Of Views
select * from FullData_Employees;
select * from ShortEmployees;
select * from ActiveEmployees;
