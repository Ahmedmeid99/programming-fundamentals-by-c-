
-----------------------
-- Case statement  
-----------------------

-- Notes :.
-- There are no Swatch Case statement in TSQL but you can 
-- use Case statement in [ Add Delete Update Select ]

use C21_DB1
Go



Select * from Employees

Select * from Departments


-- There are Two Ways to use Case statement

-- [1]

-- replace id of DepartmentId by its DepartmentName Like (Join)
Select EmployeeID,

	case DepartmentId
		when 1 then 'Human Resources'
		when 2 then 'Marketing'
		when 3 then 'Sales '
		when 4 then 'Athers'
	end

	as DepartmentName

From Employees;

-- [2] search type

Select Name,
	case 
	when YEAR(GetDate()) - YEAR(HireDate) >=2 then 'IsExpert'
	else 'Not Expert'
	end as HasExperiance
from Employees

select * from Employees


-- use Case statement for Sorting

select * from Employees
Order by 

case 
	when DepartmentID >= 3 then 1
	else 2
end
,DepartmentID desc;


-- 5	Sarah Miller	4	2023-01-05
-- 1	John Smith	    3	2023-01-10
-- 2	Jane Doe	    3	2023-02-15
-- 3	Emily Davis	    2	2023-03-20
-- 4	Michael Brown	1	2022-11-05


