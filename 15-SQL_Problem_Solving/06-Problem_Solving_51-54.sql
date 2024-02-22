---------------------------------------
--------[SQL Solve Problems]-----------
---------------------------------------
------------ [51-45] ------------------
-- Self Referential

RESTORE DATABASE EmlpoyeeDB
FROM DISK='E:\Test\EmployeesDB.bak'

use EmlpoyeeDB;
SELECT * from dbo.Employees;

-- [51] Get all Empployee that have manger along with manger`s name
SELECT Employees.Name,Employees.ManagerID,Employees.Salary, Employees_1.Name AS MangerName
		FROM Employees 
		INNER JOIN Employees AS Employees_1 ON Employees.ManagerID = Employees_1.EmployeeID

-- [52] Get all Empployees that have manger OR Havnot along with manger`s name
SELECT Employees.Name, Employees.ManagerID, Employees.Salary, Employees_1.Name AS MangerName
		FROM  Employees 
		LEFT OUTER JOIN Employees AS Employees_1 ON Employees.ManagerID = Employees_1.EmployeeID

-- [53] Get all Empployees that have manger OR Have not manger set hemfelf as manger
SELECT Employees.Name, Employees.ManagerID, Employees.Salary,  MangerName = 
		CASE
			WHEN Employees_1.Name IS NULL THEN Employees.Name 
			ELSE Employees_1.Name
		END
		FROM Employees 
		LEFT OUTER JOIN Employees AS Employees_1 ON Employees.ManagerID = Employees_1.EmployeeID

-- [54] Get all Employees Manged by Mohammed
SELECT * FROM 
	(
		SELECT Employees.Name, Employees.ManagerID, Employees.Salary, Employees_1.Name AS MangerName
		FROM  Employees 
		LEFT OUTER JOIN Employees AS Employees_1 ON Employees.ManagerID = Employees_1.EmployeeID
	)R7
	WHERE MangerName = 'Mohammed'
