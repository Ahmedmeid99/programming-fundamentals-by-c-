---------------------------------------
-- JOINS 
---------------------------------------
--	JOIN       ( INNER JOIN )
--	LEFT JOIN  ( LEFT OUTER JOIN )
--	RIGTH JOIN ( RIGTH OUTER JOIN )
--	FULL JOIN  ( FULL OUTER JOIN )
---------------------------------------

use HR_Database;

Select * from Employees;
select * from Departments;
select * from Countries;
------------[INNER JOIN]--------------
select Employees.FirstName, Employees.LastName, Employees.DateOfBirth,Employees.HireDate ,Departments.Name
from Employees 
JOIN Departments ON Employees.DepartmentID = Departments.ID ;

select Employees.FirstName, Employees.LastName,Employees.HireDate ,DepartmentName=Departments.Name ,CountrieName=Countries.Name
from Employees 
JOIN Departments ON Employees.DepartmentID = Departments.ID 
JOIN Countries ON Countries.ID= CountryID;

------------[LEFT JOIN]--------------
SELECT Employees.*, Departments.Name
FROM  Employees 
LEFT OUTER JOIN Departments ON Employees.DepartmentID = Departments.ID;

------------[RIGHT JOIN]--------------
SELECT        Countries.*,Employees.FirstName,Employees.LastName
FROM            Employees RIGHT OUTER JOIN
                         Countries ON Employees.CountryID = Countries.ID

------------[RIGHT JOIN]--------------
SELECT        Countries.Name, Employees.FirstName, Employees.LastName, Employees.Gendor, Employees.DateOfBirth, Employees.CountryID, Employees.DepartmentID
FROM            Countries FULL OUTER JOIN
                         Employees ON Countries.ID = Employees.CountryID