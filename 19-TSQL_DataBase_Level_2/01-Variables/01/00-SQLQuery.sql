
--------------------
--  [ Variaables ]
--------------------
use C21_DB1
GO

select * from Departments

select * from Employees
-- [1]
Go
DECLARE @EmployeeName nvarchar(50);

Set @EmployeeName = 'Jane Doe'

-- [2]

DECLARE @FoundEmployee nvarchar(50);

Select @FoundEmployee = Name from Employees Where EmployeeID = 3;

Print 'the Employee he has id = 3 his Name is [ ' + @FoundEmployee + ' ]'


