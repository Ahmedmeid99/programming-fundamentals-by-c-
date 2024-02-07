---------------------------------------------------------------
--SELECT _ INTO -> to Add Record(s) of data to new created table
---------------------------------------------------------------

SELECT *
INTO EmployeesCopy1
From Employees
WHERE Gander ='M' or Gander ='m';

SELECT ID,FirstName,LastName,Salary
INTO EmployeesCopy2
From Employees
WHERE Salary > 1000;

SELECT * FROM EmployeesCopy1;
SELECT * FROM EmployeesCopy2;


---------------------------------------------------------------
--INSERT _ INTO -> to Add Record(s) of data to exist table
---------------------------------------------------------------

INSERT INTO EmployeesCopy1
Select * FROM Employees
WHERE ID = 12;