-----------------------------------
-- Exists
-- Union
-- Case
-----------------------------------

use HR_Database;

-----------------------------------
-------------[Exists]--------------
-----------------------------------
Select IsEmployeeExists ='YES'
Where exists(Select * from Employees Where FirstName= 'Cameron' and LastName ='Lo');

Select IsEmployeeExists ='YES'
Where exists(Select * from Employees Where FirstName= 'Ahmed' and LastName ='Eid');

-----------------------------------
--------------[Case]---------------
-----------------------------------

Select FirstName,LastName,
GendorTitle=
Case
	WHEN Gendor='F' THEN 'Female'
	WHEN Gendor='M' THEN 'Male'
	ELSE 'KNOW'
END
from Employees;

-----------------------------------

Select FirstName,LastName,
Active=
Case
	WHEN ExitDate is NULL THEN 'Yes'
	ELSE 'No'
END
,ExitDate
from Employees;

-----------------------------------

Select FirstName,LastName,Gendor, HireDate,ExitDate,Experiance=
Case
	WHEN ExitDate IS NULL THEN DATEDIFF(YEAR,HireDate,GetDate())
	ELSE DATEDIFF(YEAR,HireDate,ExitDate)
END
,Active=
Case
	WHEN ExitDate is NULL THEN 'Yes'
	ELSE 'No'
END
from Employees;

-----------------------------------
-------------[Union]--------------
-----------------------------------
-- Must have same Name of Attributes
Select * from FEmployees
UNION
Select * from MEmployees Order By Gendor DESC;

